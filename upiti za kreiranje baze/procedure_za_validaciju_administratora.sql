use fakultet;
/*procedura za validaciju administratora*/
delimiter \\
create procedure validacija(in admin_ime_in varchar(45), in admin_lozinka_in varchar(255))
begin
	declare status_out boolean default false;
    declare c tinyint unsigned default 0;
   
    declare exit handler for sqlexception
     begin
		 rollback;
         GET DIAGNOSTICS CONDITION 1
		 @p2 = MESSAGE_TEXT;
        
         select @p2 as 'msg';
     end;
     
     start transaction;
		select count(*) into c
		from administrator
		where administrator_ime = admin_ime_in and administrator_lozinka = sha1(admin_lozinka_in);
    
		if c > 0 then
			set status_out = true;
		end if;
        
        select status_out as 'status';
     commit;
end\\
delimiter ;
