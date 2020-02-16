using System;
using System.Collections.Generic;
using System.Text;

namespace BSS
{
    class SiebelWrapper
    {
        public SiebelWrapper()
        {
        }
        static SiebelWrapper()
        {
            m_ServiceFunctionDivider = Properties.Settings.Default.ServiceFunctionDivider.ToString();
            m_mainBsName = BSS.Properties.Settings.Default.BsName;
        }
        readonly static string m_ServiceFunctionDivider = ".";
        readonly static string m_mainBsName;
        readonly static string m_FuncPs2XmlName = "_PsToXml";
        readonly static string m_FuncXml2PsName = "_XmlToPs";

        internal PropertySet PsFromXml(string Xml)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(Xml);
            //System.Xml.XmlTextReader r  =new System.Xml.XmlTextReader(Xml,
            PropertySet ps=new PropertySet();
            //ps.PsValue = Xml;
            //System.Xml.XmlWriter w = System.Xml.XmlWriter.Create( 
            //System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            //doc.LoadXml(Xml);
            System.Xml.XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", "");
            doc.InsertBefore(decl, doc.DocumentElement);
            ps.PsValue = doc.OuterXml;
/*          ps.PsValue = @"<?xml version='1.0' encoding='UTF-16'?><?Siebel-Property-Set EscapeNames='true'?><AAA>aaa</AAA>";
            ps.PsValue = @"<?xml version='1.0' encoding='UTF-16'?><AAA>aaa</AAA>";
            */
            ps = InvokeMethod(m_mainBsName, m_FuncXml2PsName, ps).FunctionResult;
            return ps;
        }
        public string PsToXml(PropertySet ps)
        {
            string xml = InvokeMethod(m_mainBsName, m_FuncPs2XmlName, ps.GetChild(0)).FunctionResult.PsValue;
            return xml;
        }
        public SiebelAnswer InvokeMethod(string BsName, string FunctionName, PropertySet ips)
        {

            SIEBELHTMLLib.ISiebelService mainBs = AppSiebel.GetService(m_mainBsName);
            PropertySet ops = new PropertySet();
            SiebelAnswer answer = new SiebelAnswer();

            //SIEBELHTMLLib.SiebelPropertySet tmpPs = ;


            //mainBs.InvokeMethod(BsName + m_ServiceFunctionDivider + FunctionName, ips.GetChild(0).SiebelPS, ops.SiebelPS);
            mainBs.InvokeMethod(BsName + m_ServiceFunctionDivider + FunctionName, ips.SiebelPS, ops.SiebelPS);
            if (ops.Property("Status") == "Error")
            {
                string errMsg = "";
                if (ops.GetChild(0).GetChild(0).Property("ErrCode") == /*"22360"*/ "11338003" &&
                    ops.GetChild(0).GetChild(0).Property("ErrMsg").IndexOf(m_mainBsName) != -1)
                    errMsg = "BS '" + m_mainBsName + "' no present on Siebel.\nIt need for running this application. Please create it and\ndescribe in application parameters";
                //answer = new SiebelAnswer(ops, );
                else
                    //answer = new SiebelAnswer(ops, "ErrCode = " + ops.GetChild(0).GetChild(0).Property("ErrCode") + "; ErrMsg = " + ops.GetChild(0).GetChild(0).Property("ErrMsg"));
                    errMsg = RecoveryFromXml(ops.GetChild(0).GetChild(0).Property("ErrMsg"));
                answer = new SiebelAnswer(ops, errMsg);
            }
            else
                for (int i = 0; i < ops.ChildCount; i++)
                    if (ops.GetChild(i).PsType == "TestBsOps")
                    {
                        answer = new SiebelAnswer(ops, ops.GetChild(i).GetChild(0));
                        break;
                    }


            return answer;
        }
        private string RecoveryFromXml(string str)
        {
            string s = "<doc>" + str + "</doc>";
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(s);
            return doc.DocumentElement.InnerText;
        }
        private static SIEBELHTMLLib.ISiebelHTMLApplication m_appSiebel;
        public static SIEBELHTMLLib.ISiebelHTMLApplication AppSiebel
        {
            get
            {
                if (m_appSiebel == null)
                {
                    Type t = Type.GetTypeFromProgID("Siebel.Desktop_Integration_Application.1", "localhost");
                    m_appSiebel = (SIEBELHTMLLib.ISiebelHTMLApplication)Activator.CreateInstance(t);
                }
                if (!m_appSiebel.IsReady())
                {
                    throw new Exception("Siebel not ready");
                }
                return m_appSiebel;
            }
        }


