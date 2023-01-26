using System.Collections.Generic;

namespace VocabE
{
    class BundleJSONClass
    {
        public class Group
        {
            public string english { get; set; }
            public string vietnamese { get; set; }
            public string english_description { get; set; }
            public string vietnamese_description { get; set; }
        }
        class Bundles
        {
            public class BundlesJSONClass
            {
                public string credits { get; set; }
                public List<Group> groups { get; set; }
            }
        }

    }
}
