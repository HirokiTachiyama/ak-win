using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stDokuWiki;
using stDokuWiki.AuthManager;
using stDokuWiki.Connector;
using stDokuWiki.Data;


// https://github.com/PetersSharp/stCoCServer/tree/master/stCoCServer/stExtLib/stDokuWikiConnector-dll/Doc

namespace ak_win {
    class DokuwikiPageGetter {

        RpcXml rpcXml;
        public DokuwikiPageGetter(string url, string user, string pass) {

            rpcXml = new RpcXml(url, user, pass);

            // public: 以下を取得するサンプル            
            // XMLMethodPageList dokuList = rpcXml.DokuPageList("public:") as XMLMethodPageList;
            // foreach(var items in dokuList.Params.Param.Value.Array.Data.Value)
            // {
            //     foreach(var item in items.Struct.Member)
            //     {
            //         Console.WriteLine(item.Name + " " + item.Value.String);
            //     }
            // }

        }

        public string GetPageFromDW(string _pageName)
        {
            return rpcXml.DokuPageGet(_pageName);
        }


    }
}
