create database AKHospital
use AKHospital

--drop 
--create 

create table Patient
(
	PatientId int primary key,
	FirstName varchar(30),
	LastName varchar(30),
	Age int,
	Description varchar(100),
	PhoneNumber varchar(20),
	Status varchar(30)
)

create table Staff
(
	StaffId int primary key,
	FirstName varchar(30),
	LastName varchar(30),
	Role varchar(30),
	Username varchar(30),
	Password varchar(30),
	Logged int
)
insert into Staff values(1,'Dagmawi','Napoleon','Admin','DagmawiNapoleon','1234',0)

create table Medication
(
	MedicationId int primary key,
	MedicationName varchar(40)
)

create table Prescription
(
	PrescriptionId int primary key,
	PatientId int,
	MedicationId int
)

insertS 2,'Adel','Abdul','Surgeon','Adel','1234'

alter table Staff 
add constraint check_Logged
Check (Logged in (0,1))

alter table Patient
add constraint check_status
Check (Status in ('Active','Inactive'))

alter table Staff
add constraint check_role
Check (Role in ('Surgeon','Nurse','Admin'))

alter table Prescription
add constraint fk_PatientId
foreign key (PatientId) references Patient(PatientId)

alter table Prescription
add constraint fk_MedicationId
foreign key (MedicationId) references Medication(MedicationId)
 

select * from Patient
select * from Staff
select * from Medication
select * from Prescription  

--==============================================================================
go
create proc CheckLogin 
	@Username varchar(30),
	@Password varchar(30)
as
begin
	select StaffId, FirstName+' '+LastName as [Staff Name], Role from Staff
	where Username in (@Username) and Password in (@Password) 
end
--==============================================================================
go
create proc Login
	@Username varchar(30)
as
begin
	update Staff
	set Logged = 1
	where Username = @Username

	update Staff
	set Logged = 0
	where Username not in (@Username)
end
--==============================================================================
go
create proc logout
as
begin
	update Staff
	set Logged = 0
end

 ------------------------------- PATIENT ---------------------------------------
go 
create proc insertP
	@PatientId int,
	@FirstName varchar(30),
	@LastName varchar(30),
	@Age int,
	@Description varchar(100),
	@PhoneNumber varchar(20),
	@Status varchar(30)
as
begin
	insert into Patient values
	(@PatientId,@FirstName,@LastName,@Age,@Description,@PhoneNumber,@Status)
end
--==============================================================================
go
alter proc updateP
	@PatientId int,
	@FirstName varchar(30),
	@LastName varchar(30),
	@Age int,
	@Description varchar(100),
	@PhoneNumber varchar(20),
	@Status varchar(30)
as
begin
	update Patient
	set FirstName = @FirstName,  LastName = @LastName, Age = @Age, Description = @Description, PhoneNumber = @PhoneNumber, Status = @Status
	where PatientId = @PatientId
end
--==============================================================================
go
create proc setInactive
	@PatientId int,
	@Status varchar(30)
as
begin
	update Patient
	set Status = @Status
	where PatientId = @PatientId
end
--==============================================================================
go
create proc getP
as
begin
	select * from Patient
end
--==============================================================================
go
create proc getAP
as
begin
	select * from Patient where Status like 'Active'
end
--==============================================================================
go
create proc getIP
as
begin
	select * from Patient where Status like 'Inactive'
end

------------------------------- STAFF ---------------------------------------
go 
create proc insertS
	@StaffId int,
	@FirstName varchar(30),
	@LastName varchar(30),
	@Role varchar(30),
	@Username varchar(30),
	@Password varchar(30)
as
begin
	insert into Staff values
	(@StaffId,@FirstName,@LastName,@Role,@Username,@Password,0)
end
--==============================================================================
go
create proc updateS
	@StaffId int,
	@FirstName varchar(30),
	@LastName varchar(30),
	@Role varchar(30),
	@Username varchar(30),
	@Password varchar(30)
as
begin
	update Staff
	set FirstName = @FirstName, LastName = @LastName, Role = @Role, Username = @Username, Password = @Password
	where StaffId = @StaffId 
end
--==============================================================================
go
create proc deleteS
	@StaffId int
as
begin
	delete from Staff
	where StaffId = @StaffId 
end
--==============================================================================
go
create proc getS
as
begin
	select StaffId, FirstName+' '+LastName as [Staff Name], Role, Username from Staff
end
--==============================================================================
go
create proc getAdmins
as
begin
	select StaffId, FirstName+' '+LastName as [Staff Name], Role, Username from Staff where Role like 'Admin'
end
--==============================================================================
go
create proc getSurgeons
as
begin
	select StaffId, FirstName+' '+LastName as [Staff Name], Role, Username from Staff where Role like 'Surgeon'
end
--==============================================================================
go
create proc getNurses
as
begin
	select StaffId, FirstName+' '+LastName as [Staff Name], Role, Username from Staff where Role like 'Nurse'
end

------------------------------- MEDICATION ---------------------------------------
go  
create proc insertM
	@MedicationId int,
	@MedicationName varchar(40),
	@PrescribedFor varchar(100)
as
begin
	insert into Medication values
	(@MedicationId,@MedicationName,@PrescribedFor)
end
--==============================================================================
go
create proc updateM
	@MedicationId int,
	@MedicationName varchar(40),
	@PrescribedFor varchar(100)
as
begin
	update Medication
	set MedicationName = @MedicationName, PrescribedFor = @PrescribedFor
	where MedicationId = @MedicationId 
end
--==============================================================================
go
create proc deleteM
	@MedicationId int
as
begin
	delete from Medication
	where MedicationId = @MedicationId 
end
--==============================================================================
go
create proc getM
as
begin
	select * from Medication
end

go
alter table Medication
add PrescribedFor varchar(100)

------------------------------- PRESCRIPTION -------------------------------------
go  
create proc insertPre
	@PrescriptionId int,
	@PatientId int,
	@MedicationId int
as
begin
	insert into Prescription values
	(@PrescriptionId,@PatientId,@MedicationId)
end
--==============================================================================
go
create proc updatePre
	@PrescriptionId int,
	@PatientId int,
	@MedicationId int
as
begin
	update Prescription
	set PatientId = @PatientId, MedicationId = @MedicationId 
	where PrescriptionId = @PrescriptionId
end
--==============================================================================
go
create proc deletePre
	@PrescriptionId int
as
begin
	delete from Prescription
	where PrescriptionId = @PrescriptionId
end
--==============================================================================
go
create proc getPre
as
begin
	select Pre.PrescriptionId, Pa.FirstName + ' ' + Pa.LastName as [Patient Name], Med.MedicationName
	from Prescription as Pre
	inner join Patient as Pa
		on Pa.PatientId = Pre.PatientId 
	inner join Medication as Med
		on Med.MedicationId = Pre.MedicationId
end
--==============================================================================
go
create proc getPatientFirstName 
	@PatientId int
as
begin
	select FirstName from Patient where PatientId = @PatientId
end
--=============================================================================
go
create proc getPatientLastName 
	@PatientId int
as
begin
	select LastName from Patient where PatientId = @PatientId
end
--================================================================================	
go
create proc getMedicationName
	@MedicationId int
as
begin
	select MedicationName from Medication where MedicationId = @MedicationId
end



