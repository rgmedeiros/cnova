use renatom
go

create table CalculoHistoricoLog (ID int identity primary key,
                                  DataLog datetime,
								  NomePesq varchar(100),
								  LatitudePesq decimal (9, 6),
								  LongitudePesq decimal (9, 6),
								  NomeProximo varchar(100),
								  LatitudeProximo decimal (9, 6),
								  LongitudePromixo decimal (9, 6)
								  )

GO

CREATE PROCEDURE IncluiLogProc(
  @NomePesq varchar(100),
  @LatitudePesq decimal (9, 6),
  @LongitudePesq decimal (9, 6),
  @NomeProximo varchar(100),
  @LatitudeProximo decimal (9, 6),
  @LongitudePromixo decimal (9, 6)
)
as

insert into CalculoHistoricoLog (DataLog, NomePesq, LatitudePesq, LongitudePesq, NomeProximo, LatitudeProximo, LongitudePromixo)
   values (getdate(), @NomePesq, @LatitudePesq, @LongitudePesq, @NomeProximo, @LatitudeProximo, @LongitudePromixo)

GO
GRANT EXECUTE ON IncluiLogProc TO PUBLIC
GO
			