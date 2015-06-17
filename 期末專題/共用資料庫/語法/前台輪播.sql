create table t前台輪播
(
 fId int primary key identity,
 fPic nvarchar(MAX),
 fFirst nvarchar(max),
 fSecond nvarchar(max),
 fThird nvarchar(max)
);

insert t前台輪播 (fPic,fFirst,fSecond,fThird)
values('\..\headImg\1.jpg','康欣','老人長期照顧中心【養護型】','關心．安心．放心'),
('\..\headImg\2.jpg','康欣','老人長期照顧中心【養護型】','鬧中取靜的世外桃源'),
('\..\headImg\3.jpg','康欣','老人長期照顧中心【養護型】','六星級庭院花園別墅');
