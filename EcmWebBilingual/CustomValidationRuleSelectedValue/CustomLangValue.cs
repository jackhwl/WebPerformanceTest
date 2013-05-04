using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace CustomValidationRuleSelectedValue
{
    public class CustomLangValue : ValidationRule
    {
            /// Specify a name for use in the user interface.
            /// The user sees this name in the Add Validation dialog box.
            //---------------------------------------------------------------------
            public override string RuleName
            {
                get { return "Custom Localization Value"; }
            }


            /// Specify a description for use in the user interface.
            /// The user sees this description in the Add Validation dialog box.
            //---------------------------------------------------------------------
            public override string RuleDescription
            {
                get { return "Validates that the specified language id exists on the page."; }
            }

            // The name of the required tag
            private string _languageID;
            public string LanguageID
            {
                get { return _languageID; }
                set { _languageID = value; }
            }


            // Validate is called with the test case Context and the request context.
            // These allow the rule to get selected value.
            //---------------------------------------------------------------------
            public override void Validate(object sender, ValidationEventArgs e)
            {
                bool validated = false;
                string test, testfr;
                var rm = new Doxim.Resources.DoximResManager();
                //rm.Language = "en";
                //test = rm.LibMisc.Get("Label_Title", rm.Language);
                rm.Language = "fr";
                testfr = rm.LibMisc.Get("Label_Title", "fr");


                // the select is last one without next select tag
                // target select tag without selected option
                // if first option value match target value
                //if (!selectedexist && firstOptionValue == _languageID)
                    validated = false;

                e.IsValid = validated;
                if (!validated)
                {
                    e.Message = "The value en:\"" + "test" + " ][2 fr:=" +testfr + _languageID + "\" was not found or was not selected.";
                    //e.Message = n.ToString() + "The value \"" + SelectedValue + "\" was not found or was not selected.";
                }
            }
        }
    }