SELECT 
    tb_trabalha_em.NUMERO_PROJETO
FROM
    tb_funcionario
        INNER JOIN
    tb_trabalha_em ON tb_trabalha_em.CPF_FUNCIONARIO = tb_funcionario.CPF
WHERE
    tb_funcionario.ULTIMO_NOME = 'Souza' 
UNION 
SELECT 
    tb_projeto.NUMERO_PROJETO
FROM
    tb_funcionario
        INNER JOIN
    tb_departamento ON tb_departamento.CPF_GERENTE = tb_funcionario.CPF
        INNER JOIN
    tb_projeto ON tb_projeto.NUMERO_DEPARTAMENTO = tb_departamento.NUMERO_DEPARTAMENTO
WHERE
    tb_funcionario.ULTIMO_NOME = 'Souza';