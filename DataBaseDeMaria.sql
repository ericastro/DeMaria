-- Database: Cafeteria

-- DROP DATABASE "Cafeteria";

CREATE DATABASE "Cafeteria"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;


-- Table: public."Capsulas"

-- DROP TABLE public."Capsulas";

CREATE TABLE public."Capsulas" (
    capsulasID SERIAL PRIMARY KEY,
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    forca integer NOT NULL )

TABLESPACE pg_default;

ALTER TABLE public."Capsulas"
    OWNER to postgres;

GRANT ALL ON TABLE public."Capsulas" TO postgres WITH GRANT OPTION;    


-- Table: public."Estoque"

-- DROP TABLE public."Estoque";

CREATE TABLE IF NOT EXISTS public."Estoque"
(
    validade date NOT NULL,
    "dataEntrada" date NOT NULL,
    "dataSaida" date NOT NULL,
    "capsulasID" integer NOT NULL
)

TABLESPACE pg_default;

ALTER TABLE public."Estoque"
    OWNER to postgres;

GRANT ALL ON TABLE public."Estoque" TO postgres WITH GRANT OPTION;


-- Table: public."KitCapsulas"

-- DROP TABLE public."KitCapsulas";

CREATE TABLE IF NOT EXISTS public."KitCapsulas"
(
    "kitCapsulaID" integer NOT NULL,
    quantidade integer NOT NULL,
    "kitSaborID" integer NOT NULL
)

TABLESPACE pg_default;

ALTER TABLE public."KitCapsulas"
    OWNER to postgres;

GRANT ALL ON TABLE public."KitCapsulas" TO postgres WITH GRANT OPTION;

-- Table: public."KitSabor"

-- DROP TABLE public."KitSabor";

CREATE TABLE IF NOT EXISTS public."KitSabor"
(
    kitSaborID SERIAL PRIMARY KEY,
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL
)

TABLESPACE pg_default;

ALTER TABLE public."KitSabor"
    OWNER to postgres;

GRANT ALL ON TABLE public."KitSabor" TO postgres WITH GRANT OPTION;

-- Table: public."Receitas"

-- DROP TABLE public."Receitas";

CREATE TABLE IF NOT EXISTS public."Receitas"
(
    receitaID integer NOT NULL,
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    kitSaborID integer NOT NULL
)

TABLESPACE pg_default;

ALTER TABLE public."Receitas"
    OWNER to postgres;

GRANT ALL ON TABLE public."Receitas" TO postgres WITH GRANT OPTION;