using GTV.Mall.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Models.ViewModel.Account
{

    /// <summary>
    /// 會員資料表
    /// </summary>
    public class MemberViewModel
    {
        /// <summary>
        /// 會員編號
        /// </summary>
        public System.Guid MemberID { get; set; }

        /// <summary>
        /// 會員Email (認證用)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 身分證號
        /// </summary>
        public string MemberNO { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 暱稱
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 手機
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? DOB { get; set; }

        /// <summary>
        /// 姓別
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 外國地址
        /// </summary>
        public bool ForeignAddress { get; set; } = false;

        /// <summary>
        /// 郵遞區號
        /// </summary>
        public string Zipcode { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 地區
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 會員YT資料
        /// </summary>
        public string MemberYT { get; set; }

        /// <summary>
        /// 會員FB資料
        /// </summary>
        public string MemberFB { get; set; }

        /// <summary>
        /// Google
        /// </summary>
        public string MemberGoogle { get; set; }

        /// <summary>
        /// 狀態
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 帳戶鎖定時間
        /// </summary>
        public DateTime? LockedTime { get; set; }

        /// <summary>
        /// 密碼輸入錯誤次數
        /// </summary>
        public int FailCount { get; set; } = 0;

        /// <summary>
        /// Security token
        /// </summary>
        public Guid? SecurityToken { get; set; }

        /// <summary>
        /// 註冊時間
        /// </summary>
        public System.DateTime CreatedTime { get; set; }

        /// <summary>
        /// 由APP匯入
        /// </summary>
        public bool? FromApp { get; internal set; }

        public MemberViewModel(Member m)
        {
            MemberID = m.MemberID;
        }
    }
}
