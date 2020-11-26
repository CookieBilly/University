/* Healthcare database */

/* Task 1 - correct the errors in this script file */

/* fixed drop for perscript_items to remove @perscription@ */

DROP TABLE bh53xv_prescript_items CASCADE CONSTRAINTS;
DROP TABLE bh53xv_drug_tab CASCADE CONSTRAINTS;
DROP TABLE bh53xv_prescription CASCADE CONSTRAINTS;
DROP TABLE bh53xv_doctor CASCADE CONSTRAINTS;
DROP TABLE bh53xv_patient CASCADE CONSTRAINTS;
DROP TABLE bh53xv_surgery CASCADE CONSTRAINTS;
DROP VIEW bh53xv_patient_history;

/* Changed surname from number to varchar2 */
CREATE TABLE bh53xv_patient
(patient_id		NUMBER(6) NOT NULL PRIMARY KEY,
surname			VARCHAR2(20) NOT NULL,
forename		VARCHAR2(15) NOT NULL,
street			VARCHAR2(30),
town			VARCHAR2(30),
county			VARCHAR2(33),
postcode		VARCHAR2(8) NOT NULL,
dob				DATE NOT NULL);

/* made item_cost be 6,2 */
CREATE TABLE bh53xv_drug_tab
(drug_code			VARCHAR2(8) NOT NULL PRIMARY KEY,
drug_name			VARCHAR2(25),
item_cost 			VARCHAR2(6));

/* added perscription table, made it reference patient */
CREATE TABLE bh53xv_prescription
(prescription_no	NUMBER(6) NOT NULL PRIMARY KEY,
patient_id			NUMBER(6) REFERENCES bh53xv_patient,
prescript_date 		DATE NOT NULL,
doctor              VARCHAR(25) NOT NULL,
pharmacist          VARCHAR(25) NOT NULL,
issue_date          DATE NOT NULL);

/* Uncapitalized No in perscription_no, added closing bracket, fixed space beforecomma, added a comma next to drug_qty, added reference to drug_tab */
CREATE TABLE bh53xv_prescript_items
(prescription_no	NUMBER(6) NOT NULL REFERENCES bh53xv_prescription,
drug_code_p			VARCHAR2(8) NOT NULL REFERENCES bh53xv_drug_tab(drug_code),
drug_qty			NUMBER(3),
drug_code_iss		VARCHAR2(8) NOT NULL,
drug_qty_iss		NUMBER(3) NOT NULL,
PRIMARY KEY(prescription_no,drug_code_p));

/* Task 2 - Add your SQL INSERT commands to insert all the data into your tables */

/* Patient table data */
INSERT INTO bh53xv_patient(PATIENT_ID,SURNAME,FORENAME,STREET,TOWN,COUNTY,POSTCODE,DOB) VALUES (500001,'Green','Janice','2, Sunny Street','South Shields','Tyne and Wear','NE34 56P','12-JUN-60');
INSERT INTO bh53xv_patient(PATIENT_ID,SURNAME,FORENAME,STREET,TOWN,COUNTY,POSTCODE,DOB) VALUES (500002,'Brown','Tony','6, The Links','Tynemouth','Tyne and Wear','NE33 22X','08-MAR-66');
INSERT INTO bh53xv_patient(PATIENT_ID,SURNAME,FORENAME,STREET,TOWN,COUNTY,POSTCODE,DOB) VALUES (500003,'Jones','Caroline','34, Cranford Sq','Hebburn','Tyne and Wear','NE34 11T','30-MAY-52');

/* prescription table data */
INSERT INTO bh53xv_prescription(PRESCRIPTION_NO,PATIENT_ID,PRESCRIPT_DATE,DOCTOR,PHARMACIST,ISSUE_DATE) VALUES (100000,500002,'12-JAN-13','Dr.Jones','P.Smith','14-JAN-13');
INSERT INTO bh53xv_prescription(PRESCRIPTION_NO,PATIENT_ID,PRESCRIPT_DATE,DOCTOR,PHARMACIST,ISSUE_DATE) VALUES (100001,500002,'12-JAN-13','Dr.Jones','P.Smith','14-JAN-13');
INSERT INTO bh53xv_prescription(PRESCRIPTION_NO,PATIENT_ID,PRESCRIPT_DATE,DOCTOR,PHARMACIST,ISSUE_DATE) VALUES (100002,500001,'24-JUL-12','Dr.Kilroy','S.Jones','28-JUL-12');


/* drug tab table data */
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('GLAX_001','Penicillin',0.5);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('PG_002','Paracetamol - 500mg',0.05);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('SN_232','Calpol - 250 mls',1);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('MR_422','Minocin MR - 56 caps',10);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('BRO_01','Brolene Eye Oint - 5g',5);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('DR_002','Micropore 6pk - 5x5',2);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('TOS_01','Sudocrem - 250g',1);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('TOS_02','Sudocrem - 250g',1.9);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('IBUP_01','Ibuprofen - 200mg',0.1);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('IBUP_02','Ibuprofen - 500mg',0.2);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('LEO_01','Fuciderm - 15g',8);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('LEO_02','Fuciderm - 30g',15);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('JJ_010','Tyrozets - pk10',1.9);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('CR_222','Dequadin - pk20',3);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('SB_410','Germalene - 30g',2);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('CR_243','Mycil - 120g',1.4);
INSERT INTO bh53xv_drug_tab(DRUG_CODE,DRUG_NAME,ITEM_COST) VALUES ('SB_412','Ralgex - 40g',2.3);

