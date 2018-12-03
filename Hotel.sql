/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     11/22/2018 9:34:17 PM                        */
/*==============================================================*/

create database QLKS
use QLKS
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOK_GUEST')
alter table BOOKING
   drop constraint FK_BOOKING_BOOK_GUEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_CATEGORY_ROOMTYPE')
alter table BOOKING
   drop constraint FK_BOOKING_CATEGORY_ROOMTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_HAS_BOOKINGT')
alter table BOOKING
   drop constraint FK_BOOKING_HAS_BOOKINGT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_RECEIVE_NHANVIEN')
alter table BOOKING
   drop constraint FK_BOOKING_RECEIVE_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_SET_ROOM')
alter table BOOKING
   drop constraint FK_BOOKING_SET_ROOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONSUME') and o.name = 'FK_CONSUME_CONSUME_BOOKING')
alter table CONSUME
   drop constraint FK_CONSUME_CONSUME_BOOKING
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONSUME') and o.name = 'FK_CONSUME_CONSUME_EXTRAFEE')
alter table CONSUME
   drop constraint FK_CONSUME_CONSUME_EXTRAFEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTE') and o.name = 'FK_NOTE_HAS_2_BOOKING')
alter table NOTE
   drop constraint FK_NOTE_HAS_2_BOOKING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'CATEGORY_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.CATEGORY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'SET_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.SET_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'RECEIVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.RECEIVE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.HAS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOK_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOK_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKINGTYPE')
            and   type = 'U')
   drop table BOOKINGTYPE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONSUME')
            and   name  = 'CONSUME_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CONSUME.CONSUME_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONSUME')
            and   name  = 'CONSUME_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONSUME.CONSUME_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONSUME')
            and   type = 'U')
   drop table CONSUME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXTRAFEE')
            and   type = 'U')
   drop table EXTRAFEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GUEST')
            and   type = 'U')
   drop table GUEST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NOTE')
            and   name  = 'HAS_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index NOTE.HAS_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NOTE')
            and   type = 'U')
   drop table NOTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROOM')
            and   type = 'U')
   drop table ROOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROOMTYPE')
            and   type = 'U')
   drop table ROOMTYPE
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   BOOKINGID            int                  not null,
   ROOMID               char(5)              not null,
   IDINFO               char(15)             not null,
   BOOKINGTYPEID        char(5)              not null,
   NHANVIENID           int                  not null,
   DATE                 datetime             null,
   CHECKIN              datetime             null,
   CHECKOUT             datetime             null,
   BREAKFAST			bit					 null,
   constraint PK_BOOKING primary key nonclustered (BOOKINGID,BOOKINGTYPEID)
)
go

