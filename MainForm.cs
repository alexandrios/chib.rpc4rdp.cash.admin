using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLog;
using Chib.Rpc4Rdp.Api;

namespace chib.rpc4rdp.cash.admin
{
    public partial class MainForm : Form
    {
        protected static Logger _logger = LogManager.GetLogger("chib.rpc4rdp.cash.admin.MainForm");
        private static R4R.Instance r4rInst;
        private long sumValue = 0;

        private String SummaValue
        {
            get {
                String s = sumValue.ToString();
                if (s.Length == 1)
                    s = "0.0" + s;
                else if (s.Length == 2)
                    s = "0." + s;
                else
                    s = s.Substring(0, s.Length - 2) + "." + s.Substring(s.Length - 2);

                return s;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // при вызове этого метода он ищет конфиги и создает все сущности которые там описаны
                R4R.Initialize();
            }
            catch (Exception ex)
            {
                r4rInst = null;
                _logger.Error(ex.Message);
                //MessageBox.Show(ex.Message, "Ошибка 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                R4RAgent r4rAgent = new R4RAgent();
                r4rInst = R4R.GetInstance(Program.RDP_INSTANCE);
                r4rInst.Domains[Program.RDP_DOMAIN].AddAgent(Program.RDP_AGENT, r4rAgent);
            }
            catch (Exception ex)
            {
                r4rInst = null;
                _logger.Error(ex.Message);
                //MessageBox.Show(ex.Message, "Ошибка 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                R4R.Startup();
                R4R.GetInstance(Program.RDP_INSTANCE).StartGlobalDomain(Program.RDP_DOMAIN);
            }
            catch (Exception ex)
            {
                r4rInst = null;
                _logger.Error(ex.Message);
                //MessageBox.Show(ex.Message, "Ошибка 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            R4R.Shutdown();
        }

        private void _summaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                sumValue = sumValue / 10;
                Double d = (Double)sumValue / 100;
                string text = String.Format("{0:f2}", d);
                (sender as TextBox).Text = text;
                (sender as TextBox).SelectionStart = 0;
            }
            else if (e.KeyValue >= 48 && e.KeyValue <= 57)
            {
                long v = sumValue * 10 + e.KeyValue - 48;
                if (v <= 9999999999)
                {
                    sumValue = sumValue * 10 + e.KeyValue - 48;
                    Double d = (Double)sumValue / 100;
                    string text = String.Format("{0:f2}", d);
                    (sender as TextBox).Text = text;
                    (sender as TextBox).SelectionStart = 0;
                }
            }
            e.Handled = true;
        }

        private void _summaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void _xReportButton_Click(object sender, EventArgs e)
        {
            if (r4rInst != null)
            {
                _logger.Trace("r4rInst != null");
                IR4RAgent r4rAgent = r4rInst.Domains[Program.RDP_DOMAIN].GetAgent(Program.RDP_AGENT);

                (r4rAgent as R4RAgent).X_Report();
            }
            else
            {
                _logger.Trace("r4rInst == null");
                Wrappers.Cash.X_Report();
            }
        }

        private void _zReportButton_Click(object sender, EventArgs e)
        {
            if (r4rInst != null)
            {
                _logger.Trace("r4rInst != null");
                IR4RAgent r4rAgent = r4rInst.Domains[Program.RDP_DOMAIN].GetAgent(Program.RDP_AGENT);

                (r4rAgent as R4RAgent).Z_Report();
            }
            else
            {
                _logger.Trace("r4rInst == null");
                Wrappers.Cash.Z_Report();
            }
        }

        private bool CheckSumma()
        {
            if (sumValue == 0)
            {
                MessageBox.Show("Не указана сумма!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void _cashOutButton_Click(object sender, EventArgs e)
        {
            if (CheckSumma())
            {
                if (r4rInst != null)
                {
                    _logger.Trace("r4rInst != null");
                    IR4RAgent r4rAgent = r4rInst.Domains[Program.RDP_DOMAIN].GetAgent(Program.RDP_AGENT);

                    //(r4rAgent as R4RAgent).MoneyOut(sumValue.ToString()); -для старой chib.cash.wtp.dll
                    (r4rAgent as R4RAgent).MoneyOut(SummaValue);
                }
                else
                {
                    _logger.Trace("r4rInst == null");
                    Wrappers.Cash.MoneyOut(sumValue.ToString());
                }
            }
        }

        private void _cashInButton_Click(object sender, EventArgs e)
        {
            if (CheckSumma())
            {
                if (r4rInst != null)
                {
                    _logger.Trace("r4rInst != null");
                    IR4RAgent r4rAgent = r4rInst.Domains[Program.RDP_DOMAIN].GetAgent(Program.RDP_AGENT);

                    //(r4rAgent as R4RAgent).MoneyIn(sumValue.ToString()); - для старой chib.cash.wtp.dll
                    (r4rAgent as R4RAgent).MoneyIn(SummaValue);
                }
                else
                {
                    _logger.Trace("r4rInst == null");
                    Wrappers.Cash.MoneyIn(sumValue.ToString());
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Text = "Администратор ККТ ";
            if (r4rInst != null)
                this.Text += "(RDP)";
            else
                this.Text += "(Citrix)";
        }
    }
}