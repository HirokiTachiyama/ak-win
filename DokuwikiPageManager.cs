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
    class DokuwikiPageManager
    {

        RpcXml rpcXml;
        public DokuwikiPageManager(string url, string user, string pass)
        {

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

        public string GetPage(string _pageName)
        {
            return rpcXml.DokuPageGet(_pageName);
        }

        public bool PutPage(string _contentStr, string _pageName)
        {
            bool ret = false;
            try
            {
                ret = rpcXml.DokuPagePut(_pageName, _contentStr);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return ret;
        }
    }
}