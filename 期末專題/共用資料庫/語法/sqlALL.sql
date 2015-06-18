create database dbKSYY 
go

use dbKSYY 
go

-----------------------------------------------------------------------------------------------------------

create table t前台輪播
(
 fId int primary key identity(1,1),
 fPic nvarchar(MAX),
 fFirst nvarchar(max),
 fSecond nvarchar(max),
 fThird nvarchar(max)
);

insert t前台輪播 (fPic,fFirst,fSecond,fThird)
values('\..\headImg\1.jpg','康欣','老人長期照顧中心【養護型】','關心．安心．放心'),
('\..\headImg\2.jpg','康欣','老人長期照顧中心【養護型】','鬧中取靜的世外桃源'),
('\..\headImg\3.jpg','康欣','老人長期照顧中心【養護型】','六星級庭院花園別墅');

-----------------------------------------------------------------------------------------------------------

create table tCommodity
(fId int primary key identity(1,1),
 fNo nvarchar(max),
 fContent nvarchar(max),
 fColor bit);

insert into tCommodity(fNo,fContent,fColor)
values('1.盥洗用具:','毛巾5條、浴巾1條、牙刷、漱口杯、牙膏、漱口水、潔牙棒','false'),
	  ('2.沐浴用品:','清潔手套、臉盆、沐浴球2個（一個洗澡用一個洗腳用）','false'),
	  ('3.清潔用品:','衛生紙、紙尿褲、小尿片、看護墊、濕紙巾、尿套、尿套固定帶','false'),
	  ('4.換洗及保暖衣物:','睡衣或外出服6套、外套、襪子、止滑鞋子（包鞋及拖鞋）','false'),
	  ('5.餐具:','茶杯（有刻度）、個人餐具、筷子、湯匙(依個人需求)','false'),
	  ('6.保養品:','梳子、鏡子、電動刮鬍刀、指甲刀、乳液、凡士林、面霜','false'),
	  ('7.護理耗材:','抽痰管、紗布、棉棒','false'),
	  ('8.其他:','輪椅、助行器 、特殊藥品','false');

-----------------------------------------------------------------------------------------------------------

create table tAttention
(fId int primary key identity(1,1),
 fNo nvarchar(max),
 fContent nvarchar(max),
 fColor bit);

insert into tAttention (fNo,fContent,fColor)
values('1.','個案入住前由家屬自行評估「日常照護評估表」，以利護理人員照護及收費。','false'),
      ('2.','評估後家屬自行備妥資料及物品後帶至機構入住或由救護車載來機構，其接送費用家屬自費。','false'),
	  ('3.','入住機構前向醫院申請病歷摘要(住院者須提供)，居家入住者須配合機構安排體檢其費用需自費，體檢報告內容需包含血液、尿液、生化檢查、胸部X光、寄生蟲、桿菌性痢疾、阿米巴痢疾…等。','false'),
	  ('4.','請攜帶住民健保卡、榮民證、身心障礙手冊方便住民就醫及委託人、緊急連絡人、住民之身分證及印章簽立委託照護契約。','false'),
	  ('5.','入住住民不得放現金或貴重物品(例：戒指、珠寶…等)，物品若遺失機構一概不負責。','false'),
	  ('6.','機構內嚴禁寵物進入。','false'),
	  ('7.','家屬攜帶食物請交由護理站處理，並請家屬攜帶安全且當餐可吃完分量之食物，請勿提供給其他住民食用，若家屬同意可由工作人員分配。','false'),
	  ('8.','請家屬配合機構訪客時間，以免打擾生活作息。早上9:00 ~11:00 下午14:00 ~ 20:00  ','True');

-----------------------------------------------------------------------------------------------------------

CREATE TABLE T床位系統
(
	f床號 nvarchar(10) primary key,
	f入住日期 date  NULL,
	f姓名 nvarchar(50)  NULL,
	f身份證字號 nvarchar(20)  NULL,
	f生日 date  NULL,
	f住址 nvarchar(200)  NULL,
	f家電 nchar(10) NULL ,
	f聯絡人 nvarchar(50)  NULL,
	f聯絡人家電 nvarchar(20)  NULL,
	f聯絡人手機 nvarchar(20)  NULL,
	f指定醫院 nvarchar(100) NULL,
	f是否住院中 int not NULL ,
	f鼻胃管 int NOT NULL,
	f導尿管 int NOT NULL,
	f其他管路 nvarchar(150) NULL ,
	f耗材 nvarchar(150)  NULL,
	f其他 nvarchar(200) NULL ,
	f備註 nvarchar(500) NULL,
	f照片 nvarchar(500) NULL,
	f宗教 nvarchar(200) NULL
);

