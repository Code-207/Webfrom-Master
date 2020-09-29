using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Code923.Models;
using Code923.services;
using Wuqi.Webdiyer;

namespace Code923
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UserServices user = new UserServices();
            repuserlist.DataSource = UserServices.Query<Users>();
            repuserlist.DataBind();
        }

        protected void AspNetPager1_PageChanging(object src, PageChangingEventArgs e)
        {
            //AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            //GetBind();
        }

        private void GetBind()
        {
            DataTable dt = UserServices.Query<Users>();
            PagedDataSource pds = new PagedDataSource
            {
                DataSource = dt.DefaultView, 
                AllowPaging = true
            }; 
           
            
            //AspNetPager1.RecordCount = dt.DefaultView.Count; //这个用于设置当前数据源的数据条数
            //pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; // 设置我们页码从第一页开始,下标为0
            //pds.PageSize = AspNetPager1.PageSize;

            this.repuserlist.DataSource = pds;
            this.repuserlist.DataBind();
        }
    }
}