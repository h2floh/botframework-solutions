﻿using EmailSkillTest.Flow.Strings;
using Luis;

namespace EmailSkillTest.Flow.Utterances
{
    public class ForwardEmailUtterances : BaseTestUtterances
    {
        public ForwardEmailUtterances()
        {
            this.Add(ForwardEmails, CreateIntent(ForwardEmails, intent: emailLuis.Intent.Forward));
            this.Add(ForwardEmailsToRecipient, CreateIntent(
                ForwardEmailsToRecipient,
                intent: emailLuis.Intent.Forward,
                contactName: new string[] { ContextStrings.TestRecipient }));
            this.Add(ForwardEmailsToRecipientWithContent, CreateIntent(
                ForwardEmailsToRecipientWithContent,
                intent: emailLuis.Intent.Forward,
                contactName: new string[] { ContextStrings.TestRecipient },
                message: new string[] { ContextStrings.TestContent }));
            this.Add(ForwardEmailsToSelection, CreateIntent(
                ForwardEmailsToSelection,
                intent: emailLuis.Intent.Forward,
                ordinal: new double[] { 2 }));
            this.Add(ForwardCurrentEmail, CreateIntent(ForwardCurrentEmail, intent: emailLuis.Intent.Forward));
        }

        public static string ForwardEmails { get; } = "Forward Email";

        public static string ForwardEmailsToRecipient { get; } = "Forward Email to " + ContextStrings.TestRecipient;

        public static string ForwardEmailsToRecipientWithContent { get; } = "Forward Email to " + ContextStrings.TestRecipient + " saying " + ContextStrings.TestContent;

        public static string ForwardEmailsToSelection { get; } = "Forward the second Email";

        public static string ForwardCurrentEmail { get; } = "Forward this Email";
    }
}
