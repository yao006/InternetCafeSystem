use InternetCafe

--����Ա��
create table manager(
id int primary key identity(1,1) not null,
adminname varchar(20) not null,
password  varchar(20) not null
)

insert into manager values('admin','123456')
select * from manager
--��Ա��
create table vip(
vid int primary key identity(1,1) not null,
vnum varchar(20) not null,
vpassword varchar(20) not null,
vbalance int,  --�������
vtime date not null, --ע��ʱ��
)

select * from vip where vnum = '12345678'
insert into vip(vnum,vpassword,vbalance,vtime)values('12345678','111',0,getdate())

DELETE FROM vip
WHERE vnum='934499656'


--���Ա�
create table computer(
pcid int primary key identity(1,1),--�������
pcname varchar(10) not null unique,--���Ա��
pcgraphics varchar(50) not null,--�����Կ�
pcstate int not null,--����״̬  0Ϊ������1Ϊ�ϻ�
pcnode varchar(300)--��������
)

--�ϻ���¼��
create table starttime(
rid int primary key identity(1,1),--��¼���
vnum varchar(20) not null,--��Ա�˺�
computernum varchar(20) not null,--���Ա��
starttime datetime,--��ʼʱ��
rstate int not null--��¼״̬
)

create table endtime(
rid int primary key identity(1,1),--��¼���
vnum varchar(20) not null,--��Ա�˺�
computernum varchar(20) not null,--���Ա��
endtime datetime,--����ʱ��
rstate int not null--��¼״̬
)

select pcid '�������',pcname '���Ա��',pcgraphics '�Կ�',pcnode '����',(case pcstate when 0 then '����' when 1 then '�ϻ�' end)״̬  from computer

insert into computer (pcname,pcgraphics,pcstate,pcnode) values('1001','GTX4060TI',0,'�¸º��õĵ���')

select vid as '��Ա���',vnum as '��Ա�˺�',vbalance as '��Ԫ��',vtime as 'ע��ʱ��' from vip where vnum like '%9344%'

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


select a.vnum as '��Ա�˺�',a.computernum as '���Ա��',starttime as '�ϻ�ʱ��',endtime as '�»�ʱ��' from starttime a,endtime b where a.vnum = b.vnum and a.vnum='934499656'


