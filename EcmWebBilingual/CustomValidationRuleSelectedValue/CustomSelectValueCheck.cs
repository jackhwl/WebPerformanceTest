using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace CustomValidationRuleSelectedValue
{
    public class CustomSelectValueCheck : ValidationRule
    {
        /// Specify a name for use in the user interface.
        /// The user sees this name in the Add Validation dialog box.
        //---------------------------------------------------------------------
        public override string RuleName
        {
            get { return "Custom Validate Selected Value"; }
        }


        /// Specify a description for use in the user interface.
        /// The user sees this description in the Add Validation dialog box.
        //---------------------------------------------------------------------
        public override string RuleDescription
        {
            get { return "Validates that the specified selected value exists on the page."; }
        }

        // The name of the required tag
        private string RequiredTagNameValue;
        public string SelectTagName
        {
            get { return RequiredTagNameValue; }
            set { RequiredTagNameValue = value; }
        }


        // The value of option the tag must appear in the response
        private string SelectValue;
        public string ExpectedSelectValue
        {
            get { return SelectValue; }
            set { SelectValue = value; }
        }

        // The value of index the tag must appear in the response
        private int IndexOfTag;
        public int Index
        {
            get { return IndexOfTag; }
            set { IndexOfTag = value; }
        }

        // The select value exist / not exist
        private bool selectValueExist;
        public bool PassIfValueFound
        {
            get { return selectValueExist; }
            set { selectValueExist = value; }
        }

        // Validate is called with the test case Context and the request context.
        // These allow the rule to get selected value.
        //---------------------------------------------------------------------
        public override void Validate(object sender, ValidationEventArgs e)
        {
            bool validated = false; string tagValue = string.Empty;
            bool foundSelectName = false; int selectNo = -1;

            if (e.Response.HtmlDocument != null)
            {
                #region loop find select and option
                foreach (HtmlTag tag in e.Response.HtmlDocument.GetFilteredHtmlTags("select", "Select", "Option", "OPTION", "option"))
                {
                    #region find select with name
                    if (!foundSelectName && tag.GetAttributeValue("Name") != null)
                    {
                        tagValue = tag.GetAttributeValue("Name").Value;

                        // find select tag name = required tag select tag name
                        if (tagValue == RequiredTagNameValue)
                        {
                            selectNo += 1;
                            // find select tag and same index(target select)
                            if (selectNo == IndexOfTag)
                                foundSelectName = true;
                        }
                        continue;
                    }
                    #endregion

                    #region under target select
                    if (foundSelectName)
                    {
                        //find option with value
                        if (tag.GetAttributeValue("value") != null)
                        {
                            // find option's value = target value
                            if (tag.GetAttributeValue("value").Value == SelectValue)
                            {
                                validated = true;
                                break;
                            }
                        }
                        // find other select (finished target select tag)
                        else if (tag.GetAttributeValue("Name") != null)
                            break;
                    }
                    #endregion
                }
                #endregion

                if (!selectValueExist)
                    validated = !validated;
            }

            e.IsValid = validated;
            if (!validated)
            {
                if(selectValueExist)
                    e.Message = "The value \"" + SelectValue + "\" was not found.";
                else
                    e.Message = "The value \"" + SelectValue + "\" was found.";
            }
        }
    }
}
