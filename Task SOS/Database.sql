 create database SWP391;

use SWP391;

create table setting(
   setting_id int primary key,
   type_id int,
   setting_title varchar(50),
   setting_value int,
   display_order int,
   status boolean,
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   CONSTRAINT constraint_name
   FOREIGN KEY (type_id)
   REFERENCES setting(setting_id)
   ON DELETE CASCADE
   ON UPDATE CASCADE
);

create table User(
   user_id varchar(500) primary key,
   full_name varchar(50) ,
   email varchar(50) ,
   mobile varchar(20) ,
   avatar_url longtext ,
   status int,
   note text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   foreign key (status) references setting(setting_id)
);

create table custom_user(
   user_id varchar(500) not null,
   username varchar(50),
   password varchar(50),
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (user_id) references User(user_id)
);

create table Client(
   client_id int primary key,
   user_id varchar(500) not null,
   mobile varchar(50),
   address varchar(50),
   position varchar(50),
   company varchar(50),
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (user_id) references User(user_id)
);

create table permission(
   screen_id int,
   role_id int,
   get_all_data boolean,
   can_delete boolean,
   can_add boolean,
   can_edit boolean,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   foreign key (screen_id) references setting(setting_id),
   foreign key (role_id) references setting(setting_id)
);

create table user_role(
   user_id varchar(500) not null,
   role_id int not null,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (user_id) references User(user_id),
   Foreign key (role_id) references setting(setting_id)
);

create table subject(
   subject_id int primary key,
   subject_code varchar(50),
   subject_name varchar(50),
   manager_id varchar(500) not null,
   expert_id varchar(500) not null,
   status boolean,
   body text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (manager_id) references User(user_id),
   Foreign key (expert_id) references User(user_id)
);

create table package(
   package_id int primary key,
   subject_id int not null,
   titel varchar(50),
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (subject_id) references subject(subject_id)
);

create table class(
   class_id int primary key,
   class_code varchar(50),
   combo_id int not null,
   trainer_id varchar(500) not null,
   term_id int,
   status boolean,
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (combo_id) references package(package_id),
   Foreign key (trainer_id) references User(user_id),
   Foreign key (term_id) references setting(setting_id)
);

create table team(
   team_id int primary key,
   class_id int not null,
   project_code varchar(50),
   topic_code varchar(50),
   topic_name varchar(50),
   status boolean,
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (class_id) references class(class_id)
);

create table class_user(
   class_id int not null,
   user_id varchar(500) not null,
   team_id int not null,
   is_leader boolean,
   status boolean,
   note text,
   dropout_date datetime,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (class_id) references class(class_id),
   Foreign key (user_id) references User(user_id),
   Foreign key (team_id) references team(team_id)
);

create table class_setting(
   class_setting_id int primary key,
   type_id int not null,
   class_id int not null,
   setting_title varchar(50),
   setting_value int,
   display_order int,
   status boolean,
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (type_id) references setting(setting_id),
   Foreign key (class_id) references class(class_id)
);

create table subject_setting(
   subject_setting_id int primary key,
   subject_id int not null,
   type_id int not null,
   setting_title varchar(50),
   setting_value int,
   display_order int,
   status boolean,
   description text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (type_id) references setting(setting_id),
   Foreign key (subject_id) references subject(subject_id)
);

create table lesson(
   lesson_id int primary key,
   subject_id int not null,
   author_id varchar(500) not null,
   video_url text,
   file_url text,
   body text,
   module_id int not null,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (subject_id) references subject(subject_id),
   Foreign key (author_id) references User(user_id),
   Foreign key (module_id) references subject_setting(subject_setting_id)
);

create table class_lesson(
   class_lesson_id int primary key,
   lesson_id int not null,
   subject_id int not null,
   class_id int not null,
   slot_id int not null,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (lesson_id) references lesson(lesson_id),
   Foreign key (subject_id) references subject(subject_id),
   Foreign key (class_id) references class(class_id),
   Foreign key (slot_id) references class_setting(class_setting_id)
);

create table wed_context(
   contact_id int primary key,
   category_id int,
   supporter_id varchar(50),
   full_name varchar(50),
   email varchar(50),
   mobile varchar(50),
   message text,
   response text,
   create_by varchar(50),
   create_at datetime,
   modified_by varchar(50),
   modified_at datetime,
   Foreign key (category_id) references setting(setting_id),
   Foreign key (supporter_id) references User(user_id)
);

INSERT INTO `swp391`.`setting`
(`setting_id`,
`setting_title`)
VALUES
(1, "User Role"),
(2, "User Status");

INSERT INTO `swp391`.`setting`
(`setting_id`, type_id,
`setting_title`)
VALUES
(10,1, "Admin"),
(11,1, "Manager"),
(12,1, "Student"),
(20,2, "Active"),
(21,2, "Inactive"),
(22,2, "Unverified");

INSERT INTO `swp391`.`user`
(`user_id`,
`full_name`)
VALUES
("A000000", "Admin");

INSERT INTO `swp391`.`user`
(`user_id`,
`full_name`,
`email`,
`mobile`,
`avatar_url`,
`status`,
`note`)
VALUES
("U000001","Phan Kim Long", "ABC@gmail.com", "0845396656", "none", 20, "none"),
("U000002","Nguyen Van A", "DEF@gmail.com", "0912345678", "none", 21, "none"),
("U000003","Tran Thi Y", "Yfbewf@gmail.com", "0787897789", "none", 20, "none"),
("U000004","Nguyen Than Hung", "hung123@gmail.com", "0912345687", "none", 22, "none");

INSERT INTO `swp391`.`user_role`
(`user_id`,
`role_id`)
VALUES
("A000000",10),
("U000001",12),
("U000002",12),
("U000003",11),
("U000004",12);




