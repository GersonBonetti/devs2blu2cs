INSERT INTO pessoa (nome,
					datanascimento,
                    idade,
                    status)
VALUES ('Meninin Maluquim', '2005-09-01', 17, 0)
;

/*DELETE*/
DELETE FROM pessoa
WHERE id = (11)
;

/*DELETE SUBQUERY*/
DELETE FROM pessoa p
WHERE id = (SELECT p2.id FROM pessoa as p2 order by p2.id desc limit 1)
;