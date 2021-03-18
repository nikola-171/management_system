use fakultet;
/*upis administratora u bazi, samo jednom će se izvršiti ova procedure
  i tom prilikom će se uneti i podaci*/
  /*select * from administrator;
  drop procedure upis_administratora;
  call upis_administratora('','d','','','','');*/
delimiter \\
create procedure upis_administratora(in admin_ime varchar(45), in admin_lozinka varchar(255),
                                     in email_in varchar(45), in telefon_in varchar(45), 
                                     in ime_in varchar(45), in prezime_in varchar(45))
begin
    declare admin_vec_registrovan tinyint unsigned default 0;
    declare hesirana_lozinka varchar(255) default '';
    
	declare exit handler for sqlexception
    begin
		rollback;
        GET DIAGNOSTICS CONDITION 1
		@p2 = MESSAGE_TEXT;
        
        select @p2 as 'msg';
    end;
    
    start transaction;
    /*hesiramo lozinku*/
    set hesirana_lozinka = sha1(admin_lozinka);
    
    select count(*) into admin_vec_registrovan
    from administrator;
    
    if admin_vec_registrovan = 0 then
		insert into administrator(administrator_ime, administrator_lozinka, email, telefon, ime, prezime)
		values(trim(admin_ime), hesirana_lozinka, trim(email_in), trim(telefon_in), trim(ime_in), trim(prezime_in));
    
		insert into fakultetska_godina(fakultetska_godina)
		values('2017/18');
        
        /*unos odeljenja*/
        insert into odeljenje_sekretarijat(naziv)
        values('služba za opšte i pravne poslove'),
			  ('služba za materijalno i finansijsko poslovanje'),
              ('služba za nastavu i studentska pitanja'),
              ('služba za tehničke poslove i obezbeđenje zgrade');
		
        insert into odeljenje_nastava_i_nauka(naziv)
        values('biblioteka'),
			  ('računarski centar'),
              ('izdavačka delatnost');
    end if;
    
    select admin_vec_registrovan as 'status';
	commit;
end\\
delimiter ;
/*upis univerziteta u bazi*/
delimiter \\
create procedure upis_univerziteta(in naziv varchar(50), in drzava varchar(45), in grad varchar(45))
begin
	insert into univerzitet(naziv, drzava, grad)
    values(trim(replace(naziv, '  ', '')), trim(replace(drzava, '  ', '')), trim(replace(grad, '  ', '')));
end\\
delimiter ;
/*upis fakulteta u bazi*/
delimiter \\
create procedure dodaj_fakultet(in naziv_in varchar(50), in mesto_in varchar(45), in univerzitet_in int)
begin
	insert into fakultet(naziv, mesto, univerzitet)
    values(trim(replace(naziv_in, '  ', '')), trim(replace(mesto_in, '  ', '')), univerzitet_in);
end\\
delimiter ;
/*upis smera na nekom fakultetu*/
delimiter \\
create procedure dodaj_smer(in fakultet_in int, in nivo_studija_in varchar(45), in naziv_in varchar(45),
							in espb_in smallint, in trajanje_in smallint)
begin
	insert into smer(naziv, nivo_studija, fakultet, espb, trajanje)
    values(trim(replace(naziv_in, '  ', '')), trim(replace(nivo_studija_in, '  ', '')), fakultet_in, 
		   trim(replace(espb_in, '  ', '')), trim(replace(trajanje_in, '  ', '')));
end\\
delimiter ;
/*upis novog studenta u bazi*/
/*select * from student;*/
/*call dodaj_novog_studenta(1,'dd','d','1998-5-9','d','d','d','d','d',1,'d','d');*/
delimiter \\
create procedure dodaj_novog_studenta(in smer_in int, in ime_in varchar(45), in prezime_in varchar(45),
									  in datum_rodjenja_in varchar(45), 
									  in mesto_boravka_in varchar(45),
                                      in ulica_in varchar(45), in broj_in varchar(45),
                                      in telefon_in varchar(45), in email_in varchar(45), in status_in int,
                                      in korisnicko_ime_in varchar(45), in lozinka_in varchar(200), in jmbg_in char(13))
begin
	declare hesirana_lozinka varchar(200) default '';
    declare id_prim int unsigned default 0;
    declare student_broj_indeksa int default 0;
    
    declare exit handler for sqlexception
    begin
		rollback;
        GET DIAGNOSTICS CONDITION 1
		@p2 = MESSAGE_TEXT;
        
        select @p2 as 'msg';
    end;
    
    start transaction;
    select max(id) into id_prim
		from fakultetska_godina;   
    set hesirana_lozinka = sha(trim(replace(lozinka_in, '  ', '')));
    
    insert into student(smer,ime, prezime, 
						datum_rodjenja, mesto_boravka, ulica, broj, telefon, email, 
                        status_studenta, korisnicko_ime, lozinka, fakultetska_godina, jmbg)
    values(smer_in,trim(replace(ime_in, '  ', '')), trim(replace(prezime_in, '  ', '')), 
		   datum_rodjenja_in, trim(replace(mesto_boravka_in, '  ', '')), trim(replace(ulica_in, '  ', '')), 
			trim(replace(broj_in, '  ', '')), trim(replace(telefon_in, '  ', '')), trim(replace(email_in, '  ', '')),
           status_in, trim(replace(korisnicko_ime_in, '  ', '')), hesirana_lozinka, id_prim, jmbg_in);
           
	select max(broj_indeksa) into student_broj_indeksa
    from student;
    
    select student_broj_indeksa as 'broj_indeksa';
    
	commit;