select * from T床位系統

insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('101',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('102-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('102-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('102-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('102-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('102-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('103-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('103-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('105-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('105-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('105-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('105-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('105-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('106-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('106-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('106-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('106-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('106-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('107-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('107-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('107-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('107-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('107-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('108-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('108-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('108-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('108-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('108-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('109-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('109-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('109-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('109-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('109-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('110-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('110-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('110-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('110-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('110-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('111-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('111-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('112-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('112-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('112-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('112-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('112-6(E)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('113-1(A)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('113-2(B)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('113-3(C)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('113-5(D)',0,0,0)
insert into T床位系統(f床號,f是否住院中,f鼻胃管,f導尿管)values ('113-6(E)',0,0,0)

/*
insert into T床位系統 (f床號)
values('101'),('102-1(A)'),('102-2(B)'),('102-3(C)'),('102-5(D)'),
      ('102-6(E)'),('103-1(A)'),('103-2(B)'),('105-1(A)'),('105-2(B)'),
	  ('105-3(C)'),('105-5(D)'),('105-6(E)'),('106-1(A)'),('106-2(B)'),
	  ('106-3(C)'),('106-5(D)'),('106-6(E)'),('107-1(A)'),('107-2(B)'),
	  ('107-3(C)'),('107-5(D)'),('107-6(E)'),('108-1(A)'),('108-2(B)'),
	  ('108-3(C)'),('108-5(D)'),('108-6(E)'),('109-1(A)'),('109-2(B)'),
	  ('109-3(C)'),('109-5(D)'),('109-6(E)'),('110-1(A)'),('110-2(B)'),
	  ('110-3(C)'),('110-5(D)'),('110-6(E)'),('111-1(A)'),('111-2(B)'),
	  ('112-1(A)'),('112-2(B)'),('112-3(C)'),('112-5(D)'),('112-6(E)'),
	  ('113-1(A)'),('113-2(B)'),('113-3(C)'),('113-5(D)'),('113-6(E)');
	  */
-----------------------------------------------------------------------------------------------------------

create table T康欣_活動剪影
(
 fid int primary key identity(1,1),
 f欄位名稱 nchar(10),
 f庭院照片_s nvarchar(1000),
 f庭院照片_l nvarchar(1000),
 f內部照片_s nvarchar(1000),
 f內部照片_l nvarchar(1000),
 f慶生照片_s nvarchar(1000),
 f慶生照片_l nvarchar(1000),
 f泡腳照片_s nvarchar(1000),
 f泡腳照片_l nvarchar(1000),
 f復健照片_s nvarchar(1000),
 f復健照片_l nvarchar(1000),
 f義剪照片_s nvarchar(1000),
 f義剪照片_l nvarchar(1000),
 f其他活動_s nvarchar(1000),
 f其他活動_l nvarchar(1000)
);

insert into T康欣_活動剪影 (f欄位名稱,f庭院照片_s,f庭院照片_l,f內部照片_s,f內部照片_l,f慶生照片_s,f慶生照片_l,f泡腳照片_s,f泡腳照片_l,f復健照片_s,f復健照片_l,f義剪照片_s,f義剪照片_l,f其他活動_s,f其他活動_l)
values('庭院環境',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (1).jpg','慶生_102 (1)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
      ('內部設施',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (2).jpg','慶生_102 (2)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  ('慶生剪影',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (3).jpg','慶生_102 (3)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  ('泡腳',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (4).jpg','慶生_102 (4)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  ('復健',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (5).jpg','慶生_102 (5)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  ('義剪',NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (6).jpg','慶生_102 (6)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (7).jpg','慶生_102 (7)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (1).jpg','outlook_L (1).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (2).jpg','outlook_L (2).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (3).jpg','outlook_L (3).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (4).jpg','outlook_L (4).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (5).jpg','outlook_L (5).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (6).jpg','outlook_L (6).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (7).jpg','outlook_L (7).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (8).jpg','outlook_L (8).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (9).jpg','outlook_L (9).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (10).jpg','outlook_L (10).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (11).jpg','outlook_L (11).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (12).jpg','outlook_L (12).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (13).jpg','outlook_L (13).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (14).jpg','outlook_L (14).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (15).jpg','outlook_L (15).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (16).jpg','outlook_L (16).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (17).jpg','outlook_L (17).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (18).jpg','outlook_L (18).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (19).jpg','outlook_L (19).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (20).jpg','outlook_L (20).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (21).jpg','outlook_L (21).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (22).jpg','outlook_L (22).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (23).jpg','outlook_L (23).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (24).jpg','outlook_L (24).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (25).jpg','outlook_L (25).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (26).jpg','outlook_L (26).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (27).jpg','outlook_L (27).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (28).jpg','outlook_L (28).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,'\..\pic\康欣_照片\外觀\outlook_L (29).jpg','outlook_L (29).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (1).jpg','inside_L (1).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (2).jpg','inside_L (2).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (3).jpg','inside_L (3).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (4).jpg','inside_L (4).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (5).jpg','inside_L (5).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (6).jpg','inside_L (6).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (7).jpg','inside_L (7).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (8).jpg','inside_L (8).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,'\..\pic\康欣_照片\內部\inside_L (9).jpg','inside_L (9).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (1).jpg','慶生_102 (1).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (2).jpg','慶生_102 (2).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (3).jpg','慶生_102 (3).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (4).jpg','慶生_102 (4).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (5).jpg','慶生_102 (5).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (6).jpg','慶生_102 (6).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\慶生\慶生_102 (7).jpg','慶生_102 (7).jpg',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\泡腳\泡腳 (1).jpg','泡腳 (1).jpg',NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\泡腳\泡腳 (2).jpg','泡腳 (2).jpg',NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\泡腳\泡腳 (3).jpg','泡腳 (3).jpg',NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\泡腳\泡腳 (4).jpg','泡腳 (4).jpg',NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\泡腳\泡腳 (5).jpg','泡腳 (5).jpg',NULL,NULL,NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (1).jpg','復健_L (1).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (2).jpg','復健_L (2).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (3).jpg','復健_L (3).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (4).jpg','復健_L (4).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (5).jpg','復健_L (5).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (6).jpg','復健_L (6).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (7).jpg','復健_L (7).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (8).jpg','復健_L (8).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (9).jpg','復健_L (9).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (10).jpg','復健_L (10).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (11).jpg','復健_L (11).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (12).jpg','復健_L (12).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (13).jpg','復健_L (13).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (14).jpg','復健_L (14).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (15).jpg','復健_L (15).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (16).jpg','復健_L (16).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (17).jpg','復健_L (17).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (18).jpg','復健_L (18).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (19).jpg','復健_L (19).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (20).jpg','復健_L (20).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (21).jpg','復健_L (21).jpg',NULL,NULL,NULL,NULL),
	  (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\..\pic\康欣_照片\復健\復健_L (22).jpg','復健_L (22).jpg',NULL,NULL,NULL,NULL);
	  --('NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL','NULL'),


-----------------------------------------------------------------------------------------------------------

CREATE TABLE tNews (
    fId      INT primary key IDENTITY (1, 1),
    fDate    NVARCHAR (50)  ,
    fSubject NVARCHAR (MAX) ,
    fContent NVARCHAR (MAX) ,
    fYear    NVARCHAR (10)  ,
    fMonth   NVARCHAR (10)  ,
    fDay     NVARCHAR (10)  ,
    fPreview NVARCHAR (MAX) ,    
);

insert into tNews(fDate,fSubject,fContent,fYear,fMonth,fDay,fPreview)
values ('2015年6月10日','test0610-1','<p>test0610-1</p>','2015','Jun','10',''),
	   ('2015年6月10日','test0610-2','<p>test0610-2</p>','2015','Jun','10',''),
	   ('2015年6月10日','test0610-3','<p>test0610-3</p>','2015','Jun','10',''),
	   ('2015年6月10日','test0610-4','<p>test0610-4</p>','2015','Jun','10',''),
	   ('2015年6月10日','test0610-5','<p>test0610-5</p>','2015','Jun','10',''),
	   ('2015年6月15日','邀朱立倫搭檔？洪秀柱：他沒意願','<p><span style="font-size:24px"><span style="color:rgb(0, 0, 255)">立法院副院長洪秀柱通過國民黨總統初選民調</span></span>，是否邀朱立倫擔任副手？洪秀柱今日表示，朱立倫沒參加初選，心意說得很明白，基本上他沒意願。</p><p>&nbsp;</p><p>洪秀柱指出，曾在閒談中對朱立倫說「找不到人那你咧」，朱回應「不要開玩笑」，兩人非正式談副手問題。會不會再正式地找朱談？洪說，朱立倫和大家都在幫忙想什麼樣的副手更合適，慢慢來不急。</p><p>&nbsp;</p><p>副手是否可來自南部或非國民黨員？洪秀柱說，不一定要有某些限制，只要有好人選都可以。</p>','2015','Jun','15','立法院副院長洪秀柱通過國民黨總統初選民調...'),
	   ('2015年6月15日','工時長早晚不定 輪班勞工淚：私生活變罪惡','<p><span style="color:#FF0000">台灣很多工作都是輪班制</span>，每天工作時間不固定，連帶影響生理作息及身體健康。台灣勞工陣線針對輪班制員工進行網路調查，發現有超過6成以上輪班勞工每日工作時數超過8小時，其中又以醫療保健與社會服務業排班最為複雜，常見早中晚班交雜的「花花班」；有7成以上勞工，認為輪班制已嚴重影響家庭及社交生活，有服務與售貨業人員抱怨沒有私人時間，「私生活變成一種罪惡」。</p><p>&nbsp;</p><p>台灣勞動與社會政策研究協會執行長張烽益指出，立法院日前三讀通過《勞基法》每周40小時工時修法，但很多勞工工作是輪班制，工時降低並不能保證勞工實際工時下降，勞陣今年5月25日到6月12日間在網路上發起調查，總計回收215個個案，其中6成都是醫療保健服務業，其次為製造業13％、半導體電子業9％，男女比約4比6。</p><p>&nbsp;</p><p>實際了解輪班制排班型態，張烽益表示，半導體與電子業多為兩班制輪班，製造業則多為3班制，排班最為複雜的是醫療保健與社會服務業，為應付醫院24小時營運，多是三班制，常見「花花班」，一個月內早中晚班都會有，排班混亂，對勞工身心有很大影響。</p><p>&nbsp;</p><p>年資22年的醫療保健業女性在問卷裡感嘆，上班時可能隨時被告知下午或隔天早上放假，放假也可能隨時被叫回去上班，輪班時間很不穩定；也有女性說，因隨時on call，引起睡眠障礙；還有服務業銷售人員抱怨「工作超級累」，薪水不到23K，根本不像人，「像機器」。</p><p>&nbsp;</p><p>台灣職業安全健康連線理事長、台大公衛學院健康政策與管理所教授鄭雅文指出，夜班輪班會影響勞工睡眠品質，勞工因無法獲得充分休息，可能引發通勤事故，還可能造成心血管、消化道、代謝系統等慢性疾病，也已被國際證明可能增加罹癌風險。</p><p>&nbsp;</p><p>鄭雅文說，國際對於夜間輪班多另訂規範，如歐盟2003年發布《工作時間指令》，明定夜間工作者工時不得超過8小時，且雇主應提供免費健康評估，若健康問題確定與夜間工作有關，雇主須將勞工轉換至日間工作；英國、德國、北歐各國相關規範更嚴格，但台灣卻缺乏法令保障。</p><p>&nbsp;</p><p>勞陣秘書長孫友聯表示，很多24小時工作非必要，呼籲勞動部應對輪班工作有更多管理，包括限縮不當輪班，對於非得要輪班的勞工，也應在法規上有更多保障，並應定期針對輪班產業進行勞動檢查。</p>','2015','Jun','15','台灣很多工作都是輪班制，每天工作時間不固定...');

-----------------------------------------------------------------------------------------------------------

create table t連結
(fId int primary key IDENTITY(1,1),
fName nvarchar(50),
fPic nvarchar(50),
fConnection nvarchar(MAX)
);

insert into t連結(fName,fPic,fConnection)
values ('高雄市政府社會局','../images/1.jpg','http://socbu.kcg.gov.tw/'),
	   ('衛生福利部社會及家庭署','../images/2.jpg','http://www.sfaa.gov.tw/SFAA/default.aspx'),
	   ('中華民國家庭照顧者關懷總會','../images/3.jpg','http://www.familycare.org.tw'),
	   ('中華民國老人福利推動聯盟','../images/4.jpg','http://www.oldpeople.org.tw'),
	   ('台灣失智症協會','../images/5.jpg','http://www.tada2002.org.tw/'),
	   ('衛生福利部','../images/6.jpg','http://www.mohw.gov.tw/CHT/Ministry/Index.aspx'),
	   ('高雄市家庭照顧者關懷協會','../images/7.jpg','http://www.caregiver.org.tw/'),
	   ('台灣長期照顧專業協會','../images/8.jpg','http://www.ltcpa.org.tw/main.php');

-----------------------------------------------------------------------------------------------------------

create table about
(
 id int primary key IDENTITY(1,1),
 article nvarchar(max)
);

insert into about (article)
values('<p><span style="color:rgb(0, 0, 204)">康欣養護中心</span>於90年6月30日立案49床，位於溪北街開業逾十年，因典寶溪上游河道過於狹窄，加上又位處低漥地區，大雨一來就宣洩不及，年年飽受淹水及緊急撤離院民之苦。故邱院長斥資上億元，打造4層樓高之長期照護家園，將原有<span style="color:rgb(0, 0, 204)">康欣養護中心</span>遷移至本棟建築之一樓，二樓至四樓將籌設護理之家。</p>

<p>將提供之服務內容有：護理服務、生活照顧、就醫服務、營養服務、復健服務、靈性照顧、入住適應輔導、活動安排、志工關懷&hellip;等之服務特色，服務內容詳述如下：</p>

<ol>
	<li><span style="color:rgb(153, 0, 255)">護理服務</span>：將聘任4位護理人員提供護理服務，本機構實施主護護理制度，每位住民有其主責之護理人員，給予身體、心理、社會之全面評估，擬定照護計畫及定期評值修正照護計畫。</li>
	<li><span style="color:rgb(153, 0, 255)">生活照顧</span>：將聘任7位照顧服務員，提供二十四小時貼心之生活照顧，照料住民日常生活起居。</li>
	<li><span style="color:rgb(153, 0, 255)">就醫服務</span>：與合格救護運輸公司簽訂合約，住民可方便就醫；並與醫院簽訂合約，提供門診、住院等就醫需求之轉診服務。</li>
	<li><span style="color:rgb(153, 0, 255)">營養服務</span>：聘任營養師針對住民體位、健康狀況、個別喜好進行營養評估，每月追蹤體重及異常營養指標，定期追蹤並修正營養照護計畫，提供符合住民個別需求的治療飲食及供應多樣化之快樂餐。</li>
	<li><span style="color:rgb(153, 0, 255)"><strong>復健服務</strong></span>：<span style="color:rgb(153, 0, 0)">與合約醫院合作聘任之復健科醫師，定期評估住民日常生活技巧、功能性活動、輔具需求，執行復健治療項目，以提供有需求之住民復健服務，增進住民自我照顧之能力，可重返社區。</span></li>
	<li><span style="color:rgb(153, 0, 255)">靈性照顧</span>：尊重個人信仰，容許住民床旁擺設宗教信仰之物品；特設立獨立之宗教室，提供住民宗教崇拜活動，並與宗教團體合作定期關懷住民。</li>
	<li><span style="color:rgb(153, 0, 255)">入住適應輔導</span>：由護理人員及社工協助新入住住民適應機構環境、常規及人員之認識，給予心理情緒之輔導，預防住民遷移壓力症候群之發生。</li>
	<li><span style="color:rgb(153, 0, 255)">活動安排</span>：由社工設計及帶領，定期舉辦團體、個別性及社區活動，如：慶生會、節慶慶祝活動及各類團康活動等，豐富住民生活內容。</li>
	<li><span style="color:rgb(153, 0, 255)">志工關懷</span>：結合社區資源，開發個人及團體志工，定期關懷住民生活，讓住民期待社區好友造訪。</li>
</ol>

<p><span style="color:#FF0000">康欣養護中心邱美玲院長以營造快樂的老人家園為宗旨，十幾年來已照顧上千名長輩，相信以院長的服務理念延伸至護理之家，加上專業且堅強的工作團隊必能將本機構成為優質之機構。</span></p>
');

-----------------------------------------------------------------------------------------------------------

create table Fees_table_1
(
 id int primary key IDENTITY(1,1),
 room nvarchar(MAX),
 price nvarchar(MAX),
 care nvarchar(MAX),
 careprice nvarchar(MAX)
);

insert into Fees_table_1 (room,price,care,careprice)
values('五人房','25000元','鼻胃管護理','1000元'),
	  ('四人房','26500元','導尿管護理','1000元'),
	  ('二人房','32000元','機構內復健','1500元'),
	  ('保證金','30000元','救護車','1200~1600元/單趟（含隨車人員）');

-----------------------------------------------------------------------------------------------------------

create table note
(
 id int primary key identity(1,1),
 content nvarchar(MAX)
)

insert into note(content)
values('<ol>
	<li>單人隔離房平日不使用，若需使用時即按元住房收費標準收費</li>
	<li>另外收費項目有：管灌特殊配方、護理耗材、就醫費用、掛號費、體檢費、日常用品耗材（全包3000元）&hellip;等</li>
	<li>每月基本費及照護費須於月初預繳，消耗品月結，於次月繳交</li>
</ol>

<p><span style="color:rgb(51, 51, 204); font-family:微軟正黑體,新細明體,verdana,arial,helvetica,sans-serif; font-size:large">&nbsp; &nbsp; &nbsp; &nbsp; 匯款：郵局代號700&nbsp;&nbsp; 帳號：0101523 0098245 邱美玲</span></p>
');