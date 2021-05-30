create database TelefonRehberi
go
use TelefonRehberi
go
create table Kullanici
(
KullaniciID uniqueidentifier primary key,
KullaniciAdi nvarchar(20) unique, -- unique = ayný kullanýcý adý olamaz. (kontrol etmesem bile)
Sifre nvarchar(20) not null,
)

insert into Kullanici values(NEWID(),'Demo','Demo')

create table Rehber
(
ID uniqueidentifier primary key,
isim nvarchar(20) not null,
soyisim nvarchar(20) not null,
telefonNumarasiI nvarchar(12),
telefonNumarasiII nvarchar(12),
telefonNumarasiIII nvarchar(12),
EmailAdres nvarchar(30),
WebAdres nvarchar(30),
Adres nvarchar(100),
Aciklama nvarchar(100)
)
go
create proc spRehberYeniKayit
(
@ID uniqueidentifier,
@isim nvarchar(20),
@soyisim nvarchar(20),
@telefonNo1 nvarchar(12),
@telefonNo2 nvarchar(12),
@telefonNo3 nvarchar(12),
@emailAdres nvarchar(30),
@Adres nvarchar(100),
@aciklama nvarchar(100),
@webadres nvarchar(30)
)
as
begin
insert into Rehber(ID,isim,soyisim,telefonNumarasiI,telefonNumarasiII,telefonNumarasiIII,EmailAdres,WebAdres,Adres,Aciklama)
values (@ID,@isim,@soyisim,@telefonNo1,@telefonNo2,@telefonNo3,@emailAdres,@webadres,@Adres,@aciklama)
end

create proc spRehberKayitDuzenle
(
@ID uniqueidentifier,
@isim nvarchar(20),
@soyisim nvarchar(20),
@telefonNo1 nvarchar(12),
@telefonNo2 nvarchar(12),
@telefonNo3 nvarchar(12),
@emailAdres nvarchar(30),
@Adres nvarchar(100),
@aciklama nvarchar(100),
@webadres nvarchar(30)
)
as
begin
update Rehber set 
isim=@isim,
soyisim=@soyisim,
telefonNumarasiI=@telefonNo1,
telefonNumarasiII=@telefonNo2,
telefonNumarasiIII=@telefonNo3,
EmailAdres=@emailAdres,
WebAdres=@webadres,
Adres=@Adres,
Aciklama=@aciklama
where ID =@ID
end

create proc spRehberKayitSil
(
@ID uniqueidentifier
)
as
begin
delete Rehber where ID = @ID
end

create proc spRehberListe
as
begin
select*from Rehber
end

create proc spRehberID
(
@ID uniqueidentifier
)
as
begin
select *from Rehber where ID = @ID
end

insert into Rehber(ID,isim,soyisim,telefonNumarasiI,telefonNumarasiII,telefonNumarasiIII,EmailAdres,WebAdres,Adres,Aciklama)
values(@ID,@isim,@soyisim,@telefonNumarasiI,@telefonNumarasiII,@telefonNumarasiIII,@EmailAdres,@WebAdres,@Adres,@Aciklama)

select count(*) from Kullanici where KullaniciAdi= @KullaniciAdi and Sifre = @Sifre

update Rehber set ID=@ID,isim=@isim,soyisim=@soyisim,telefonNumarasiI=@telefonNumarasiI,telefonNumarasiII=@telefonNumarasiII,
                    telefonNumarasiIII=@telefonNumarasiIII,EmailAdres=@EmailAdres,WebAdres=@WebAdres,Adres=@Adres,Aciklama=@Aciklama
					
