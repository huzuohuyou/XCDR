-- Table: public."InPatient"

-- DROP TABLE public."InPatient";

CREATE TABLE public."InPatient"
(
    "DiseaseCode" character(36) COLLATE pg_catalog."default",
    "PatientId" character varying(36) COLLATE pg_catalog."default",
    "PatientNo" character varying(36) COLLATE pg_catalog."default",
    "CaseNo" character varying(36) COLLATE pg_catalog."default",
    "CardNo" character varying(36) COLLATE pg_catalog."default",
    "Name" character varying(200) COLLATE pg_catalog."default",
    "Sex" character varying(20) COLLATE pg_catalog."default",
    "BirthDate" date,
    "CountryName" character varying(200) COLLATE pg_catalog."default",
    "Nation" character varying(200) COLLATE pg_catalog."default",
    "InDate" date,
    "InpatientAreaCode" character varying(36) COLLATE pg_catalog."default",
    "InpatientAreaName" character varying(180) COLLATE pg_catalog."default",
    "InDeptCode" character varying(36) COLLATE pg_catalog."default",
    "InDept" character varying(180) COLLATE pg_catalog."default",
    "InDeptDate" date,
    "OutDeptDate" date,
    "DoctorCode" character varying(36) COLLATE pg_catalog."default",
    "DoctorName" character varying(50) COLLATE pg_catalog."default",
    "InSource" character varying(20) COLLATE pg_catalog."default",
    "InTimes" character varying(28) COLLATE pg_catalog."default",
    "OutDept" character varying(18) COLLATE pg_catalog."default",
    "OutDeptName" character varying(180) COLLATE pg_catalog."default",
    "OutDate" date,
    "AdmissionSituationFlag" character varying(20) COLLATE pg_catalog."default",
    "InDiagCode" character varying(90) COLLATE pg_catalog."default",
    "InDiagName" character varying(900) COLLATE pg_catalog."default",
    "OutDiagCode" character varying(90) COLLATE pg_catalog."default",
    "OutDiagName" character varying(900) COLLATE pg_catalog."default",
    "OutStatus" character varying(20) COLLATE pg_catalog."default",
    "OutType" character varying(20) COLLATE pg_catalog."default",
    "IncrementFlag" character varying(100) COLLATE pg_catalog."default",
    "Id" bigint NOT NULL,
    CONSTRAINT inpatient_pkey PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."InPatient"
    OWNER to postgres;