/*==============================================================*/
/* Index: BOOK_FK                                               */
/*==============================================================*/
create index BOOK_FK on BOOKING (
IDINFO ASC
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on BOOKING (
BOOKINGTYPEID ASC
)
go

/*==============================================================*/
/* Index: RECEIVE_FK                                            */
/*==============================================================*/
create index RECEIVE_FK on BOOKING (
NHANVIENID ASC
)
go

/*==============================================================*/
/* Index: SET_FK                                                */
/*==============================================================*/
create index SET_FK on BOOKING (
ROOMID ASC
)
go



/*==============================================================*/
/* Table: BOOKINGTYPE                                           */
/*==============================================================*/
create table BOOKINGTYPE (
   BOOKINGTYPEID        char(5)              not null,
   SOURCE               char(10)             null,
   constraint PK_BOOKINGTYPE primary key nonclustered (BOOKINGTYPEID)
)
go

/*==============================================================*/
/* Table: CONSUME                                               */
/*==============================================================*/
create table CONSUME (
   BOOKINGID            int                  not null,
   BOOKINGTYPEID		char(5)				 not null,
   surchare				int					null,
   cocacola				int					null,
   lavie				int					null,
   snack				int					null,
   instantNoodle				int					null,
   extrabed				int					null,
   constraint PK_CONSUME primary key nonclustered (BOOKINGID,bookingTYpeID)
)
go

/*==============================================================*/
/* Index: CONSUME_FK                                            */
/*==============================================================*/
create index CONSUME_FK on CONSUME (
BOOKINGID ASC
)
go

/*==============================================================*/
/* Index: CONSUME_FK2                                           */
/*==============================================================*/

/*==============================================================*/
/* Table: GUEST                                                 */
/*==============================================================*/
create table GUEST (
   IDINFO               char(15)             not null,
   FullNAME            char(100)             null,
   DOB					datetime			null,
   NATIONALITY          char(3)              null,
   constraint PK_GUEST primary key nonclustered (IDINFO)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   NHANVIENID           int                  not null,
   TENNV                char(50)             null,
   STARTDATE            datetime             null,
   ROLES                bit                  null,
   ACCOUNT              char(20)             null,
   PASSWORD             char(30)             null,
   constraint PK_NHANVIEN primary key nonclustered (NHANVIENID)
)
go

/*==============================================================*/
/* Table: prepaid                                                  */
/*==============================================================*/
create table prepaid (
   BOOKINGID            int                  not null,
   BOOKINGTYPEID		char(5)				not null,
   AMOUNT               int                  null,
   dateRecive			datetime				null,
   NHANVIENID           INT					 NULL,
   constraint PK_prepaid primary key (BOOKINGID,BOOKINGTYPEID)
)
go
/*==============================================================*/
/* Index: HAS_2_FK                                              */
/*==============================================================*/
create index HAS_2_FK on prepaid (
BOOKINGID ASC
)
go

/*==============================================================*/
/* Table: ROOM                                                  */
/*==============================================================*/
create table ROOM (
   ROOMID               char(5)              not null,
   ROOMTYPEID           char(20)                  not null,
   NUMPERSON            int                  null,
   constraint PK_ROOM primary key nonclustered (ROOMID)
)
go

/*==============================================================*/
/* Table: ROOMTYPE                                              */
/*==============================================================*/
create table ROOMTYPE (
   ROOMTYPEID           char(20)                  not null,
   PRICE                int                  null,
   constraint PK_ROOMTYPE primary key nonclustered (ROOMTYPEID)
)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOK_GUEST foreign key (IDINFO)
      references GUEST (IDINFO)
go

alter table ROOM
   add constraint FK_ROOM_HAVE_ROOMTYPE foreign key (ROOMTYPEID)
      references ROOMTYPE (ROOMTYPEID)
go


alter table BOOKING
   add constraint FK_BOOKING_HAS_BOOKINGT foreign key (BOOKINGTYPEID)
      references BOOKINGTYPE (BOOKINGTYPEID)
go

alter table BOOKING
   add constraint FK_BOOKING_RECEIVE_NHANVIEN foreign key (NHANVIENID)
      references NHANVIEN (NHANVIENID)
go

alter table BOOKING
   add constraint FK_BOOKING_SET_ROOM foreign key (ROOMID)
      references ROOM (ROOMID)
go

alter table CONSUME
   add constraint FK_CONSUME_CONSUME_BOOKING foreign key (BOOKINGID,BOOKINGTYPEID)
      references BOOKING (BOOKINGID,BOOKINGTYPEID)
go


alter table PREPAID
   add constraint FK_NOTE_HAS_2_BOOKING foreign key (BOOKINGID,BOOKINGTYPEID)
      references BOOKING (BOOKINGID,BOOKINGTYPEID)
go

insert into NhanVien 
values (001,'admin',11/22/2018,1,'admin','admin')

insert into ROOM
values
('M01','SUPERIOR',2)
,('M02','SUPERIOR',2)
,('004', 'SUPERIOR',2)
,('104', 'SUPERIOR',2)
,('204', 'SUPERIOR',2)
,('304', 'SUPERIOR',2)
,('404', 'SUPERIOR',2)
,('102', 'PREMIUM DELUXE',3)
,('302', 'PREMIUM DELUXE',3)
,('202','FAMILY DELUXE',4)
,('402','FAMILY DELUXE',4)
,('101','DELUXE',2)
,('103','STANDARD',2)
,('105','SUPERIOR',2)
,('201','DELUXE',2)
,('203','STANDARD',2)
,('205','SUPERIOR',2)
,('301','FAMILY SUITE',4)
,('305','SUPERIOR',2)
,('401','FAMILY SUITE',4)
,('405','SUPERIOR',2)

insert into ROOMTYPE
values('SUPERIOR',736000)
,('STANDARD',644000)
,('DELUXE',1012000)
,('PREMIUM DELUXE',1242000)
,('FAMILY DELUXE',1380000)
,('FAMILY SUITE',1564000)

insert into BOOKINGTYPE
values ('001','AGODA')
,('002','Booking')
,('003','Free')

insert into Guest values ('unk1','noname','1/1/2018','MAL')
,('00000001','quoc cuong nguyen','1/1/2018','VIE')

select * from Booking
insert into BOOKING
values
(8,'205','00000001','001',001,'11/26/2018','11/28/2018 14:00:00','11/30/2018 12:00:00',1)
,(7,'205','00000001','001',001,'11/26/2018','11/26/2018 14:00:00','11/27/2018 12:00:00',1)
,(6,'201','00000001','001',001,'11/26/2018','11/26/2018 14:00:00','11/27/2018 12:00:00',1)
,(5,'203','00000001','001',001,'11/26/2018','11/25/2018 14:00:00','11/26/2018 12:00:00',0)
,(4,'201','00000001','001',001,'11/26/2018','11/26/2018 14:00:00','11/27/2018 12:00:00',1)
,(3,'105','00000001','001',001,'11/23/2018','11/24/2018 14:00:00','11/26/2018 12:00:00',1)
,(2,'103','00000001','001',001,'11/23/2018','11/24/2018 14:00:00','11/26/2018 12:00:00',0)
,(1,'103','00000001','001',001,'11/23/2018','11/23/2018 14:00:00','11/24/2018 12:00:00',0)


insert into CONSUME
values
(8,'001',0,0,0,0,0,0)
,(7,'001',1,1,1,1,1,1)
,(6,'001',0,0,0,0,0,0)
,(5,'001',0,0,0,0,0,0)
,(4,'001',0,0,0,0,0,0)
,(3,'001',0,0,0,0,0,0)
,(2,'001',0,0,0,0,0,0)
,(1,'001',0,0,0,0,0,0)

insert into prepaid
values
(8,'001',0,null,0)
,(7,'001',1000000,'11/27/2018',001)
,(6,'001',0,null,0)
,(5,'001',0,null,0)
,(4,'001',0,null,0)
,(3,'001',0,null,0)
,(2,'001',0,null,0)
,(1,'001',0,null,0)

select IDinfo from booking
	where checkin <= getdate() and CHECKOUT > getdate()

select * from booking where Roomid = '101  '
and checkin <= 11/24/2018 and CHECKOUT > 11/24/2018

select * from Guest where IDinfo in (select IDinfo from booking
	where checkin <= getdate() and CHECKOUT > getdate())

select  Fullname , booking.RoomID ,ROOMTYPEID,Checkin,checkout
from (Booking left join GUEST on booking.idinfo = guest.idinfo) left join room on booking.ROOMID = ROOM.ROOMID
where checkin <= '11/27/2018 1:40:00' and CHECKOUT >= '11/27/2018 1:40:00'

select * from booking where checkin >= '11/11/2018' or CHECKOUT <= '12/15/2018 '


insert into BOOKING (roomid,idinfo,BOOKINGTYPEID,NHANVIENID,date,CHECKIN,CHECKOUT,BREAKFAST)
values
('205','00000001','001',001,'11/26/2018','11/28/2018 14:00:00','11/30/2018 12:00:00',1)

select * from ROOMTYPE where ROOMTYPEID = 'SUPERIOR'
select * from Guest where IDINFO like 'unk%%'

update GUEST set IDINFO = 'unk1',FullNAME = 'ga tai chanh' where idinfo = '000000002'

select * from booking where BOOKINGID = 1 and BOOKINGTYPEID ='001'