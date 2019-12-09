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

CREATE TABLE public."Capsulas"
(
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    forca integer NOT NULL,
    "CapsulasID" integer NOT NULL DEFAULT nextval('"Capsulas_CapsulasID_seq"'::regclass),
    CONSTRAINT "Capsulas_pkey" PRIMARY KEY ("CapsulasID")
)

TABLESPACE pg_default;

ALTER TABLE public."Capsulas"
    OWNER to postgres;

GRANT ALL ON TABLE public."Capsulas" TO postgres WITH GRANT OPTION;    


-- Table: public."Estoque"

-- DROP TABLE public."Estoque";

CREATE TABLE public."Estoque"
(
    validade date NOT NULL,
    "dataEntrada" date NOT NULL,
    "dataSaida" date NOT NULL,
    "capsulasID" integer NOT NULL DEFAULT nextval('"Estoque_capsulasID_seq"'::regclass),
    CONSTRAINT "Estoque_pkey" PRIMARY KEY ("capsulasID")
)

TABLESPACE pg_default;

ALTER TABLE public."Estoque"
    OWNER to postgres;

GRANT ALL ON TABLE public."Estoque" TO postgres WITH GRANT OPTION;


-- Table: public."KitCapsulas"

-- DROP TABLE public."KitCapsulas";

CREATE TABLE public."KitCapsulas"
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

CREATE TABLE public."KitSabor"
(
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    "kitSaborID" integer NOT NULL DEFAULT nextval('"KitSabor_kitSaborID_seq"'::regclass),
    CONSTRAINT "KitSabor_pkey" PRIMARY KEY ("kitSaborID")
)

TABLESPACE pg_default;

ALTER TABLE public."KitSabor"
    OWNER to postgres;

GRANT ALL ON TABLE public."KitSabor" TO postgres WITH GRANT OPTION;

-- Table: public."Receitas"

-- DROP TABLE public."Receitas";

CREATE TABLE public."Receitas"
(
    "receitaID" integer NOT NULL DEFAULT nextval('"Receita_ReceitaID_seq"'::regclass),
    descricao character varying(200) COLLATE pg_catalog."default" NOT NULL,
    "kitSaborID" integer NOT NULL,
    CONSTRAINT "Receita_pkey" PRIMARY KEY ("receitaID")
)

TABLESPACE pg_default;

ALTER TABLE public."Receitas"
    OWNER to postgres;

GRANT ALL ON TABLE public."Receitas" TO postgres WITH GRANT OPTION;