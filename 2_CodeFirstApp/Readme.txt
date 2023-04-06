
EF CodeFirst İşlemleri

1- Models oluşturulur.
2-Entity Framework Nuget package den yüklenir.
3-DbContext classından kalıtım alacak class oluşturulur.

TANIM : DbContext classından -> Database table'a karşılık gelecek Modeller Dbset içerisinde belirtilir.Crud işlemler bu classdan kalıtım alacak nesne sayesinde CRUD işlemler yapılır.

4-App.config dosyasına connectionString yazılır.(dataSourceden database adını al ve değiştir ne yapmak istiyorsan onu yaz.)
connectionString name DbContext clası ile yapılır.
5-
Proje Rebuild edilmeli.
Migration işlemi Nuget Package Console da yapılır. 
	enable-migrations
	add-migration migration_adi
	Configuration.cs
	ctor
	AutomaticMigrationsEnabled = true;//otomatik migration oluşturur.
    AutomaticMigrationDataLossAllowed = true; // veri kaybını engeller
TANIM : !Migration : Model değişikliğini algılayan classa denir.

6- Nuget Package Console'a 
  update-database yazılır.