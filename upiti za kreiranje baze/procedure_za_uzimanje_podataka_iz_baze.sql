use fakultet;
/*uzimanje liste predmeta na kojima predaje profesor*/
delimiter \\
create procedure daj_predmete_na_kojima_predaje_profesor(in id_in int unsigned)
begin
	select r.email, p.naziv, pnp.tip
	from radnik as r, predmet as p, profesor as pr, profesor_na_predmetu as pnp
	where r.id = id_in and r.id = pr.radnik_id and pr.radnik_id = pnp.profesor_id and pnp.predmet_id = p.id;
end\\
delimiter ;
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
select s.broj_indeksa, s.JMBG, s.ime, s.prezime, sm.naziv, f.naziv as 'fakultet', s.diplomirao, s.espb, s.prosek, s.status_studenta as 'status_studenta'
    from student as s, smer as sm, fakultet as f
    where s.smer = sm.id and sm.fakultet = f.id and broj_indeksa = broj_indeksa_in
    order by sm.naziv asc;

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
	select * 
    from radnik as r, profesor as p
    where r.id = p.radnik_id and p.radnik_id = id_in;
end\\
delimiter ;
/*uzimanje liste svih registrovanih profesora*/
delimiter \\
create procedure daj_sve_profesore()
begin
	select * 
    from radnik as r, profesor as p
    where r.id = p.radnik_id;
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
create procedure daj_student_polozeni_predmeti(in broj_indeksa_in int unsigned)
begin
	select * from studenti_sa_predmetima_koje_su_polozili
    where broj_indeksa = broj_indeksa_in;
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
create procedure daj_studente_sa_predmetima_koje_slusaju(in broj_indeksa_in int unsigned)
begin
	select s.broj_indeksa as 'indeks', s.ime as 'ime', s.prezime as 'prezime',
		   sm.naziv as 'smer', p.naziv as 'predmet', p.id as 'id', f.fakultetska_godina as 'fakultetska_godina'
	from student as s, student_slusa_predmet as ssp, predmet as p, fakultetska_godina as f, smer as sm
	where s.broj_indeksa = ssp.student and ssp.predmet = p.id and ssp.fakultetska_godina = f.id and sm.id = s.smer and s.broj_indeksa = broj_indeksa_in;
	
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
/*uzimanje liste svih diplomiranih studenata*/
delimiter \\
create procedure daj_sve_diplomirane_studente()
begin
   select * from student
   where diplomirao = 1;
end\\
delimiter ;
/*uzimanje liste svih promena na univerzitetima*/
delimiter \\
create procedure daj_listu_svih_promena_na_univerzitetu()
begin
   select u.naziv, up.korisnik, up.vreme, up.poruka
   from univerzitet_promena as up, univerzitet as u
   where up.univerzitet = u.id;
end\\
delimiter ;
/*uzimanje liste svih promena na fakultetima*/
delimiter \\
create procedure daj_listu_svih_promena_na_fakultetu()
begin
   select f.naziv, fp.korisnik, fp.vreme, fp.poruka
   from fakultet_promena as fp, fakultet as f
   where fp.fakultet = f.id;
end\\
delimiter ;
/*daj studente iz arhive*/
delimiter \\
create procedure daj_listu_studenata_iz_arhive()
begin
   select * from student_arhiva;
end\\
delimiter ;










