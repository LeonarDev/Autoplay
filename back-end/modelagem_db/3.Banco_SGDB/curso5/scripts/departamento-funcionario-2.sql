SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO tb_departamento VALUES
(1, '2020-02-01', 'Pesquisa', '23456789011');

INSERT INTO tb_departamento VALUES
(2, '2019-04-02', 'Comercial', '28856783021');

INSERT INTO tb_funcionario VALUES
('23456789011', '1966-03-04', 'Pedro', 'P', 'Machado', 'Rua Projetada A numero 27', 20000, 'M', '23456789011', 1);

INSERT INTO tb_funcionario VALUES
('28856783021', '1973-12-25', 'Maria', 'R', 'Oliveira', 'Rua Altamira 23', 18000, 'F', '28856783021', 1);

SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO tb_funcionario VALUES
('56987456215', '1985-09-11', 'Marcio', 'J', 'Gomes', 'Rua Casemira 20', 10000, 'M', '28856783021', 1);

INSERT INTO tb_funcionario VALUES
('85463295482', '1982-08-08', 'Claudia', 'K', 'Lopes', 'Rua Utubaiana 08', 12000, 'F', '28856783021', 1);