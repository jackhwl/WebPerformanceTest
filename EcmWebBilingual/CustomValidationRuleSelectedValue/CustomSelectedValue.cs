using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace CustomValidationRuleSelectedValue
{
    public class CustomSelectedValue : ValidationRule
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
            private string SelectedValue;
            public string ExpectedSelectedValue
            {
                get { return SelectedValue; }
                set { SelectedValue = value; }
            }

            // The value of index the tag must appear in the response
            private int IndexOfTag;
            public int Index
            {
                get { return IndexOfTag; }
                set { IndexOfTag = value; }
            }

            // Validate is called with the test case Context and the request context.
            // These allow the rule to get selected value.
            //---------------------------------------------------------------------
            public override void Validate(object sender, ValidationEventArgs e)
            {
                bool validated = false;           string tagValue = string.Empty;
                bool foundSelectName = false;     int selectNo = -1;
                bool isFrstOption = false;        string firstOptionValue = string.Empty;
                bool selectedexist = false;       //int n = 0;

                //foreach (HtmlTag tag in e.Response.HtmlDocument.GetFilteredHtmlTags("select", "option"))
                //    n += 1;


                foreach (HtmlTag tag in e.Response.HtmlDocument.GetFilteredHtmlTags("select", "Select", "Option", "OPTION", "option"))
                {
                    // find select with name
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

                    // under target select
                    if (foundSelectName)
                    {
                        //find option with value
                        if (tag.GetAttributeValue("value") != null)
                        {
                            //save the first option value
                            if (!isFrstOption)
                            {
                                isFrstOption = true;
                                firstOptionValue = tag.GetAttributeValue("value").Value;
                            }

                            // find option's value = target value and selected
                            if (tag.GetAttributeValue("selected") != null)
                                selectedexist = true;
                            if (selectedexist && tag.GetAttributeValue("value").Value == SelectedValue)
                            {
                                validated = true;
                                break;
                            }
                        }
                        // find other select (finished target select tag)
                        else if (tag.GetAttributeValue("Name") != null)
                        {
                            // target select tag without selected option
                            // if first option value match target value
                            if (!selectedexist && firstOptionValue == SelectedValue)
                                validated = true;
                            break;
                        }
                    }
                }

                // the select is last one without next select tag
                // target select tag without selected option
                // if first option value match target value
                if (!selectedexist && firstOptionValue == SelectedValue)
                    validated = true;

                e.IsValid = validated;
                if (!validated)
                {
                    e.Message = "The value \"" + SelectedValue + "\" was not found or was not selected.";
                    //e.Message = n.ToString() + "The value \"" + SelectedValue + "\" was not found or was not selected.";
                }
            }
        }
    }