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
  [role] INT NOT NULL,
  [username] VARCHAR(255) NOT NULL,
  [password] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([idUSERS]))

-------------------------------------------------
-- Table [RRTOSZ]
-- -----------------------------------------------------
CREATE TABLE [RRTOSZ] (
  [idRRTOSZ] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NOT NULL,
  [type_system] VARCHAR(255) NULL,
  [type_work] VARCHAR(255) NULL,
  [description] VARCHAR(255) NULL,
  [result_state] VARCHAR(255) NULL,
  [result_work] VARCHAR(255) NULL,
  PRIMARY KEY ([idRRTOSZ]),
    )

-- -----------------------------------------------------
-- Table [PPSPPZ]
-- -----------------------------------------------------
CREATE TABLE [PPSPPZ] (
  [idPPSPPZ] INT NOT NULL IDENTITY(1, 1),
  [date] DATETIME NULL,
  [person] INT  NOT NULL,
  [defect] VARCHAR(255) NULL,
  [fixed] VARCHAR(255) NULL,
  [person_check] INT  NOT NULL,
  PRIMARY KEY ([idPPSPPZ]),
  
  
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
  [idUPPPT] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NULL,
  [person] INT  NOT NULL,
  [topic] VARCHAR(255) NULL,
  [place] VARCHAR(255) NULL,
  [grade] VARCHAR(255) NULL,
  PRIMARY KEY ([idUPPPT]),
  
  CONSTRAINT [fk_UPPPT_USERS1]
    FOREIGN KEY ([person])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [UO]
-- -----------------------------------------------------
CREATE TABLE [UO] (
  [idUO] INT NOT NULL IDENTITY(1, 1),
  [date] DATE NOT NULL,
  [idUSERS] INT  NOT NULL,
  [apperience] VARCHAR(255) NULL,
  [mass] FLOAT NULL,
  [pressure] FLOAT NULL,
  [state] VARCHAR(255) NULL,
  [actions] VARCHAR(255) NULL,
  PRIMARY KEY ([idUO]),
  
  CONSTRAINT [fk_UO_USERS1]
    FOREIGN KEY ([idUSERS])
    REFERENCES [USERS] ([idUSERS])
    )

-- -----------------------------------------------------
-- Table [OBJECTS]
-- -----------------------------------------------------
CREATE TABLE [OBJECTS] (
  [idOBJECT] INT NOT NULL IDENTITY(1, 1),
  [name_object] VARCHAR(255) NOT NULL,
  [adress] VARCHAR(255) NOT NULL,
  [idUSERS] INT  NOT NULL,
  [RRTOSZ_idRRTOSZ] INT NOT NULL,
  [idPPSPPZ] INT NOT NULL,
  [idUPPPT] INT NOT NULL,
  [idUO] INT NOT NULL,
  PRIMARY KEY ([idOBJECT]),
  CONSTRAINT [fk_OBJECT_USERS]
    FOREIGN KEY ([idUSERS])
    REFERENCES [USERS] ([idUSERS])
    ,
  CONSTRAINT [fk_OBJECTS_RRTOSZ1]
    FOREIGN KEY ([RRTOSZ_idRRTOSZ])
    REFERENCES [RRTOSZ] ([idRRTOSZ])
    ,
  CONSTRAINT [fk_OBJECTS_PPSPPZ1]
    FOREIGN KEY ([idPPSPPZ])
    REFERENCES [PPSPPZ] ([idPPSPPZ])
    ,
  CONSTRAINT [fk_OBJECTS_UPPPT1]
    FOREIGN KEY ([idUPPPT])
    REFERENCES [UPPPT] ([idUPPPT])
    ,
  CONSTRAINT [fk_OBJECTS_UO1]
    FOREIGN KEY ([idUO])
    REFERENCES [UO] ([idUO])
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
  [UO_idUO] INT NOT NULL,
  [idMANUFACTURER] INT NOT NULL,
  [number] INT NULL,
  [date_start] DATE NULL,
  [place] VARCHAR(255) NULL,
  [mark] VARCHAR(255) NULL,
  [factory_number] INT NULL,
  [date_created] DATE NULL,
  [concentration] VARCHAR(255) NULL,
  [TYPE_EX_type_ex] INT NOT NULL,
  CONSTRAINT [fk_EXTINGUSHER_UO1]
    FOREIGN KEY ([UO_idUO])
    REFERENCES [UO] ([idUO])
    ,
  CONSTRAINT [fk_EXTINGUSHER_MANUFACTURER1]
    FOREIGN KEY ([idMANUFACTURER])
    REFERENCES [MANUFACTURER] ([idMANUFACTURER])
    ,
  CONSTRAINT [fk_EXTINGUSHER_TYPE_EX1]
    FOREIGN KEY ([TYPE_EX_type_ex])
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


INSERT INTO [USERS]([name], [last_name], [username], [password]) VALUES ('admin', 'admin', 'admin', HASHBYTES ('MD5', 'eO3VRUuP'));