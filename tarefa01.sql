SELECT
	d.Nome AS "Departamento",
	p.Nome AS "Pessoa",
	p.Salario AS "Salario"
FROM
	Pessoa p INNER JOIN Departamento d ON p.DeptId = d.Id
WHERE p.Salario IN (SELECT max(p2.Salario) FROM Pessoa p2 GROUP BY p2.DeptId)