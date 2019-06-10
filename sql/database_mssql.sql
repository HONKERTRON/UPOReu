USE [UPOReu] ;

-- -----------------------------------------------------
-- Table [USERS]
-- -----------------------------------------------------
CREATE TABLE [USERS] (
  [idUSERS] INT  NOT NULL IDENTITY(1, 1),
  [name] VARCHAR(255) NOT NULL,
  [last_name] VARCHAR(255) NOT NULL,
  [patronym] VARCHAR(255) NULL,
  [phone_number] VARCHAR(255) NULL,
  [email] VARCHAR(255) NULL,
  [role] INT NOT NULL DEFAULT 1,
  [username] VARCHAR(255) NOT NULL,
  [password] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([idUSERS]))

-- -----------------------------------------------------
-- Table [OBJECTS]
-- -----------------------------------------------------
CREATE TABLE [OBJECTS] (
  [idOBJECT] INT NOT NULL IDENTITY(1, 1),
  [name_object] VARCHAR(255) NOT NULL,
  [adress] VARCHAR(255) NOT NULL,
  [idUSERS] INT NULL,
  [idRRTOSZ] INT NULL,
  [idPPSPPZ] INT NULL,
  [idUPPPT] INT NULL,
  [idUO] INT NULL,
  PRIMARY KEY ([idOBJECT]),
  CONSTRAINT [fk_OBJECT_USERS]
    FOREIGN KEY ([idUSERS])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [OBJECT_STATE]
-- -----------------------------------------------------
CREATE TABLE [OBJECT_STATE] (
  [OBJECT_STATEid] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NOT NULL,
  [description] TEXT NOT NULL,
  [idOBJECT] INT NOT NULL,
  PRIMARY KEY ([OBJECT_STATEid]),
  CONSTRAINT [fk_OBJECT_STATE_OBJECT1]
    FOREIGN KEY ([idOBJECT])
    REFERENCES [OBJECTS] ([idOBJECT])
    )


-------------------------------------------------
-- Table [RRTOSZ]
-- -----------------------------------------------------
CREATE TABLE [RRTOSZ] (
  [idOBJECT] INT NULL,
  [idRRTOSZ] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NOT NULL,
  [type_system] VARCHAR(255) NULL,
  [type_work] VARCHAR(255) NULL,
  [description] VARCHAR(255) NULL,
  [result_state] VARCHAR(255) NULL,
  [result_work] VARCHAR(255) NULL,
  [worker] INT NULL,
  CONSTRAINT [fk_OBJECTS_RRTOSZ1]
    FOREIGN KEY ([idOBJECT])
    REFERENCES [OBJECTS] ([idOBJECT])
    ,
  PRIMARY KEY ([idRRTOSZ]),
  CONSTRAINT [fk_RRTOSZ_USERS1]
    FOREIGN KEY ([worker])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [PPSPPZ]
-- -----------------------------------------------------
CREATE TABLE [PPSPPZ] (
  [idOBJECT] INT NULL,
  [idPPSPPZ] INT NOT NULL IDENTITY(1, 1),
  [date] DATETIME NULL,
  [person] INT  NOT NULL,
  [defect] VARCHAR(255) NULL,
  [fixed] VARCHAR(255) NULL,
  [person_check] INT NOT NULL,
  PRIMARY KEY ([idPPSPPZ]),
  
  CONSTRAINT [fk_OBJECTS_PPSPPZ1]
    FOREIGN KEY ([idOBJECT])
    REFERENCES [OBJECTS] ([idOBJECT])
    ,
  CONSTRAINT [fk_PPSPPZ_USERS1]
    FOREIGN KEY ([person])
    REFERENCES [USERS] ([idUSERS])
    ,
  CONSTRAINT [fk_PPSPPZ_USERS2]
    FOREIGN KEY ([person_check])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [UPPPT]
-- -----------------------------------------------------
CREATE TABLE [UPPPT] (
  [idOBJECT] INT NULL,
  [idUPPPT] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NULL,
  [person] INT  NOT NULL,
  [topic] VARCHAR(255) NULL,
  [place] VARCHAR(255) NULL,
  [grade] VARCHAR(255) NULL,
  PRIMARY KEY ([idUPPPT]),
  CONSTRAINT [fk_OBJECTS_UPPPT1]
    FOREIGN KEY ([idOBJECT])
    REFERENCES [OBJECTS] ([idOBJECT])
    ,
  CONSTRAINT [fk_UPPPT_USERS1]
    FOREIGN KEY ([person])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [UO]
-- -----------------------------------------------------
CREATE TABLE [UO] (
  [idOBJECT] INT NULL,
  [idUO] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NOT NULL,
  [idUSERS] INT  NOT NULL,
  [apperience] VARCHAR(255) NULL,
  [mass] FLOAT NULL,
  [pressure] FLOAT NULL,
  [state] VARCHAR(255) NULL,
  [actions] VARCHAR(255) NULL,
  PRIMARY KEY ([idUO]),
  CONSTRAINT [fk_OBJECTS_UO1]
    FOREIGN KEY ([idOBJECT])
    REFERENCES [OBJECTS] ([idOBJECT]),
  CONSTRAINT [fk_UO_USERS1]
    FOREIGN KEY ([idUSERS])
    REFERENCES [USERS] ([idUSERS])
    )


-- -----------------------------------------------------
-- Table [MANUFACTURER]
-- -----------------------------------------------------
CREATE TABLE [MANUFACTURER] (
  [idMANUFACTURER] INT NOT NULL IDENTITY(1, 1),
  [name] VARCHAR(255) NULL,
  PRIMARY KEY ([idMANUFACTURER]))

-- -----------------------------------------------------
-- Table [TYPE_EX]
-- -----------------------------------------------------
CREATE TABLE [TYPE_EX] (
  [type_ex] INT NOT NULL IDENTITY(1, 1),
  [description] VARCHAR(255) NULL,
  PRIMARY KEY ([type_ex]))

-- -----------------------------------------------------
-- Table [EXTINGUSHER]
-- -----------------------------------------------------
CREATE TABLE [EXTINGUSHER] (
  [idEXTINGUSHER] INT NOT NULL IDENTITY(1, 1),
  [idUO] INT NOT NULL,
  [idMANUFACTURER] INT NOT NULL,
  [number] INT NULL,
  [date_start] DATE NULL,
  [place] VARCHAR(255) NULL,
  [mark] VARCHAR(255) NULL,
  [factory_number] INT NULL,
  [date_created] DATE NULL,
  [concentration] VARCHAR(255) NULL,
  [type_ex] INT NOT NULL,
  CONSTRAINT [fk_EXTINGUSHER_UO1]
    FOREIGN KEY ([idUO])
    REFERENCES [UO] ([idUO])
    ,
  CONSTRAINT [fk_EXTINGUSHER_MANUFACTURER1]
    FOREIGN KEY ([idMANUFACTURER])
    REFERENCES [MANUFACTURER] ([idMANUFACTURER])
    ,
  CONSTRAINT [fk_EXTINGUSHER_TYPE_EX1]
    FOREIGN KEY ([type_ex])
    REFERENCES [TYPE_EX] ([type_ex])
    )

-- -----------------------------------------------------
-- Table [DETAILS]
-- -----------------------------------------------------
CREATE TABLE [DETAILS] (
  [idRRTOSZ] INT NOT NULL,
  [name] VARCHAR(255) NULL,
  [amount] INT NULL,
  
  CONSTRAINT [fk_details2_RRTOSZ1]
    FOREIGN KEY ([idRRTOSZ])
    REFERENCES [RRTOSZ] ([idRRTOSZ])
    )


INSERT INTO [USERS]([name], [last_name], [username], [password], [role]) VALUES ('admin', 'admin', 'admin', HASHBYTES ('MD5', 'eO3VRUuP'), 10);
INSERT INTO [USERS]([name], [last_name], [username], [password], [role]) VALUES ('beb', 'beb', 'beb', HASHBYTES ('MD5', 'beba'), 10);


INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('Григорий', 'lastname1', 'username1', HASHBYTES ('MD5', 'password1'));
INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('name2', 'lastname2', 'username2', HASHBYTES ('MD5', 'password2'));
INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('name3', 'lastname3', 'username3', HASHBYTES ('MD5', 'password3'));
INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('name4', 'lastname4', 'username4', HASHBYTES ('MD5', 'password4'));
INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('name5', 'lastname5', 'username5', HASHBYTES ('MD5', 'password5'));

INSERT INTO [OBJECTS]([name_object], [adress]) VALUES ('name1', 'adress1');
INSERT INTO [OBJECTS]([name_object], [adress]) VALUES ('name2', 'adress2');
INSERT INTO [OBJECTS]([name_object], [adress]) VALUES ('name3', 'adress3');
INSERT INTO [OBJECTS]([name_object], [adress]) VALUES ('name4', 'adress4');
INSERT INTO [OBJECTS]([name_object], [adress]) VALUES ('Тестовые занчения', 'Тестики');


INSERT INTO [OBJECT_STATE]([date], [description], [idOBJECT]) VALUES ('2019-06-05', 'decs1', 1);
INSERT INTO [OBJECT_STATE]([date], [description], [idOBJECT]) VALUES ('2019-06-06', 'decs2', 2);
INSERT INTO [OBJECT_STATE]([date], [description], [idOBJECT]) VALUES ('2019-06-07', 'decs3', 3);

INSERT INTO [EXTINGUSHER] ([number], [date_start], [place], [mark], [factory_number], [date_created], [concentration], [type_ex])
VALUES ('123', '10/10/10', 'RTR', 'RTR', '1124', '10/11/11', '1', '2');
 


INSERT INTO [TYPE_EX] ([description]) VALUES ('какое-то описание'); 
INSERT INTO [TYPE_EX] ([description]) VALUES ('бебское описание'); 
INSERT INTO [TYPE_EX] ([description]) VALUES ('бибское описание'); 
INSERT INTO [TYPE_EX] ([description]) VALUES ('описание описание');
INSERT INTO [TYPE_EX] ([description]) VALUES ('пока на описаниях хватит');


INSERT INTO [MANUFACTURER] ([name]) VALUES ('Бебский завод');
INSERT INTO [MANUFACTURER] ([name]) VALUES ('Бибский завод');
INSERT INTO [MANUFACTURER] ([name]) VALUES ('Завод имени Ильича');
INSERT INTO [MANUFACTURER] ([name]) VALUES ('Одесский завод');
INSERT INTO [MANUFACTURER] ([name]) VALUES ('Заводчянский завод');



INSERT INTO [UO] ([date], [idUSERS], [apperience], [mass], [pressure], [state], [actions]) VALUES ('10/10/10', '1', 'ERT', '', '', 'QWERTY', 'QWERT');
INSERT INTO [UO] ([date], [idUSERS],[apperience], [mass], [pressure], [state], [actions]) VALUES ('11/11/11', '2', 'ERT', '', '', 'QWERTY', 'QWERT');
INSERT INTO [UO] ([date], [idUSERS],[apperience], [mass], [pressure], [state], [actions]) VALUES ('12/12/12', '3', 'ERT', '', '', 'QWERTY', 'QWERT');
INSERT INTO [UO] ([date], [idUSERS],[apperience], [mass], [pressure], [state], [actions]) VALUES ('7/7/7', '4', 'ERT', '', '', 'QWERTY', 'QWERT');
INSERT INTO [UO] ([date], [idUSERS],[apperience], [mass], [pressure], [state], [actions]) VALUES ('8/8/8', '5', 'ERT', '', '', 'QWERTY', 'QWERT');

