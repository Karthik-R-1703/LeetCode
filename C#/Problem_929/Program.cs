using System.Collections.Generic;

namespace Problem_929
{
    // 929. Unique Email Addresses
    // https://leetcode.com/problems/unique-email-addresses/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails1 = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            NumUniqueEmails(emails1);

            string[] emails2 = { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" };
            NumUniqueEmails(emails2);
        }

        public static int NumUniqueEmails(string[] emails)
        {
            int no_of_emails = 0;
            Dictionary<string, List<string>> v_emails = new Dictionary<string, List<string>>();
            foreach (string email in emails)
            {
                string[] e = email.Split('@');
                string local_name = e[0];
                string domain_name = e[1];
                List<string> local_names = new List<string>();
                if (v_emails.ContainsKey(domain_name))
                {
                    local_names = v_emails[domain_name];
                }
                else
                {
                    v_emails.Add(domain_name, local_names);
                }

                string v_local_name = string.Join("", local_name.Split('.'));
                v_local_name = v_local_name.Split('+')[0];

                if (!local_names.Contains(v_local_name))
                {
                    no_of_emails++;
                    v_emails[domain_name].Add(v_local_name);
                }
            }

            return no_of_emails;
        }
    }
}
