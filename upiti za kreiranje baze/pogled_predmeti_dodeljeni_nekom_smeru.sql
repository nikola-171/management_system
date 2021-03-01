CREATE VIEW `predmeti_dodeljeni_nekom_smeru` AS
select distinct p.id, p.naziv, p.godina, p.semestar, p.espb
    from predmet as p, predmet_na_smeru as pns
    where p.id = pns.predmet;