        //---------------------//---------------------//---------------------//
        public class PropertySet
        {
            private SIEBELHTMLLib.SiebelPropertySet m_ps;
            public PropertySet()
            {
                //m_mainBsName   = MainBsName;
                m_ps = SiebelWrapper.AppSiebel.NewPropertySet();
            }
            private PropertySet(SIEBELHTMLLib.SiebelPropertySet SiebelPropertySet)
            {
                this.m_ps = SiebelPropertySet;
            }
            internal SIEBELHTMLLib.SiebelPropertySet SiebelPS
            {
                get { return m_ps; }
                //                set { m_ps = value; }
            }

            internal string PsType
            {
                get { return SiebelPS.GetType(); }
                set { SiebelPS.SetType(value); }
            }

            /*public void SetPsType(string Name)
            {
                SiebelPS.SetType(Name);
            }
            public void GetPsType()
            {
                return SiebelPS.GetType(Name);
            }*/


            internal string PsValue
            {
                get { return SiebelPS.GetValue(); }
                set { SiebelPS.SetValue(value); }
            }


            /*public void SetPsValue(string Value)
            {
                SiebelPS.SetValue(Value);
            }*/

            internal void AddChild(PropertySet ps)
            {
                this.SiebelPS.AddChild(ps.SiebelPS);

            }
            internal void Property(string Name, string Value)
            {
                SiebelPS.SetProperty(Name, Value);
            }
            internal string Property(string Name)
            {
                return SiebelPS.GetProperty(Name);
            }
            /*internal string this[string Name]
            {
                set { SiebelPS.SetProperty(Name, value); }
                get { return SiebelPS.GetProperty(Name); }
            }*/


            internal int PropertyCount
            {
                get { return SiebelPS.GetPropertyCount(); }
            }

            internal int ChildCount
            {
                get { return SiebelPS.GetChildCount(); }
            }

            internal string GetFirstProperty()
            {
                return SiebelPS.GetFirstProperty();
            }
            internal string GetNextProperty()
            {
                return SiebelPS.GetNextProperty();
            }
            internal PropertySet GetChild(int Index)
            {
                return new PropertySet(SiebelPS.GetChild(Index));

            }

        }

        
    }
    struct SiebelAnswer
    {
        /*private SiebelAnswer()
        {
            errorMessage = "";
            invokeMethodResult = null;
            functionResult = null;
        }*/

        /// <summary>
        /// For succesful result
        /// </summary>
        /// <param name="InvokeMethodResult">property set it returned from invoke Method. It include FunctionResult</param>
        /// <param name="FunctionResult">result of function</param>
        public SiebelAnswer(SiebelWrapper.PropertySet InvokeMethodResult, SiebelWrapper.PropertySet FunctionResult)
        {
            isError = false;
            invokeMethodResult = InvokeMethodResult;
            functionResult = FunctionResult;
            errorMessage = "";
        }
        /// <summary>
        /// Siebel return is error
        /// </summary>
        /// <param name="InvokeMethodResult">property set it returned from invoke Method. It include FunctionResult</param>
        /// <param name="ErrorMessage">Message for user</param>
        public SiebelAnswer(SiebelWrapper.PropertySet InvokeMethodResult, string ErrorMessage)
        {
            isError = true;
            invokeMethodResult = InvokeMethodResult;
            functionResult = null;
            errorMessage = ErrorMessage;
        }

        private bool isError;
        public bool IsError
        {
            get { return isError; }
        }

        private SiebelWrapper.PropertySet invokeMethodResult;
        public SiebelWrapper.PropertySet InvokeMethodResult
        {
            get { return invokeMethodResult; }
        }

        private SiebelWrapper.PropertySet functionResult;
        public SiebelWrapper.PropertySet FunctionResult
        {
            get { return functionResult; }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
        }

    }
}