/* prescription items table data */
INSERT INTO bh53xv_prescript_items(PRESCRIPTION_NO,DRUG_CODE_P,DRUG_QTY,DRUG_CODE_ISS,DRUG_QTY_ISS) VALUES (100000,'GLAX_001',14,'GLAX_001',14);
INSERT INTO bh53xv_prescript_items(PRESCRIPTION_NO,DRUG_CODE_P,DRUG_QTY,DRUG_CODE_ISS,DRUG_QTY_ISS) VALUES (100001,'PG_002',24,'PG_002',24);
INSERT INTO bh53xv_prescript_items(PRESCRIPTION_NO,DRUG_CODE_P,DRUG_QTY,DRUG_CODE_ISS,DRUG_QTY_ISS) VALUES (100002,'SN_232',1,'SN_232',1);
INSERT INTO bh53xv_prescript_items(PRESCRIPTION_NO,DRUG_CODE_P,DRUG_QTY,DRUG_CODE_ISS,DRUG_QTY_ISS) VALUES (100002,'CR_222',5,'CR_222',5);

/* Task 3 - Enter each your SQL query to answer each question under the relevant comment */

/* Task 3 - Question 1 */
SELECT surname, forename, town, postcode FROM bh53xv_patient WHERE town <> 'Tynemouth';

/* Task 3 - Question 2 */
SELECT prescription_no, surname, forename, dob, doctor, issue_date FROM bh53xv_prescription pr, bh53xv_patient p ORDER BY doctor ASC, prescription_no DESC;

/* Task 3 - Question 3 */
/* UNSURE ON THIS, REVIEW LATER */
SELECT pi.prescription_no, count(pi.prescription_no), sum(dt.ITEM_COST * pi.DRUG_QTY) as total_cost FROM bh53xv_prescript_items pi, bh53xv_drug_tab dt WHERE dt.drug_code = pi.DRUG_CODE_P GROUP BY pi.PRESCRIPTION_NO;

/* Task 3 - Question 4 */
CREATE TABLE bh53xv_doctor
(doc_id					NUMBER(2) NOT NULL,
doc_forename			VARCHAR2(20),
doc_surname				VARCHAR2(25) NOT NULL,
employ_date				DATE,
surgery					VARCHAR2(30),
PRIMARY KEY(doc_id));

/* Task 3 - Question 5 */
INSERT INTO bh53xv_doctor(DOC_ID,DOC_FORENAME,DOC_SURNAME,EMPLOY_DATE,SURGERY) VALUES (1,'Fred','Jones','23-JAN-1995','Penshaw Medical Centre');
INSERT INTO bh53xv_doctor(DOC_ID,DOC_FORENAME,DOC_SURNAME,EMPLOY_DATE,SURGERY) VALUES (2,'Barney','Kildare','18-OCT-1992','Lisbon Square Surgery');
INSERT INTO bh53xv_doctor(DOC_ID,DOC_FORENAME,DOC_SURNAME) VALUES (3,'Elma','Ford');


/* Task 3 - Question 6 */
SELECT pre.prescription_no, pre.patient_id, p.dob, pre.prescript_date, round(months_between(sysdate,p.dob) / 12) as Age, round(months_between(sysdate,pre.prescript_date), 1) as months FROM bh53xv_prescription pre, bh53xv_patient p WHERE pre.patient_id = p.patient_id;

/* Task 3 - Question 7 */
SELECT p.patient_id, p.surname ||', '|| substr(p.forename, 1,1) ||'.' as FULLNAME, substr(p.postcode, 1,4) as Area, substr(p.postcode, 6,10) as Location FROM bh53xv_patient p;

/* Task 3 - Question 8 */
CREATE VIEW bh53xv_patient_history AS SELECT pre.patient_id, count(pre.prescription_no) as num_pres FROM bh53xv_patient p, bh53xv_prescription pre GROUP BY pre.patient_id;

/* Task 3 - Question 9 */
SELECT p.patient_id, p.forename, p.surname, p.dob FROM bh53xv_patient p WHERE p.dob < (SELECT dob FROM bh53xv_patient WHERE patient_id = 500001);

/* Task 3 - Question 10 */
CREATE TABLE bh53xv_surgery
(surgery_id		NUMBER(6) NOT NULL PRIMARY KEY,
name			VARCHAR2(40) NOT NULL,
address			VARCHAR2(95) NOT NULL,
phone			VARCHAR2(20));

ALTER TABLE bh53xv_doctor MODIFY doc_forename VARCHAR2(25) NOT NULL;
ALTER TABLE bh53xv_doctor ADD surgery_id NUMBER(6);
ALTER TABLE bh53xv_doctor ADD CONSTRAINT surgery_fk FOREIGN KEY (surgery_id) REFERENCES bh53xv_surgery(surgery_id);

INSERT INTO bh53xv_surgery(SURGERY_ID,NAME,ADDRESS,PHONE) VALUES (111,'Penshaw Medical Centre','Penshaw road 101','019121311131');
INSERT INTO bh53xv_surgery(SURGERY_ID,NAME,ADDRESS,PHONE) VALUES (112,'Lisbon Square Surgery','94 Lisbon Square','01912899331');

UPDATE bh53xv_doctor SET surgery_id = 111 WHERE surgery = 'Penshaw Medical Centre';
UPDATE bh53xv_doctor SET surgery_id = 112 WHERE surgery = 'Lisbon Square Surgery';

COMMIT;






