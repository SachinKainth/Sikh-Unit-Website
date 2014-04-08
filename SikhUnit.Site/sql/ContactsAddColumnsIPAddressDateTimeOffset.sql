﻿ALTER TABLE [dbo].[Contacts] ADD [IPAddress] [nvarchar](max)
ALTER TABLE [dbo].[Contacts] ADD [DateTimeOffset] [datetimeoffset](7) NOT NULL DEFAULT '0001-01-01T00:00:00.000+00:00'
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201404011902435_AutomaticMigration', N'SikhUnit.DataAccess.Migrations.Configuration',  0x1F8B0800000000000400ED5BCB6EE33614DD17E83F085AB505C64A328BB6037B06691E45D0C9039167B6035AA21D3614A58A54E07CDB2CFA49FD855EEA498A94A571ECD81964132424EF2179EFE1EBEAE4BFAFFF8E3F2C23EA3CE09493984DDCC3D181EB6016C421618B899B89F99BDFDC0FEF7FFC617C16464BE773D5EEAD6C07968C4FDC3B2192779EC7833B1C213E8A4890C63C9E8B5110471E0A63EFE8E0E077EFF0D0C300E10296E38C6F33264884F33FE0CF939805381119A2977188292FCBA1C6CF519D2B14619EA0004F5C9FDCDF7D62448C4E9140C74180391F81BDC04BE13AC7942018928FE9DC751063B1400206FCEE13C7BE4863B6F013284074FA986068374794E37222EF9AE643E7747024E7E435866BF9C4AD670BF33D03BF884739BC7CCE13F798CE32AD0934FA0B3F6A05507493C6094EC5E32D9E978617A1EB78BA9DD736ACCD141BD937FCC6C4DB23D7B9CA2845338A6B57293EF5459CE23F31C3291238BC4142E094490C9CCFC1E8BDD597FC59F506B101BEB9CE255A7EC46C21EE262EFCEA3AE76489C3AAA41C01C41EE8094622CD705F27B9F7AEB26886D3BE99B580AED00359E4136D41FAC022EE3AB798E6B5FC8E2405E146B2E64B112FE73C8DA3DB9896ED8BD22F53942E30B0741A1B557E9CA5416B1463AF61C34A8E489C578A3C8522FDB35A0D324D5170BF599E95445A876715992C3CAB28B816CFE4368B02F13D52ED2C42841E87610AC7C9D629F72CBCF6B3D9DF38105BEFE7123C8616DB9FCFC5CD7385072E16780AB793EBF99CE3DA81EDD2950B7BF092BA88A4EFBEC305B5058E0F76EA4722E4A8B3F4D5B36BAF01C2138A1E7719C5CB8C93E0330971FC1AC5CD7A768AE8FDAB639FEED863CEE380E4A3566EE25F6C4FB633163ADDF7B462B0D5DD0EC69B5141124A02E874E2FE624CD98A56BF2E1AB4F292A8C31DBAED205FB3534CB1C0CE71503C7F4F100F50686E12E087502F015EE054060651B81D729122C2844922C2029220DA39E896C540E2C911D5D8ED9A539C602639D3E9F7219DD6AF03B3E7BA83968FFA5C32F614DE98EB34BF6413607F731B4133C47195E3683341DAF858A8E3852B5243589D0A069174F3F2716B5817B4EC312E9F0736FBEAE5D007915F876C00C53DA9CFBC39F86D18CAB5A00FA8397B6C40CAC9D407546FB5369C661F6EC3280CD18353BDFB9406E6ABB04DD5959B4F3DE23AFA06D5576E378A7D45BEF6AEA1CFC6B2B1D69C6F127F5E91F9AB32845E478A707C899204F67825655896387E912F3C79E37F7B5A2E2A30BC805BB273F568EB9EE0C4027AB66AE58208F13949B9A8D6B0EB9C8491D16CE00AAF7AD316BA19AA8A635573F97BC99FEECCE9C84A9CC699E730BF48EEA5F9E1DC0EB96997676E1145A9E5227012D32C62DD7B7AB77571B4ABF645C970042D1FA802691526DED86B39C2380D0CC71B27A71EC641412E16E4A6626CA6090785D86EB6D7116E0FA2F314EFC6D1327A2A9656B1374CA9CFDE4D91C59AEB1BC4974ECBED5046CFDCA9387ACD7392B0CEBDA92075E1709C3AB7A6E2D485C37194DC99E6E89B35BCD3CE83A980EDBABD591EE5BD72538BC392B5CBF1FA964687DDAEF7D21D0545BDAD6F2A325DA9BF41E15965BCEB18752E473551A7AD45B5626F62AE3EAC3615F3AE44E1A098AF32DE75CC771423E5CDBAA91075641C07456885ED771D20E371DC6E52F75E3F925B8FE171F930ED17D5182FD5A289EB806B1EC0F7F04AF51FB9C0511EDC91FF0F3DA104E6DB34B8448CCC3117D3F81EB3897B747078D492E3AC218DF1380FE95EEA63889C7B6FA6FA1B55046AEA9A3DA034B843E94F115AFEAC22AD297BC907BC996F96BB919BBC008FB706FB740DC90683B633EDC656E266936B3C297E1B23424B76F124AC96B4E24958867CE2496876894408A552D61997A537290E482118FDF5850B26F669F779113A887D729885BFA6BC611B01D8A584619F02F01294092FC15F6B090ECA2F86CF2A0BD0BF18AEA170584B57D0F5116B2B5A8217221F30BF4176E40074D971977EA07817C2513F8B21AA057F3B3EFBDAB4059DD2021BAEF5737497EA6095E8C006DE8815864812BA150936EC4AC53058ADD02356B0F5A1491D06AB197AC40CB68E3429C450B5C36AB183AD1B5528F14C62088DEACAD7EC3E0184A199D88EE2C14CDEC0E6A0FCDF14EC4A9C2C1A08F95F540C07DAB650B7B960F3B8DA9E5A23AA9A188F0F814299C94B0599C34A816A99D2CBF5749F11CDF257D80C8717EC3A13492660CA389A514D9F2777B955FDE7B20E7DCCE3EB24FF77874D4C018649E49BE49AFD91111AD6E33EB7BC3F3A20E4F659DE07642C85BC172C1E6BA4AB980D042ADD57EFFA531CC10D54607ECD7CF480BBC7D6EF43DD63E3538216298A7889D1D8C39F40BF305ABEFF1F0C5436C9F9370000 , N'6.0.1-21010')
