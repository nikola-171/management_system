CREATE VIEW `profesori_po_predmetima` AS
select p.id as 'profesor_id', pr.id as 'predmet_id', p.ime as 'profesor_ime', p.prezime as 'profesor_prezime', pr.naziv as 'predmet_naziv'
from profesor as p, predmet as pr, smer as s, predmet_na_smeru as pns, profesor_na_predmetu as pnp
where p.id = pnp.profesor_id and pnp.predmet_id = pr.id and
      p.id = pns.predmet and pns.smer = s.id
      order by p.id asc, pr.naziv asc;