PGDMP                         w         
   manager_db     11.3 (Ubuntu 11.3-1.pgdg19.04+1)     11.3 (Ubuntu 11.3-1.pgdg19.04+1)     x           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            y           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            z           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            {           1262    24585 
   manager_db    DATABASE     |   CREATE DATABASE manager_db WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'pt_BR.UTF-8' LC_CTYPE = 'pt_BR.UTF-8';
    DROP DATABASE manager_db;
             admin    false            �            1259    24899 	   voluntary    TABLE     �  CREATE TABLE public.voluntary (
    id character varying(36) NOT NULL,
    voluntaryname character varying(300) NOT NULL,
    voluntaryemail character varying(300) NOT NULL,
    voluntaryphone character varying(300) NOT NULL,
    voluntarypassword character varying(300) NOT NULL,
    voluntarycep character varying(300),
    voluntaryavenue character varying(300),
    voluntarynumber character varying(300),
    voluntaryneighborhood character varying(300),
    voluntarycity character varying(300),
    voluntarystate character varying(300),
    voluntaryaffinity character varying(300),
    voluntarysocialnetwork character varying(300),
    voluntaryphotoimagename character varying(300),
    isapproved boolean DEFAULT false NOT NULL
);
    DROP TABLE public.voluntary;
       public         kaspary    false            u          0    24899 	   voluntary 
   TABLE DATA                 COPY public.voluntary (id, voluntaryname, voluntaryemail, voluntaryphone, voluntarypassword, voluntarycep, voluntaryavenue, voluntarynumber, voluntaryneighborhood, voluntarycity, voluntarystate, voluntaryaffinity, voluntarysocialnetwork, voluntaryphotoimagename, isapproved) FROM stdin;
    public       kaspary    false    196   �	       �
           2606    24907    voluntary voluntary_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.voluntary
    ADD CONSTRAINT voluntary_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.voluntary DROP CONSTRAINT voluntary_pkey;
       public         kaspary    false    196            u   �  x���;n1�Z{�)� t(R�.�.E�m���fW����}r�\,J7G�B�G��I��D��+�%�xB�d^��r��uִ79?o�S;˺=�8�w.�_��s�|d�-}0٣E����k��U��u,_�r�a,�y��g,?��~]��0_�m��R������'�i��ֻ�q3�V�r��f>>��a�I��Z�A�2��"5�X;[o#��v~:�+�O-����E����QC �����.�� ���K��Ԃm.#c�����XSE��`�����U�Y �,����s�kj��t�͐2+$��)[��v�p4?�Z{��u�e�K 
4��āƝ?�_�M6D�g�]�
���!um����'�_+�Z Y�(�_Cu�R݌�*;>�
����8���J�H,�r�F��_x�~>�N�W)Cn     