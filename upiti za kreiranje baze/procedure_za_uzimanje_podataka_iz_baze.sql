use fakultet;
/*uzimanje podataka o administratoru*/
delimiter \\
create procedure daj_podatke_o_administrator(in admin_ime_in varchar(45))
begin
	select * from daj_podatke_o_administratoru
    where administrator_ime = admin_ime_in;
end\\
delimiter ;
/*uzimanje podataka o studentu na osnovu broja indeksa*/
delimiter \\
create procedure daj_podatke_o_studentu(in broj_indeksa_in int unsigned)
begin
	select * from prikaz_studenata
    where broj_indeksa = broj_indeksa_in;
end\\
delimiter ;
/*uzimanje podataka o administratoru*/
delimiter \\
create procedure daj_administratora()
begin
	select administrator_ime, administrator_lozinka, email, telefon
    from administrator;
end\\
delimiter ;
/*uzimanje liste svih univerziteta*/
delimiter \\
create procedure daj_sve_univerzitete()
begin
	select * from daj_sve_univerzitete;
end\\
delimiter ;
/*uzimanje podataka o univerzitetu na osnovu njegovog ID-a*/
delimiter \\
create procedure daj_univerzitet(in id_in int)
begin
	select * from daj_sve_univerzitete
    where id = id_in;
end\\
delimiter ;
/*uzimanje liste fakulteta*/
delimiter \\
create procedure daj_sve_fakultete()
begin
	select * from prikaz_fakulteta;
end\\
delimiter ;
/*uzimanje podataka o fakultetu na osnovu njegovo ID-a*/
delimiter \\
create procedure daj_fakultet(in id_in int)
begin
	select f.id, f.naziv, f.mesto
    from prikaz_fakulteta as f
    where f.id = id_in;
end\\
delimiter ;
/*uzimanje liste svih smerova*/
delimiter \\
create procedure daj_sve_smerove()
begin
	select * from daj_sve_smerove;
end\\
delimiter ;
/*uzimanje liste svih studenata*/
delimiter \\
create procedure daj_sve_studente()
begin
	select * from prikaz_studenata;
end\\
delimiter ;
/*uzimanje liste svih predmeta*/
delimiter \\
create procedure daj_sve_predmete()
begin
	select * from daj_sve_predmete;
end\\
delimiter ;
/*uzimanje liste svih profesora*/
delimiter \\
create procedure daj_profesora_na_osnovu_id(in id_in int unsigned)
begin
	select * from prikaz_profesora
    where id = id_in;
end\\
delimiter ;
/*uzimanje liste svih registrovanih profesora*/
delimiter \\
create procedure daj_sve_profesore()
begin
	select * from prikaz_profesora;
end\\
delimiter ;
/*uzimanje liste svih predmeta po smerovima*/
delimiter \\
create procedure daj_predmete_po_smerovima()
begin
	select * from predmeti_po_smerovima;
end\\
delimiter ;
/*uzimanje liste svih profesora sa predmetima na kojima predaju*/
delimiter \\
create procedure daj_profesore_po_predmetima()
begin
	select * from profesori_po_predmetima;
end\\
delimiter ;
/*uzimanje liste predmeta na kojima postoji registrovan profesor*/
delimiter \\
create procedure daj_predmete_sa_profesorom()
begin
	select * from predmeti_sa_profesorom;
end\\
delimiter ;
/*uzimanje liste smerova sa fakultetima i univerzitetom na kome su registrovani*/
delimiter \\
create procedure prikaz_smerova_po_fakultetima_i_univerzitetima()
begin
	select * from smerovi_po_fakultetima_i_univerzitetima;
end\\
delimiter ;
/*uzimanje liste studenata sa predmetima koje su položili*/
delimiter \\
create procedure daj_student_polozeni_predmeti()
begin
	select * from studenti_sa_predmetima_koje_su_polozili;
end\\
delimiter ;
/*uzimanje liste predmeta koji su dodeljeni nekom smeru*/
delimiter \\
create procedure daj_predmete()
begin
	select * from predmeti_dodeljeni_nekom_smeru;
end\\
delimiter ;
/*uzimanje liste studenata sa predmetima koje slušaju testiraj*/
delimiter \\
create procedure daj_studente_sa_predmetima_koje_slusaju()
begin
	select * from studenti_sa_predmetima_koje_slusaju;
end\\
delimiter ;
/*studenti koji nisu diplomirali*/
delimiter \\
create procedure daj_studente_koji_nisu_diplomirali()
begin
	select * from studenti_koji_nisu_diplomirali;
end\\
delimiter ;
/*uzimanje liste predmeta koji nisu dodeljeni nekom departmanu*/
delimiter \\
create procedure daj_predmete_koji_nisu_na_nekom_departmanu()
begin
	select * from predmeti_koji_nisu_na_nekom_departmanu;
end\\
delimiter ;
/*uzimanje tekuće fakultetske godine*/
delimiter \\
create procedure daj_tekucu_fakultetsku_godinu()
begin
	declare fakultetska_godina_priv varchar(45)default '';
    declare max_id int unsigned default 0;
    
    start transaction;
		select max(id) into max_id
        from fakultetska_godina;
        
        select f.fakultetska_godina as 'fakultetska_godina'
        from fakultetska_godina as f
        where f.id = max_id;
    commit;
end\\
delimiter ;


