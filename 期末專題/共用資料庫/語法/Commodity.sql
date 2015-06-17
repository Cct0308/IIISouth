use dbKSYY 
go

create table tCommodity
(fId int primary key identity(1,1),
 fNo nvarchar(max),
 fContent nvarchar(max),
 fColor bit)

insert into tCommodity(fNo,fContent,fColor)
values('1.盥洗用具:','毛巾5條、浴巾1條、牙刷、漱口杯、牙膏、漱口水、潔牙棒','false'),
	  ('2.沐浴用品:','清潔手套、臉盆、沐浴球2個（一個洗澡用一個洗腳用）','false'),
	  ('3.清潔用品:','衛生紙、紙尿褲、小尿片、看護墊、濕紙巾、尿套、尿套固定帶','false'),
	  ('4.換洗及保暖衣物:','睡衣或外出服6套、外套、襪子、止滑鞋子（包鞋及拖鞋）','false'),
	  ('5.餐具:','茶杯（有刻度）、個人餐具、筷子、湯匙(依個人需求)','false'),
	  ('6.保養品:','梳子、鏡子、電動刮鬍刀、指甲刀、乳液、凡士林、面霜','false'),
	  ('7.護理耗材:','抽痰管、紗布、棉棒','false'),
	  ('8.其他:','輪椅、助行器 、特殊藥品','false')