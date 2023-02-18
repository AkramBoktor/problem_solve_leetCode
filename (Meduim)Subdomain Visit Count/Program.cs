using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _Meduim_Subdomain_Visit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubdomainVisits(new string[] { "19000 discuss.letcoode.com" , "1200 Yellow.com"}));
        }

        public static List<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> subDomainsVisist = new List<string>();
            foreach (var domain in cpdomains)
            {
              var  repetNumer = int.Parse(Regex.Match(domain, @"\d+").Value);

                var domainStringSplit = domain.Split(".");
                if(domainStringSplit.Length > 2)
                {
                    for (int i = 1; i < domainStringSplit.Length; i++)
                    {
                        if( i == domainStringSplit.Length - 1 )
                        {
                            subDomainsVisist.Add(repetNumer.ToString() + "." + domainStringSplit[i]);
                        }
                        else
                        {
                            subDomainsVisist.Add(repetNumer.ToString() + " " + domainStringSplit[i] + domainStringSplit.Last());

                        }
                    }
                }
                else
                { 
                    if (subDomainsVisist.Any(s=>s.Contains(domainStringSplit.Last())))
                    {
                        int repetNumber = int.Parse(Regex.Match(domain, @"\d+").Value);
                        var ElementExists = subDomainsVisist.Select((Value, Index) => new { Value, Index })
                 .Where(s=>s.Value.Contains(domainStringSplit.Last())).ToList();
                       int countDuplicated = repetNumber + int.Parse(Regex.Match(ElementExists[0].Value, @"\d+").Value);
                        subDomainsVisist[ElementExists[0].Index] = countDuplicated.ToString() + "." + domainStringSplit.Last();

                    }
                    subDomainsVisist.Add(domain);

                }
            }
            return subDomainsVisist;
        }
    }
}