end\\
delimiter ;
/*upis novog predmeta u bazi*/
delimiter \\
create procedure dodaj_novi_predmet(in naziv_in varchar(45), in godina_in tinyint, 
									in semestar_in tinyint, in espb_in tinyint, in departman_in int unsigned)
begin
    declare id_predmeta int unsigned default 0;
    
    declare exit handler for sqlexception
    begin
		rollback;
        GET DIAGNOSTICS CONDITION 1
		@p2 = MESSAGE_TEXT;
        
        select @p2 as 'msg';
    end;
    
	start transaction;
    
	insert into predmet(naziv, godina, semestar, espb)
    values(trim(replace(naziv_in, '  ', '')), trim(replace(godina_in, '  ', '')),
		   trim(replace(semestar_in, '  ', '')), trim(replace(espb_in, '  ', '')));
           
	select max(id) into id_predmeta
    from predmet;
    
    call dodaj_predmet_smer_par(id_predmeta, departman_in);
	
    commit;
end\\
delimiter ;
/*upis novog profesora u bazi, vraca njegov ID*/
delimiter \\
create procedure dodaj_novog_profesora(in ime_in varchar(45), in prezime_in varchar(45),
									   in datum_rodjenja_in varchar(45), in telefon_in varchar(45),
                                       in email_in varchar(45), in JMBG_in char(13),
                                       in korisnicko_ime_in varchar(45), in lozinka_in varchar(45), in zvanje_in varchar(45))
begin
	declare hesirana_lozinka varchar(200) default '';
    declare id_profesora int default 0;
    declare exit handler for sqlexception
    begin
		rollback;
        select 'doslo je do greske' as 'msg';
    end;
    
    start transaction;
    set hesirana_lozinka = sha1(trim(replace(lozinka_in, '  ', '')));
    
    insert into radnik(ime, prezime, datum_rodjenja, email, telefon, korisnicko_ime, lozinka, JMBG)
    values(ime_in, prezime_in, datum_rodjenja_in, email_in, telefon_in, korisnicko_ime_in, hesirana_lozinka, JMBG_in);
  
	select max(id) into id_profesora
    from radnik;
    
    insert into profesor(radnik_id, zvanje)
    values(id_profesora, zvanje_in);
    
    select id_profesora as 'id_profesora';
	commit;
end\\
delimiter ;
/*Unos nove fakultetske godine. Pre nego što se unese u bazi vrši se presek studenata.
  Na osnovu ostvarenih espb bodova u prethodnoj fakultetskoj godini će se utvrditi da li
  će student u novog fakultetskoj godini biti na budžetu ili ne */  
delimiter \\
create procedure unos_nove_fakultetske_godine(in godina varchar(45))
begin

	declare broj_bodova int default 0;
    declare novi_status tinyint unsigned default 0;
    declare student_indeks int unsigned default 0;
    
    declare potreban_broj_bodova int default 48; /*potreban broj bodova za budzet*/
    
    declare id_stare_godine int unsigned default 1;
    declare id_nove_godine int unsigned default 1;
    
     declare c cursor for
		select broj_indeksa from student;
    
    declare exit handler for not found
    begin
    end;
    
	
    declare exit handler for sqlexception
    begin
        rollback;
         GET DIAGNOSTICS CONDITION 1
		@p2 = MESSAGE_TEXT;
        
        select @p2 as 'msg';
    end;
    
    select max(id) into id_stare_godine
    from fakultetska_godina;
    
     select id_stare_godine as "stara_godina";
     
    insert into fakultetska_godina(fakultetska_godina)
    values(godina);
    
    select max(id) into id_nove_godine
	from fakultetska_godina;
    
    
    select id_nove_godine as'godina';
         select id_nove_godine as "nova_godina";

    open c;
     l : loop
		fetch c into student_indeks;
         
       select student_indeks as "tekuci student";
        
        select sum(p.espb) into broj_bodova
        from predmet as p, student_polozio_predmet as spp
        where spp.predmet_id = p.id and spp.student_broj_indeksa = student_indeks
			  and spp.fakultetska_godina = id_stare_godine;
          
		if broj_bodova is null then
			set broj_bodova = 0;
        end if;
	   select broj_bodova as "broj_bodova_studenta";
              
		if broj_bodova >= potreban_broj_bodova then
            select "ima potreban broj bodova" as "poruka";
		set novi_status = 1;
		else
        set novi_status = 0;
           select "nema potreban broj bodova" as "poruka";
       end if;
        
        update student
        set status_studenta = novi_status, fakultetska_godina = id_nove_godine
        where broj_indeksa = student_indeks;
        
        set broj_bodova = 0;
     end loop l;
    close c;
    
end\\
delimiter ;
