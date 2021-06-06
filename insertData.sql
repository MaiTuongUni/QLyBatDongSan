use QuanLyBatDongSan
go

insert into clients(firstname,lastname,phonenumber,email,address) values 
(N'Hà',N'Nguyễn','0911000999','hangyen@gmail.com',N'26 lạc long, quận Tân Bình'),
(N'Tây',N'Mai','0123638636','maitay@gmail.com',N'26 Quang Trung, quận Tân Bình'),
(N'Văn',N'Nguyễn','0911000999','nguyenvan@gmail.com',N'26 lạc long quân, Tân Bình'),
(N'Hà',N'Thanh','0911000999','thanhha@gmail.com',N'26 lạc long quân, Tân Bình'),
(N'Xuân',N'Long','0911000999','longxuan@gmail.com',N'26 lạc long quân, Tân Bình');
go

insert into property_type(name,description) values
(N'Tên thuộc tính',N'Mô tả ngắn'),
(N'Tên thuộc tính 2',N'Mô tả ngắn'),
(N'Tên thuộc tính 3',N'Mô tả ngắn'),
(N'Tên thuộc tính 4',N'Mô tả ngắn'),
(N'Tên thuộc tính 5',N'Mô tả ngắn');
go

insert into owner(firstname,lastname,phone,email,address) values 
(N'Chủ 1',N'Nhà','8080678546','email@gmail.com','Long An'),
(N'Chủ 2',N'Nhà','8080678546','email@gmail.com','TP HCM'),
(N'Chủ 3',N'Nhà','8080678546','email@gmail.com','Đồng Nai'),
(N'Chủ 4',N'Nhà','8080678546','email@gmail.com','Vũng Tàu'),
(N'Chủ 5',N'Nhà','8080678546','email@gmail.com','Thanh Hóa');
go

insert into property(type,squarefeet,ownerId,price,address,bedroom,age,balcony,pool,backyard,garage,description) values
(1,100,1,'2.000.000',N'86 Nguyễn Tài Lộc',3,1,1,1,2,1,N'Nhà đẹp'),
(2,200,2,'20.000.000',N'86 Nguyễn Tài Lộc',3,1,1,1,2,1,N'Nhà đẹp'),
(3,200,3,'3.000.000',N'86 Nguyễn Tài Lộc',3,1,1,1,2,1,N'Nhà đẹp'),
(4,100,4,'4.000.000',N'86 Nguyễn Tài Lộc',3,1,1,1,2,1,N'Nhà đẹp'),
(5,50,5,'500.000',N'86 Nguyễn Tài Lộc',3,1,1,1,2,1,N'Nhà đẹp');
go

insert into sale(propertyId,clientId,finalprice) values
(1,1,'1.000.000'),
(2,2,'2.000.000'),
(3,3,'3.000.000'),
(4,4,'1.000.000'),
(5,5,'600.000');
go

insert into users(username,password) values
('user1','user1'),
('user2','user2');
go