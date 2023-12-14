-- select * from Students;
--
-- drop table Students; -- drop относится к DDL
-- delete from Students; -- delete относится к DML

create table Students(
  Id int primary key identity(1,1),
    Name nvarchar(30) not null,
    Age int not null,
    Email nvarchar(50) not null unique check(Email like '%_@_%._%'),
);
go;

insert into Students (Name, Age, Email) values ('Ynes', 24, 'ylamblot0@slashdot.org');
insert into Students (Name, Age, Email) values ('Gael', 100, 'gjaneway1@jiathis.com');
insert into Students (Name, Age, Email) values ('Hollis', 87, 'horleton2@army.mil');
insert into Students (Name, Age, Email) values ('Klarrisa', 24, 'kcreagh3@wordpress.com');
insert into Students (Name, Age, Email) values ('Danya', 59, 'ddowson4@blogs.com');
insert into Students (Name, Age, Email) values ('Kelley', 91, 'krides5@msu.edu');
insert into Students (Name, Age, Email) values ('Addy', 54, 'aasee6@baidu.com');
insert into Students (Name, Age, Email) values ('Lissy', 72, 'lclayworth7@fda.gov');
insert into Students (Name, Age, Email) values ('Helena', 22, 'hbroggelli8@addtoany.com');
insert into Students (Name, Age, Email) values ('Kendre', 85, 'kgierke9@chronoengine.com');
insert into Students (Name, Age, Email) values ('Neely', 74, 'nsicha@t-online.de');
insert into Students (Name, Age, Email) values ('Jazmin', 66, 'joakesb@cocolog-nifty.com');
insert into Students (Name, Age, Email) values ('Aurelea', 51, 'acongreavec@yellowbook.com');
insert into Students (Name, Age, Email) values ('Bernie', 63, 'bbendind@merriam-webster.com');
insert into Students (Name, Age, Email) values ('Garald', 13, 'gtulke@privacy.gov.au');
insert into Students (Name, Age, Email) values ('Claudie', 59, 'cshillidayf@amazon.com');
insert into Students (Name, Age, Email) values ('Nata', 18, 'nantonaccig@flavors.me');
insert into Students (Name, Age, Email) values ('Lusa', 52, 'ltrevenh@dion.ne.jp');
insert into Students (Name, Age, Email) values ('Karena', 72, 'kmordecaii@linkedin.com');
insert into Students (Name, Age, Email) values ('Cody', 74, 'cdewburyj@salon.com');
insert into Students (Name, Age, Email) values ('Goldia', 9, 'gmatyasikk@theglobeandmail.com');
insert into Students (Name, Age, Email) values ('Farlee', 71, 'fdradeyl@army.mil');
insert into Students (Name, Age, Email) values ('Jacqueline', 61, 'jneilanm@over-blog.com');
insert into Students (Name, Age, Email) values ('Lesley', 11, 'llepopen@marketwatch.com');
insert into Students (Name, Age, Email) values ('Erna', 38, 'etriggleo@blinklist.com');
insert into Students (Name, Age, Email) values ('Pietrek', 79, 'pmilbournep@un.org');
insert into Students (Name, Age, Email) values ('Didi', 70, 'dmendoncaq@dell.com');
insert into Students (Name, Age, Email) values ('Findlay', 26, 'fbushillr@webnode.com');
insert into Students (Name, Age, Email) values ('Fiona', 68, 'fcookmans@disqus.com');
insert into Students (Name, Age, Email) values ('Tyler', 98, 'tbrockingtont@vinaora.com');
insert into Students (Name, Age, Email) values ('Chris', 95, 'cswinglehurstu@slashdot.org');
insert into Students (Name, Age, Email) values ('Wilmar', 42, 'wchadbandv@hugedomains.com');
insert into Students (Name, Age, Email) values ('Cindie', 74, 'ckearyw@admin.ch');
insert into Students (Name, Age, Email) values ('Lynett', 41, 'lrignoldx@biblegateway.com');
insert into Students (Name, Age, Email) values ('Quinlan', 18, 'qtennyy@wufoo.com');
insert into Students (Name, Age, Email) values ('Worden', 11, 'whacklyz@indiegogo.com');
insert into Students (Name, Age, Email) values ('Arlene', 16, 'aslaymaker10@nature.com');
insert into Students (Name, Age, Email) values ('Leanora', 8, 'lbravery11@ovh.net');
insert into Students (Name, Age, Email) values ('Zacharias', 48, 'zpetricek12@wired.com');
insert into Students (Name, Age, Email) values ('Vicki', 7, 'vfontes13@washington.edu');
insert into Students (Name, Age, Email) values ('Remy', 58, 'rmagauran14@thetimes.co.uk');
insert into Students (Name, Age, Email) values ('Earvin', 98, 'echaim15@about.com');
insert into Students (Name, Age, Email) values ('Martyn', 61, 'mbanaszczyk16@scientificamerican.com');
insert into Students (Name, Age, Email) values ('Quinlan', 16, 'qpennoni17@php.net');
insert into Students (Name, Age, Email) values ('Corrie', 3, 'cpickburn18@tiny.cc');
insert into Students (Name, Age, Email) values ('Jenelle', 89, 'jtimlin19@gizmodo.com');
insert into Students (Name, Age, Email) values ('Say', 50, 'sbutterfield1a@cpanel.net');
insert into Students (Name, Age, Email) values ('Austin', 99, 'akillingsworth1b@biglobe.ne.jp');
insert into Students (Name, Age, Email) values ('Jonell', 46, 'jbignal1c@geocities.com');
insert into Students (Name, Age, Email) values ('Arne', 64, 'ataber1d@macromedia.com');
insert into Students (Name, Age, Email) values ('Broddie', 23, 'bklaus1e@privacy.gov.au');
insert into Students (Name, Age, Email) values ('Aloisia', 77, 'apenfold1f@alexa.com');
insert into Students (Name, Age, Email) values ('Gearard', 55, 'ggarfoot1g@hatena.ne.jp');
insert into Students (Name, Age, Email) values ('Abbey', 24, 'apinwill1h@umich.edu');
insert into Students (Name, Age, Email) values ('Charmain', 69, 'charrow1i@storify.com');
insert into Students (Name, Age, Email) values ('Hartwell', 71, 'hlesly1j@mtv.com');
insert into Students (Name, Age, Email) values ('Gherardo', 50, 'gnelson1k@csmonitor.com');
insert into Students (Name, Age, Email) values ('Weidar', 62, 'wtharme1l@dailymail.co.uk');
insert into Students (Name, Age, Email) values ('Jase', 93, 'jmilmoe1m@pinterest.com');
insert into Students (Name, Age, Email) values ('Amaleta', 67, 'amelato1n@aboutads.info');
insert into Students (Name, Age, Email) values ('Marquita', 40, 'myvon1o@sbwire.com');
insert into Students (Name, Age, Email) values ('Stephannie', 49, 'sbengal1p@sina.com.cn');
insert into Students (Name, Age, Email) values ('Finley', 29, 'fosselton1q@eepurl.com');
insert into Students (Name, Age, Email) values ('Amerigo', 8, 'alangthorne1r@booking.com');
insert into Students (Name, Age, Email) values ('Demetra', 85, 'darckoll1s@oakley.com');
insert into Students (Name, Age, Email) values ('Derrek', 57, 'dlevis1t@spiegel.de');
insert into Students (Name, Age, Email) values ('Giusto', 89, 'graw1u@youtu.be');
insert into Students (Name, Age, Email) values ('Ddene', 37, 'dcorrison1v@google.ca');
insert into Students (Name, Age, Email) values ('Kennedy', 95, 'kdallander1w@home.pl');
insert into Students (Name, Age, Email) values ('Layne', 12, 'lgrattan1x@loc.gov');
insert into Students (Name, Age, Email) values ('Archie', 55, 'atynan1y@discovery.com');
insert into Students (Name, Age, Email) values ('Franny', 91, 'fleahy1z@state.tx.us');
insert into Students (Name, Age, Email) values ('Halsey', 41, 'hmckinlay20@surveymonkey.com');
insert into Students (Name, Age, Email) values ('Lonnard', 6, 'lmcardle21@hp.com');
insert into Students (Name, Age, Email) values ('Jory', 73, 'jgossage22@wikimedia.org');
insert into Students (Name, Age, Email) values ('Frederico', 24, 'fundrill23@edublogs.org');
insert into Students (Name, Age, Email) values ('Lou', 74, 'llillie24@printfriendly.com');
insert into Students (Name, Age, Email) values ('Natal', 18, 'nstevani25@rambler.ru');
insert into Students (Name, Age, Email) values ('Katerine', 99, 'kmatz26@macromedia.com');
insert into Students (Name, Age, Email) values ('Lem', 50, 'ltrusty27@shinystat.com');
insert into Students (Name, Age, Email) values ('Imelda', 53, 'iizkovici28@usda.gov');
insert into Students (Name, Age, Email) values ('Augy', 32, 'aaudsley29@parallels.com');
insert into Students (Name, Age, Email) values ('Arnaldo', 66, 'alofthouse2a@indiegogo.com');
insert into Students (Name, Age, Email) values ('Sabine', 80, 'sthibodeaux2b@wikimedia.org');
insert into Students (Name, Age, Email) values ('Sampson', 90, 'sbotler2c@ihg.com');
insert into Students (Name, Age, Email) values ('Jandy', 91, 'jdawkins2d@aol.com');
insert into Students (Name, Age, Email) values ('Datha', 4, 'ddodle2e@newyorker.com');
insert into Students (Name, Age, Email) values ('Alfredo', 40, 'atruman2f@yahoo.com');
insert into Students (Name, Age, Email) values ('Chic', 3, 'cdicty2g@networkadvertising.org');
insert into Students (Name, Age, Email) values ('Carson', 21, 'cdonaghie2h@1688.com');
insert into Students (Name, Age, Email) values ('Fredrick', 49, 'fwherton2i@netlog.com');
insert into Students (Name, Age, Email) values ('Joycelin', 39, 'jcardenas2j@pen.io');
insert into Students (Name, Age, Email) values ('Cullie', 56, 'cverney2k@addtoany.com');
insert into Students (Name, Age, Email) values ('Calida', 3, 'cgatheridge2l@list-manage.com');
insert into Students (Name, Age, Email) values ('Angy', 84, 'apeschmann2m@dailymail.co.uk');
insert into Students (Name, Age, Email) values ('Nolana', 47, 'nfairham2n@blinklist.com');
insert into Students (Name, Age, Email) values ('Conn', 37, 'cpersence2o@nytimes.com');
insert into Students (Name, Age, Email) values ('Arch', 89, 'afellis2p@cloudflare.com');
insert into Students (Name, Age, Email) values ('Lusa', 58, 'llogg2q@ox.ac.uk');
insert into Students (Name, Age, Email) values ('Nicolette', 59, 'nbennison2r@mtv.com');

go;


select Name as FirstName, Email as EmailAddress
from Students
where Age > 50
order by Name asc;



