select * from contatos;

select * from compromissos;

SET SQL_SAFE_UPDATES = 0;
DELETE FROM contatos WHERE id between 2 and 10;
DELETE FROM compromissos WHERE id between 2 and 10;

SET SQL_SAFE_UPDATES = 1;

ALTER TABLE contatos AUTO_INCREMENT = 1;
ALTER TABLE compromissos AUTO_INCREMENT = 1;