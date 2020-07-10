select * from jogos


CREATE TABLE JOGOS(

id int primary key identity,
DATAJOGO DATETIME NOT NULL,
TIPOJOGO CHAR(1) CHECK (TIPOJOGO IN ('G','P')) NOT NULL,
APOSTA int,
QUANTIA int,
MODOJOGO SMALLINT CHECK (MODOJOGO IN (3,4,9)) NOT NULL,
ID_JOGADOR INT REFERENCES UTILIZADOR(ID) NULL,
)

drop table jogos


--cada vez que um jogo é jogado

go
create or alter proc usp_jogos @tipojogo char(1), @aposta money, @quantia money, @modojogo smallint, @id_jogador int AS
BEGIN TRY
BEGIN TRAN

IF @id_jogador IS NULL
INSERT INTO JOGOS VALUES(getdate(), @tipojogo, @aposta, @quantia, @modojogo, NULL)
ELSE
INSERT INTO JOGOS VALUES(getdate(), @tipojogo, @aposta, @quantia, @modojogo, @id_jogador)

COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH


--retorno para estatísticas

go
create or alter proc usp_jogos_stats AS
select count(id), (select count(TIPOJOGO) from jogos where TIPOJOGO = 'G'), (select count(TIPOJOGO) from jogos where TIPOJOGO = 'P'), sum(Aposta), (select sum(quantia) from jogos where TIPOJOGO = 'G'), (select sum(quantia) from jogos where TIPOJOGO = 'P')
from JOGOS

SELECT * FROM JOGOS
SELECT * FROM utilizador
DROP TABLE JOGOS

insert into jogos values(getdate(), 'G', 100, 500, 3, null )
insert into jogos values(getdate(), 'G', 100, 500, 3, null )
insert into jogos values(getdate(), 'P', 300, -300, 3, null )
insert into jogos values(getdate(), 'P', 300, -300, 3, null )
insert into jogos values(getdate(), 'G', 100, 500, 3, null )
insert into jogos values(getdate(), 'G', 100, 500, 4, null )

go
create or alter proc usp_highscore as
SELECT CONCAT(LEFT(utilizador.nome + SPACE(15),15), RIGHT(SPACE(15) + utilizador.creditos,15))
FROM utilizador