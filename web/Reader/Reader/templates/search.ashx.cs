using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Reader;
using System.Data.SqlClient;

namespace Reader.template
{
    /// <summary>
    /// index 的摘要说明
    /// </summary>
    public class index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            string schitem = context.Request["schitem"];
            string schtx=context.Request["schtx"];
            
            string html = "";

            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(schitem) || string.IsNullOrEmpty(schtx))//scan all case
            {
                dt = SqlHelper.ExecuteDataTable("select * from caseBook");
                schtx = "";
                var Data = new
                {
                    book = dt.Rows,
                    tx = "",
                };
                html = CommonHelper.RenderHtml("schCResult.htm", Data);
                context.Response.Write(html);
            }
            else//search
            {
                string a = "%%";
                schtx = a.Insert(1, context.Request["schtx"]);
                
                if (schitem == "caseName"  )
                {
                    dt = SqlHelper.ExecuteDataTable("select * from  caseBook  where caseName like @tx",new SqlParameter("@tx",schtx));
                    //allnum = SqlHelper.ExecuteDataTable("select * from caseBook where caseName like @tx",new SqlParameter("@tx",schtx)).Rows.Count;
                    var Data = new
                    {
                        book = dt.Rows,
                        tx = context.Request["schtx"],
                    };
                    html = CommonHelper.RenderHtml("schCResult.htm", Data);
                    context.Response.Write(html);
                }
                else if (schitem == "isbn") 
                {
                    dt = SqlHelper.ExecuteDataTable("select * from caseBook where isbn like @tx",new SqlParameter("@tx",schtx));
                    //allnum = SqlHelper.ExecuteDataTable("select * from caseBook where isbn like @tx",new SqlParameter("@tx",schtx)).Rows.Count;
                    var Data = new
                    {
                        book = dt.Rows,
                        tx = context.Request["schtx"],
                    };
                    html = CommonHelper.RenderHtml("schCResult.htm", Data);
                    context.Response.Write(html);
                }
                else if (schitem == "writer")
                {
                    dt = SqlHelper.ExecuteDataTable("select * from caseBook where writer like @tx",new SqlParameter("@tx",schtx));
                    //allnum = SqlHelper.ExecuteDataTable("select * from caseBook where writer like @tx", new SqlParameter("@tx", schtx)).Rows.Count;
                    var Data = new
                    {
                        book = dt.Rows,
                        tx = context.Request["schtx"],
                    };
                    html = CommonHelper.RenderHtml("schCResult.htm", Data);
                    context.Response.Write(html);
                }
                else if (schitem == "vwriter")
                {
                    dt = SqlHelper.ExecuteDataTable("select * from vsch where vwriter like @tx", new SqlParameter("@tx", schtx));
                    
                    var Data = new
                    {
                        book = dt.Rows,
                        tx = context.Request["schtx"],
                    };
                    html = CommonHelper.RenderHtml("schVResult.htm", Data);
                    context.Response.Write(html);
                }
                else if (schitem == "division")
                {
                    dt = SqlHelper.ExecuteDataTable("select * from vsch where division like @tx", new SqlParameter("@tx", schtx));
                    
                    var Data = new
                    {
                        book = dt.Rows,
                        tx = context.Request["schtx"],
                    };
                    html = CommonHelper.RenderHtml("schVResult.htm", Data);
                    context.Response.Write(html);
                }
            }
            

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}