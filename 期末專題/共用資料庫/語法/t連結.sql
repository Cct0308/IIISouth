create table t連結
(fId int primary key IDENTITY(1,1),
fName nvarchar(50),
fPic nvarchar(50),
fConnection nvarchar(MAX)
)

insert into t連結(fName,fPic,fConnection)
values ('高雄市政府社會局','../images/1.jpg','http://socbu.kcg.gov.tw/'),
	   ('衛生福利部社會及家庭署','../images/2.jpg','http://www.sfaa.gov.tw/SFAA/default.aspx'),
	   ('中華民國家庭照顧者關懷總會','../images/3.jpg','http://www.familycare.org.tw'),
	   ('中華民國老人福利推動聯盟','../images/4.jpg','http://www.oldpeople.org.tw'),
	   ('台灣失智症協會','../images/5.jpg','http://www.tada2002.org.tw/'),
	   ('衛生福利部','../images/6.jpg','http://www.mohw.gov.tw/CHT/Ministry/Index.aspx'),
	   ('高雄市家庭照顧者關懷協會','../images/7.jpg','http://www.caregiver.org.tw/'),
	   ('台灣長期照顧專業協會','../images/8.jpg','http://www.ltcpa.org.tw/main.php')