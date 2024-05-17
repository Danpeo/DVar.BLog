PGDMP      9                |         	   DVar_BLog    16.0    16.0     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    34091 	   DVar_BLog    DATABASE        CREATE DATABASE "DVar_BLog" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "DVar_BLog";
                postgres    false            �            1259    34118    FeedbackProcessings    TABLE     �   CREATE TABLE public."FeedbackProcessings" (
    "Id" uuid NOT NULL,
    "FeedbackId" uuid NOT NULL,
    "DueDateTime" timestamp with time zone NOT NULL
);
 )   DROP TABLE public."FeedbackProcessings";
       public         heap    postgres    false            �            1259    34104    FeedbackResponses    TABLE     �   CREATE TABLE public."FeedbackResponses" (
    "Id" uuid NOT NULL,
    "FeedbackId" uuid NOT NULL,
    "Response" text NOT NULL,
    "ResponseDateTime" timestamp with time zone NOT NULL
);
 '   DROP TABLE public."FeedbackResponses";
       public         heap    postgres    false            �            1259    34097 	   Feedbacks    TABLE     }  CREATE TABLE public."Feedbacks" (
    "Id" uuid NOT NULL,
    "FeedbackType" integer NOT NULL,
    "MessageTitle" text NOT NULL,
    "MessageBody" text NOT NULL,
    "FeedbackCratedDateTime" timestamp with time zone NOT NULL,
    "UserFullName_Surname" text NOT NULL,
    "UserFullName_FirstName" text NOT NULL,
    "UserFullName_MiddleName" text,
    "UserEmail" text NOT NULL
);
    DROP TABLE public."Feedbacks";
       public         heap    postgres    false            �            1259    34092    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            �          0    34118    FeedbackProcessings 
   TABLE DATA           R   COPY public."FeedbackProcessings" ("Id", "FeedbackId", "DueDateTime") FROM stdin;
    public          postgres    false    218   �       �          0    34104    FeedbackResponses 
   TABLE DATA           a   COPY public."FeedbackResponses" ("Id", "FeedbackId", "Response", "ResponseDateTime") FROM stdin;
    public          postgres    false    217   H       �          0    34097 	   Feedbacks 
   TABLE DATA           �   COPY public."Feedbacks" ("Id", "FeedbackType", "MessageTitle", "MessageBody", "FeedbackCratedDateTime", "UserFullName_Surname", "UserFullName_FirstName", "UserFullName_MiddleName", "UserEmail") FROM stdin;
    public          postgres    false    216   �       �          0    34092    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    215   �       d           2606    34122 *   FeedbackProcessings PK_FeedbackProcessings 
   CONSTRAINT     n   ALTER TABLE ONLY public."FeedbackProcessings"
    ADD CONSTRAINT "PK_FeedbackProcessings" PRIMARY KEY ("Id");
 X   ALTER TABLE ONLY public."FeedbackProcessings" DROP CONSTRAINT "PK_FeedbackProcessings";
       public            postgres    false    218            a           2606    34110 &   FeedbackResponses PK_FeedbackResponses 
   CONSTRAINT     j   ALTER TABLE ONLY public."FeedbackResponses"
    ADD CONSTRAINT "PK_FeedbackResponses" PRIMARY KEY ("Id");
 T   ALTER TABLE ONLY public."FeedbackResponses" DROP CONSTRAINT "PK_FeedbackResponses";
       public            postgres    false    217            ^           2606    34103    Feedbacks PK_Feedbacks 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Feedbacks"
    ADD CONSTRAINT "PK_Feedbacks" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."Feedbacks" DROP CONSTRAINT "PK_Feedbacks";
       public            postgres    false    216            \           2606    34096 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    215            b           1259    34128 !   IX_FeedbackProcessings_FeedbackId    INDEX     m   CREATE INDEX "IX_FeedbackProcessings_FeedbackId" ON public."FeedbackProcessings" USING btree ("FeedbackId");
 7   DROP INDEX public."IX_FeedbackProcessings_FeedbackId";
       public            postgres    false    218            _           1259    34116    IX_FeedbackResponses_FeedbackId    INDEX     i   CREATE INDEX "IX_FeedbackResponses_FeedbackId" ON public."FeedbackResponses" USING btree ("FeedbackId");
 5   DROP INDEX public."IX_FeedbackResponses_FeedbackId";
       public            postgres    false    217            f           2606    34123 ?   FeedbackProcessings FK_FeedbackProcessings_Feedbacks_FeedbackId    FK CONSTRAINT     �   ALTER TABLE ONLY public."FeedbackProcessings"
    ADD CONSTRAINT "FK_FeedbackProcessings_Feedbacks_FeedbackId" FOREIGN KEY ("FeedbackId") REFERENCES public."Feedbacks"("Id") ON DELETE CASCADE;
 m   ALTER TABLE ONLY public."FeedbackProcessings" DROP CONSTRAINT "FK_FeedbackProcessings_Feedbacks_FeedbackId";
       public          postgres    false    216    4702    218            e           2606    34111 ;   FeedbackResponses FK_FeedbackResponses_Feedbacks_FeedbackId    FK CONSTRAINT     �   ALTER TABLE ONLY public."FeedbackResponses"
    ADD CONSTRAINT "FK_FeedbackResponses_Feedbacks_FeedbackId" FOREIGN KEY ("FeedbackId") REFERENCES public."Feedbacks"("Id") ON DELETE CASCADE;
 i   ALTER TABLE ONLY public."FeedbackResponses" DROP CONSTRAINT "FK_FeedbackResponses_Feedbacks_FeedbackId";
       public          postgres    false    216    217    4702            �   \   x�ʻ�0 ��La���2�M��W?z�-ʄ�p�wـ�#�xfl�J
��S^CX���F��p�Y �w�Sxv?Q�@i��Z� �-�      �   8  x����q1E�*6�q� @l�LE8���;p�܃_��^G��8�2����Δ95[�dMP�&k9�$邥�v�H� �\BQozԮh��<�yy^Y 3��H��tUQu{B�p�T�N�ww�Fq,�J��@E�ڢb���t��~���/�x˴�rEe���E"�>�����-�<M��VR��㍷��u�����x>�ӆe�|�B�r�}���09��.�p��TS]��k�6v�6���Њr7K	�/�׸Y�۸����cܧ�Ͽ�z�d"[ҳr���|�|�^.� 1��      �   �  x��S�n1=;_�w4��=��{�p�]��Hi+e�[	�zH��;P���~��#�	H�@9�9�3�y�7�^"R�d@�E`k����wV��T�8N��B�"@�VJ�����Y��y�$һ�Ηi�6"}ȗ�&ݦM��k!����0�8y�gaxQ/�M���{�J9�[��X��E�����(8������8�h�[Ӵ�j��<��}Z�/i[��X���ڣ��!�qbԓ��� .t>���E.�%~0p��-b�|�Bu`P֤윱MH+�������.P�bob�x:�1�j�֎���F���!��/�AA�w�AW/�k\a�W���X�u��+qH�:��1Kj��RII��,)���2Ȧw@p�{�Uѹ�C��{��U��v���}ί��1��R�ʯҧ�+����o�2���&��������H^�k��.�j�j[�՟��l6�:���l^�秓��d2��q�      �   L   x�32021054347462����,�L���3�3�2�H�X[��;������$%&g�'�g�C���qqq �A     