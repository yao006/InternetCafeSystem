use InternetCafe

--管理员表
create table manager(
id int primary key identity(1,1) not null,
adminname varchar(20) not null,
password  varchar(20) not null
)

insert into manager values('admin','123456')
select * from manager
--会员表
create table vip(
vid int primary key identity(1,1) not null,
vnum varchar(20) not null,
vpassword varchar(20) not null,
vbalance int,  --卡上余额
vtime date not null, --注册时间
)

select * from vip where vnum = '12345678'
insert into vip(vnum,vpassword,vbalance,vtime)values('12345678','111',0,getdate())

DELETE FROM vip
WHERE vnum='934499656'


--电脑表
create table computer(
pcid int primary key identity(1,1),--电脑序号
pcname varchar(10) not null unique,--电脑编号
pcgraphics varchar(50) not null,--电脑显卡
pcstate int not null,--电脑状态  0为待机，1为上机
pcnode varchar(300)--电脑描述
)

--上机记录表
create table starttime(
rid int primary key identity(1,1),--记录序号
vnum varchar(20) not null,--会员账号
computernum varchar(20) not null,--电脑编号
starttime datetime,--开始时间
rstate int not null--记录状态
)

create table endtime(
rid int primary key identity(1,1),--记录序号
vnum varchar(20) not null,--会员账号
computernum varchar(20) not null,--电脑编号
endtime datetime,--结束时间
rstate int not null--记录状态
)

select pcid '电脑序号',pcname '电脑编号',pcgraphics '显卡',pcnode '描述',(case pcstate when 0 then '待机' when 1 then '上机' end)状态  from computer

insert into computer (pcname,pcgraphics,pcstate,pcnode) values('1001','GTX4060TI',0,'嘎嘎好用的电脑')

select vid as '会员序号',vnum as '会员账号',vbalance as '余额（元）',vtime as '注册时间' from vip where vnum like '%9344%'

select * from computer where pcname like '%02%'

select * from vip

update computer set pcstate = 0 where pcname = '1001'

update vip set vbalance = 220 - 20 where vnum = '55555555'

select * from starttime
select * from endtime
select * from computer
insert into starttime(vnum,computernum,starttime,rstate) values ('934499656','1001',GETDATE(),0)
insert into endtime(vnum,computernum,endtime,rstate) values ('934499656','1001',GETDATE(),0)

delete from starttime where vnum = '934499656'
delete from endtime where vnum = '934499656'

select top 1 starttime from starttime  where vnum = '934499656' and computernum = '1003' order by rid desc

select top 1 computernum from starttime  where vnum = '934499656'  order by rid desc


select a.vnum as '会员账号',a.computernum as '电脑编号',starttime as '上机时间',endtime as '下机时间' from starttime a,endtime b where a.vnum = b.vnum and a.vnum='934499656'


