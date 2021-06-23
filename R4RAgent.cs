using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using Chib.Rpc4Rdp.Api;

namespace chib.rpc4rdp.cash.admin
{
    class R4RAgent : IR4RAgent
    {
        static Logger _logger = LogManager.GetCurrentClassLogger();
        IR4RContext _ctx;

        public bool Init(string domain)
        {
            _logger.Debug("Init");

            return true;
        }

        public void Start(IR4RContext ctx)
        {
            _logger.Debug("Start");
            _ctx = ctx;
        }

        public void Stop()
        {
            _logger.Debug("Stop");
            _ctx = null;
        }

        public void InvokeMethod(String method, R4RParameters r4rParams)
        {
            if (_ctx == null)
            {
                _logger.Warn("Agent is not started");
                return;
            }

            IR4RClient client = _ctx.Client;
            client.InvokeMethod(String.Format("rpc://{0}/Wrapper/{1}", Program.RDP_DOMAIN, method), r4rParams, 20000);
        }

        public void Print(String text,
            bool isFz54, bool isPreCheck, bool isCashlessCheck,
            bool isECheck, String clientPhone, String clientEmail,
            String service, String cashier, int bankComiss, String agentPhone,
            String operatorOper, String operatorName, String operatorAddress,
            String operatorInn, String operatorPhone)
        {
            _logger.Debug("start Print");
            R4RParameters r4rParams = new R4RParameters();
            r4rParams["text"] = text;
            r4rParams["isFz54"] = isFz54;
            r4rParams["isPreCheck"] = isPreCheck;
            r4rParams["isCashlessCheck"] = isCashlessCheck;
            r4rParams["isECheck"] = isECheck;
            r4rParams["clientPhone"] = clientPhone;
            r4rParams["clientEmail"] = clientEmail;
            r4rParams["service"] = service;
            r4rParams["cashier"] = cashier;
            r4rParams["bankComiss"] = bankComiss;
            r4rParams["agentPhone"] = agentPhone;
            r4rParams["operatorOper"] = operatorOper;
            r4rParams["operatorName"] = operatorName;
            r4rParams["operatorAddress"] = operatorAddress;
            r4rParams["operatorInn"] = operatorInn;
            r4rParams["operatorPhone"] = operatorPhone;

            InvokeMethod("Print", r4rParams);
            _logger.Debug("end Print");
        }

        public void X_Report()
        {
            _logger.Debug("start X_Report");
            R4RParameters r4rParams = new R4RParameters();
            InvokeMethod("X_Report", r4rParams);
            _logger.Debug("end X_Report");
        }

        public void Z_Report()
        {
            _logger.Debug("start Z_Report");
            R4RParameters r4rParams = new R4RParameters();
            InvokeMethod("Z_Report", r4rParams);
            _logger.Debug("end Z_Report");
        }

        public void MoneyIn(String summa)
        {
            _logger.Debug("start MoneyIn");
            R4RParameters r4rParams = new R4RParameters();
            r4rParams["summa"] = summa;
            InvokeMethod("MoneyIn", r4rParams);
            _logger.Debug("end MoneyIn");
        }

        public void MoneyOut(String summa)
        {
            _logger.Debug("start MoneyOut");
            R4RParameters r4rParams = new R4RParameters();
            r4rParams["summa"] = summa;
            InvokeMethod("MoneyOut", r4rParams);
            _logger.Debug("end MoneyOut");
        }

    }
}
