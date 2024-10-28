using Bridge_pattern;

class Program
{
    static void Main(string[] args)
    {
        
        notice emailNotice = new EmailNotice();
        NoticeBase textEmail = new TextNotice(emailNotice);
        textEmail.Notify("Это текстовое уведомление для Email.");
        notice smsNotice1 = new SmsNotice();
        NoticeBase TextSms = new TextNotice(smsNotice1);
        TextSms.Notify("Это текстовое уведомление для SMS.");

        notice smsNotice = new SmsNotice();
        NoticeBase htmlSms = new HtmlNotice(smsNotice);
        htmlSms.Notify("Это HTML уведомление для SMS.");
        notice emailNotice1 = new EmailNotice();
        NoticeBase htmlEmail = new HtmlNotice(emailNotice1);
        htmlEmail.Notify("Это HTML уведомление для Email.");
    }
}