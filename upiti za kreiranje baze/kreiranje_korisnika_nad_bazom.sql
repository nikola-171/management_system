use fakultet;
/*napravili smo korisnika koji će moći samo da poziva ugrađene procedure*/
create user 'fakultet_admin'@'localhost' identified by 'admin_lozinka';
grant execute on fakultet.* to 'fakultet_admin'@'localhost';











