using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 用户表
/// </summary>
public class UserEntity
{
    public int UserId { get; set; }

    public string NickName { get; set; }

    public string Password { get; set; }

    public int? VerifyCount { get; set; }

    public DateTime VerifyTime { get; set; }

    public string VerifyCode { get; set; }

    public string Vc { get; set; }

    public bool? Multionline { get; set; }

    public decimal? Money { get; set; }

    public decimal? Moneyi { get; set; }

    public int? Points { get; set; }

    public decimal? Recharge { get; set; }

    public decimal? Withdraw { get; set; }

    public decimal? Income { get; set; }

    public decimal? Outgo { get; set; }

    public decimal? Reward { get; set; }

    public decimal? Punish { get; set; }

    public int? UpLoad { get; set; }

    public int? Down { get; set; }

    public int? Sale { get; set; }

    public int? Good_Judge { get; set; }

    public int? Bad_Judge { get; set; }

    public int? Med_Judge { get; set; }

    public int? Flag { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public string LastLoginIP { get; set; }

    public decimal? Moneyf { get; set; }

    public int? FreeSmsNumber { get; set; }

    public int? BuySmsNumber { get; set; }

    public bool? IsBindMobile { get; set; }

    public int? FansCount { get; set; }

    public string TradeVerify { get; set; }

    public DateTime? TradeVerify_Time { get; set; }

    public int? Type { get; set; }

    public string Company { get; set; }

    public string RealName { get; set; }

    public int? Sex { get; set; }

    public string IdCard { get; set; }

    public string Email { get; set; }

    public string QQ { get; set; }

    public string MSN { get; set; }

    public string Address { get; set; }


    public string ZipCode { get; set; }

    public string Tel { get; set; }

    public string Mobile { get; set; }

    public string Fax { get; set; }

    public int? PayMode { get; set; }

    public string Accounts { get; set; }

    public string Payee { get; set; }

    public int? Bank { get; set; }

    public string BankArea { get; set; }

    public string BankBranch { get; set; }

    public string City { get; set; }

    public int? Job { get; set; }

    public string Intro { get; set; }

    public string Sign_bbs { get; set; }

    public string Sign { get; set; }

    public int? Refused { get; set; }

    public int? Speak { get; set; }

    public string NoSpeakReason { get; set; }

    public string Lockey { get; set; }

    public DateTime? LockUntil { get; set; }

    public string LockReason { get; set; }

    public int? Frozen { get; set; }

    public DateTime? FrozenUntil { get; set; }

    public string FrozenReason { get; set; }

    public int? NoSell { get; set; }

    public DateTime? NoSellUntil { get; set; }

    public string NoSellReason { get; set; }

    public int? Vip { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? Update_Date { get; set; }

    public int? Reply { get; set; }

    public int? AUser_Id { get; set; }

    public int? Status { get; set; }

    public int? IdVerify { get; set; }

    public int? NoBuy { get; set; }

    public DateTime? NoBuyUntil { get; set; }

    public string NoBuyReason { get; set; }

    public int? NoBuySelf { get; set; }

    public DateTime? NoBuySelfUntil { get; set; }

    public string NoBuySelfReason { get; set; }

    public int? WatermarkCode { get; set; }

    public DateTime? NoSpeakUntil { get; set; }

    public int? NoContribute { get; set; }

    public string NoContributeReason { get; set; }

    public DateTime? NoContributeUntil { get; set; }

    public int? SpaceUserLevel { get; set; }

    public DateTime? Liquidate { get; set; }

    public DateTime? IdCradEndDate { get; set; }
}
