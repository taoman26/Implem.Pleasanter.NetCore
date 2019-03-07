using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Extensions
{
    public static class SearchIndexExtensions
    {
        public static void SearchIndexes(
            this int self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            Update(searchIndexHash, self.ToString(), searchPriority);
        }

        public static void SearchIndexes(
            this long self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            Update(searchIndexHash, self.ToString(), searchPriority);
        }

        public static void SearchIndexes(
            this decimal self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            Update(searchIndexHash, self.ToString(), searchPriority);
        }

        public static void SearchIndexes(
            this DateTime self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            Update(searchIndexHash, self.ToLocal(context: context).ToString(), searchPriority);
        }

        public static void SearchIndexes(
            this string self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self,
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this string self,
            IContext context,
            Column column,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            if (column?.HasChoices() == true)
            {
                SearchIndexes(
                    context: context,
                    searchIndexHash: searchIndexHash,
                    text: column.Choice(self).SearchText(),
                    searchPriority: searchPriority);
            }
            else
            {
                SearchIndexes(
                    context: context,
                    searchIndexHash: searchIndexHash,
                    text: self,
                    searchPriority: searchPriority);
            }
        }

        public static void SearchIndexes(
            this IEnumerable<SiteMenuElement> self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Select(o => o.Title).Join(" "),
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this ProgressRate self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Value.ToString(),
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this Status self,
            IContext context,
            Column column,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            if (column?.HasChoices() == true)
            {
                SearchIndexes(
                    context: context,
                    searchIndexHash: searchIndexHash,
                    text: column.Choice(self.Value.ToString()).SearchText(),
                    searchPriority: searchPriority);
            }
            else
            {
                SearchIndexes(
                    context: context,
                    searchIndexHash: searchIndexHash,
                    text: self.Value.ToString(),
                    searchPriority: searchPriority);
            }
        }

        public static void SearchIndexes(
            this Time self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Value.ToLocal(context: context).ToString(),
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this Title self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Value,
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this User self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Name,
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this Comments self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Select(o => SiteInfo.UserName(
                    context: context,
                    userId: o.Creator) + " " + o.Body).Join(" "),
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this WorkValue self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Value.ToString(),
                searchPriority: searchPriority);
        }

        public static void SearchIndexes(
            this Attachments self,
            IContext context,
            Dictionary<string, int> searchIndexHash,
            int searchPriority)
        {
            SearchIndexes(
                context: context,
                searchIndexHash: searchIndexHash,
                text: self.Select(o => o.Name).Join(" "),
                searchPriority: searchPriority);
        }

        public static void OutgoingMailsSearchIndexes(
            IContext context,
            Dictionary<string, int> searchIndexHash,
            string referenceType,
            long referenceId)
        {
            new OutgoingMailCollection(
                context: context,
                where: Rds.OutgoingMailsWhere()
                    .ReferenceType(referenceType)
                    .ReferenceId(referenceId)).Select(o => " ".JoinParam(
                        o.From.ToString(),
                        o.To,
                        o.Cc,
                        o.Bcc,
                        o.Title.Value,
                        o.Body)).Join(" ")
                            .SearchIndexes(
                                context: context,
                                createIndex: true)
                            .Distinct()
                            .ForEach(searchIndex =>
                               Update(searchIndexHash, searchIndex, 300));
        }

        private static void SearchIndexes(
            IContext context,
            Dictionary<string, int> searchIndexHash,
            string text,
            int searchPriority)
        {
            text.SearchIndexes(context: context, createIndex: true).ForEach(searchIndex =>
                Update(searchIndexHash, searchIndex, searchPriority));
        }

        private static void Update(
            Dictionary<string, int> searchIndexHash, string searchIndex, int searchPriority)
        {
            var word = searchIndex.ToLower().Trim();
            word = CSharp.Japanese.Kanaxs.KanaEx.ToHankaku(word);
            word = CSharp.Japanese.Kanaxs.KanaEx.ToZenkakuKana(word);
            if (word != string.Empty)
            {
                if (!searchIndexHash.ContainsKey(word))
                {
                    searchIndexHash.Add(word, searchPriority);
                }
                else if (searchIndexHash[word] > searchPriority)
                {
                    searchIndexHash[word] = searchPriority;
                }
            }
        }

        public static IEnumerable<string> SearchIndexes(
            this string self, IContext context, bool createIndex = false)
        {
            return new Search.WordBreaker(self, createIndex).Results
                .Select(o => o.Trim().ToLower())
                .Where(o => o != string.Empty)
                .Distinct()
                .ToList();
        }
    }
}