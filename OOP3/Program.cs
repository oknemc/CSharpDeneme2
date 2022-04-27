using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKrediManager = new EsnafKredisiManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
List<ILoggerService> loggers2 = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };
List<ILoggerService> loggers3 = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager, loggers3);
 
List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

// İnterface birbilerinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanılır.