using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    internal static class Equivalences
    {
        internal static readonly Dictionary<string, TypeMapping> GOG_MAPPINGS = new Dictionary<string, TypeMapping>()
        {
            ["<Module>"] = new TypeMapping()
            {
                typeName = "<Module>",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=q$HTrT0Ugo0EJVqwLmz0WkkInuNtu$6_yuJyhJjaFzqc="] = new TypeMapping()
            {
                typeName = "#=q5bLh0RExqnrWknrhBEVT93EDcDbBfHEGlHNAnMLv$qw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qnadJWwRPcz16c1tx$x5T_7eFyyD_Gmn4QUMnxP_Rcpp3l6KohSWujdecPhy$2SNA"] = "#=qPEHBaZZtGwQGLyafG6OpE34sZ4JfJfANDA3oLadmnc1MlUN6fAdSOsrzrBGorBQO",
                    ["#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieWGb0VeeTPXRlMtYO46QnOz"] = "#=qxNBUaXuqiNDVl0rP$I9Lv5rMOuBDiRQKTXPTy3_1zMxddY3vkxwgnckT$je66ehl",
                    ["#=qwF4fXmtqVePh7UIGjn31qR$MmhaFhbizI9rqgAR9_s7dHlE$KEGmjUey0pVX3qxb"] = "#=q4dr1U8prqCvrzV7N0OcR$cJrlVcj14IDrosFPWMSLVKwuicimBpzHqaLoss5ozn2",
                    ["#=qS6MjAePom9jZFoXlJAI_FGZc0j_h9NfxypIRXMngwVb6l3B3hccbqFwYKMUIHORF"] = "#=q$KSp$23WiyM$l2dhcJ$OESum5K7xcHAGMz9PETkaSHgsVm9fr04nWsTZ6ntZLqmy"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPeAqGeEeO1cHeWNv0EN0RA=="] = "#=qbqQ74uQfh934IUEbW55l$g==",
                    ["#=q4jNqleUohYOS6cAKrOZDhg=="] = "#=qxgGv37d4vlpUKcZx_tBIsQ==",
                    ["#=q4PXCZsqGCjViT5tXjqOXmw=="] = "#=qWBJKRTKTyFfHMe$DZRUQcA==",
                    ["#=qp$bVPkSDLPcdLwCNt67jJw=="] = "#=qCcPSaP0iX490JXjbOf$ZDg==",
                    ["#=qNTz1WCgwpVEX7TkEzaAXv1yVyAp0fGknzqtJ4_5gClk="] = "#=qSFAQvEXU_YZhaTU8ecvMgZLp3DDGQ8c_HPIShSEeaBo=",
                    ["#=q3DO9hInPz1wluiHs_Sgthw=="] = "#=q4_NlcT_n_bTmiLKJtBYLcA=="
                }
            },
            ["#=q$P5tYAWnrIOJdBAjknm6cTIPIy5tsham_DhcWP$JofHYmutDanfqA9Gk62rXBibk"] = new TypeMapping()
            {
                typeName = "#=qN7eLW4_z$H06j75fsx1F2PgturQlqAdVxTYBJq8KzAztnekqVr2Lc7vh9tqVJqe7",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qCANdmCvHwu1egzK4c3kvZg=="] = "#=qZnubof$WudxIn5ocGt04Jg==",
                    ["#=qsDedfIPxnu7HHv$ZSV$6GA=="] = "#=qBk2mhzhaFGZfsBfeJopvEw==",
                    ["#=qfxF6B12Fx879AKrxRi_ONg=="] = "#=qPIrwsW5r67tc$dlIZYdaRg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qOajVIKRU4HatNb_ERnZcdQ=="] = "#=qpBJSxnZ4ww5R_Mq3VHmSGQ==",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ==",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=q$QUUkl85NZEEyiMbpNV3BTXacDmjz5wCvIK7q7G701cUDw39uKt7kmvERY_hI0Di"] = new TypeMapping()
            {
                typeName = "#=qB90vFDheOemrIFj1sNVRSj2YFzRySTETNL3bHML8GpYJKCtDdyU6mA9v6ZEoZ8w8",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q81yjraNOGIPwwjqiF28wWA=="] = "#=qhTeYPl3nRUQs5r9xFg92xA==",
                    ["#=qQvp79qfYqG73HlELTWb_3g=="] = "#=q1vIQXJJLPXM43pnsYczAfg==",
                    ["#=qnbjbmitNRXcgEuSrrRET0A=="] = "#=qtQr24pOqwevbcP9L9zM5$Q==",
                    ["#=qNY9vL8HjP8weOGFiB9NrOMwSnlkSi1bgsRdBNyPKKew="] = "#=qs5Maxx$0hcx9f80xH7r4UVGi7DrSHW_kuans9NLIXTw="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q2hfluxH_AsGFO4gTZw2tCA=="] = "#=qXw87wHWyVf72eb0VSEhPyw==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qWjYyrsEdmMsgHEslo8Hp3MPq3Za$daWvqRvQ$L2_pkQhzCK8kDIbBEWLG7FnvICO"] = "#=qcgZ1XpqZ0zHVk0dHNMQMTZdoCKASThOS2rXrMn3_M5MjfMVHl6CNts46K5TDD$tZ"
                }
            },
            ["#=q$sjS9zT_vE$ynB8BfSB5qkBaKOUjGjvwRohhiSkNgCc="] = new TypeMapping()
            {
                typeName = "#=qf5CEvsrJc8bk8nueMk5$HJcjiqJ955TBRNlHG0rmekY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8jxuUqv_Cfc6GApdZZVAPQ=="] = "#=qNKUrXaYgUio68_eGLvJ4mA==",
                    ["#=qdSLZKYudMSCjc23UxiCSoA=="] = "#=qT0s2wnqFuct2Q7VVrsUDxA==",
                    ["#=qTiooxYUffbmir8Q1D55j3g=="] = "#=q11CQen3XB3HNrra_hU20PA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q$yMWVw3qQ$UwLBLRMbRwJhuoIQxLrak35b3P35VKPns="] = new TypeMapping()
            {
                typeName = "#=qb$_ILk2dkJJtP_asdZlvTOGVURBQmQ0CtubfCY7x04A=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUN0P8eIauFb5mYNImpqMHsmoITaBIXCWk23oIQWAkjE="] = "#=qz0GY9bDg3i2NZeLbTzpfTzLWEA$ZhSq2mPbSSOrQvuE=",
                    ["#=qMfOxxOSR7esOnjSiR$1MCA=="] = "#=qanqs90IU3lY_97ahFZRTnQ==",
                    ["#=qh$x4igIdB$Qwy0W9Grzt$KfarhAO6KX57m7UIm8wHiU="] = "#=qGzlfgfv1Csd6PRw3wxOmxD08uA373ftGzkS2tTZBgTU=",
                    ["#=qAjghnJHNU6mmMHcGsrbz1Q=="] = "#=qbX9R10ig1CnEGYBOVrc$yw==",
                    ["#=qttz7lPANOsfVDWTt_P04eV6twQULr1zpE4qB2uHqAYc="] = "#=qN0EfZbN_kRw$ebwFetLCXtN6KRweEmnBLgq3TY1IVvE=",
                    ["#=qZLg$wXD2cFu0aA7sh9WlLfkMJaVoRY3NH9tHuiayBfw="] = "#=qDya94Dq0CkiHC5GbfBwpncMuzT3$px3O3jfArWoTMuM=",
                    ["#=q26N$MsgRjbdKw7K7LE93aA=="] = "#=q9TPlPwjRZS2ZslNZiECjIg==",
                    ["#=qYdFiXB3L$39zWwV2rzfjMg=="] = "#=qWE4AiurtdrYVBuCT3difXQ==",
                    ["#=qMmUX$l4yVSANrOg8KGWaqQ=="] = "#=qywxuvKMJ70UlX_oc25CjdQ==",
                    ["#=quLWYgLUofU_ND9A6i8HqBA=="] = "#=qAg2WYI4GngojPWhFdtSFXA==",
                    ["#=qWAOhtw6gGY0cE5BqZA_V$A=="] = "#=qa9GJrlrbzWNd9_BDga0wAQ==",
                    ["#=qEvu0sqQMP9z8zDroDhW$Zg=="] = "#=qNjOn7wpsNIvYlb$elotk8w==",
                    ["#=q9WIhVIl5p5vis9I$j1GxbQ=="] = "#=qeRIRsHXOv38ZstCPuR$7iw==",
                    ["#=qVeqpM0zv0z6isJPJhsCaalLGv3$FzgMQ4vKwW6ZIhw4="] = "#=qhfJXus3NSuFuQwUWdC5vbtGgIGhpHGivJpzAQK0k6YA=",
                    ["#=q$SPLCjSrN0cGbMif_HGCvg=="] = "#=qjfm8pswgg1Rdpx5OQilfjA==",
                    ["#=qW$1mqB2L$DtffrdR5DCoHQ=="] = "#=qdWDsBwfxyo5seIpevEuQZQ==",
                    ["#=qEQzVGPIdYxZHlJgfyxpJHw=="] = "#=qCDdMHMKicKuXayAB8m6Bsw==",
                    ["#=ql$eZsapMnEfgp4pV84Eq3A=="] = "#=qwj$e37DQKCfrHTBLHMl0Lw==",
                    ["#=qSO4xfsEsiXsdckbXbhBbXw=="] = "#=qgjxe8jWr1m8z2qxq92Fxug==",
                    ["#=qycl4VjPy2KX$VWR24PVKaKOUZR7iC9fZr4nFGtN3c4Q="] = "#=q4$hTvb9cARsV7c$uJ1plgwnpqWnka6SLv3yGaAjZp9Q=",
                    ["#=qdK5YJiYNilcKuSoUcU6e2A=="] = "#=q2tpFFmbvJ1bDL1dUk9K66g==",
                    ["#=q$ChD9CJ6YBsqjTV_GWVFLXg218OyjwlE2q31YBxGNik="] = "#=qbpCau1C_v0X2fx3iPAL4mIWOnG62RrNWXWTQjEE7utc=",
                    ["#=q5sgprPuget5ANY9MjX5bZ8W6VF1rNRaOtqdn63hfsEA="] = "#=qpHytqdSauvd0D6raxBeGz$uUknSq$mojq933Cqb11AI=",
                    ["#=qOQuk6qab57YRDN7byg9FSQ=="] = "#=qWHZbtuDaeYroU0NdtQEC3Q==",
                    ["#=qo_MOi3$ARaoAcgtJpuZwKQ=="] = "#=qWly2LPQ6UVhE2JzVqkc4gA==",
                    ["#=q5dzKqG1d8OsnCRO$WGtrYJs29WwTVIMnQsGfINegpEs="] = "#=qw0o1xCiJmZMZxYxo9WKPdLN5NyJGtzjQ_ykqrtC2log=",
                    ["#=q9KdeGQKHIiUuwmcVCUPChg=="] = "#=q05DvHeAX6QyLN9ANrawA3A==",
                    ["#=qq6qgDz3JccYIvM7WZLL0AA=="] = "#=qY1YwihMFfwue5A5xBYh4sw==",
                    ["#=qy0vm$fqlq32jOHfus1Ea_PHrxn6AvKE$I4k7zlhCOG0="] = "#=qlY$SD7ROfEi0bESxkkNlus3nq7th3wJjDIkMswRXMgE=",
                    ["#=qCAoGVzkf2xLI4c6lq$VhjA=="] = "#=qtTOSXrbq4KqgwejMyRbWwg==",
                    ["#=qLhxq_oFLl5ZNhnSu68SmlFT5nSI2_seVdYpc4dP3Ot4="] = "#=q0XzRGRxe4_oGtcjM5ltl9khMtTt2OLe3RbsRdKGJfUM=",
                    ["#=qfB3oXbBVuakuGlKwe1fx$Q=="] = "#=qJ1NRuutut5fgBGFM4NpFXQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor"
                }
            },
            ["#=q_10k0OvEklgnDTj2GDNfBAn9Z5pd$YwoLqDTGWGtU5K4$f8ryuCES3uObrgTdlHjxnAIDJHQZVVVjsqwCkYEgg=="] = new TypeMapping()
            {
                typeName = "#=qb5cKASIN44To8UOazchhBpxofXEkliZxq5fCoJ5Qn$SeyPdiFD3aFBIOwQ2b_gp_x4MqtqUt18v5QJrZ7mC$jA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=q_8UHw$gP9dY_PiU5Ec0gPg=="] = new TypeMapping()
            {
                typeName = "#=qMs_$ZBL7YYNqFesVC2D74w==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qwUAKpZSx65Ots1h3sLdeTA=="] = "#=qg7nkKX$1WznCFxkCrE3jBQ=="
                }
            },
            ["#=q_ahKp7kUfzoLGUnQx6FcxKTDAZLy5ozkqfZCOliLw70="] = new TypeMapping()
            {
                typeName = "#=qQgs1RuhLzBJOttA0tGwD6tqMj81AWOFTogT3uaqnofU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qJf99bfFt8jHgm1BCkNUErQopuD4Uym5j9pbBjqfe6QY="] = "#=qoCskE7SIz1A5nvpyNTp_9Bur4O5MFktwWTpcOqDqWVk=",
                    ["#=quMkLbOeQaZ_W8v8oUXNqDOYps1q4gWVpDsxn_ZzGhxM="] = "#=qjoEh4dJLIkFUS3Om1gp8Ouz04ViFHzXVCO6AkbsYgtM=",
                    ["#=qwfSbPUM4VnTxEY5fn2nm_Q=="] = "#=qxdQwdy2Pv6ldvnj$sNgZdw==",
                    ["#=qTmo$r$3rtzgwhbkRYh_fBciExz2QULKdUNN6u9GVgjs="] = "#=qhGdxadIUZQx7whXGoLu6FoaNk$2Y7vw_oCuD$AO1K_k=",
                    ["#=qIAdEGmu0Mour6lWjdm85Rg=="] = "#=qOxg1WN65Ahy5ZzRzmh401w==",
                    ["#=qfcBTZN0w57bbrbcW5SdRAuVHvbvp5jHe3pGA4Tegvs4="] = "#=qzdDRGzM0q1_wbb5EcFlT9F3TcTHZGjiFTAEgrcy41Tc=",
                    ["#=qNj7fyUqL1CV3i_mjvRy8HQ=="] = "#=qursvdByKG7V2giLAW_f9fg==",
                    ["#=q0cc_yQIhtwWrZnKgIm$GwklHP0ZIKgR3TUaEpg1Vpug="] = "#=qSY7yNY9GGJ9_EyAxRW2DsrgS0CnDQxvkB07R60qrjVE=",
                    ["#=qoYZfIPY_ajeaJ$rXe92mV0lKu4NDdAL9PJ522E9W7SM="] = "#=q2fduwmfJtfe_F8IpGnYvrqDVjQBDcbAIMC8bFIy169Y="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ=="
                }
            },
            ["#=q_cxfLpUljKkzjeK3fPMBkG3px6FflpNUVhxoFBvbCyQ="] = new TypeMapping()
            {
                typeName = "#=qxspDdaUapO1_cZgipRI3r17gz_dP40$fRnLzd5ci0kI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhZNZ1cqGfMbGEdQgQxAmsQ=="] = "#=qW$zxcowAgjsJNZNTgaAAhw==",
                    ["#=qfUFWBEwAN4QRVr6bHg$gwg=="] = "#=qpgwfNJ8QeCWFbZ$YPrxfUg==",
                    ["#=qI3$R9zYGDvEtUAUJ11$EHHiQgTU41aZnz_dserBfW6ZFlZiVH$BOFD9Ec44tJSnZ"] = "#=qU27ij5fQijngKkZdv9E_7D58TGVeFAGDr9h2DFr7J_4p6MhksPBz7PNG7T3joaVz"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qiMMuBjtLB1WpDxeqfdBs8w=="] = "#=qko4Vjff_$McXUus6$BDu2w==",
                    ["#=quBhgajhF_ljbxFrqT2G7cA=="] = "#=qr79LpqtvYA3QjuIVkor9NQ==",
                    ["#=qFWQKzqIyd32NdzlATQ8WgPGClzZrWhpDlgFK31bVkEo="] = "#=q1RkEzLIf8S69Z_r6lcRDsSt2UydjoJpCisKSuA2M4VI=",
                    ["#=qydyW78Naus8HHbt0_nx2aQ=="] = "#=qWGCyTJ1yn703gOkz9pwr$Q==",
                    ["#=qR6a2LWiIFu7nChX$riEI_w=="] = "#=qqZ6WUdc6_X0HqOW13WIjVw==",
                    ["#=qCDzArzDdDg$WdoIdohdhSQ=="] = "#=qOTgngbmRi1VGHO31QbQc8g==",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qU69_9aVh2Rzx4DhKJHbHoQ==",
                    ["#=qvkE_ZkDZnI7DPbvyFWMHEg=="] = "#=qhoajjt3TorsWd4vioP2T3Q==",
                    ["#=qAaMb2ZaXzTzgm9zzN8o_lg=="] = "#=qMXFAczyNNc2Du_HIueVUBg==",
                    ["#=q3pWuu9Puy7fezWQLQUEdlQ=="] = "#=qQ2r$PoteNJE8ZHLq_Z0Cwg==",
                    ["#=qU_rC7iia1QJEs7ZStYaJtQ=="] = "#=qDZCJwsXrSNjTHDyMToNLlw==",
                    ["#=qfaaMiyR3YApDdWCL6hCaIA=="] = "#=q3NQeVyLgIe4g_Hg9sX667Q==",
                    ["#=q2sna6XLVsJYU8lYTMs5EkA=="] = "#=q1oH_nkUwO5vf69hKI4ULEg==",
                    ["#=qSoNeRR$xCzDxZCl7BvFmLfZnCpfAjVA_7WpITMhrmt0="] = "#=qSL5aaRBq$ou16YaK8otaI6xPtopTVxmmrVjjxNAhIXw=",
                    ["#=qbS4lwAE70aK57QX0ePkiyg=="] = "#=qVx3Rf5LXPh$yQG6Xq6HqGA==",
                    ["#=qmjbTtqkurNuvFhZ8_$c2zw=="] = "#=qfkUnPfxjny8Cj2fsnLSm3Q=="
                }
            },
            ["#=q_jRFx7VyYFz9R6cW_6g5y2SXU7aVBG$2lPsdoP91hc0="] = new TypeMapping()
            {
                typeName = "#=qdoDCB90DTKj43eJRalQbXoWRGIA8RaBzTDzJGADorlw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZzFDaqUY6KGeHUxjsxVkHw=="] = "#=q_kY8LIfhfgV_KeiACHIjxQ==",
                    ["#=qHQyzY1UrFP83237GoqhK1A=="] = "#=qtQgmSYIHTjEYh9lQVTFGCw==",
                    ["#=q859Xauv_jt305GcEgD2DGw=="] = "#=qZTHiUmk54oFc9_PBHvGBHQ==",
                    ["#=qC_T0VfPyomq4eCP9BN0jDw=="] = "#=qPlLCI6NkzE1uSCsy4$yxGQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["op_Implicit"] = "op_Implicit",
                    ["op_Implicit"] = "op_Implicit",
                    ["op_Explicit"] = "op_Explicit",
                    ["op_Explicit"] = "op_Explicit",
                    ["#=qczaKhCQlQEWEhnKK35KAmw=="] = "#=qr17JWxWI8hMGcpLHLh8gbg==",
                    ["#=qVFcS92AYUVlTLmsUe8$tHw=="] = "#=qq37GRDc7hX$LzgTkdtf_qA==",
                    ["#=qVuGS6xZ1IZ3ozkeQWHaN0Q=="] = "#=q0idM8VtYc8UnfHGQ9saQTw==",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode",
                    ["op_UnaryNegation"] = "op_UnaryNegation",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_LessThan"] = "op_LessThan",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_LessThan"] = "op_LessThan"
                }
            },
            ["#=q_kNnXHjBp6OH1879peO3_DruPfChZ2vzI_L2drgdLTw="] = new TypeMapping()
            {
                typeName = "#=qdlOGUClq_hef$lmdOoIA3MuCLamy0P0OkFKKNj$8Dqk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qC1N1QIcG3BaOsMiqVVYv5w=="] = "#=qaV3zXffPT6MHZ7aIXynRzw=="
                }
            },
            ["#=q_l3R5srrpQOzQ$BHgldRs63KwVp9KjoeBxett_nfXmq2DLvlGk2Enzv3BNx3N50c"] = new TypeMapping()
            {
                typeName = "#=qBdkKGWictHDMwxeo8bJsHioI84o8HxCMtE1VoOyFE7j2FApjRNaQSnR6bZBA3NKQ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvEwtUgigEMwPmSJDYnMMHg=="] = "#=q$NyGxt8aCJenZZD0UP9fqA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qXnV1JQX2upmt6kgBlsDTjX4SuVHrxOctmOGIgYZjhws="] = "#=q6myNUR54T_4$s4WJovOCoi8x0m$qen$OpkmTodlDXFg=",
                    ["#=qIhvIxL2PwbdLWsG2Vorj_IjEkFxRlyoy5AyufJJOpVc="] = "#=qFjMoX9LUAWv1$_D9nCObLuWkv_q7dpYrcIdn3XEIaOM=",
                    ["#=qqerH6pujKh0o8nffTsYQMuE2DRUn7xxQphwHW$vuQbs="] = "#=qHXmI4qmyE4peb1eg7VwZEvZxVTuYXZ3JaWwbo_WoBBE=",
                    ["#=qCX6OzFg7k0W55gOwKlh78g=="] = "#=qGmi8NDf7P8sP4LIFsVtAcQ=="
                }
            },
            ["#=q_NBFQMIpQjD$HQamvk2Uhg=="] = new TypeMapping()
            {
                typeName = "#=qSkcqgdy9Vz4sVR55nYkG2w==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUC2C9uvRe8E4WJkEZD2lCQ=="] = "#=qBjRSRWm2T6_SAB9mX8Qgyg==",
                    ["#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaQAAi85cwz6g5fJYFeX0O5$"] = "#=qx0_l8pnI2JruIsOcenadpyL70K6t1xDvi08bU9Vr9EuTvuC7qS6mEvGzwIJ7jSwc"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qND5lBYJi883PM1uE3Hn7rw=="] = "#=qYNohvEClb2dtx8E3ZvQHnw==",
                    ["#=q4C02Ev21FiT1oXYb4pBhrw=="] = "#=qGT3u5wsZmVs1N_W80ZLeqQ==",
                    ["#=qsoXd87bPwuzNd5k0VX1Ibg=="] = "#=qBUbG1ifuVUrbgUYRwkZTNQ==",
                    ["#=qAkHelsufH$tdco9NsxR03w=="] = "#=qpHWHKKGCSM10qu7Y87sySw==",
                    ["#=q0IKouFewI4DFr4BllgNRPg=="] = "#=qkSk2$KMJrsIc1uGs1uEqtw==",
                    ["#=qf$OdUWcAu97LPeS1n90aPg=="] = "#=qe$6I38D_iGXOaUAlAemjEQ==",
                    ["#=qIX_CQlTKgULakme2_LKyYVNohKD1fxHvMBb7lEWe5Zs="] = "#=qbQRsCv4NxyEzLbZUh9pBdMCVfrTPzblgT66c0uLAn18="
                }
            },
            ["#=q_nLOusJvZNMdZW9mRouSpROgtE1KhupR_7NOuk_O8Tk="] = new TypeMapping()
            {
                typeName = "#=qSLJCwKtSFmo1_PT54uu02Gv8PEfKSNjoJtXCYRAFqzk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qg$_T1Qv_AVtV62w$cvsLRQ=="] = "#=qRf3cexUZptY8FppDhn0W5g==",
                    ["#=qGlfh1wQHWgZVkTkq2hhgxQ=="] = "#=q9Qm8NETJf2rlxAMgv1xC2A==",
                    ["#=qkf4OqdjPq0CKltFebAmmEA=="] = "#=q0VR33lK$$SaVYWqwiphPew==",
                    ["#=qyaZsWWSVQgjYdMBhpphb$A=="] = "#=qsSH0YS7wzM5RFCXKzYu7wQ==",
                    ["#=q2EhnJmUuzYxKmetjqN$jgg=="] = "#=qnQrKH3fDf6x3TyRnD8zzsg==",
                    ["#=qYvoqxWbE$sfTLSvxKyQ07Q=="] = "#=qyw98Ei2yEuA6NwJeK4FGjQ==",
                    ["#=q$H6Dgx0qFvmtg5gt3hCKwg=="] = "#=qlhRxq8f9xSAbg1Ea$3U8Qg==",
                    ["#=qZW_f5r4D0K2GrKl_pfmAYw=="] = "#=qfic4za0JVC3BY$shoZaOKw==",
                    ["#=qSsddimZejqItgV2_Oz5Oow=="] = "#=qPnDL$h1VGsNLU88sM71XIg==",
                    ["#=q9Np0g6LsVrfwBfCxmXS15A=="] = "#=qjdl9T$PHLkaznL6RK5C_9w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qehyDgICILI901uOvQeB9pQ=="] = "#=qMWkpFsVdR77UqrIL1qJyaQ==",
                    ["#=qg6OKTyiHhTZNDOdes6vsjg=="] = "#=qiBPOIOpb4A2t$GKSvdEPyQ==",
                    ["#=qoChCilbo3C7j0clX7hBsYQ=="] = "#=q2YqkWzddT9CRgozv1qJV4Q==",
                    ["#=qfsXu$4SCnkjImqRRStJVKg=="] = "#=qL8cGW_$DjPscCtNRHBM7Sg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qSPc$AGOeNCdM4JciqBmBD62Kd3Ea7jPny6vyL9315Kk="] = "#=qZKmB0wtIRbK6QQiL_69RuNTp3JhJkKi2Cbsr4$qcLsY=",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=q_p$8c1qRehKveVCBYNgkjqI_wIp3SVMWj5b1elqM10U="] = new TypeMapping()
            {
                typeName = "#=qkVE9cQEcPYWuf_zGmdT6lzkbNNU8wNRrkYF1uVxA4eI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qzW$tbbSW6SgwWM1im_QOTg=="] = "#=qfiNwEvih5_TrYHyafESMow=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q7fgsuzfL_Kv5TaGp85$iIBR2ZeY_L48i$KXNEpxy$T4="] = "#=qxoIvfVdB_bnEdb2BZtuAiTmzwrVO5lZ89mZdMfMK_$8="
                }
            },
            ["#=q_sQ$0CAEq3SoQ6jbIpskO3GC27DySozNsL2JXGc6cza1pO$966SGQkdvdux8Om8m"] = new TypeMapping()
            {
                typeName = "#=q1vv2LktBrv6O3OL23S1CU4kYgA_1uBLPVyDwzVhJyAmhOqclzBiYFNQworQMwkUN",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qyTWQ9v58KMM7ELwIfCk3Jg=="] = "#=qAceO9gi76u9FzY2tV8h_xA==",
                    ["#=qt4Z6KOKCNp_I3nHpvGXeeiu9NOlsQgCfX5meLmVxQ90="] = "#=qF$Csg6ZuUGIRBZtfXghibg79hXKA1anoz4JGHoWmQDY=",
                    ["#=qmgMMHEC7vF$s9Qm5J7emlO9S83kvFzPz3Uq8mSZ3too="] = "#=qP70RY6AGVoGiTdKAliexnjnmeXEXmVyrLf934eGM4_M=",
                    ["#=qb9YPl$DEk8Sv6lgLg7yB8A=="] = "#=q_sPncPZ5_QreetGYACUufw==",
                    ["#=qXB5OLckNOOyDVwjO6XTrjQ=="] = "#=qBqsOo0brD422J29qeOaxPQ==",
                    ["#=qfijSdyxSp5SwYOPdUJXiUQJCEXGlTqjhRigdCx5uqOQ="] = "#=qGtmIlqdNdQ8FALs9jFzWOtbjF3oRqxfLoMHtPHO1rUo="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qMllvOkcGIQq1SKr58I7cQw=="] = "#=qu0J8K5FO3GDiKfY5dSDhHg==",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qCDCYlFDfXIAnRPnsUb1w8g_lBL7Sss5L_d14CnNposw="] = "#=qiPxC9JH3XUE_xEwlYu3RS974I6ExR$MdzEb8r8twOqI=",
                    ["#=qZjv1jZBt7qvwdOI$Y7hAO65ZMY0drVkwt9rNPxDYnHg="] = "#=qQ2_KSwsDtxsRWEDqKlX$2GJr5eZ77V_lkmowP2pz1w0="
                }
            },
            ["#=q_usE$zDQl2kO1WlNM1cRru0HS9Dbu1PAS5gZUIz6UUw="] = new TypeMapping()
            {
                typeName = "#=qYm1rrQZFJYstrbsp_Za4STXKV9TB0zxrSnheqQg_e2k=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qv5VQKwkPjJRFojjL9eCP_w=="] = "#=q9qDbe12M1LiJdJehT9Gq9Q==",
                    ["#=qMZevEvmDNvNZzg7i3athZQ=="] = "#=qNW0mZnO5sfbvEUFSVF$RYw==",
                    ["#=q6FB0xkFdEQwwsNmIm0SEF6k9bH_WlwlgWg5N1QxvCFg="] = "#=q_K7GUBv3VrtIF3I0196BDAybyD56kznT9nvS3a1pZZk=",
                    ["#=q5sVq$mUcmJmMQz6ZmMAKqRNqksmc5lH_ooQYT9XXDbI="] = "#=qVc_meTFkvFrB1U6WIIqaoYiYIJrbLnwwLrxvPey8Vn8=",
                    ["#=qJYk65zaRO$1kCSElh555TnTLRvWG9GomnXNkQZgv05w="] = "#=qMYei9wAWwjRK4de4XKpOO0tcZ1Yajun1IVZ5Lq3IrcI=",
                    ["#=qsrv2AGzsxP2UBWwfEM0j_A=="] = "#=qgkneTtLxvakrKf5OEFJ5BA==",
                    ["#=q$_NHSWn4IRaXSgM4aK7rqw=="] = "#=qv2LXvCXUB4fPP1Ci1xbC6w==",
                    ["#=qLs625FIoby0ulvzpdv1TcA=="] = "#=qPvy8bhZDv0S4QrFirCJ7eA==",
                    ["#=q2Rr6vuCw34_AdnTGqI6xDg=="] = "#=q42PfnzgQHqLcWKsHhYl0Kg==",
                    ["#=qzPlxyeOJc9buUzvbHdwLnw=="] = "#=qU$pkAM8FC2Cq$C7gQwINkg==",
                    ["#=qLyn6cU$beFeTMm4_28oAbQ=="] = "#=qcFZSAv2l4eXEE1O9W3iOqA==",
                    ["#=q4CapAD7Ug0yffRqrMRTYDQ=="] = "#=q53w01MCixQQerPopl7IJvA==",
                    ["#=qB1cFuA8KDTE4gEWV8Si0jQ=="] = "#=qCA8KY0DOoUVBIi8vUknuWA==",
                    ["#=qg_7iy7ucXMZAnTtKSVSquQ=="] = "#=qAjKBMVs4LzsO2WslXvoQoA==",
                    ["#=qU0l_W36qgbt3tq5npWRfBPuPJ68yj2LTtV22AyZgK6c="] = "#=qqoV6CN$8m9Mv7XW6QN1Icj7cx8ET$l2QoaVbo69AZQM="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6Kn6bOooI9sZXCjGb76fhQ=="] = "#=qtb2r9FkQ3khrey1W9PK0gg==",
                    ["#=qnxVXjR8t9igWtdIUHhSb7g=="] = "#=qIBaj4WCNUQz5GE1U$1Mi6A==",
                    ["#=qoqTU$Md0jL3EVN44WEJQ4QoexXl2rsWbD8UQnkkeAH4="] = "#=q62rjT2QGdwauXWdylhtNm8w9zdoqADH6ZBxXLwrpiUk=",
                    ["#=qwcZ8cZ67FI7tcnI72k3MH4I14QwzFhx1pWxLGGXtIng="] = "#=qVmipR0xGpXOPuR7iFhQ9CXn_qvC609C7Opzt1g17tOY=",
                    ["#=qMTQwj_lIhXfnK8OlhIHIxQ=="] = "#=qTRF4sZX13SNyj3rXFRuzwQ==",
                    ["#=q_WDUr4ElEDK6ZVOMZFoo6c7UgYpzI$zHIGSiRM9OF0g="] = "#=qmReUOl4lcDQNRpp1_PzMrXmRjJF0K8G$C4A$EMPpwns=",
                    ["#=qKsOdxkrQrvkBHzWk4uB5UV_Jm6mKKXqm5LpXxfTChcM="] = "#=q8LBd35bRV63kx1slKArgj7lofYJ9nPWaCPglXjg4blE=",
                    ["#=q3wIsdMC8cCAAcTOzPU5xUg=="] = "#=qzT5RNUGcPWlOijjuvlO4dw==",
                    ["#=q_OEUQ20Egtc$HnukLrks9Q=="] = "#=qrJ4Olc7T_yZ3fU4Uh2DHGw==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qA1PTPvsDtQf$5tEHmKkqVA=="] = "#=q5Eo82T4aWyU_J_vUU130Jg==",
                    ["#=qxytsy4vJAnFbomGfihSaMQ=="] = "#=qWqtJs9x3mrtyhzVSLabqow==",
                    ["#=qB26dPFvu2PLhUWEkLPr75Q=="] = "#=qkaIVWLT2bB1iXzK6ptprRg==",
                    ["#=qeo34pauEhA_NlFDjQkiICw=="] = "#=qDeXzxtGozVTVPbIXuizSzA=="
                }
            },
            ["#=q_WGcFqMqYsrvujxMZkgXH_soFtszL461qNwF96uLV4GPPuYaXAbw0vKsMyE6uzVJ"] = new TypeMapping()
            {
                typeName = "#=qJkcHICK1$5r_i1Yr8BLCdenT4tnh3uCnMGHRq$c1P0mRxvUCAXsZPuN6W6DKn1II",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEkG$cbSD0f_w8y_cFuCT$A=="] = "#=q8$Xntx1YkBrxfY5XlT3lng==",
                    ["#=qXEVSWVy8ZnlHJaYbYOrxpw=="] = "#=qboL4S_GKHT3Ah$LpvT92JA==",
                    ["#=qhL$OI6wXVzK5z0UTB3Mdcw=="] = "#=q9SEmqBzAmEdVjwhxjhwdDQ==",
                    ["#=qSnlpxlQxKYBTQ3eQIuo3pA=="] = "#=q7VXXrPXrz_jqFEB2xKljRQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6ILMBj_mlp31wZ4XY$GWPZlRTBZoWRgn_YuHJCqRrp0="] = "#=qXA7ucsT_UlYxlwSftKjamFRU7Uuy9AqnXmtiIejeIN0=",
                    ["#=qoOuDFqUfnbvUpcK_3ppFWQ=="] = "#=qc$mCHpENg4QtLRCZmImOyQ==",
                    ["#=qHlzHXPwW$xnuG_i0xALEOA=="] = "#=q79Vud6aEq652UjvKLDjG1Q==",
                    ["#=qXERR_K15lCdqMNs4XwdvWw=="] = "#=qND_n1b8IfTBqaq8vjW2NOg==",
                    ["#=qV1uHKKGc1hfXIG2BW1PcbR674UvPXZ58xsPTyL5d$10="] = "#=q2HZR8xN1uiQTug6PqDWaW7eq30SA_RRM_l5j9qpfC6k=",
                    ["#=qXzI1DGARWTgeV4lXv35wOA=="] = "#=q4nIm8Fm1$TB2fCoAfARfJQ=="
                }
            },
            ["#=q_ZrJdupqi2q4OVN50Tatxsp2$yGWlkO9ccVogd_BkTA="] = new TypeMapping()
            {
                typeName = "#=qhj5l1J6rg$vuS8A6vJqbBmSYtUkBCfx3oWHS_ExQ9RQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qYxTR56qChicmAzpeuml97g=="] = "#=qja4MvashGQhwi3gZZkEr6w==",
                    ["#=qus4jMVaNh0IEVwBja2eGtw=="] = "#=qgJmcYOEhFt3zCXpRXRQaeQ==",
                    ["#=qatJjNKNMRYdZ_4ju31jxvA=="] = "#=qWi1Maz8aLsYTF7udBxpvag==",
                    ["#=q26wuLMaFgZ0Zhrb3T9NfPw=="] = "#=qv36rLBf_bzuW6MBFEa8mQg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor"
                }
            },
            ["#=q0Jt9QlnDZkp27EiWzQ4EYHMHBO0Fu_mvE6WhgBcGjSA="] = new TypeMapping()
            {
                typeName = "#=qys4AjflD$CiTcfRG1FM3Ik5szD1A04D$dDMw7fEnXuA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkZJPkW4WcXNaeVcQGcA_vA=="] = "#=q4tW6JmaohrdXXZjqSKw7Uw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qqqbd3A7tnwgWx$sp1KJC3g=="] = "#=qyILcvlG2kyorf62xSFJWCw==",
                    ["#=qyc3m37ICNRahg_4DPdFJVQ=="] = "#=qzeuhCx5wgv18NwFKqAehTw==",
                    ["#=qhPfiYrdyCeLKOs4TzAjzjQ=="] = "#=qCEMejE$sW9s9camooJps$A==",
                    ["#=quMeVwbafCnI6R_aH5rfRoA=="] = "#=qc7pHLaGF0cX6FB0YhFaPbw==",
                    ["#=qwvDjYR0ZH7RpO$9xHuRA8XmKhUS$k4fsH1BaQ6NGF9c="] = "#=qa4vwQoMqCOMpL1ui4asXAtAPuBTQjlTHU8k12NWVFpI=",
                    ["#=qWzoGIwk9DLZSuBIRZqDbqZgNQXflAxvL1fauZfgD2wQ="] = "#=qvbrGojyu168mSH4w$VAiXSTlWqU6PsHD$K$CMczzP0M=",
                    ["#=qV0LB5FENBy1$SfWjmPqZuiLiTwrDzNGbIxEjM1uHPLs="] = "#=qXU8ufS88_QEdIsXlwiBab79n0ET7XYPR9vvNhg4oOkQ=",
                    ["#=qIfHISY1KGms5F3OzOsU4IC9ywSinmSVoNUHkWkQkvoc="] = "#=qbnZ17iBqrrHRiVJ2Kbus7$iUYWtyI2wFXBvP6cvbXiU=",
                    ["#=qDVCxvBbzk06g4bKrjJwOrwBN6ymK8K64WQZLP3JrgUc="] = "#=qYOcFAdNYmdpaUPrtMVnrJLJiO_usS3hJwsEGQWpQEcM=",
                    ["#=qk_lLdRVhJDP$y0bPbhJEh4BfRMGutq6dP6VnrUvb0VM="] = "#=qXLfb2zfEKmTcu3REJ84YvZy2SA0dClRVacazTL4NEtk="
                }
            },
            ["#=q0NVRfoyYceCu82Nj5byweaUZ24fmEeLKZE91_aFg6l7xnkMJaqimMTDx_Yi4zruc"] = new TypeMapping()
            {
                typeName = "#=qvYRFl_yh8FvHiv$h3rymwca41Itqbp690xtO2ICIeeBJtLIxaI1yN4EZL7pgIiM_",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qDt3qIrkPzjpUNXKYtszIhQ=="] = "#=qCBRzNbCdgwLJ2keDCpFLOA==",
                    ["#=qkZRyTALb4GVbbQJYimOebA=="] = "#=q$6EeTzcu2sq54BxF36WTOw==",
                    ["#=qPHWs7HEvosey6nkqsxs2Tg=="] = "#=qCsMEl9MDzVaisTZ1qDAlxQ=="
                }
            },
            ["#=q0Va0gjgnphj23L5evNAj1sbNuWC8I4bqrCh6isbslE9FeQAiwU9QdmZbsNO06VmJv3$eKsoXd_4m5u8$g4T1EHkr5TOtwewo$JBp90Amm6w="] = new TypeMapping()
            {
                typeName = "#=q$ux6DH_Geul3_8w4qcw65h_5xoA$oI1ChEkM9NlJp2Nu_RQwJSVpRh$aLJFOnk_uLx91Yw$sDQNOBu2cqMhgER$ehywK2r58KskRpPgaoxQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qA2mIsuYUeV0Q1m0CMc_0h3CwAZlyA3MWSoe_UVHn9$s="] = "#=q2dv7WmLjrXuvQ4rSDAwRoPZ4Tz4uiMaPd2CpVtgsaUA=",
                    ["#=qDyDj9LNxg5V$VcCuhY7zhNq4ilZxq4xvIAUGz4EssRY="] = "#=qt2LenG4$xvMVLII7QF_TrLF8j4WlFZM3p$6fcwTCGnM=",
                    ["#=qBgfjObqNCksrsZw2FR_PmSJDTNlqwm6ZpNpLSAfcqDo="] = "#=qzQK6Y9jSK8GOYyqVGqa$GHLjrfxEDu4t8U5AWO5C6WY=",
                    ["#=qs9_iXAHqmQjPiPZ$1SbZIskIn5_8vhJRK0oflQxf7io="] = "#=q3RvpEUJgY2zyL1HZ3osaUBDN5aesMFv_x_jc3gpuXqk=",
                    ["#=qL9ANqZnTHDVGLphDhEap7Fw6Z5qac4usvtkJ3CXp1Sw="] = "#=qAqoO8H0IP78Xqk4YHkXApsb7ps7BNbBBTFX47tpIERI=",
                    ["#=qfSCwOKke3jQf$w35XK2nUt_5Zccf2y8SS09sk8FXEBA="] = "#=qXuqiCJSC6p3s5R4Vb0aLuvu2ggSaPu5yLK7YV3F7lXE=",
                    ["#=qbBO7v0u2EBuK3qBueGnvz1EApVaNYDYwwI1ZxhEFAoI="] = "#=qVFWdKFHxoBhzR4JNBSZBhTY81mprHzIkUsBOOIpkG5c=",
                    ["#=qvFa$wXJdtGX9h_kqsw5_5TyYcW3DfohReOJpr4MX0io="] = "#=qEQOFMiBHQ8WaaRJokuSNEo9z6bukKOPxY1gMElmW4Wo=",
                    ["#=qOTQeuVkByFoicrWWMj0Vif0QzULFZ2vQEvk6H7s_RgY="] = "#=qkv3_jxbPgKUolFqoQXvFskvmOeEn0B6tW2LdsQS4LvU=",
                    ["#=qr6a8fFB3nDg5_aMBRh_3Ix$YZ3KzCBmkOVVREFK5szc="] = "#=qlzAh6uHWKHYZQ1FOMadgSfYr6WiF1iFddhP6nYt1QCE=",
                    ["#=qeX7yDGZzNkK3aBBYDC29ePqrS$ZPATAJ0jb7xqxUKq0="] = "#=qI9iqHPhmdfMbDGbPOpXcGCk0MaY9V5oAGebL9ylTK9o=",
                    ["#=qgSOFu8Ca_PWTCf7oItdL3EVikRMDwl8EMSwLecx_T88="] = "#=qiI2giOr$ZJLQD_N4kE$wxWrUYHpStaecUpr5yIhgZXM=",
                    ["#=qfTlwbVcB$wHjjpKKbCGz2UNKE2TT5alxOTQ$xtfAK_Y="] = "#=q9bbHbl6Izck1nG1cbeRpq1GQx$GgFRF6HxUkNIoTab8=",
                    ["#=qGfUAUjOgpyAU9p5PmYBnVAu0We6in0eiQ9wCSAe7d6M="] = "#=q3EOi4AHDB_3_7SRetBEvt0b7habhhvVPnIZsIbPi23U=",
                    ["#=qKqFLP_PbWh0RtOUM3A8M6TewENMFcMRdVtSjSGorfGU="] = "#=qs5g9etOrMkGViXylYOW4OKY86FhtGWmAXQ5D5i99pXo=",
                    ["#=qnF5RGrAccospCdyuhbjr3MuzYKcQQMAMTTpewug2SHg="] = "#=qM1lVaO3fCTO0n_qWWYbJQNw8upc2sE5u4SkjY5O3y_k=",
                    ["#=qVhu0PwpzlfBGRiArrS_ypjfEmVNowSTxhstNJyLMogY="] = "#=qTfcrHZJW7NZsiOWsQnEIFitMzAk3CV3AbRWmpOqhnDc=",
                    ["#=q1MMoKW1j9U6uTXypZYD2IRiz7kAGAg7xvYrQNO1OwDE="] = "#=qCa69$TdwC8ed5qlTdb4Z9GBN7yrYzXWacnNgkaBj$sM=",
                    ["#=qiUs8f8eTqGyeUcU9HJ_dEQAQpRuWFRXHXrx00Fcc7QY="] = "#=qUvhRe$3mYmOaRLmEP4WjucjGUvQDpfkszZmf$bMN0DU=",
                    ["#=qINfork$vwDC88Pm3Zs6M1uZnv_38Vaa7U1_5Zp0DubI="] = "#=qwuVJ8xjYgDMojNVX4QRlub4SapMw5kj0SjCPJiN0wto=",
                    ["#=qKmC3OOW4reQGLPUq$4WrTafcV0ppqWt1WDhzyF_xoWo="] = "#=qaaR0NOOmlm4uwhdIbI71W_VG1xmqrNjG58Gserroeuw=",
                    ["#=qmTNqPVJHPadKayqlc$ynW_LSLP0Bhodmd6kpXF95lgA="] = "#=qwGUkhG9iMK7e2iIyQqMiaTCVaMvyqGRbwGG4QskjEFM=",
                    ["#=qyZX_YD6HEKTG1Z6VirLIaODUhI6X9mORJ1C49Sd9enQ="] = "#=qep0pTSjCE$s0wmXh$c01KiONbOeMN8xyNfmIWHhn3UE=",
                    ["#=q800Gpm21hSPI9$eM9pySrfQLHLqsTCDdd07lVc7xcdc="] = "#=qY9gDKhaBg04TIxIKbirfihb1ci_$aLCjVU2tsuC4nrY=",
                    ["#=q8kIQhnEqKc0kai1uew2aDfcF$Mf78KKJPKQZE3DBMZ4="] = "#=qQ6XzhsDphHFiIhHBNa5XnmmTp9yFJzIxIj1rF5nQNgw=",
                    ["#=q1$Qq2YT07nes7ihTtZ$jCbhsODYh_KXb2lavBTBK3mM="] = "#=qFpSbUS5nRiVwq5rr2QcO9Dk_hKqTcxDtSJsTgc2uEXE=",
                    ["#=qxJ04HL4J$YfSfLKLly5HGcrlqviTYKQeR726KtjafmY="] = "#=qhMvBT9PbeYLqHdW_Rj76x8hS40OXJ_lKYl_uCqOdknY="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=q0xNJZZ4NR4YKn8g_34lx9uBcvBty8FcE68QVMgSu1rU="] = new TypeMapping()
            {
                typeName = "#=qaaWUIndjc1sBEQCkFr3IH_ZYAv_6W4BIFwnZh4Kc7Qw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgs5TLssuQ1sLkl6rawd7RQ=="] = "#=qvVqkrnITTDLTh$nf7rIbKw==",
                    ["#=qexikswxXAVAdcLaUqa1zHw=="] = "#=qkzriDqDqKkLXuG7wFJELxg==",
                    ["#=qN7vFWSGhmUy3za8iKEhw9g=="] = "#=qPy45sty8jrHJ4aYn$mlE7A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qcWes4icNmYOuqrR6W0MU8w=="] = "#=qcWes4icNmYOuqrR6W0MU8w==",
                    ["#=qh_hLEg0AplIj3mkwDvegcw=="] = "#=qyYyVJYUqlv2iwJUwDkFtrg==",
                    ["#=qHjk$Z$TGR3HVfynfZs0AMg=="] = "#=qUwf95CXJraowMFi2XCuHoA==",
                    ["#=qg5Y4Kl1EaORN1hXMFpYDJQ=="] = "#=qlBeB8eOwlC9SrRMHerzPHw==",
                    ["#=qyiyB3SxLqHkGimP0P1pFhA=="] = "#=qmt1Dw8UY7IqzklXigj05ew==",
                    ["#=qm0fReaVzQUZBZw5S78Gdkw=="] = "#=qp1$Fn5c94uAKmtzI2hIIZw==",
                    ["#=qSPYnqGIm_yT4SeCqrmANqg=="] = "#=qFRq0aOm0tBz9d7v9Vm5ujA=="
                }
            },
            ["#=q1$kOO0muxS4_JlBlK4tR2b2kS1N2p5UP3h3gkU3RydM="] = new TypeMapping()
            {
                typeName = "#=qYb4zj3hotrK2OrUNSFG_f4eMI6QdACLmq89nNltJr$0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q5Sqc71u6or8Yrma8lxa59A=="] = "#=qKO9Dk2BgTLN8yqAYPW2Fmw==",
                    ["#=q_mNdKaKfOKXMYa4Xf52tKg=="] = "#=qNizkO6dpOLiYo2dEbxY2UA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qiyK2JdzhPgc1njqcjMYDXA=="] = "#=qr4G7z_F6RWHHItbYb4uXYA==",
                    ["#=qovk6_7JKns4Wd9GmeWmGzg=="] = "#=qIgIeqxezYcUgTGXEGknIAQ==",
                    ["#=qsckbYXprnBPuU$Ejx06WRg=="] = "#=qb8bbWePdZ4bdbsCV3pWg_Q==",
                    ["#=qtTq3lOKdhKBSI0NaV8huVQ=="] = "#=qyORxBO$mphmdUZOIhCpdTQ==",
                    ["#=qhRyGAtH1kTumQykSf0JYwg=="] = "#=qoM5Kw2a5AdZIHsawBwa54A==",
                    ["#=qd_0BHVcJN3S5prrM_wz8Tw=="] = "#=qc8H5Sjw7ILkuLuDUHkwO7g==",
                    ["#=qWEd5Unke67_7ABqyiGRqTw=="] = "#=qI1yiNf7DzEnRx3esjAVrjA==",
                    ["#=qPSoY6BpZUfVvXZk1pRufLA=="] = "#=qFpy75FOQurZ6obFZYU54mg==",
                    ["#=q5Qitjp$4WDeEqW8VoOQLSA=="] = "#=qpYRntfG5UeXm8mzfHNqhNg==",
                    ["#=qFO48EGjPXF28q29beMzKSA=="] = "#=qA0N1V4wpjFjqwWNy6j8ypQ==",
                    ["#=qOX8cVDEABjOi8TSSKD90FA=="] = "#=q8Y9ekYzUs3pywlck_TgPeQ==",
                    ["#=qd1N2S00084SgVKvVM2L4XQ=="] = "#=qsBemO_KSsO0kLupxqlOStg==",
                    ["#=q8GHtx47qEQzMtBk$6obO$w=="] = "#=qT3sm6QqKOFAo8y00IDq3Kw=="
                }
            },
            ["#=q11uh633qTsfUopZj$O9sU2dne99Cvurge$_r5JUhoVdc9wI97SE67iiTyzOh_QnCiRugSbnBZDCIhrKlsWsdgg=="] = new TypeMapping()
            {
                typeName = "#=qkBBIX2wQxPJH$IxIDEN6K8PPdVOjq6rcFZXC0DO9JAvu6sNYagLf4KiWQZ8nuCGWAI6EgKZbD4qZZXtFank0Zg==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qMtdRBgMSaqfYNIho4d_6_CEedy5BwWXkT0x9TR4qss8="] = "#=qb30ltlRIyMUhhyhBdA7bflqdwCOIgcEq23ug9LX0TL0="
                }
            },
            ["#=q12xoESoiEj_qzyG4M7lgg_zjRGXfI9q1ic_ePtQQZVU="] = new TypeMapping()
            {
                typeName = "#=qkkgaPAfgAwpCxHvkfIfGzLgkVi2KNg01x9F1kNpA2PQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q3QfZ7gXT5sh33LlpQEfgo2JsiajzXYARZ6v68esowGw="] = "#=qrBOa89qELB4TVU0Vc46U$tiXZKpQ9_zDSb2lf3m6qVs=",
                    ["#=qUlRcP6f8V7wFjrjryxzs5A=="] = "#=qkpfkVnki_YTiMLM0KgoVgw==",
                    ["#=qSlhQ$wdEy$PmcvaOMn7QA$seXXSJPFMKtDYwpnsLLSM="] = "#=qTxF5bJxWE6JcFiTY9239J67MeKVwbprymEuwFSfJVF8="
                }
            },
            ["#=q131LWDPqUzsCWnAoOMhio3Ihoy4Um6L3_Y$c$POxX94="] = new TypeMapping()
            {
                typeName = "#=qT96wL9wWBJso6Nux89ItSyjfIGUb6dMBq5b1AzjgZd8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRhAc8HQ3FfDBf7uUgd7diw=="] = "#=qWUDNXyIWMKcWZyfYTjHXcQ==",
                    ["#=q5XLX6Hc2VxQdGcwvjaUFOg=="] = "#=qyEZYjoUIhC9kLcJb2JVgSw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q13oBCFY5kC_QE6df_h8hSjy80sYwYD64BdZb$4i_IDyx2mKeVaM2NvZSknuQIPjA"] = new TypeMapping()
            {
                typeName = "#=qqWiwAaHN37GLy_zuRejZ51Mw17WMpaWkzILm7O$hH7ZCHeozm9GlTsnt88cf8c0m",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qOD0TGCX$AUkBZ1ghIMyZfg=="] = "#=qPhXFjCEOWZ26GLbh6cU62g==",
                    ["#=qjCnLExFlnW0_5xAbm9GWAw=="] = "#=qjCnLExFlnW0_5xAbm9GWAw==",
                    ["#=qL6tJ2SOfu4VVBGzwRu2$XA=="] = "#=qgM2hG6Gc3eEFzrqy8gAnEQ==",
                    ["#=q3sXvUKnBznhAPLa9wVMMEQ=="] = "#=q2YqxVE2L2hF52JaT4e8xnA==",
                    ["#=ql7oPMKqLa6vB183rPhamfA=="] = "#=qHF6aD8Ucu2xJ2pG4ggysPA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qOQ$kikdZD7GkviVblI37_A=="] = "#=qG$FKaRUh_QBzNxbYAVhi$A==",
                    ["#=qHjeJ7qjX_koyzO9dLcNhlw=="] = "#=qVekiTAFAOdIS0R22evhzMQ==",
                    ["#=qCcC2k$o6Cd4UYNo8p5Sw7w=="] = "#=qyTVC$R$CybDTkwt99s$BDw==",
                    ["#=qCoHMu1Jr087R3LAlUT5XiA=="] = "#=qpHiFn9kJVSk_7heypdHcmA=="
                }
            },
            ["#=q17$WsCddnO6S$DFo4bgWNYMaB_Sp8kBuDjCXKGY39yg="] = new TypeMapping()
            {
                typeName = "#=qDI_fkfGT7ILaJon9gWJzRaYWlbTrInyPas630QqYqsQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkAFod_acKEv3tPydelWv5Q=="] = "#=q5TVSLZ6$mSfpTEPjKfvvbA==",
                    ["#=qD$ZGfyD$aBl0VfPOKzXu1A=="] = "#=qUczHXFq1OcxS7yFHxbZsdw==",
                    ["#=q5JNFQEJtxghZPvZVcush6g=="] = "#=qj1kZ82aZZfXIHMPkFdRwOQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qQ0yLatQEvFFgIJ7x9E$IIg=="] = "#=qmpwq763TJ1qXu5xbOclGig==",
                    ["#=qEz9vAuUceuvZKRnZtve54Q=="] = "#=qi$W_mL$NKOkG4KT$gDjvPA==",
                    ["#=qqQ384JdsORIc9dHiDXR8$A=="] = "#=qMwSiX4GGeRLlmJEl$kgcWA==",
                    ["#=q8BJkYYg0ev$lEZcj1jMSpA=="] = "#=qPDLx_GY_m5lUym$amqNWDw==",
                    ["#=qsZGxxjmttv6uyv8vwTTftA=="] = "#=qfx2lEJ2VfTGuRyodNFZEKg==",
                    ["#=qNoON$eETQrQ00PSK6JCAMQ=="] = "#=qs1fwAD94_U9SVDPYT89SUw=="
                }
            },
            ["#=q1HWp3v5dD6BoibI0X_gzv2JxaCIIn4yXecNE7tyq8N8="] = new TypeMapping()
            {
                typeName = "#=qONQ_dXYqmUz8SracyVaxsYy$3n_KjeQpzaRaKV17gV8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q3QfZ7gXT5sh33LlpQEfgo2JsiajzXYARZ6v68esowGw="] = "#=qrBOa89qELB4TVU0Vc46U$tiXZKpQ9_zDSb2lf3m6qVs=",
                    ["#=qUlRcP6f8V7wFjrjryxzs5A=="] = "#=qkpfkVnki_YTiMLM0KgoVgw==",
                    ["#=qSlhQ$wdEy$PmcvaOMn7QA$seXXSJPFMKtDYwpnsLLSM="] = "#=qTxF5bJxWE6JcFiTY9239J67MeKVwbprymEuwFSfJVF8="
                }
            },
            ["#=q1OvqTL6pFEEBOPpB9Qa01Ver5UhlhcJn9sLpnNQ9PcU="] = new TypeMapping()
            {
                typeName = "#=qcSfgNuWnll7YlHJSZpjS50B7LVNrdtNYV9H$qyr2_oA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmQnWYgI6cOY6APPG2seiAA7qvroH8VpePTOTqoT_aiw="] = "#=qIB65V0JhvxtxlbzLDZacBiYqM9xs$CJjlPFbOaY92lk=",
                    ["#=qg4U7O3cmyhygS$m412stAw=="] = "#=q2Q6KzmO9zSJ3DAf65YAVag==",
                    ["#=qQTxu54cWZmgB2LjMshn_yQ=="] = "#=q$z9cqLbIQNA6j8zku4_eUQ==",
                    ["#=qXuy7RAHCp9ImTQfGkE78tJHB$7c7mdVFA2tSvFn5s1s="] = "#=q4oUxFyIxkJRIvdFl$7X8ZoYKmfb5BEUsX0XOH62_75g=",
                    ["#=q6AWU6tcYrIJwi7Tzt9RpC5Fysg1K1IVS7t4hiThCQwk="] = "#=q3mSuMFY8CFgMqYr$HsS7AQhUUKPjVYAqBousEYIrddQ=",
                    ["#=qNWX3NI102mYjuhPWPnRZpA=="] = "#=qNBn09PKHvC89y2$q_nfWNA==",
                    ["#=qE$s4_9qxaNyHJMlVK22Jsg=="] = "#=qhffvc$TwYcRnK7joBLGZsA==",
                    ["#=qD9WH9mgXPR8ayRg3yYz2gw=="] = "#=qBjAZj2wiA7h1Va89UOuATA==",
                    ["#=qJK61Zz1DllDPHTtbAumHRA=="] = "#=q7rJKLySOT3uEG6D5lbe6MQ==",
                    ["#=qJL7v$ikZJbNXZGWbZNZD4iJiuHVprCWSjh1jqMczRgk="] = "#=qgqm2FV2yO97qkhr1T29BwlIM7UkUVRKLp060rG9_qVA=",
                    ["#=qf_eZlY8YOllcvE8VMJDXIw=="] = "#=q3nblZnRnjeQmuvKMFeWssQ==",
                    ["#=qzYI2b7tVy_BvAUnqtotUDw=="] = "#=qDOrc5aWh9egi0WdnxTM81Q==",
                    ["#=qwxWz_19GaYn9KFGNYf_3DQ=="] = "#=qTUQRtHhIWP$hGh0AIqMsdg==",
                    ["#=q2hCqebANwIXwI7OYKihLiNWXmtL5sNSMe_KpB7y88ck="] = "#=qZ6jmN4eWYXTJ3op97HaqO12sGWUyMiCv$0Pd8qk9IxQ=",
                    ["#=qqTRcIJivaGaQwQKgmnOhNQ=="] = "#=qWxXam2BHXgGaPR10mEifpw==",
                    ["#=qmJyYMTQ1xmo$vjr9CqbuRw=="] = "#=qJjAs1EgVTaSr7ZwkDtHcfw==",
                    ["#=qHaf6Ttpg2ZJn$CUYE9HRd1y5ZsCHxw5d4cDKwffJVCc="] = "#=qeu8gI8egVqB_$0KRuIg7RkYNJLE4_SVYRpDWJuW8Tkw=",
                    ["#=qjECEMtUahXSpBx3R62ytZQ=="] = "#=q$4$cedL2TG5l7QpEBg76$g==",
                    ["#=qU4Vt_GlZ8hLE6bX1jLnhIQ=="] = "#=qUsKMhr2BFOst9IDpEOqw3w==",
                    ["#=qxLNP0dLAfDe3INeLzt13yQfDbzCCxnh$uc4FJMbT5rU="] = "#=qG_e6xmv_fqI4gIiUKnsPGlsqKQvNSDqQ48uLpXNyTtU=",
                    ["#=qWiUFRoA3Yv2Z8QTMx$ySHg=="] = "#=qDzMpiZZx5$FFKCbqTfs3Dw==",
                    ["#=qM$tuPWoyK_cj2gKLsTBWgjAuXnXYeN87cgRYCHpDwbQ="] = "#=q0u05ktWBlmR_XdVpjbyDa$C2atS1nffWLSNnNHHYqPk="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qbcpiONqJvkLKux2EFNig_g=="] = "#=qcUVqSF9usBwFpjlW5VURsg==",
                    ["#=qLrkGftwr4BRlL0KZ48MyJg=="] = "#=qdfpIUjcwycJeS_Z9_8FN6A==",
                    ["#=qFZTB8pFeXOh0EoAGMgV0iQ=="] = "#=q5qtEzzx_TiuzxVFSXBqFFA==",
                    ["#=qsZVWz18fKjtkAHy7bVhHRQ=="] = "#=qhippzhBjjn9WjeBCyX$aYg==",
                    ["#=qUX9MmldPlN5D8mPpURKPmg=="] = "#=q0qs_Lz8F0pBV4OkJaRJTUw==",
                    ["#=qiGp63jVbT7CFszTZ8qIUjw=="] = "#=qdIohKvV7yuHZnpNQU3gf5w==",
                    ["#=q$EHsmgYAIGr6pBsRWDawYjix1cib07KypbF1B7ZC8KU="] = "#=qHaD2e75L6GTxsTuM2E3FtbDkCPO2gHGlH$M$1L_$hP4=",
                    ["#=qBG4D4CxgbPNNrEOs945FUQ=="] = "#=qyWj$_DCsKYglT$F_M5RWIw==",
                    ["#=qBffKop$4ZVYS0TkhXAzEoQ=="] = "#=qhJkIwASou7uE6Bq$HVKOIQ==",
                    ["#=qQVqUgmtCmn35dO$oajECvQ=="] = "#=qA0GQadznzd0cNQCo2$527A==",
                    ["#=q3vzh0xvE52XhSrCMXmJFqg=="] = "#=qLZ4oyYshvBqEI$99$3SsEQ==",
                    ["#=qAAeQYNaosJmR1tTdaIXRQg=="] = "#=q_OOHwiCrNOVDcz1zTpdFFg=="
                }
            },
            ["#=q1sCpxgeqUYF$oPZHVPo8TNqfAKSlblq_NTIwTCena5A="] = new TypeMapping()
            {
                typeName = "#=qLqj_Zn$CEDeCS$aRnAn2EbmDqIuxRYrpCofo6rgYCn4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q1vI3mMcWvvIFqz$oyDDsIA=="] = new TypeMapping()
            {
                typeName = "#=qxAcvz_BCrP3JTbWlp02p2A==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q5IyJHarDDd4RPIOrhGj7Zw=="] = "#=qPguG58w_oHPAddobKsJPxA==",
                    ["#=qSUYtyKNxmAe7GXr7fjGgMA=="] = "#=qyUoSuwgrrIogwHx$Sg8GbA==",
                    ["#=q98JNvnTOG7Iw$N3ZftqWXw=="] = "#=qTXo7df_GeKDg3l100y34PQ==",
                    ["#=qWSgFs6XwhqNtCLacmj2XGA=="] = "#=q$_laOFPXJpYvKLpogUJmTw==",
                    ["#=qubgEvTMvJrNCjSmfiAu8Hw=="] = "#=quuyWhWKNvG4eQnZox5YDzQ==",
                    ["#=q5qy_tu4QBr9bC3KoreD3OQ=="] = "#=qz9e8Jq$Mk1RA8dxqebkvhg==",
                    ["#=qFfISQCY1VtkkI2ClnkvtXQ=="] = "#=qjaqE3LdOpykTGPjORZKCaw==",
                    ["#=qcVffp43xlvckx_eQjLjqxA=="] = "#=qWsIb2zbb5lVxE24k115mNg==",
                    ["#=qIXbJwgRgDGE22dQ_aekM$w=="] = "#=qn6Woep6EtNpT6mLNh5OQ7w==",
                    ["#=qEyo4laQnh4I86a4Y5nXvKw=="] = "#=qnoymy3nesieYkkNACQ3ORQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=q4lNuizBtSKCkY2vxyTu7AQ=="] = "#=qIyEdz6pk3Xu$3c43Nxl_fQ=="
                }
            },
            ["#=q1WFHJ62Zf7dvUUiXxLfRYJWKHmjiI5l_Wpq2mCRX0ceY_ZfKae0aA65yj5b_bPah"] = new TypeMapping()
            {
                typeName = "#=qYza932nTwfHFDMkY42yvoYf0wJINHhwhVEa5EigPT0zuo97xA17OFens62X1pGPo",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qcRsmnmOK0DMYBYrEIdGzTA=="] = "#=qybRdZ_rrNbA7O0$6IAyx$w==",
                    ["#=q4LD1G9QoghSbppEcFXUbkA=="] = "#=qTBUQm5_DIczV22Hz_iJcBA==",
                    ["#=qMhJ6zj3CcCAJRkMiPBnUtA=="] = "#=qlOmf53gAxAoeuEFra6pU8w==",
                    ["#=qCw5HPacG9PPGN8P_QgmXgO1Spvjx0FqNIJPIXsJ3aGg="] = "#=qa6KsbJbyfxoVucQU1R0_EjC_jSXDT2Vkmxy$idzq0AU=",
                    ["#=qy4ZDqdMPrkNzqSzBcwIMcUSv2ZgL$wN1lp_n13p32J8="] = "#=qYtTiA8$NH_3hefKcJw5lJkSgKoqdsjhJxb$oF4a0Elw=",
                    ["#=qf_kPmy4jlK5A9YY7vPlDwa0pnGrwI1v1E2emTWAbrNA="] = "#=qAmD7GXZcPHemBCu_4w8KrjChtTNMdc_HiEKbGJuygaU=",
                    ["#=qe4MeNjVX8LRmbY8LdpiKGQ=="] = "#=qJUjcfWLYY2m35xUJQZjnuw==",
                    ["#=q83Y1Z7cHJz2LnoZLrJ9VaBWw9ahpAGSwNlevMmT_hY4="] = "#=qDhrTGcqCEPGMXLj7H3yyX0OCB_Q135RWpdhJdt70Mdo=",
                    ["#=qkgmeoChP3oU53KKP91BzDQ=="] = "#=qBG5V7_dGFonEUG5B7hujWg==",
                    ["#=qUls4qzsAqToI6E9rP4hgGQ=="] = "#=q4RrkzqrU1JCeqLlDke5m6Q==",
                    ["#=qm$CkhIIbsCN996BcOKSjmg=="] = "#=qJgls2GtXC$Km6IBbjhO3qg==",
                    ["#=q0Njz89KGh0QN7YRPVJQStg=="] = "#=qS3GGrD1PxDm09JYtZxPoqA==",
                    ["#=qwRCcbZ_uxECDr1gUpvmWuw=="] = "#=qkOcEzMEaLL0IA$T_WY9aUg==",
                    ["#=qqVub9LcAHouuQjqB1$78oQ=="] = "#=qGBXXXn6piAfACpDLPsBTmA==",
                    ["#=qN3qVTEpvYEhVuAxEnjuNZQ=="] = "#=qlz7Ug4$HL4jcIBO3KvPuuA==",
                    ["#=qYL9cgAVbny3u$T_TwT8TJQ=="] = "#=qFZQvmhoTaOpsSOWD4gl$6g==",
                    ["#=qY8fZr9Hmp4_MNxVWbequCQ=="] = "#=qyJkp5b6b4EkCWVZKG8fHeA==",
                    ["#=q3Q$6ENU3p5tdweRXlxsJvA=="] = "#=qTaS9PHdFIxNQk4cyI1nbag==",
                    ["#=q0Y27eAIaFa7z8VnTeMVz3Xgip_eIDO5p1EBhmerQnYY="] = "#=qcjjl2RYJBpe758Tz7$HO1yX97bjrDeOlfC62yggQbRk=",
                    ["#=qicu6FRo7HD$6UrX1cjSsYA=="] = "#=qvFWpZLwT4RX4QXx7DU$qdg==",
                    ["#=qNV6PqLhHlM62LaOdBq1HcA=="] = "#=qn6jROF3MORtGg0JCxPV5LA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qDT7aIM1b3$iKkbsit_T8pw=="] = "#=q4h5k5saHsoNDQEQ0WGWJ4g==",
                    ["#=qBO$nOp7_sWyNclXNHIzxPQ=="] = "#=qe4HjaFHqt9Js2TwLm8fSiQ==",
                    ["#=qKpPmt2R$rW50aKIO4JPYdg=="] = "#=qsqFrvvuSaKHCL2maP3ffGQ==",
                    ["#=qJe9dp97TzlKuEn4irU1pLg=="] = "#=qXjumoHcmzNe0dRZevcoYLQ==",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qB1jyBEYGDdpn18zMbxa2Bg=="] = "#=qeRUu8CYHFrVXBmtiL8knFQ==",
                    ["#=qLRNI7kIue8ZCO2VY9sBMKQ=="] = "#=qSj82PhhRzY98M0Jt6x8ODw==",
                    ["#=q9GPGs3o$Qu4X_WPcgVkfnA=="] = "#=qJEop9RJ_rJedqxtpHQBCHg==",
                    ["#=qf5CjhwLAMANylAB3VbtqHw=="] = "#=qUgjNlZ8SZjgZgQ1Knb09IQ==",
                    ["#=qclpDnFqEpGBx0h1ozj_BnQ=="] = "#=qlJz6Lyz0RTAHQLT7k0zGcg==",
                    ["#=q5fcm61k7LrdfiMQp06xlFA=="] = "#=qSkkafNkc3RIu59uXkqXI8g==",
                    ["#=q8ZLm3d5qWeWU4087jwfn2Q=="] = "#=qCPgAi2LtTnaYZBR2L6TwZw==",
                    ["#=qXiZW$pkcnQbdUPsXv4zx6sHIEomPnKhIpUhdgJVOElw="] = "#=qjMmMW6HpezjJLk8IxZxWTL9NmSu2tiYkhiyvo4c6EHE=",
                    ["#=qaKUzHCXvTmzanteYPqR0qQ=="] = "#=qdkfsmovLPG4xJCLu3vfRgQ==",
                    ["#=q$lOkSb74Vow4lGlK7tBotQ=="] = "#=qzHOaTIDcr3b_U1nS1LpmZQ==",
                    ["#=qYeskWi6UjPfguYs4NwV_lw=="] = "#=qjTtsRIq1I$B5ayoINmXZew==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qIlgz4OgKBCWcgCpEBkVQMWtCsi6i21FjyDgaxmG2qg8="] = "#=qmCB0kNO6w0ZlPj8nG5sDHJa5Dz4g3i_GhCL8RXToF3c=",
                    ["#=qJde1ptKqXqEMMbxpQ10u3FNuiEpTcKAMqQzfvBXFrjk="] = "#=qxtS_gLHyljmTDsKg8pKDLztc2pcVl2VTSduUbGC$uHo=",
                    ["#=qMflyJQoUsZBLJSTPpJmHCQ=="] = "#=qsx2KipH4Ztc2PuzTnaOCnQ==",
                    ["#=qSKNJEvkaPHNRJAsfx7cOhw=="] = "#=qOJv3pDJiQI3eMqmjn51XpQ==",
                    ["#=qeD7s5JcIjrFTuVbaDetzAA=="] = "#=qT__lw72kthlZs8itQt5ntQ==",
                    ["#=qOJXKPjRI83Ny9XZAbkijkA=="] = "#=q3aUoG5yt1YbFJFEHB2wZ8A==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qLLScOj$obrn66cR6Q4aTug=="] = "#=q4HRMCImnVV41VDcDBLSAIw==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw==",
                    ["#=qLXjLES2MIzK_$J1e4Xxg4A=="] = "#=qtVPHXRI8u_IzKmyp2_mY6w==",
                    ["CompareTo"] = "CompareTo"
                }
            },
            ["#=q1WhqvWX3WLECk8XL4IasAkP9wPLDIhMKKusc9Mn9HxA="] = new TypeMapping()
            {
                typeName = "#=qUzTUmTYCsu0yi0asyZZDrwdML$chEGjMmB8pPstmhYQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qbq3OHiMtort7qMXLC8a_Iw=="] = "#=qZLoSTB3BYyhRJkTgIw_H3g==",
                    ["#=qoJ4p3O9oWYEYvPlEQO3cAw=="] = "#=qK1eomV2ZLPzwCcAoyeH9sQ==",
                    ["#=q0uyWdYD9FP5ycZiluvb4eNRlmTjhX_qh3VtykQ8xTNg="] = "#=qaxt0PoIJxaVj8tABwQSouoOYdPIRZFGG_Gu$D094X3c=",
                    ["#=qKdWhbwq1PdCo1N1n08iBHmD26WR36KCY0ElWjBl7TW4="] = "#=q2ovMWftbJCyydduq2$3najxpTOv1Fj3WE1wECA6cca0="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qCf4ThiK3GttoEbAx2I7ixA=="] = "#=qdhkI2$koDO8YA9A5JsZePw=="
                }
            },
            ["#=q1wmNOxJ$BGpORqRUsIt0eA=="] = new TypeMapping()
            {
                typeName = "#=qknnftVM6rHbzwL4K$FpcJA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFf788Qx1H5j_$sHd$RxaqA=="] = "#=qQpKq7jgcAoJ5BnSfOb7m4g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qfamLzQ5bKBvueUlpoOPk_A=="] = "#=qcl9DgWtaNKOwXzWHGidS7w==",
                    ["#=qlc4K86GMPBX4Zr_XUatAjw=="] = "#=qMRY4iMY91JSxCL29LwTKEQ==",
                    ["#=qAEFclPoAVycVXJEWfNUdCR2Np9rWJX2V7c6RsRbGjOc="] = "#=qATBOgQwOIJLkPvkHm62LrsGu_5ItuA3Rzvvd75kpK9o="
                }
            },
            ["#=q1Yd$zw16LhFjb5EndRY745MCOaUoYKY5988yhja6xS9Ki9QLxR3WTtxaRWyM5nM3"] = new TypeMapping()
            {
                typeName = "#=qt7Ft_7YxqVYKlLgBzhDMtGkNE7hl_45tpxdHt_QaCzLBB2WaKPj_EpDAQQCJj8tZ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qaxgmMLWSl0nUtSlaTU7juld8nFkQRDC6Zd$giayQAdk="] = "#=qBmHqaM$8h4AR2dy6MiFbUpIE7I467iwKhWWUyhS8zHM=",
                    ["#=qwQK94m553C0kCPS2wibTLO_cY7jM95uci5EZfh7Em$Q="] = "#=qRhy2$QicN6UiNF3aDsMlSRG2aa9FHuxN63jVAT2hclI=",
                    ["#=qM9NUGl_rBHpmTo4Ic_SvLdwVPbMYpfn3Rd7v7cVofqc="] = "#=q8sRnqSetw$qLD_2$JUwRvLdIhVuHrcskaRt49FTnHz8=",
                    ["#=qbDSsJDJqi$CA9CZFBlKQDqt1Utp$M3VCh5up1yBqVCw="] = "#=qFssxstX2dNOdDjwwyu_bjtgelWhUoZlx11jHXJLCYiE=",
                    ["#=q8cRg79m0Uo_SWvUwyYaKM_lz0S$LSwT5u3fjk4bG8U4="] = "#=qkuihdLKH36HecW_6_oG$24mO6st4fCRLHcukw4r7zEE=",
                    ["#=qdSwoniNUspHCTgcKrOHR$hRWkMDNRkjei9n6aVD9ce6r$JULPoKjdE8bUygZUWGz"] = "#=qhTqBvopw_6RxU__BVi47xn62HxHJ6lQqU6rmgTU$EoL6r7AuacXx5IEpI4GQL_Rn",
                    ["#=qhJnqdeFq9V1xhn9XivHrXmFXoU7pEY1VrCnHJ42jiLd$$oEy8BCYZn$rrKLwn3ao"] = "#=qBLZm6Xe7fxTFUjkmDqiIchoizOddRcx3eRcuNBFTDVu_z_Pqh09$J$l0VrY5yQA_",
                    ["#=qC97zwAbh$AK4rZ54FAVB_sBtjsHLAIFWdeuFjPM6uD9kzNq10N86cX$MFkVX78KU"] = "#=qGV$XNVbgR7SfXjzaUaNZtRtTXhUTeZmV68h7RaCtRQZOVKE$8H7o_H6GJnMwg6dV",
                    ["#=q40oZZgzKOmzqQdd1Qnpn3dEF9Bf6rRbk1JS2KTnHZ5_RURHfkqA1knr9ZTJqcdnS"] = "#=q97Pim2Khd_xQMVVhSqeNMo5jwbO9_GjDnQcoASloNdsWmQy0MLp53EX256lEWAAM",
                    ["#=qeDsY2lcjabPOJKADBRrEOKbCcH3jaiKwgohUyutbD$HaAPieM$y5kOo9pLV5j2Ib"] = "#=qS6MjAePom9jZFoXlJAI_FGZc0j_h9NfxypIRXMngwVaWQNRO7BuxKHPcvZpo1sNz"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J"] = "#=qdU9ONl7OzTiwqEhiiLIIW6k7u5XTMLHP4q2pu0HMMT0PhXadfwEAYtRzIAtuMGGm",
                    ["#=q8WJ7p2j2nwZ0mDr$Pej4zOon4v6qApqtRVzjclzhN4s="] = "#=quBLsha$MEpijXx2VyXTQYF__GX_JqZSg2wMluMaZxmo=",
                    ["#=qdF7My9Z0ImSiDeMprbILuA=="] = "#=q$osW7SuAA99n7RqRDnYNow==",
                    ["#=qRlawHPiN44sgztbZacmMpIdNzGZuyjS1r1x7eM4vqLI="] = "#=q1muhmFS8uRZTkv$fzaFmgPBaLd1K73R8po7wBPAz9x0=",
                    ["#=qJh_TOjERTt$Cj5JUQGeYNg=="] = "#=qGwpMwLTanRulyjR$n5PT$Q==",
                    ["#=qBKuDtr1$ilPj15o2_5KJ$dGZ5xKOiIYDLynnABJ78qw="] = "#=q_U3BKkgEVqWGbPAkkEaNW2nVCvQl81s8vpdO_0m9o5c=",
                    ["#=qphih$08YWj3UfzXcCfs6P7t_3wiK62MouD6wW7vUdpU="] = "#=qdm0Zs9sBMXpb6vJUYOcvRWOnsl5C8vk58tR0T6DiddM=",
                    ["#=quKjcJj8QZW_A0G7Rvc6VxQ=="] = "#=q53QAS6hIBfxZdC9qsDgfEg==",
                    ["#=qZRLv3ORSHMjc9GmqYG4cnw=="] = "#=qeuuvz1jYvnMztX9pfvje6A==",
                    ["#=qmb9S0gFkQ4Pljkez7z9S3Q=="] = "#=qs7kSaR2kQbbKhEZLblWsaw==",
                    ["#=qoydSjx1jR3uTrY2n5OSadg=="] = "#=q6jMw4pIyCpDaw9E$rpBBlw==",
                    ["#=qj4amyHx4npMyhrU1SYey2g=="] = "#=qTHxSechsq0snxAayLFTKfA==",
                    ["#=qo1UIxqukfpm6LP49gNTTbuDOgm0vIOZzgEnTcvWM28s="] = "#=q$j0LcdLsqVqR5cRi7YAavuuQCK0lmEzdk3Dy_bWarOs=",
                    ["#=q4uTMoqvpTL3wXiKGPyJD1klDyQsKllSoK4Fx0OVgFWk="] = "#=qnwKN50qD3qOraLyj7wWh3tSIqk7gAAhsOQpf42xZAMo="
                }
            },
            ["#=q2_N1VSbz4cq8ou2_1968WArry0g44fCMPTfZ2_P7Sy8="] = new TypeMapping()
            {
                typeName = "#=qJn_uoOOlkGsLgG3m49_YcgQXyEL6ql5XE4hKQMSo0PA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUw3OoJNfVCIsfI7x1LO7Rw=="] = "#=qP2D20zpOAjBwPLUgkVeGlQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q_u_wDedjLgF1mzG6SrNEiQ=="] = "#=qh8xaJYoLO445y5WPpMUJSA=="
                }
            },
            ["#=q27mRMNBgy2qYYiOMU143MezpgXdHryZlfiHbtDXdXNQ="] = new TypeMapping()
            {
                typeName = "#=q07T0DVgv1iYxDnCC72dNu7$3VY8X_D8hunLS8NWEt4U=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q2vPRlV7_KCwaTRU3PIJ4qg=="] = "#=qd6so4SiPPYbixcLN2CGnIQ==",
                    ["#=qkZ2N46T7UFVy$zd4btZEzA=="] = "#=qGBsCvv$M3m34Wre_kfQWxw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w=="
                }
            },
            ["#=q2Gom$3uGGmupydDIy1iirmuFlyeRr1GUBPUJdESmugM="] = new TypeMapping()
            {
                typeName = "#=qkS_FM73iHOtq_By1ZNMKECatXiPmREIlDeaYXFXl$MA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qzuTR_ci0PESkfBiQlg9kzA=="] = "#=qep1rZasH5biOtUVRjaxX_A==",
                    ["#=qEbjlKeKn6rL2O3BWNC9p6A=="] = "#=qklddokZsrVOWtvLPcvr2Wg==",
                    ["#=qwocV3X$bLXpJEf211oU0KQ=="] = "#=qrAzHGga9rlgt1$vsg1N2FA==",
                    ["#=qYOrfLiPKVmF6S$f1yKOsPw=="] = "#=q1iNS9DMvGKAblbXSotbDfw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=q2Gyy1SS_bXrH3DV7CtrZWsb1ewBWM_2S$_uG2lRI6ac="] = new TypeMapping()
            {
                typeName = "#=qeUep31v5MwSl0s7sluzxRxLjSUIlotD0LYCus3Q8V7w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=q2pT4NGiz45M_ss04fpLNqUoLRv0Tfe4uaxBS9bRqGTE="] = new TypeMapping()
            {
                typeName = "#=qoSI2b56YYW5lSl6MFy1t$Yoir4_fdesTseCbjXocfHQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlOXaY6yZ5f82hIoGtDx6Jg=="] = "#=qudu2A5ELkSx1v4Ho7BC7wQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qKZNi0RfbnzjAcF$apJZ$LA=="] = "#=qFZIzJHi797oSPaxrgSoGbQ==",
                    ["#=q$CzEFuCFmZI3sEWS80CMUw=="] = "#=qc50vhrUgPb039nf49CqFVA==",
                    ["#=q4FAPZa3Uq7PG3280pb$JfQ=="] = "#=qm3KnIRMSKNhgTEZzOKAwIA==",
                    ["#=qxIvDn6CKi5EIjTGBQqMXiA=="] = "#=qFcOJTG5MCQHHFuL2Yg4OWg==",
                    ["#=qC2hggupUKpv3NISxgDbzTQ=="] = "#=qGKjXwtipKSE6pP6g1PlohQ==",
                    ["#=qOyhvbwLyGy2Gfjpo925x2g=="] = "#=qNNr0NagINaX$Quut028zBA==",
                    ["#=qlGMMCVDgbj1anQHhOPVgog=="] = "#=qDyei7APCYQJW6LofP3O2Zg==",
                    ["#=qmA9aQwHSdA_gz$b91ORP4g=="] = "#=qkxdJ_zqaMxpb$fzwAL_62A==",
                    ["#=q7Ez6NenyKfN2K$r$09P0Ig=="] = "#=qPzeDyaHc3fanDMvbZ8z6cw==",
                    ["#=qTuL5rQswbHd0Sb4s9Rr5$w=="] = "#=qyQwshP0Y2P_4992ElwzsKw==",
                    ["#=qimHewr2ocPFFHZyFY8QF0g=="] = "#=qx4WIuoeSxt6Qb4p3_0u_wQ==",
                    ["#=qzoLtx_31OmiFu4jI3$jQUQ=="] = "#=qqK6P4ireuP6LFOsLLphFbg==",
                    ["#=q6NkReHwciCH0XXX6Qh_lRw=="] = "#=qQRSCKfn0n1fLbtLITQJ1jw==",
                    ["#=qqf7DwBELO9Jc5hPXIiqV6Q=="] = "#=q506TzTZsCQh4suDgAoe07g==",
                    ["#=qxVTOY6d_XeffDrqqqn$AQA=="] = "#=qSIReokfXMh7TMBiNGYgBPQ==",
                    ["#=qKqqDA5Dj_tYZa_ZChl6cCw=="] = "#=q2oq8_uWY28ff6EqzHUargw==",
                    ["#=q3oTdz9BhYXY8HpEUhyNDXw=="] = "#=qSEqA8KWgERx4JY83fMSSLA==",
                    ["#=qCalrSKlE3T_Jc59ffxnkrw=="] = "#=q28SMMrTXkNc8MGh__QJSGg==",
                    ["#=q2ly8KsBdhrSfK9KI1CWe1g=="] = "#=qcEXl6mDLIMC8IQ4Gn3nJKg==",
                    ["#=qU$17ZFp0IRHklgX89UnOlg=="] = "#=qpkOmq8nuQIciTfincyZp2A==",
                    ["#=qXj$vTRhtfMY6n6dvYeFZ7Q=="] = "#=qRnj5KqvQChDcFIrMyL6Sxg==",
                    ["#=qNmfklpE2cKpSaXXwgphXlQ=="] = "#=qRZMOQBWS3_9Zuzjs0Bp2CA==",
                    ["#=qgCPm3pKcOr2fp2M4AZE7NA=="] = "#=q$ByQlRSagu1JpIw2f7r3FQ==",
                    ["#=qVAUymLjyceoeKaxG4RyMxA=="] = "#=q5IXnp4ayQSKy10Rf1TLqjg==",
                    ["#=qNrAc5UhBkqIiCBO4giU2qQ=="] = "#=qRWt17alL0Korx9b5G5j41A==",
                    ["#=qm8nJt9hAJQRqR4JQa4mv5g=="] = "#=qCI2lhIq7ZTTXQdlagXIKXw==",
                    ["#=q6WqdgdRdd9f3mlo6Ork3bw=="] = "#=qsdbxto8aiktjsYuusOTisQ==",
                    ["#=qojSRsgtbXgXiWltcEPAbYg=="] = "#=qiysdjKKZW_mgX0e87aPlkw==",
                    ["#=qN7L$8Uuesf22Z14jLVO_9w=="] = "#=qSNDsTlX1OlFjn_nPnZRmrg==",
                    ["#=qCroQ_$HkFC4ll1F4aKXgUw=="] = "#=qhWv3Xz6ydSbzyFB6xv_Chg==",
                    ["#=q5jl4gWfC126pAL7UuvvA7g=="] = "#=qb_nLx6RQIoz7SdxA68GvHA=="
                }
            },
            ["#=q2s5YLH0nmVm98BdBdNqwzQbj6AC$J8vwZ$9OWaRy3_IQG10aCJkYTlbSW2_rM6P3VnW1VHxeiRn9FCq5CzttkA=="] = new TypeMapping()
            {
                typeName = "#=qG_DPWDxQ1Ats2oRCzI62JXkUxMMEUB9CcRqWLTBHavYms_R8z5l0MRnsY2ymv1GeLscskBGZofn5vaLfrNTOiQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=q2TjQ5smwH_mFAlONlBNmBsCft4fsAZe7gfXKxwXDkAc="] = new TypeMapping()
            {
                typeName = "#=qdZ4L8xo$5d8nFmnJ6ovVNmCRCTH0G1z8iHGrj6L_CdY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qla4yfYsWunGUATOBpyHdRw=="] = "#=q5jeWl2xEELX2uqSkKpf7Qg==",
                    ["#=qW8XsnPeGRG_xp7TQxkgXpA=="] = "#=qs1gmi0MtYyCQaY49x4Vp2g==",
                    ["#=q1G99VYcTIQ2Mftbk2CBfv6l2M8JCDDM_xNn9MRSOppxDpIqAvavRmXdtGlVOgfCU"] = "#=qr$wA7P6YKF_2iWqmWrbjiyV94MnGDcMt0Mi$dzLiW4Pr6SVENKZx6qxwX5Mt1k0i"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=qV3G4Uj7Q8BZIo6ZAldxPMcMgLUtg0gZeh2amL1K$6AM="] = "#=qdAqEpZC4CTVdSR4mx33dJd_Eq3sMIQHpHArq35NCwdw=",
                    ["#=q7oqWQD4G2Mw8jUKoIghWfTsgfrSSqinFb0of_crxrQk="] = "#=qlBxB0r1AtQtIBlrxiIpMn6fOwnQWLF_ZScuawbeB8Kc=",
                    ["#=q2q$wM1rnKgtWKUn_AfR4_vRb$hmV$Puf2rVVD0otmdo="] = "#=qmhMQRy1o4MF28x8BE5mjt2W1qRqlF4o7xyuVZTmmeFU=",
                    ["#=qrQqMNwhJe7h1AjcqymvAp3eIg7_Ypw0hq5k6cUbYgU0="] = "#=qWb65idIsoqF5J8cCRlg6pXf7_EcYl8IzkAWvKsJL390=",
                    ["#=qhVLymAiZwNQ0JQsfL_C_9c2PiVIUuPhYZ8NhMWtQMzI="] = "#=qJy2n6SSm5dlLjdBLNT$ay793F3tS1dWEIP1387uHXec=",
                    ["#=qQlcHAxRvrUeNFY5rAN1dOA=="] = "#=qFRxI9S7o9TfHdpRFlwFcRg==",
                    ["#=qoCN37HhGZtx3XprurY1V3Doxb3v5e9FyGWd2vDIA28c="] = "#=qYk2He4ICsm611TMol7SygFj$QXfddeCBrK$SHo1l8ws="
                }
            },
            ["#=q3cSQqlp_AgY7e4VWfNuFX43VnNiGK0cXQbxdMhC2ky0="] = new TypeMapping()
            {
                typeName = "#=qmOQ38tkYnHB7koJtoFWk_m6hys$MJTAAL_9uRsYtF2Y=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRxABc7TLu1qSla85PjdB$iWEk$jAWpZA$Ed5iHNpp_M="] = "#=qKoZsiq8eshjsihiAPdzGk4IXNvBiqggTNKJA9l7Fm3E=",
                    ["#=qXi6xofMvSpdB5T1AXCeuNSOS9BXQMnSLGFiy1uk71Es="] = "#=qP3EYi5XYvnCawWBGTwpsXDL$fxNRBhqojOWK58lnAAU=",
                    ["#=qtqWzpNW0sOq2ANR0At5c5A=="] = "#=qX3UrT8dx1wQ8Q39mgOCPTw==",
                    ["#=qKMGhu3YmTFLV$Jcb8hGA8g=="] = "#=qwebVBM50NJkTciULaMFbvg==",
                    ["#=qnuNKwgvnVgGZS7M0JwUgSQ=="] = "#=qUgJHMQD$H1_L_m$lwv250Q==",
                    ["#=qqh57CGEUJVkhYjj5OmhkmtZD5xOGPm123qaJqxI_mp4="] = "#=qK3qzBMGxENMoBoeodHUzP8G8ig5d1K4ceeHSD1l2JKA=",
                    ["#=q$F76GT8xiU0eIoGQhxddtmXXsh4Lpx8sUOwIB6aFxg4="] = "#=qfEJV8lNAOksEUNMTqfV7SWj0b8tYlx30SsW8Xjwdl20=",
                    ["#=qaJT$uM_Bv7QiL9wR0JLKoQ=="] = "#=q9jNDzq6XJvBfA0BVsZsU1A==",
                    ["#=qVmRczehQT6g3yxJsRT4DuQ=="] = "#=qC97sUxhDfCrMCpnshAgzxA==",
                    ["#=qn8hKXlEt08VP0ZAsM$YUPg=="] = "#=qyc$Je5hEU7JtSac1Rv7W5Q==",
                    ["#=qAhDlqncrnbS9pkMuhiQYGQ=="] = "#=qk1YaGNvPz5Y1FukMWzODfg==",
                    ["#=qxLLHu4zfxdbMLIND5BNcfA=="] = "#=qefiS9F9UVcant_JWHW2rTg==",
                    ["#=qvMX_UaSEA0JIpmWzeXXfgEEyNBFRVj6mZN8mNy5omBo="] = "#=qbfIM906J6TvpG0OHRFN10Dwd8wyEro1$0XVgCwq9Wak=",
                    ["#=qFEAGr7zh3XO1$FHI_FC0Zw=="] = "#=qPv2CtI_N0UlRBCeG3krTKA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qzWXMC9nnPyOtj3Qc0suTMw=="] = "#=qVliwgDfpxP5mE$LbV2M50A==",
                    ["#=qPIVpqsSkAd4KbtvmY9eOPQ=="] = "#=qLLx_Qv7NIvzNRfsJYXA6Mw==",
                    ["#=qFZjFEGLfqpxv0v1dmoaAhUpRUGRucmzZbo5IN5jHwtI="] = "#=qOlXovA4wX$qVSc4m9h1PriszfNwnp6My6j4SsAKe630=",
                    ["#=qXT_5BRBAIQYIjKMmruYZY6YDqQcobWt5UtXOor9aDaM="] = "#=q5dRH3ZhPV8mGlrjN3susESGobMQhvk_dGW6eJL0MAuo=",
                    ["#=qtzAre_$8HLn06p64psvgVhRSEn$s7dGT6OhweSYK7vI="] = "#=qNZJhLVQDR5trr1GB1ohORrwlB8$GLn8phOdPwXARGkc=",
                    ["#=q41FNmDOkUzOLkeAwXMgGfg=="] = "#=qTd5CESZlwqccBKmxCUTzGw==",
                    ["#=qEqDgz6JHtO_LOhKwzToeCA=="] = "#=q18oiB_SrjESMLrX1Bo2Lqw==",
                    ["#=qlCygEPpqQUOsifl3XEntjg=="] = "#=qCOOuKKprJcHgCMyAQNPhfA==",
                    ["#=qhZEe8tyDulfgRqFlJ3uHxQ=="] = "#=qYccInqdJPIBNF7twCBe9EA==",
                    ["#=qk70PUIK09yPwvdssvxECrw=="] = "#=qfn9fZAnkheI7tnkRquKHpw==",
                    ["#=qOA5FYOzQK5YEutIR_0g1dA=="] = "#=qqM3Aw_HQu01Vc1VKgRqfVg=="
                }
            },
            ["#=q3eVMUR7DyBvYdj7DstzKdBH2vFa2T3SJTcfhZCTAPVYYy2YwdFUK1pAcUpIvaNvWktbFr6i6Tq8Zh4JlKYkGyA=="] = new TypeMapping()
            {
                typeName = "#=qBBL6X8KSk57qSlgtlcomwVK4RPaNyj8ufdzs$YpcskCHLenGwqGqEG2Sy4HX54Yt_9iAAaELxStHirGwTABW9A==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=q3eVMUR7DyBvYdj7DstzKdMCCeYcipHwFoIVKKBOqgzcrnBMGlqo4dipUWyqbAZLe"] = new TypeMapping()
            {
                typeName = "#=qjqby9YTsAd55pZRttcpcpc14vUXz2k33eBscDYfq8um8M$WCslw1Xc1bscI$QlQt",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qLcC0wTwqqdH6fS$oP1CF2A=="] = "#=q$v$YT$RHBF$H3yjgBXYKVw==",
                    ["#=q3eh4f0lddgsL1Qv$qeKeUA=="] = "#=qH9l17R0w0v2biGtWSXj50w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q8OShz5mSlXNztqKfbbCH8A=="] = "#=qmQz0qnTitDOnymEgnv82pg=="
                }
            },
            ["#=q3IDIilNcChqf6CKYd_GWuHCV2IeX3uoL50CXUDXtddk="] = new TypeMapping()
            {
                typeName = "#=qQ$MVmi$$LXF6Fdfa7UUB3G6xTzGYWa6TzWh_qN2tj2M=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qW1AHspvOnHQB7pKbYbTJnw=="] = "#=q87GaD5WZ6f3t2ROPE40XzQ==",
                    ["#=q$Lwgdr8eeUp98ejrkFNV1w=="] = "#=qAqePaBO0ktrzh4MBE92jIg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q3jDC5ZB503Meita2KJ5aAxGfcmfbca0LUAxDoJrZg7E="] = new TypeMapping()
            {
                typeName = "#=qHYoScqygwoG4jQshM7lSxhbyVMFRBPW7QZYNGv44k9g=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q2UNguYoKA9JWolA8FRMzbo8jjwMEz47U1sBvPzOj83c="] = "#=q9apLAwRwL_Net_Uijtee7YhBgCguq09JtkGdp1mA_Wo=",
                    ["#=qFuLF$IYP7kxzJg1RPIE9Xg=="] = "#=qc73rTbIx6dlYtXuwMXarRg==",
                    ["#=qYHNP9ywXhzJTseDU8fmlJAA7hVuYdEq2MgpN0qb_puE="] = "#=qRKMOBY6BXqir4tdiO0dTFwv3t4oz_Z$pGOTDsqPLPiE=",
                    ["#=qUj3pCooZVU$2wFVwNfFYjg=="] = "#=qhIAlVkwTsJR3G5z_xT69Vg==",
                    ["#=qPJq2t_UV8Hx$DtBv8HE3nw=="] = "#=qTxd72rAYdG6IBta$Ibtr1Q==",
                    ["#=qfNkpVhUnTH8WRCDZu$tuJg=="] = "#=q1MbxGp3STOlpw_ZfvGKITg==",
                    ["#=qJsgxwi6DfSCSrGQWWuYhJw=="] = "#=qHOtm_cLGQNfkhe16SR3Rpg==",
                    ["#=q8ykWEql9fdenVggbpHJX1g=="] = "#=qI8zwqBuyKhsYznHjVVWiWQ==",
                    ["#=qo4fHyHiMZPdSEQ9T97lXqQ=="] = "#=q8a59o6_wuUT42YrTMP4uNA==",
                    ["#=qQ641PoOFR$V0XWps6KyLLA=="] = "#=qPd0wrHgPWL3x46zk6wRoOw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qbHkKGsAkIXIULKOk6oIQvTJVxxjaH8bemJ4qPWoXh70="] = "#=qUEsWYreRgph$rfnqS9YEnw1i67_E2ek0O59eQe8gUSk=",
                    ["#=qwG0Pk2uAJqAyx3EX3k7EyA=="] = "#=qRyWFnOaBVm1BzOD2kaSf7w==",
                    ["#=qhF9jUF$2MnsrMyl5dN$vkQ=="] = "#=qP8yvoOXnV0Tzt_aa5ocZrg==",
                    ["#=qD1VqnQ0HynXNwN2$l8QskA=="] = "#=q7jc7PlOub0IEkb$Xm_dxXA==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=q3JmacHP5QxeYtq9$OaGz$SUC1d7LPXZjwVyzU2F1PIM="] = new TypeMapping()
            {
                typeName = "#=qEPHQjRJ$C5hp5WjnKNzrtHTJKCKDkNoAYuUsdMaDEms=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qeB$atR$1Ldm481Lx4Rvn1w=="] = "#=qAJlkeK7UhPn7$7m1BZDSIw==",
                    ["#=qIzhIB3W2tJ5sqlhrxNL29w=="] = "#=q9XoFvelOfMKxU9lQVJaJ5A==",
                    ["#=q$HG5foxRwIWtGZohQCTxjQ=="] = "#=qdhhMla1af_1riGol2yAZAQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["ToString"] = "ToString",
                    ["#=q89XzYXsIobwDyO5S24DyEA=="] = "#=qm_Q_XGvNcA51nElA3roS0Q==",
                    ["#=q94moHiuHtH2M1NvwTaQS_w=="] = "#=q9OyufEquiEi94wWhRlNYkQ==",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode"
                }
            },
            ["#=q3lN1FMOEDKyw_QP60RZS49lfhHif_gYv5RAzuRsvoCs="] = new TypeMapping()
            {
                typeName = "#=q$8wkxLExdLIdOdrBnxfJxWSCO0xOayQmROF_Jd5uCf4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qoZTaokcLlpRC329gvDkXeQ=="] = "#=q6kjoGTBputP3RHY3_p19Sg==",
                    ["#=qJDhHFCxSPuaf7roULzvVgA=="] = "#=qQJWCPqyup0D6ebGop5rShQ==",
                    ["#=q1$9wRyjax96$frpimnH$LA=="] = "#=qgK7OVUeHxLAeeixoHMQvjw==",
                    ["#=qSevwQSapCly0vBCVua79lA=="] = "#=qeU1y$z0J2sGydyLyjaYc2w==",
                    ["#=q3dnR206xU1411t0A4g3Pdg=="] = "#=qukoigoW8GkWwM$_xUjM7Cw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qOJhk4bZAVzFXE_W7QGgrFg=="] = "#=qOFFlCddNquiHFtbGErjRQg=="
                }
            },
            ["#=q3Nz8NAuMsjsqQ3Y29d0Mfv6JaNziJPzGaDE3d0$edqm8yfMbbeUllDbZnSDF_AlG"] = new TypeMapping()
            {
                typeName = "#=qcWLH$W_qU2i91FGsxRTWjJXCMl9zizQZCA8A2f3cfO2oYY18KL8x05Y38eev2j9k",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9D4gofCW$RE71gIJTn7xsg=="] = "#=qN9bFA63uWC3Hvp2pp74o6A==",
                    ["#=qtcFJxHRuUkViBRUvBlGhIHtLxOj_SzwkoPPI_g9W9U8="] = "#=qepDPjOMoqM97bhnunLuRgkbl1XO38n0o6U_43pBktmE=",
                    ["#=qm$jD679l7cW_IVcaApzpkw=="] = "#=qxPxsnF2Bc_UGl89TlX6Ukw==",
                    ["#=q7W4broBpR4jo0ztn2kG3paGcN$7jlIV8xnXdrZgNJ6k="] = "#=q$XcRD$kziUKVe6m57VV3G2y770bgkhggI1M49iOHS7M=",
                    ["#=q19J0GuRDBbPq2_JDkDG6gA=="] = "#=qLUr_PwGolWouTZOxVWQ0Yg==",
                    ["#=qg8Ee36c2HYQM05_2O5AeFw=="] = "#=qkQo5SOYr7HtP5l4D9vPRaQ==",
                    ["#=qEIehLyStJrfB_jStn8QgkQ=="] = "#=qCH5mv2_5Vt7hiAwBXdz4Ew=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=q3ooxeKiVnyB5Z_owGRwWQf7X29IOTVMF9I5KYpO_0y6wZPXkvkzadLXQ03Lj4zXx"] = new TypeMapping()
            {
                typeName = "#=q1WFHJ62Zf7dvUUiXxLfRYCMn1mfDpx2AwctGOl0Mh86dFKR3tnThTWl3fV1BlTJw",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qsqvw5r8ZWlC2S4$9kZ1Isw=="] = "#=q_ZGWsPiAYfaXmjh0MKZb$g==",
                    ["#=qbOkHnkKV9aKwxaP4P59bDg=="] = "#=q7lHeBwX0TiCWS$DbaslANA==",
                    ["#=qZuUKpnnvGUWzBt5hSSXloQ=="] = "#=q1pJzvnVkEdO5wu4EofrAqA=="
                }
            },
            ["#=q3ooxeKiVnyB5Z_owGRwWQY4JM$AtYkCg39oTN$GkE0jM05J5GdAvTElgujCZrpjq"] = new TypeMapping()
            {
                typeName = "#=q0Y8qxRGsmEFjZwxrj9rYitQXIack5rLxqLFlxtX5Eib1oOtzTqv_4rIuvO68dZLF",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvZyrU8Zr6JigEiuI62rC$w=="] = "#=qDzgPea5RueRbAaz4MgzVWQ==",
                    ["#=qJr5W9UL$rN886oL1Easo3Jg_tAmPOUBskqmlpInbGrc="] = "#=qFmB52DzjGlzyh$J8zGc_k4PWAcpLbZc8AY8fDuISt5E=",
                    ["#=qfoX6vVHVUp50HC70w9mZz0gi1OLZqDUxHr8gw1wb4E0="] = "#=qfqcHKYeWnaqTfC0mkY3AFUjrkb2GrW2ZaAPmdn_B6sU="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=q3Pu8lM5YqhCPnW3rfYRzi1nruclKdLkuSBDqH$NBrdY="] = new TypeMapping()
            {
                typeName = "#=qhl01NJDhf5syx$pe3xdi19TJ3DbdcSSQY$QVK1T6tws=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3kMHogzWmTkCBphbWnnqo7PM7c0t25NB_0nLSJN9_eo="] = "#=qS8dAuDw92am0Eb$bTH_oLU1U82YUoXHtOhxxgbzyiM4=",
                    ["#=qsHMcolZ7WUlQ2J$VpwUktg=="] = "#=qdak_dqQhu6BefpcEVSFZvw==",
                    ["#=qCiCnzXEaxfMw7tDucT19zw=="] = "#=qvNy8qHdm4Ge7RO0DeK5eQg==",
                    ["#=qIOCbB9pZ7MvB0pxm4V6zyQ=="] = "#=q3mVM$bayeJTZ9hvfYz26ww==",
                    ["#=qKIA1aRGzu2hWXmD8_tL2_LutsWFgmAlCz$AcRl80z4M="] = "#=qPh9Mz7FPD8JFNvHbne1k3uIAQNS4V1VqKKC7CCANZeA=",
                    ["#=qWZae8nkUBxlCg1v7_S3_Hg=="] = "#=q_JVd0_2O801Nq4g7QPh1dA==",
                    ["#=qiVJZPFR$UJOcJOCuW7lCkQ=="] = "#=q7Z1c8lbmtbpJD6X5B90pVA==",
                    ["#=qSYP3K6UkPa8nsYcZpfTl3g=="] = "#=qbu5yi3VKPl3NHhNo851e3w==",
                    ["#=qeRm_E33CfxHZ8zlv389k0g=="] = "#=qjE0XS8ZoQSfQT8hIWE2hTg==",
                    ["#=qJ2FTZ7usSQwr8ZBkmgoCu2Pk7$vfxSS29gG01XmPJso="] = "#=qCPR5LMQn7k0VJ1LPjq4IN9IDoVEl6azbkS9fFScq19I="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qXJwfKIH7JShbGmrEchAZz4GRyVxhHsedN7Gtmz40uHg="] = "#=qwVGAb9CjdInq25Bl7TC3dgSFsLJCAB0aLC_WUO3XvKQ=",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qoyEDe9x_AOuhdfmIn0l_Rg=="] = "#=qhmJRs$8RV8V5yevdzqPwow==",
                    ["#=qP$HNGUDvfih4Obw1_sgYr$ODUp3ky_IMKb87d3rRMc4="] = "#=q9owsjuVCRQijLUmuPy35TLZx8IClLB$loyWhCIYIWnQ=",
                    ["#=q1RgqbZfJZkRcNRN9VdHGLLk5T_J59xMvu66zCVrfzh0="] = "#=qjqxkumvPH_ADNHYF$20_A7GQU7YjRB7j4lZ0fTT2DO4=",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ=="
                }
            },
            ["#=q3qC9qnS6GH07e2h5$6pXSjdm4$JYvxF3MuKEOglyyTElJtsHOyRPn9rLP6puIu9N"] = new TypeMapping()
            {
                typeName = "#=q4YQA5FQELKUqcnP0suqYArYCLLKyBlU$sp2vh2JRzrWOldZzXZeTO2GkWPBYq1Rj",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiMmVVdhsmE679kggC8VOvRJ6by$dtRRTDrmeuW2KqCoYF_H_0nPhBgKKobTKzYVy"] = "#=qJY67TAg2XmI8PdCK_VY9uCkKrapyjscEbEp3f4tChRL_LPu02Tm8a3v4tyFurt1Q",
                    ["#=qr$O5k$cR4WJXDNf_rbN9XgCgCcecUIy37ocySZfsUzVrExhWGII2r$RUc56HRyos"] = "#=q$KSp$23WiyM$l2dhcJ$OESum5K7xcHAGMz9PETkaSHjrXf0bRyU1jMRtJekyDjem"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw==",
                    ["#=qlpkiSnOi7ZwjgCRYONbkEw=="] = "#=q4xDAxAcPCLmLbAKkqdT6gg==",
                    ["#=qZEUCmiGnofsNz1Z39H202A=="] = "#=qAbpqLIzHxYjPBQgMLFZbpw=="
                }
            },
            ["#=q3uln4LSIWXdzKWPtMsaB7Bovquka5pi9JHJBn29c$nNiq6nzfK6TpGEO5k2hZhwc"] = new TypeMapping()
            {
                typeName = "#=qYza932nTwfHFDMkY42yvoVQHAbzCIzn8zcTO82BRWKjfsPWZ6qdN8V$mxE2hNSQj",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q_xp8tF0FsBPxhlxs4Carp9N48Si86gBfCEGyGqKkJqH7SDJXXjkZSKs1Fq3NIqjL"] = "#=qsLZXYNDe6JFj_8qaypi5dzo_vOFyLMNjuqVpKVzuU7O1xwFphO9UfRLUYZV857PU",
                    ["#=q6jNOZZdAmsSMGVRZdAQ5VGqk_eAXjLCiHLtQqvivviznLtaWczBn_rQcV_1h5gZC"] = "#=qSQmOYNPlnIFPzEBKglSnG8BHZUs1Env3SJ4vP48KWhKGQ1oTuUBFHw2Ntydgt6kY",
                    ["#=qTVRKfwqZXeruiGXr$R4Z4EL$TbGjn66u3$TGzjtOkiJA3rVQz8MPOMx$37$P1sYV"] = "#=qBL3WkhvL0nZ6vYS4_cZy3iggkKfKg_WE6AFjSdpC9H5aQgcv6XzOAzoW52PN2qOS",
                    ["#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaSJoEphRGq4sfHYCtfQ6yZT"] = "#=q3UqA7WAox9J$aALjuTnb3$ed796mKVfvbfNIDYT3uuT1lLpZlkl8Iuzxz26OBg90"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qhXxavwqCn8p6vL1nDo6SIy5Q4OQGnrmlfkEH_IAPYLI="] = "#=q$gCKpVK9dO_6dxjGUzW7cKx9zlbFoFHd80PbN55Gs4M=",
                    ["#=qCVEdJnzSTNkGjTVwCEzQ4sMDDSp6UO4391Jll0JAnKA="] = "#=qK6ywjHa$A0TFnWg8FNfEuBe2Jvifyrze8qUcJtmh2qk=",
                    ["#=qdnoS_InIWbR_nYckvALsawdKtRwYV113LX5rin$p5MM="] = "#=qt6aRRHDpT0V7QGiYflRR$_jGAwJnzAisywye578Nc78=",
                    ["#=qvnPuXkhneDghlAjgeoGDgimGwtP8ryEv78TgEj9$OAM="] = "#=qHKs3FAOIjG99paa3eBKisRp5jzCx_F_NMNBF57lLXrY="
                }
            },
            ["#=q3z7uRx_nWe6tRKV2BzqFReqHWRMK0xjqkqkjL23tqZU="] = new TypeMapping()
            {
                typeName = "#=qKWmxBn082_Pd5h_O5b2FfbP4l1L7WfC$zlmm1_IssfQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFhp9YYmL1fWbKubFg7FJOA=="] = "#=qDvzNWb0mbn7VaWm0ygoexw==",
                    ["#=qN5cxjmgzjDi$$$qW1aBFCg=="] = "#=qrWWlrsrZl5phU48OUWPi0w==",
                    ["#=q6TjgI_PbtAkUI7wkDutTvQ=="] = "#=qGmmvoxs0SGR9V2Tc0sZdbg==",
                    ["#=qQ2GkY1OinPanheD7Q1dTHg=="] = "#=qnntF0SZtmKRVbaJbMv0qUg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["Write"] = "Write",
                    ["Read"] = "Read",
                    ["SetLength"] = "SetLength",
                    ["Seek"] = "Seek",
                    ["Flush"] = "Flush",
                    ["get_Position"] = "get_Position",
                    ["set_Position"] = "set_Position",
                    ["get_Length"] = "get_Length",
                    ["get_CanRead"] = "get_CanRead",
                    ["get_CanWrite"] = "get_CanWrite",
                    ["get_CanSeek"] = "get_CanSeek",
                    ["#=quPOeg1DzfOAFCggOta9Z$w=="] = "#=qDx6j6jwMSO6aN7B71CMZXg=="
                }
            },
            ["#=q415o16bRkolAD66C0zRz3eaiTLOTT4o2i66AAG87aZU="] = new TypeMapping()
            {
                typeName = "#=q9ajPRKzN2R_tduWqS3SKGNPbzhmem3hkSWQQGE5vofs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q415o16bRkolAD66C0zRz3QIomT0hw9oLGggLDNiPyPM="] = new TypeMapping()
            {
                typeName = "#=qkBNGtuloO7yDIijZ$uMn34X7w2YskdR$QRcCLj3eH9I=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q41QOkfPt8a8hLPxHgEpDo3AOTpbQrdfsBC04stlcwdH2dFe5Fe7arSrCSrxMqBYf"] = new TypeMapping()
            {
                typeName = "#=qZftPM7xS6nkeoZJ5uTxgy4LhqVFAUM40DWx5W4oddlKz4dqIwvK5BMktwNs58igu",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmCqsaTv15JTKVZXB8G$xIA=="] = "#=q$TepIVSD0PYi1ox4x0Blkg==",
                    ["#=qEfSql$libJGfo5lNoMiuS1unM0VvUAlILVHWmcmpFmiwmJoExHvhoOA1ypRliRAU"] = "#=qUqS$zDPDuL4K1LzV7RvVVZB76gOdvD37B$g52NJXRG4XOtpW2tXaTW$SSheCNqqK",
                    ["#=qMs$MQ5zt6clvN258MuIM5fu91oOKTN8rpFyuWWlRulTwRMz1YKf8p2XnNA_qtb7f"] = "#=qIdEXAB3j_MxqprV8j04xXWgMkr6bcHKoKezqalw5RM2oODqb3OJa7locGzm7dZ44"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qHTN3pJJ6kWYEUv93Y7EX4g=="] = "#=qjc57$S3j_8qXYZt2guE31A==",
                    ["#=qv0Iz1TInhdn0NpX__6pe3w=="] = "#=qWAEvC3E1VnSSXO58gJX05g=="
                }
            },
            ["#=q44uijWe1r4kCd7azu3MpZJz_twBRU3Dby_yZXJn5QowzESW0AnYLpvejVd9RcfSn"] = new TypeMapping()
            {
                typeName = "#=qnIxybuQUWaGrTirDdU13JI5Flk3TyAKzNIWaL0cALMA8VeN2j95CuBjXh29dEwca",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q46eoZgYGoqFLQKz5$0xVB8quDT4d$nVZ20bkQDGkkGU="] = new TypeMapping()
            {
                typeName = "#=qg0VI_0U9JV_oU0FJFRLATl4VYNgMD5ikybn$LybEeFU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qot6x7PrbIePLOy7fCwvBdw=="] = "#=qbIYzg5SYz1lSZzv8Rt7Eyw==",
                    ["#=qFBTcn7N6eGzmwW$i8fI_Rw=="] = "#=qAPN3CBeheHfHgco1hhMI_g==",
                    ["#=q89FAVtQV9ukd2GphUDHOAQ=="] = "#=qLgtI$v_IOzTHgyfMwWjxog==",
                    ["#=qBC9EzZ6vvUvJQQjPDk5Z2A=="] = "#=qY2y6TXm1eO9PQfFxVmLn1g==",
                    ["#=qEGQaQkar9lM$WuaT2MEwiQ=="] = "#=q4kZV$7MxhabZ3IeAvpKGgg==",
                    ["#=qzGsQKkqR9COwlzTn9W9s$g=="] = "#=qUfyqLbD2_PoS3GvnZRvQRw==",
                    ["#=qTTeObqmxrDUhojHJ3KB1eA=="] = "#=q0b3FIcWbzK4kQnND0FTL7Q==",
                    ["#=qRH45x6crJVjRJVNorxiFRQ=="] = "#=qp7HYGiIWZZhsgrHSPd4Bpg==",
                    ["#=qKQuDZQTITBpQ_9O86Nn0CQ=="] = "#=qHxYx5mhtOcJkJthThHiuQQ==",
                    ["#=q89bw$ZQhJFZvNwJ97YFqiA=="] = "#=qB3VSbx6Nhwznp47TBrKRDQ==",
                    ["#=qUJmTBB6e9Wx7MzUGyv1Tqg=="] = "#=qoABCTnrhBGEFNARW6Y6Xtw==",
                    ["#=qFS9cY3z96Fj4mCBh5JEVeg=="] = "#=quzkPeKM$axZd4amxvCLmDw==",
                    ["#=q8O6Jg0nhuMMpwyCOTSlQ7Q=="] = "#=qfDX178su6Y3R44WqqGerPw==",
                    ["#=qzk6CJle52usH6i9B2tPJ$A=="] = "#=qK8VfbxI0f6i9pHcplDRm_Q==",
                    ["#=qWx$kEvl7IGMluWbH8HO4QA=="] = "#=qutnzeIOz6ikmC9E4CxvAaA==",
                    ["#=qwKzAZlN4Jw$$pV4V_TQuKA=="] = "#=qOzoNTqayiVM7t6bpPLy6Uw==",
                    ["#=qV9eB8UzrSI21irF2Ei4Idw=="] = "#=q0Z0YkvEN8kgaCT8UPZSiHA==",
                    ["#=qtPMJX$8Ap$fzRJnN2Sdh7w=="] = "#=qPMBhw8BD6SPaunL3zllkAQ==",
                    ["#=q5OPJd0YLTQIP0xouE_Sy7Q=="] = "#=q5nn_AdHrjoCQl$_2O6aYdw==",
                    ["#=qrzCQiMURLMO6vB7K7KYh0A=="] = "#=qMELKyJ$SpCDupcQt6M7eTQ==",
                    ["#=qXCUVlkijjVg1CBJyy83yYw=="] = "#=q$zV7H9QHRIl74WzOAXlEFA==",
                    ["#=q6Cp511ZjQ59$sRVyMBahCQ=="] = "#=qJ4fWvNyijYXRWtEuBkFoqA==",
                    ["#=qXafzR5wvfNrJAdvtWRuFwg=="] = "#=qCc1ckUIrc7l5kxSEPGogLA==",
                    ["#=qw3UJUAVNzHKonvXqztMHfQ=="] = "#=qOAYyv7ki_ykEG2RQ8U8AmA==",
                    ["#=qsoWV4222rDHaMw71jgiXQg=="] = "#=qE0AWgiMlocqHVTq2ADE3_w==",
                    ["#=qM$tLkCToTmwxeFLMsOVU8Q=="] = "#=q_GEKBS1uof8Jft_SNtoCqA==",
                    ["#=q17b37EXB0eehazMHi9$LCA=="] = "#=q1WJm1w7K7h8u6PHo_9GJuA==",
                    ["#=qRuljuD$0n7n$iZahQ_1YZA=="] = "#=q$ZTI3KR_O886sbmwKpxCuQ==",
                    ["#=qFXG0ScDSA0csSzs71SEstg=="] = "#=qR1qImZ50nZ1sdi$S8KaF6g==",
                    ["#=qWpdqejmhrTX3ENkV6P_ZDw=="] = "#=qbVXTyDjrB7S_HGwGz9o7ZQ==",
                    ["#=qCKJlos$UW_C7mfYbFkvgxw=="] = "#=qiRxcAC4d3V1FMGrsU9as5Q==",
                    ["#=qTLs7kYcdBuV0qzp44L6NZQ=="] = "#=q1_y60FIbWgWx69g7Pd6IJA==",
                    ["#=qSND0XKiv3g3Fer4VMmDpVg=="] = "#=qx7s$x9o2rXj9hX3QMS8Q_A==",
                    ["#=qVCM4WFN0HBeVSc07$IIRRw=="] = "#=qH5pDglzNQ04_LNlkC_Dpbg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q80MCTb0_K2u76Gtz_Yz5iQ=="] = "#=qctQxwwvCuoGH$IKdTCDX5Q==",
                    ["#=qbKr7fkORILrqQuoN2KV4jw=="] = "#=qkUbYGcT5NKKSCmSSHe39_w==",
                    ["#=qD_yulWHaAddMyrWQ6y0aGA=="] = "#=qmPF2ckObnT8LEyv6X$4lXA==",
                    ["#=qLrYdLkvvXZuw7BE5GmvI4A=="] = "#=qgUnJyor5ErpDayBrLr84aQ==",
                    ["#=qDKxE5Ski9CRbpkq_MlP1mQ=="] = "#=qVfDWsqO6seJAU0hoRzy7xQ==",
                    ["#=qb$RQBcqRSkcxgswUsA5$iw=="] = "#=qa_QxyZRsTo2PEdCpvNT6aw==",
                    ["#=qRL3LvRGGJsL7pAPGFYQJdiPTTkr49pfUHqOKvy0mUg8="] = "#=qNuPDG4OwFlb_ZoYw$OSJ36S4g4VBbhBOId6DNo49oN8=",
                    ["#=qb8ndgiM4ECjkgbFcDNQ1zw=="] = "#=qZQSInKW7lw$z9u7Z0ssnpw==",
                    ["#=qiXuvPawOPBg6297G3GBrNw=="] = "#=qm_Ubrvd$XdYlkme0poy1mg==",
                    ["#=qHZtc7pfi9ztZS_z0T2lVPA=="] = "#=qF_UTgfZ0kwpWx6g0BdGpoQ==",
                    ["#=qrwB4ckT0QoCi2IVUPeyVD3GnmgkBZnMmHZPpb3WOx6A="] = "#=qKBG6141RW1s3WHwNaHquOxD_APWczBkZYsgjwO39Fqc=",
                    ["#=q6nER_IHU$CiLJH_LhVpQ1w=="] = "#=qtwoDtfgKgphKwNiq6tgMpQ==",
                    ["#=qrcRFIKIVDPGystMQZ6cpqA=="] = "#=qWJNSCZNWGUxNKaXzmRDmpg==",
                    ["#=qkPelKQMw7w35gJfAsorfmQ=="] = "#=qxJ1E9D1Sr81NUZ4MlPuBNg==",
                    ["#=qm8$g__ksMi5bFsrMV6Bx1g=="] = "#=qn1R5UAvahYCtqxUggHOhVw==",
                    ["#=qlZKPqAmQ0t4yLflRPHRkQA=="] = "#=qXORM2CT7P9tRSqbbnsG4xA==",
                    ["#=qzISF8vOvPmcNLxZjewdVgA=="] = "#=qQsh_w9HxD0kPZg2rBs8sgg==",
                    ["#=qG1y3TtncQrsvMT$GLLBg4w=="] = "#=qWFO7wP8YCMHGzwZ9OH3wyA==",
                    ["#=qtWICZYxunj6sgJiObtmj1g=="] = "#=qZjkTsMxI0Qffl63AeCNM4Q==",
                    ["#=q9Tm4zp258sY8h2MCZSteMA=="] = "#=q9A2XBOTDRM7oe3fp6fA8Tw==",
                    ["#=qVr9isX8vPaYaNGWuA$LqXg=="] = "#=qvCM8JwcKQZSC9lCxvsNHBw==",
                    ["#=qLfX6Zt74WaQ1ZWxhhrHQ0w=="] = "#=qhkK2QjE2hK$dBe$kZ3lh$w==",
                    ["#=q0iGs85Nl9bKT2mSPUXPUqg=="] = "#=q6ICZGcfQkUGVeSBIwDe6eQ==",
                    ["#=qUN9hdrF6BmYbX0uNNLFPsA=="] = "#=qhriNKW8W7C7dPDAv5gQgtQ==",
                    ["#=q11nibsjonYJKfDu2mVf57A=="] = "#=qHJWSSGJgEtYGaKZkCIhHUg==",
                    ["#=qZ$pkE1NNzrcgoryFfoIzLQ=="] = "#=qf0qSkFhmUIq05b3jwvCzdg==",
                    ["#=q7p3vS$619phmTlIYwFKESA=="] = "#=q5OLQxTEex8ynLarkSSSe3Q==",
                    ["#=q_tLfMwzXSTv6cBdj$9CZ7A=="] = "#=q05nXI6LvFmrjCNaWcpgzkQ==",
                    ["#=qxOKBxuPV5d4bVIHWDuew_Q=="] = "#=q2gSP35MqpsWC7tFFD$A48g==",
                    ["#=qcWO2OgfAIKkhrMR3UZuFDw=="] = "#=q1DXga2JH5yLfmnc8W0$Tcg==",
                    ["#=qZIKq8iuDaAUajzzo2msfYw=="] = "#=quTaBnw_Huj0AvV3AOn7O3g==",
                    ["#=qkwt2FYlYrDClAHMTpfEVsw=="] = "#=qLfIBxzIXHtDxtitSNR4jsw==",
                    ["#=qd2zffZFxwhxXOwWePDUULQ=="] = "#=q67$OIBYbFy6S6WDg1k2FQg=="
                }
            },
            ["#=q4FuVHPX8Nu2CLnuCI9LQmhn8qdXyoevVSrB_fhZ2YWmo8p3khVeGCVul0nhDuxPk"] = new TypeMapping()
            {
                typeName = "#=q5tsSpIdRWEJlBqWqupL9Mg_$ccebR0VPcAtvPoKNLXBjDS9nmSpI3PtYk1i0PFuh",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qWzPuN21nMeCgrORdSHHaXA=="] = "#=qj_kTT8abQe_ocNNlQYQnAA==",
                    ["#=qcqzDfInmaZKykCo$E199HQ=="] = "#=qLz046$JDAJwA1P8KK07_jA==",
                    ["#=q0a8$kyoQNJIWx3QNNz5ujA=="] = "#=qA11p72vmgDsflBAAr0ZViw==",
                    ["#=qpjp2AOT3FS41L2gtAeYiU0Pq8Of1NdwL0MUTxPNQfbI="] = "#=qaRnSCNf4D26CUNNjCekbG77HH0nXcRxrvTddfscnJi8="
                }
            },
            ["#=q4qD7FM61ItTja0EPTlrb63r6ga_yHM4Ir5SdhMxQEOkU4BIqEwKdXzYSxQO26vnW"] = new TypeMapping()
            {
                typeName = "#=qSaOwmO77W5YbalAa4U5ojgNh2hlcPPCghgdGacqMG7xhSZj_hMVfhTFUodn0JQqm",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxkv8f2GEsnz86nAScntseg=="] = "#=qSYfGMzHgdrUs_cxPAHUcuw==",
                    ["#=qxGOWJSh$soQG3Sc8VC_cQ$GgxqJayuorLZrxGknj61E="] = "#=qEo25OREH0eZ0oYnYFlpyM_Lyq4zyXQhH97Ip8qVX4tY=",
                    ["#=q5QSH1C1ULvgadEsJqtDRdN$V$U00I73CseH3Wqb5PmM="] = "#=q49LUWRjYIxiDcBJmzXBI1SOeYSYpnoYpuXOnImrUvPE=",
                    ["#=qp6XZsjjLbtsnyvspmRSj$4p6cJ_mmp16bCXRAN4f1TQ="] = "#=qNumO0zsNEB6vUq2KjD6zlIY75ntXFW0Pd4V_fiQm6Xs=",
                    ["#=qP2yCkCZ5qFQGE2f7VgkxDUzbHkN7fk_xtPh69wzNoJI="] = "#=qbbZbDiNP6VhhNpcw82cBdCVAH5axqvrd7LSgAnejP10=",
                    ["#=qOaojNN9qchKxc5qs3aPTKQ=="] = "#=q8u0ea5yCqOMonyjQjI6SUw==",
                    ["#=qO$EjxrD2aKl_QBr5Fhb5jw=="] = "#=q1B_tYdfk9inaSMXJhVp3mA==",
                    ["#=qq0q8RBsKvug2t0sGQgL4f2rxDYY78t4P0Zbp10mHfyttgBe1RAdtlzAsPdpvjLVa"] = "#=q1shuZo5qb2mRXR1Rczc3xPAtViFn0TitD3oigtFhWcExi1uwTIc2v0j3QuPOJwD0"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qX9a1xfdpCCxd9h_7o132HLa1LDF28h_85B22P0B8blU="] = "#=qrQzPtQ4WcRMC3a1DcI07rHp6F5jrgtZhqjclt5oKVkQ=",
                    ["#=qsBI9keCp40iwRAL4yMqGFg=="] = "#=qItXoAmxgMNIdQysWRFFG6g==",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qh2N4nuF9LIF5yhRVm2X3A51lFwpvCRV1vWdfb5nE2bg="] = "#=q0gtVrX13AZrqyfQipbCr0n7PAeJwvOqAA9dqgf0Yx4I=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w=",
                    ["#=qIQeOaIN3irVlptmX_0cEoRDhCcBCv7z5dvfBvJD1A60="] = "#=qu2nWHsrwihI4wgq35QTcG8ubiprIz4SUkE_nQYTp2s8=",
                    ["#=qmRwo8BofkfN_AqDks7IeGw=="] = "#=q8iirplM9BLRe8QO_V55i6g==",
                    ["#=qbhUX4jTjxbxmg92EZ49muA=="] = "#=qq_GC4LRWNz1vDYSi7grIkA==",
                    ["#=qZMoJsyWjqkNIS39dni7wnQ=="] = "#=qYoS0OpOSyHzZ6Rdr9PhhMQ==",
                    ["#=qD0RDYcXYhksUisncYjYLLQ=="] = "#=qjQkkGslpFS0iQHHHcqiMzQ==",
                    ["#=qkZCUmBvZsvC3qjkBsEePOw=="] = "#=q_3rGpChZ2KYrv7vjCEFpDg==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw=="
                }
            },
            ["#=q4RAeLqefk0w3q$oeqxhinXOZYWv33b4ZCCIVOoWRn4fku8YIP6vonraGMK44s9iP"] = new TypeMapping()
            {
                typeName = "#=qyLz0bgZckBFXyGBhv85BGU857kA6GJP5NHeDsgIhqI1U993LVSBI6hvwrDjBcDT6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q4RAeLqefk0w3q$oeqxhinYZSrIJ4Kctx4vw7IhIDIxjiE4HkXtRfpV8TyiVhgxuF"] = new TypeMapping()
            {
                typeName = "#=q1E7lUiJAMH7q76gvSVqeQ4f95Dxa0xXnUaAThNSfb6x8pO9Xlm4pKsFSQBxYmszY",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["Invoke"] = "Invoke",
                    ["BeginInvoke"] = "BeginInvoke",
                    ["EndInvoke"] = "EndInvoke"
                }
            },
            ["#=q50Yq9Me1s2AJ5uIhhU6V4lraWdgGLyXTw28eWbPrhLcMyyxIinZa6Urcp2WHCq$Z"] = new TypeMapping()
            {
                typeName = "#=qvIdYQAvp$Ph5TX7Xd1ErSbXZcAZyt9qs$RJCmmUK68K8nyl0oacCmnx$GAi8vdq6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3Nzh_K93kArcGmd2HDlurw=="] = "#=qCx0mlGq1GxCwVXkHkf8XNA==",
                    ["#=qk_PDo$74Ml8$hYf2DCtj$Q=="] = "#=qrqfrqBH8AvIL4OE19VrExA==",
                    ["#=qj$7ctc_l8lJFlBXgEYlp_rh$sUtKyJB$86Eevhy3yFs="] = "#=qyF4b2fbIFBCIBG1Kk48P0sCbqH3NlqQddXTngcuIGt4=",
                    ["#=qZzEDLn39qw2lxJkBzXdFzQ=="] = "#=qqY6QeWtT9hC_n$$oINRudQ==",
                    ["#=qSYL_cJGOnSP7Y$CPRjnNzA=="] = "#=qSk_J9EeSXF_nyks3SEHcUQ==",
                    ["#=qY7CUccv1cgELRN4Oxg0$KQ=="] = "#=q14rT8C3du$WmN9zDj4C70A==",
                    ["#=qjKJUsnrWwgdOLCHSvnX3cw=="] = "#=qkh3BjloPF0$6AAuN6IRJTQ==",
                    ["#=q0N2YMnjKg2_vdae29jXJOQ=="] = "#=qhk4TZOY5P4zmTT$Hbj3N_A==",
                    ["#=q6jNOZZdAmsSMGVRZdAQ5VGqk_eAXjLCiHLtQqvivviy9J6bW_aDQ_NtIKmLbS9Hj"] = "#=qPc$byJ3NRWMTA0f9Wk99L3iv3bgcIzZZX3njDG8nwKH8NbBy4SnwtWhfeWn6m9FL",
                    ["#=q1J4Ikg2IFUkjTgq0S01fKz4FNBSMoHuwuWASsbz9TfFKt1ml4CobCCFQnQsSFWEu"] = "#=qgpyFA18LChCON9wSQjuUW3y2uAU4FdTci$8N7ujZsP6l9tmydJnzAYiOHA02mXGS",
                    ["#=qOwCcmx4b1V8emqFXYnRJCVh$3iWCLp4wYUMe_qzueG8XgRDxk_vZYf0cMdZW1osP"] = "#=qzELDO7ZQDf090iJ9KFHQ0_DlH1CxKV78stxnuURMCJv41o4v8RqLa2fSYGklPVSm"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J"] = "#=qdU9ONl7OzTiwqEhiiLIIW6k7u5XTMLHP4q2pu0HMMT0PhXadfwEAYtRzIAtuMGGm",
                    ["#=qdF7My9Z0ImSiDeMprbILuA=="] = "#=q$osW7SuAA99n7RqRDnYNow==",
                    ["#=qRlawHPiN44sgztbZacmMpIdNzGZuyjS1r1x7eM4vqLI="] = "#=q1muhmFS8uRZTkv$fzaFmgPBaLd1K73R8po7wBPAz9x0=",
                    ["#=qJh_TOjERTt$Cj5JUQGeYNg=="] = "#=qGwpMwLTanRulyjR$n5PT$Q==",
                    ["#=qsCgbdP1ml$7thpwlS2Z71A=="] = "#=q8r5PQ$e0y$Ju4O7QSfaQjA==",
                    ["#=qfbFzGXzedoWpPiQgC670Cw=="] = "#=qsVM__CboO8FR9Jbr9myjSg==",
                    ["#=qZPmYydp4nsUPaUfSYmgdYuYDOUYNxLFAAqsFSS$fbcU="] = "#=qElt5ZkwVj1Il7Bs9zKsnQlf1WBtZWBSvu70BwOqlE1g="
                },
                // added manually
                nestedTypeEquivalences = new Dictionary<string, TypeMapping>()
                {
                    ["#=q39ulrHCaIbRwWgaeMcWXyQ=="] = new TypeMapping()
                    {
                        typeName = "#=q4eOI3WBYc_UL4qZre9ugRw==",
                        fieldEquivalences = new Dictionary<string, string>()
                        {
                            ["#=qUCdShVP5cRtybGImHpYbVA=="] = "#=qqSr9h$VhhQ1Kc1fsJXxmig=="
                        }
                    }
                }
            },
            ["#=q5EVa_6qiWW78THvUYCxIaYivRLSKBZQ_fyFgAG9C3Ik="] = new TypeMapping()
            {
                typeName = "#=qQu0EDU1H7xrS0UHdhUeA2T7g4e8CXFJsL9JBgIuqa3k=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qla_FrBrg_Kmf6k6zymHOPO3NZ_Ezny7Jw1K7Ki2x8NU="] = "#=qD9hjC7HHttwFKO2MZrYMKxWY_VzwCuPFTco_XdqiVIg=",
                    ["#=qXfBCXU9Vj70t0yAekzIL1QzRXEI7Hq3brz6HFObOnWU="] = "#=qnJDPBJEOBxPBX$GIE6dOkwYvaRUH5$m1R2tFpDB2e48=",
                    ["#=qXgD66aITrpljU8WhJNsDFT8obntNrc5h6yUwMDsCQ_Y="] = "#=qbjPiZsG$vx6p$L6ix1wmToEPNEKX4tLIQ0pTXavS$oc=",
                    ["#=qzsKUygckEZ3OT_hRUrn4wW_Nme4Hm2sXWWGnWG5U8MY="] = "#=qFGZNVxzP37uC$o5EBFw1DwSbm32$sJ0DTs8FiFZVM8A=",
                    ["#=qkR8ivVRwPN2EsxpXOYllKiCN$tLGKUtPCGTUlbErMHE="] = "#=q_GBm_L1iKlyCYyEfQJWNGzejdl2vCPIvOSOKsuGLHv0=",
                    ["#=quGDeGK4PnlmAkv_aDpnRK20kcY9TVdaBydQxmkV2E70="] = "#=qdAfKkplIZwA9ckVd03164Fug06va2gGEeqtR1PyvIcc="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qV2H6Aam3IDo3KAvUuA4V$g=="] = "#=qM18L8eaqATYWRLWFX9EmHw==",
                    ["#=qlro_ZQfKNooAO8SFyI_2FA=="] = "#=qEOR_M1AL9pzkzktlBfiXnQ==",
                    ["#=q0f3M3DwfPTtfXCssfCy91Q=="] = "#=qiEAsDjkqc8RbLN2kV19DAw==",
                    ["#=qzQyEPz$468lM0mCH1NSk6Q=="] = "#=q5MJMhNwZauBpXdA4vtURrw==",
                    ["#=q8GIbz0KvhXnNXKYMYxZZCw=="] = "#=qrVnPMbmcxrI15ofXEnmw5w==",
                    ["#=q8ujUlrvrLcyHMjgNUwdvx7ULI9jYIq5sxC1WLv8PnQg="] = "#=qKg$hk_u5dTGKKFxgSNfLRLxLHbrLo729Aq9dFdiG$B0=",
                    ["#=qgpZoShbxplEbU_z_JdQZsjg5HvI47V3Fq8b_6dD1UT8="] = "#=qjuKIaKvx2LZ4oPhuw59t9TEM0Vr757THev0ho_H2jYA=",
                    ["#=qApuPsyTBoPWfrZxffqm$9w=="] = "#=q8GIbz0KvhXnNXKYMYxZZCw==",
                    ["#=qm5QhfoO4qA$jiYPRtMx83Q=="] = "#=q0$aSzRlx9j9jhIHKfz5qoQ=="
                }
            },
            ["#=q5qZ3hMgYMXSHEEOkEEprWQB6ikqnD02yc58E1wVmhvJ2Cy89MmNn4un1kQsULNG0"] = new TypeMapping()
            {
                typeName = "#=qwX4yQfcm4UvMHojKIw1qfLmWssQ$1dYwdvPAGyieP$nRXsDOXDc_lQut5rkc2j9Z",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkqtUwWZfxKMvW$0wkrSFzw=="] = "#=qN9iNqyOHV9AChfcPd2HMCQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qsqvw5r8ZWlC2S4$9kZ1Isw=="] = "#=q_ZGWsPiAYfaXmjh0MKZb$g==",
                    ["#=qbOkHnkKV9aKwxaP4P59bDg=="] = "#=q7lHeBwX0TiCWS$DbaslANA==",
                    ["#=qZuUKpnnvGUWzBt5hSSXloQ=="] = "#=q1pJzvnVkEdO5wu4EofrAqA=="
                }
            },
            ["#=q5T7X$VWyN5cPALVAz6lnIekcQamne$425YRvkYlLAsew_$gO4CIELGeC$QIZUFOY"] = new TypeMapping()
            {
                typeName = "#=qpgK8YBukoTxekUijWE$ZsVcppdh39nIpsVhCWvHuBfFz80D3Li0TUCtbjRds9_8Y",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=q5w2NmjJr0SO1Y61F1g2tRzKXjbKQABZ6HTg$VlPIIh5AMtgVFOVP5f9splCgY398"] = new TypeMapping()
            {
                typeName = "#=qN7eLW4_z$H06j75fsx1F2Nag9E3h9YbtQcJFdoHbGx6BQOCC3kbUaSpW4C_0WFac",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=q5y3FY6n4K4qD_zbNUoqw$C8oqPAt01KzbzJktIjIMt$fKwUqNJWJr$xFP4eJfQgk"] = new TypeMapping()
            {
                typeName = "#=qrZ3JJ73oeryHy9HKIn7spra_srBK$0uuE4ps5ktnBq7uOlGJDh$hi4iDZPSD6EG6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q63gHpxRhf2to$oAqCOiSt9GA72$1DCQUVAs6t35lpzo="] = new TypeMapping()
            {
                typeName = "#=qKr4F7vwxa_735G_zt4PADCAFoeXVS21EMUAC0VTpjc4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=q6gq0cQEss_n1aOJJVScsFj6YhxxWOXQgYd9hJoarlag="] = new TypeMapping()
            {
                typeName = "#=qCD74eH94lqwCcQMZ3bvFgwGRh_sXOGMonMgXub5ixck=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qfgXSWHHyARM7uAsa_DgfjQ=="] = "#=qcv4vf9xCtYMmUwco8tTzgg==",
                    ["#=q77OEYHhS8kDl8vKOCAM0GA=="] = "#=qnr65c8amN_XeNQHo2C$_sA==",
                    ["#=qL$8T8Sx3_Ec06TF_9r_hng=="] = "#=qTYpwLpGQu1gNx8vggfPfrg==",
                    ["#=qTPmH9di$qQOZZXZVXOptarU5eASwx51s0Wf2y3hGjP0="] = "#=qjVtK9IpLqE2mY107$wfolk_psTQRBAuagGXMmYZHwJw=",
                    ["#=qSJQ4Vhz9NCJgbUC4Ubz1Og=="] = "#=qPlb3G07nqV9M94Wk$I3Uaw==",
                    ["#=qTi906m0U$DHtFOoegjuhD3LC3uESJWtXnzSD1c3TlxhEojSiFZfs6FuGNxSXwSc6"] = "#=qzyzjuPcZHQvqXiJAAQJiRCfDvGjPEEeU9eDZrb2g4QlJgSTmmJJLAkHinaORCsgW"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qN_twrebll3l9JJRnT_kSRg=="] = "#=qzvB6ECVZuXraHarECGOxGw==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qtTE9gKc9eUDESTmJjbpwoZTh66SUvmCAgL_hOoOP_Us="] = "#=qmm5j8nh7GIkheU48W42UOfEpj01JPN1z7ZWnbwDx6_E=",
                    ["#=qFlZOXZZEvrINeKxL1uI98tU6IxAlL2g8bhj6JVsJrXM="] = "#=qnHVnwhy7ktQaVoHgspAikA0CQbc8hfJ1jYPkCvIwVgE=",
                    ["#=qS_VJd93o4E9$$$ZC2KQtu2pPAqgKdVjV6AVtO$xPq5k="] = "#=qF7G6$6nKCwA$FP_wZAhyvFVmA46HpMjbmo_xRt5f7f4=",
                    ["#=qLGIzQkYXWHfiiuwhk10P6O6v1zq9JFw50H4lwklmcVk="] = "#=qmU6NMWEBH_nIXcPeI$suP$NMlCnvls2DKRqBjs5K_0k="
                }
            },
            ["#=q6LuOO0mn6Dnnb0uSbunfd8q6uwX_zr1$Snj15$thTU3oIwB82JWzCIfvGh5gxIEf"] = new TypeMapping()
            {
                typeName = "#=q_DsP87Ukgrh15snJJ12a8kQGfBkVD6nRfEPCH4bMt4NdMsXlLyqu6LSiewbhLmlu",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0LgrCUZlCvXGSpK8CYks1A=="] = "#=qBhk5RkNyAmaq_UrcSkj6zA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ=="
                }
            },
            ["#=q6qiR6uabiQfRuOgF9X64HE6OlrAKtA7JtCSVmJwBtRA="] = new TypeMapping()
            {
                typeName = "#=qwzZohC1vr4SOqAkn2a_Tg8r8gHgQCLfD5ZD6Ld$og9k=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qYZaT6bzQY60bKiYSp1w$6w=="] = "#=qxscTPjAPNr_r7q4aGGrAWw==",
                    ["#=qan1wFuWxzv4rO$W9J_lABw=="] = "#=qzJ$jAW_rdjeANrU2xqYthw==",
                    ["#=qGQmc4glERqYaAtfRJufpFA=="] = "#=qiwnj30E6$3dhP788A7wqBA==",
                    ["#=qvRkjpgLjSn3AOkAwdzZTHw=="] = "#=q3$MSTSjxzqXCfF4xNVvNww=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q6vqqs8pvDxI3_vCzeeJuzaYsuiPmEynS$IKB1XK4ZRA="] = new TypeMapping()
            {
                typeName = "#=qrRrQ$i54YvwYGn9BOF7N9Wwa7gKVWC2DA0xN8hptCKM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q5QhNOHmk0QaV$TjL1vnCew=="] = "#=qJggV914E9xriluVBqXNfdQ==",
                    ["#=qWnabsMzAb8y2gBwmWONd8A=="] = "#=qRhTQGmN$5ou0crZAMWQpBw==",
                    ["#=qmL8SAAy8$QqkSKsnFKm2rrf5MS$6Arjfs9J$ijQ5FHY="] = "#=qVvELc5u1E5FxUAeXs$ZjRDuYWl_xt5GoGtdJ709XPjE=",
                    ["#=qraLi1cHHrIieWGoAzwVO2w=="] = "#=qZuOFSpuEdHfiAIem_8JneA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qZyLBBvNGoDROu08MSKBrrw=="] = "#=qiCHDJ7CU90p97rjK64g48w==",
                    ["#=qS98Fr7wSyrIJyTDxaHukaA=="] = "#=qkc1pC9lieoLRFcpu0gcwxQ==",
                    ["#=qJcUngnqJYCRteDC1XeBrIA=="] = "#=qCDzArzDdDg$WdoIdohdhSQ==",
                    ["#=qTWc2ZtM7bPs8$zNvSO6aag=="] = "#=qPYAIbUiAboHoNrxSgu4BBw==",
                    ["#=q$yFTYB3SUa8iy6tRD6x8zg=="] = "#=qDIXh41e$Q2CFGupm$2$QfQ==",
                    ["#=qFnX9MXksrS68SnPAzll7bw=="] = "#=qw_ZSz$iFJxLp4kVwrtHxkQ==",
                    ["#=qijlqnIWbUUfMFmJFZ1JxUA=="] = "#=qckQb1OEo6AH$GBDeKcJgCQ==",
                    ["#=qijlqnIWbUUfMFmJFZ1JxUA=="] = "#=qOdIm8QrpvQrmHWXsZ7glKA==",
                    ["#=qryFbP16_h9wKYp9iONXV6A=="] = "#=qjvF7jVKbwEw9xayd$NC6PQ==",
                    ["#=q7fgsuzfL_Kv5TaGp85$iIBR2ZeY_L48i$KXNEpxy$T4="] = "#=qxoIvfVdB_bnEdb2BZtuAiTmzwrVO5lZ89mZdMfMK_$8="
                }
            },
            ["#=q7b2JFOlBzt3tDA9fc2pZ45HDnjG4s$uuPBN1Nlf5zVI="] = new TypeMapping()
            {
                typeName = "#=qPn4Q7JFXNw12lklD8tbid98NlQrnGMsvDvsIuAqIlyc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qo8VkjPEAyqmgF3oJUawTHIq_tH_3CR0oSX$DGGjH_k0="] = "#=q$zJkYMCySZbme7KxitRXfFkR_04AMWd28pHJLfDvwaw=",
                    ["#=qxj3DWpn7QHRTZoEaIvC2Eyn6qq46c5xI7bpg56wvrHg="] = "#=qVd_S$LJBtunip6GG2ZqzeLoyZjd8rO0NFR_VbITScoM=",
                    ["#=qKBMiWME8SZzoBsZ8bKPIWuv1T3Wnt56A1RAhLk2CcAU="] = "#=qv8KrdFlPM7u7T$9Ng8Eb5rkdAFNf6iK7667tFuxkPSE=",
                    ["#=qm09kE5f15oOkpKAkz_bKDDc0MJI2plXlvTQtYr5uPs4="] = "#=qo8VkjPEAyqmgF3oJUawTHA5NOENsdOi93ejGEf5rBcw=",
                    ["#=qo8VkjPEAyqmgF3oJUawTHEHreSggUytuWSDCGaEfDU7qTW1OcMd5IBzT8Tr_qODR"] = "#=qalYcfuRuYrH$Yh2jH4Y9FX9PBBEOGekRDD$xKoorKLe$WQa7d_wZzNNMpm6h7Ly7"
                }
            },
            ["#=q7Ec1Bm1UiS9Pfg8tqkM1ksiwIZGSXGN7MpuM4VtNhJ_H$$GzrJb5wykq3NrAigLF"] = new TypeMapping()
            {
                typeName = "#=q914aR34eW9cV7cgl56DWp42WWzMP_u$tWpYxkwFZvZa_17JpZ5uPwnj8wMaqB5CD",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7ECsLhkszqEH7Tm5OxEUArtC8MZUCOeHqTC38rKi8sg="] = new TypeMapping()
            {
                typeName = "#=qvq$cNwgswhuE3hS56DO8lr_BujG0sZELwL0D5GezVBo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkV$1qjNGjF7OqRVLBLzoVw=="] = "#=q5eXyzch38LDGHtzJgL_2EA==",
                    ["#=qDj1C3DUi2LnGtVVN$Wbcgw=="] = "#=q62nl1ZlknczEg6C36_ucPw==",
                    ["#=qLZkLXIrjbu4lUJZVaXjUng=="] = "#=qY5delHcqqDO8vx74yd$vag==",
                    ["#=qfdCNnoIW61jBRGZ4U4CmXQ=="] = "#=qJDrkJIMrsCish7u4Nhdqfw==",
                    ["#=qn1qSvx9G6$nJwfnFmQOwnZAvzt269tEaw_0nQudww$s="] = "#=qaBvVHJ8sc9MKn3iVp9X885Eda5k46RJro0$8P6VuPII="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc="
                }
            },
            ["#=q7lodS1stZhirINriZpKo6fIWFeMLmoMegyX4hl7kDW4="] = new TypeMapping()
            {
                typeName = "#=q0FvOIVOJ1Kvxk_BfdaVsEAoTFF5GNbvg3rptNlnrnXc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7OX0pHnuInNBXcut6IYEQpGwiAyuXl3$KihgXj4I99w="] = new TypeMapping()
            {
                typeName = "#=qmCwViJiTFNoWY3QfmmdNVY2ThYzZPqbS5ych8dLuUAY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8$0eDxPAmAwlPvAJZ$nSTVR2KZfkEBYkM36y_rRo3NU="] = "#=qJmc3r9TuXJa7$anATdrKYSuN7KEDKO3v7VEB471ir7c=",
                    ["#=qkadf7h1lg0kjwT3ShDDEbA=="] = "#=qNZ8bVGRW0i5wDhgD8U4TDg==",
                    ["#=quGQCVp3AOgfQU9SMAGWFCw=="] = "#=qtTGpt6AiQ58Y9pj61hgmaQ==",
                    ["#=qrqgYBgmRJrP$efam20a7ZUJylX_LwHm7i2aBlOCIMuA="] = "#=qfrTMnvIbXwdJgTRTdJF5lOHr$omvv8vAq3oSEgrymtY=",
                    ["#=qkXOxb073dCttkunVKBd5YQ=="] = "#=qHbcIIItlc0cSwt1_KLdRVw==",
                    ["#=qjc7tv$LKIpBTLpzJXxvWgQ=="] = "#=qTvRSpbVocUcqHEOEN8d3Xg==",
                    ["#=qbGUm2TCIuLfOwISiGLna3w=="] = "#=qsDDVD$Ys73NC9FqCc4ryGg==",
                    ["#=qWe_OXM$ax0BYdQAanySzY0v$6jSGSvvFfqr8$AuC7Ts="] = "#=quSfkhtCHnVbe9pr$0xaqMHCk756jM14MLnykHCPfE8o=",
                    ["#=q7S9Ide2uIqD49hJ0nThU_g=="] = "#=q8thRaU7QJjWZJgt88QY3Ig==",
                    ["#=q241IAPD185UjVaLPwa0E9Jg_Vc_VQYl4WOLqa5q3hrc="] = "#=q9MutMw9us2Ow5Bn1h_zGnMaUjjjmizExVXIH9YGMxJg=",
                    ["#=q$K5o9xKJj2a01oWzbkS2xKUBGs$6XlHI7GVtFJzX0eY="] = "#=qdnv9OZUO$Ng1O5xgiSiapp3zxhkQBOcB2RGm73iRcb0=",
                    ["#=qftWQbq$dGMiNkiggylSo2q0NphzVUze9zbzBfERYp4w="] = "#=q07Dg0SQ$T_sjmUClqbgtkSTaaggZwa4DWHmzDGDQR_I=",
                    ["#=q1QM9sW4ZagEga9XOiL_aUJwVD$pqAPDSmme1w0zI31o="] = "#=qZLUoTA2eu6AoSOYhh745KH71HfUJ6odlAXnVy4lQkkc=",
                    ["#=qwaV$NyCCRr4G_1l35npb6d_sIH0$5nDsAGUo4Pjim4Q="] = "#=qYNsA6o_iU32mXVcHup3Msl6YbvTD7odXfmK4$dgMpQc=",
                    ["#=qIdEXAB3j_MxqprV8j04xXWgMkr6bcHKoKezqalw5RM2JdtGHSnK34tdLZohHT0lU"] = "#=q7wE5Ffer63JNOCtvo8n3lxXLQhzHDHC6LguO8KLEDTziCkn$gJfdJIZYx5HbsWWy"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=q0S4BVh0b5pBer4KXNMY2uRD0eb$mnB1M3vogdcV_Eok="] = "#=qPH30UbLNyD7bI4uRXJw0Bogdq1Yz4TqI4IxFhFxBE0M=",
                    ["#=q_qilizN6_P1$f4VPOol678UZfrMa1VCZheiW$zVSkuw="] = "#=qiVO0jdGuW2Xc0jhKmFWvZDMej98pghCGlHSccBI2jsw=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qm3ojxOUgizHHi8xL1QdD$w=="] = "#=qabG6IdQ9osDqpyxrAnXnUw==",
                    ["#=q9kQqRYYJDDc619EwEi8Fsp2IcoQeEwql3bn7O7Nyu3E="] = "#=qEeVK0bZf139Lyicxb2iPSeno3EwbD9BlChBYdSPvOSU=",
                    ["#=qXAXMTKVtzdYtMPSYPPzYDg=="] = "#=qtWkyXVAXNzkh3CrbG0mHdg==",
                    ["#=qtSDphkwyL4Qc1Wfbh7pR3S8uMAHRn4j9Ehi53WGULG0="] = "#=qgR5CcYDWwXef3Pf5uDeYa30r83bpFQMpBatcdbRP10k=",
                    ["#=qQgcyFc03_iZ1Ocz4ZjG2qGOuBCNIWoOvxtAZVyn8fTQ="] = "#=qzotSQp$I_24wDEwuXfzr0tXSe9Tu$tu2MtkZHKJkYaM=",
                    ["#=qccJ9cNF3GucYBcfNhfJ72$vtZaaVZoc6h9hAcnwjQhk="] = "#=qoz0NjJwsvRFD7_dheC0yl85miXvrHJDtNuQ9sg8APoE=",
                    ["#=qNtRTFmcznljPnMJ$4giQAPnrk_r1eSGrFim4z7lyAVc="] = "#=qJ5Genf1V2QymsBnZyKQqBWmsi6RHb_$JeDCxLAfGX4I=",
                    ["#=qRxKcOz2_e1dr2zxdAgodO1IyzPuk0lyM4L14qBT1ysU="] = "#=qbjsSwotxspju42lr0s9e$oOFm5c5phNoTxduMo3vCFE=",
                    ["#=qkZZs4LpeLO1lD3w0zGQGcArsNg1SsKV69Rd9HW9tZ3c="] = "#=q852GDObtgAzOJ6rgMdL5DUUntsV73EYFNF9LFPhtUAE=",
                    ["#=qjg$6jdHxd74Iq_SIC1hhCwGCA2Fyj$u9csroAypfboY="] = "#=qOqiShxk$AZqWwRqHq$GXCwpIMGKVOlQ6TxNCOtecdR4=",
                    ["#=qNeEzmMk$zBFel1kmyZ8oC6uN38rVQNgPRVxw9WSkLQg="] = "#=qmx09K1ze50i0rtPeFt$LTxQcLDlaA30UvkmOLl$Gv08=",
                    ["#=qE$IU7AJzFGmPWNWWRxmPzoYy57fv6PPhSTXxy4ayHao="] = "#=qCBPYlTEkGQXMZmLAAbpT4Xbc9HVTiuP70PrLMGwLDwk=",
                    ["#=qzHhfvxGn64KpIARPVV9B9C$Gsjy$uxETnlk8rYFpm5E="] = "#=qaenlYvgfbJNLTe3yQnQ60xQD2z9C4zxEPFyzCKx8pIs=",
                    ["#=qQN$d_m6kZPh0Ci5f0rivei66lRxC1l5qE9$HHo7vSZs="] = "#=qc2AQeK3pestkB4UzS5sR4oMqUY7cl8s9p$nRrtEEscI=",
                    ["#=qfvO_2kuh_9vR5LROMhtX8d7DKSXL8l$WS8Acf6eL7Ac="] = "#=qsJZWFwZhcps1b2$2pLCm5zNqPK_rIxQ2IQxi2SDlk6w=",
                    ["#=qPD1M5CBCvcU5FKdUnIy5wWKGDJ6HcBZd9Z$DIGGUVzQ="] = "#=q_MStLsKAo7mbrn30VzS7nHxOhud_r0iC3jfy_XBGYZ4=",
                    ["#=qvfsk4DNdj9vXgKdeeJDa$6LScJ1i07o69lDdPgjjFQs="] = "#=qJ7YGSBDqtPOMN5I$OBOUfqjcriBtlp6jAuzsTJonQSI=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=q8iqubh91TOoJOGXHSb3UaRjEUs1QCDEpZg0MVPPvqzw="] = "#=qfmJNts9KlMs3LHUIg$2yy13o1OG1qTWTCWl91ESCl9k="
                }
            },
            ["#=q7SGKtt8hlQekf5qeuTNigYVg3bdC6eJF3U9uMhUM2Am7S7rruIO2edhqWERoETHp"] = new TypeMapping()
            {
                typeName = "#=q7$38X59HCaas0hKHFasdiKxjGJlQrGxp7u4tc6nswe3jBHEZWqOHlHlJpl3nG9sA",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7sHe_EVdzoc7rEBDLG1m8jM1dyCb7lzwO9T9YqIANhRH9$AfT2gzROGUDr5ee_Rp"] = new TypeMapping()
            {
                typeName = "#=qDtNO7y_DRVkQpcWjGhLXRkGo2pzOsFU9FJhDo8N$G6KIf2_VGGkU8eyM6WfzN1UX",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7sHe_EVdzoc7rEBDLG1m8rRfrJGX58CPgOqAg$rKT3YkWUu60Fov16tTC4aTnAm3"] = new TypeMapping()
            {
                typeName = "#=qngsS4UAva_xkQobrpNdpx95Bx_5MoGbyTHGAaSO3GWgh6x1vBDkp64tzJWwb$ajm",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7sqO$xivb4AG7z1ssMCQdh_bbCczqS7seiY_zWwOMFQ="] = new TypeMapping()
            {
                typeName = "#=qWA23pZEYrviniEkvPjiTinkEMzTuFLBL71ZJ0p9ozd8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=q67Wv9ziCmz1uxPRiBO1Ftw=="] = "#=qx8SSmiUOQs5zDUQZS$HjFw=="
                }
            },
            ["#=q7VUnXPoBpq9cTix1BH60jEY_dGqz_gdZ4tbbmJfmBdA_RJ8Pu_X3sXyqXSkK7Sch"] = new TypeMapping()
            {
                typeName = "#=qgtjiEe7sUqmafq$tAVXakuCzNbUoetVwb9voCyOqPsoPkvk_BiQ9n2MEUwPMv2PR",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q7YXkeis_Hw_OD2w_VNsHg4bPBs4059$LQRgQRLxoE1c="] = new TypeMapping()
            {
                typeName = "#=qrermwqtwggUzLc9pNf7gpViZNY6Yq19zgfRs3frlX2E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=q86KkTrYS4$VROwOOpOybMVYF1jYMws_YPX2ehxURPgcU08_HZBOoHrmEmPgCs6Ay"] = new TypeMapping()
            {
                typeName = "#=qW90LWmkllqQTD5EM4EMSNhPtIO67DglFn2mhvP49owXbgIWggmOUOCPZAl6Q1Hlb",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9h3tFWhp54Odb3Z6rT2dMA=="] = "#=q73Vk1gfIp3ekllWeuXrNeA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qJh_TOjERTt$Cj5JUQGeYNg=="] = "#=qGwpMwLTanRulyjR$n5PT$Q==",
                    ["#=ql5AQNs_XDb2XpOqteD6_xw=="] = "#=q3vypAHZkdNGdtX7c$7fdkA==",
                    ["#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J"] = "#=qdU9ONl7OzTiwqEhiiLIIW6k7u5XTMLHP4q2pu0HMMT0PhXadfwEAYtRzIAtuMGGm",
                    ["#=qdF7My9Z0ImSiDeMprbILuA=="] = "#=q$osW7SuAA99n7RqRDnYNow==",
                    ["#=qRlawHPiN44sgztbZacmMpIdNzGZuyjS1r1x7eM4vqLI="] = "#=q1muhmFS8uRZTkv$fzaFmgPBaLd1K73R8po7wBPAz9x0="
                }
            },
            ["#=q8EV5FN_h8uf1u0$uMpaHuNioEK10D5KRt2VDOjrAGGo="] = new TypeMapping()
            {
                typeName = "#=qSn1zUchuXYGpjr996HJb_YqEmTEnx75DOPUa7VQKY2g=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiWapjzj9R1AEfwiUVs1u4w=="] = "#=qSVer_aEmHT2gzJ9j2aJ65Q==",
                    ["#=qfegiEfELKRpVNdaidbvQMQ=="] = "#=qDcrqBpKAX$6qLcd0uDCNkg==",
                    ["#=q5V9HfjeBOAC670KDHVVeJA=="] = "#=qjzNoRSwhfuf2XCY_S2dYCw==",
                    ["#=qucQQ6NxPxWLbD1mc9aoBOw=="] = "#=qnGJZSWhoNOdY93$x_RR9Zw==",
                    ["#=qpCMH5rDtEVKS4sroohgq1g=="] = "#=qRsYf3N_HFsQkvaIKRlSrPQ==",
                    ["#=qPXC7$MGsDYqO$vyyyikCGQ=="] = "#=qTRsGiPSt9qS$uthQ43$Zow==",
                    ["#=qEWtx84ndVnzqkV_6qcVDcA=="] = "#=qW8CSAXjSRH86r$XMzNb2FQ==",
                    ["#=qRR3jhMQ2YzW3uoKqGDdohQ=="] = "#=qUHrPs_3ktaBXnJjW$3d2YA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qktCs3i1rO9FA2gX4HHpOEw=="] = "#=qAJCTlnIUzCH8hFd_3s8lqg==",
                    ["#=qz4xTDb3BgVudZIFakckbcA=="] = "#=qM$VeUP1fcSxj$ZkPDIVzoQ==",
                    ["#=q8KlCfoGWfThIPDcsdRKczw=="] = "#=qHC2P_f7VF2yXnbxqLbLeCA==",
                    ["Dispose"] = "Dispose",
                    ["#=qUpuWQHEzxJYQYp0p$oBQf8bnPMHijRjuCXtQs8R0WTsIOidW9od48t5D8mGjeAm9"] = "#=qb6d_WRvyG8hlZeey4Fnqwp7f0jQfzH3tmR_1EP029wbvBc4oFDxVNTpwA80KD$bK",
                    ["GetEnumerator"] = "GetEnumerator"
                }
            },
            ["#=q8Is8RtfrAzqsMWBLpfh4XewZnZ285kIdE5Zote6JdoCJJ6fdL8gXhqVPW9IX7qNH"] = new TypeMapping()
            {
                typeName = "#=qLfsE46_I3bOLizv6EYAfek9Avsy0sRMXyQfPtmeyWyI659CHiG9qwSXcAJAG1AYh",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qa6C4hhWcgGsddlkqS$Nlog=="] = "#=qUKsMCu547pkuEbZw2JLWEQ==",
                    ["#=qAh8mm8vj65_AFSbLhxu$2fvMvlqDSDPiE$_DmLCQmJNOF9P6UXrepDpdt7e1Shy4"] = "#=q4TCP9VVxWi1Ubo2EWeJPe0kwz4XV$umur0Jz2$jkY90oMlRBiqAMonF2PFw2pyPo",
                    ["#=qMj7OvsJ1X3Igt34MsrgsyrS8gfKxfvDHtsnoXRSA6bSY4qM1PgrwmRhkiQDzO7KU"] = "#=qU1ssvtk$leEsQwmy8XTvZJtViCYsMaBEnn0eSIYi$bYpx7j_m6Wor8NK5TVBtZpz",
                    ["#=qzyzjuPcZHQvqXiJAAQJiRCfDvGjPEEeU9eDZrb2g4Qli6un6Xl_Z_FwDi79N0NeP"] = "#=qv36bjNy3i3nLv6gGnHcV_sGblMBZSKynRTJmsvzJVbtLF0Aojpp4CMSMTp8P9YTp"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qEtjlz3zhDimmOLQggy3aoMdrLGhgwJr5DrgcOCt_sCg="] = "#=qKzdeQyO94snSKCWKWMHJnZNFTp9UBEd3G9S3r2XAS40=",
                    ["#=qr4gE7dI5ytu_UglfSJT$oXGmYu7QfY4htab7IymZbA0="] = "#=qj4hv$$cnCPXy1a$lqD_A5jm63M2jMKjeAh2EbhMtvro=",
                    ["#=qpXZrRg3pbRvZKTNHjn4eFg=="] = "#=qx_oxV5eYpKGOCN$y_BbG7Q==",
                    ["#=qO6YNmvZicLYfm0LiCSgZAg=="] = "#=qCJDc$_64nHbQxKDiSQxBMw==",
                    ["#=qLDn3xZhJ904LspKaLitj3g=="] = "#=qj$nkFlTGzRxKvC4e_U2BgQ==",
                    ["#=qhuLH3W6G8OouJ4C7pmV0hA=="] = "#=q4ZFHCzDSI4Cs93VJS$xPLg==",
                    ["#=qvK9ndBUUNWnaFx_sppBtcQ=="] = "#=qyoymaVBeGkX2lkbfQbdRkQ==",
                    ["#=qk8T8cCw4CgzrDF6t_Nqw2A=="] = "#=qxCGa43s3hln0GQMG3aUUig==",
                    ["#=qVFmwwM350JyO0Lk0WI1vhA=="] = "#=q19gixo56UuPL1qlqcHcR_g=="
                }
            },
            ["#=q8q1F_MKieQnak0BE$HFx_QzjPmBAKu9MYpjFU8q4werMVNa0RDIeAoE3TRZ$DVySxPeCPIz2h5ScTS7u1HfCwg=="] = new TypeMapping()
            {
                typeName = "#=qHfLyKpmpzQuL5H1SaAXf1ejqNl3Vn8hHHfq85YVYnKcp78rknYzTECKHKkYau7U4eN29uXEYm_g6M0uK_YCu6Q==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=q8rmpJZvNxhaITlmB7d9v_FIQeiBuS19Xr1kItLXtVb4="] = new TypeMapping()
            {
                typeName = "#=q3yoUbf70yP3ABJ7DcNjc7sJzlrit$5RpbDl4TM50J0E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8q45TYJz8ZaKCvrTFU5qt$i_4LYmylTH68jhq1XBqKg="] = "#=qSFeJgeeLZEYrhyRGMPwGph6jao0iT_Y6$KOOhaNzHwo=",
                    ["#=qQpRkG15pURuOuh_V7EymsvcTE5ukYzsk9D13RQyQgXQ="] = "#=qWdeXYpQQHOBEDlNu8kG1$ADkr5_wk4DYrxnb6uccGtY=",
                    ["#=qpFSAJdNATBmPA_I71FHCWStMnrSw7NImp5TPd52up8s="] = "#=qyD6vKshkygv$6q9aPC7Mti_mVLMFS8eShhbE6XVKOlQ=",
                    ["#=quuFXbwYJ1NLynjpK_jLJNzOn0sHeRFBosELBGzdeWik="] = "#=qYYZnoSZk9yiDdrHfxuGHeSzt7Z$CTxSwZCYJSkQX2ec=",
                    ["#=qi8HpAYz34TWtN1heJxEE2Q=="] = "#=qWOs1UAp5xjmA$pqUd6Ainw==",
                    ["#=qSKYGJ9W02Os3PxQ_faCN6w=="] = "#=qc8a6teMXWenaASvzdqtPzQ==",
                    ["#=qzG4bLdLb0PkP5YgEkHTlvkCPFjZuVJxZxlczmNfOYF4="] = "#=qWifpBmRS14OPv_eJAUCIcoGRJjycnEq9ionIBheWYkI=",
                    ["#=qJj_6s35rmN7NdOfYllMI2A=="] = "#=qu0$pXF$fDLXR6lqV$_2ohw==",
                    ["#=qST6ZE1Vlv3xAwFBe9HRQOQ=="] = "#=qjlADefJB5k_wAyN8PiOb1w==",
                    ["#=q9IMJg3pHPUUomEm7HZ1UgQ=="] = "#=qUM3YaUnsfyoelgv8is21Zw==",
                    ["#=qXwHasBEgEIUaSUZbU99tWg=="] = "#=qEd2DHyfe0dBYvEHuctM9cQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qimk11ClI$gAF1x9d26jrs8FaEsHlEODSc$zAMzu6A6k="] = "#=qTZwLhDruwYBegsK7CHH0$E24WZBYWhulwecvhVN6Nkw=",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qqXOuwLDlt7vPOUgrKw8KiAPhouyzdg$2MuGb_MRIi4k="] = "#=qPuPcmJ7_qVGHy0eP6MvS5Hru3Sx_epdYlpn5YHFwTpk=",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qrL$Z58SCnkb70u8_vpOmnzcLDKvwRUYbBn4_1lcOa4Y="] = "#=qc7_hLc5Pc4rL8YLn4EOgNN$CUND7H134ZY$p69C8Yn8=",
                    ["#=qwq7J2SGXwkqEiUGVyWHvew=="] = "#=qcSowUDH4xMT7HQTxpI0lxw==",
                    ["#=qwSjhDvwd52WJdnC8EG1uLjUkDZfhPodlut_T8MkSiDo="] = "#=qYKHi_xwoal$qdNcn$$Qjwk4u2viTQ3SWielaZ8epAw0=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY="
                }
            },
            ["#=q8tzotdVhGl$Mla05WWe_XjrOECPdKEk2S_etLV7PXh093s5aAwlzgfzWTUXp4DPJ"] = new TypeMapping()
            {
                typeName = "#=q9Rts$AbCmHNufje36uuclyITS9CoQqqFdbF2_EHotM3LEW8zUNJt$9_hy_UDWZiu",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qrsSTBIGprAJs6kw7WSANJw=="] = "#=qrw1v_$4$o4bN0uKwiPnMTQ==",
                    ["#=qFCeWQNMdgI2b$RlhiYa6ZQ=="] = "#=q7aYzCgt7ixLQh4ZPOfBQrA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qhpfW_b$5WDWJFRSrvwSr5Q=="] = "#=qzEljcNisX98SkVvlVGBg2A==",
                    ["#=qx$YVf$zgcxhB50xK8Nefzw=="] = "#=qqkTzYICKsnH0qTFGZp5yrA==",
                    ["#=qRxokpbJ0gb94DKjaMRlVcg=="] = "#=qb9gWdbIO8grbCCCeE$YbXA==",
                    ["#=qfNAEG8yyL$WjBj_8ufCbeg=="] = "#=qe2UgXik9AzUO6XhrAwgkGg==",
                    ["#=qy24V1hnVE2JNuRDF$XP$pQ=="] = "#=qesN84Ue6Hu7_TY3K4OA2iA=="
                }
            },
            ["#=q8UijvfSphufwYD2R3BO2PJuVJv$1W1i0iZNvDzTG1j5SoHrRdelhsLg8zEJLJBWn"] = new TypeMapping()
            {
                typeName = "#=qcutHm3NPxnG9wTyCnrK$cYWwrSv6nYfoj7YcGfzJ9Gx9CZ8SMJkDpdksPeDumFfZ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q6yDZKTT8Qs_$b8mchlxbFw=="] = "#=qyzTJdjTZXmIWqh2HZL4CPA==",
                    ["#=qVVneXbeOZMG2$7YUVN8WPtzzh_AlVL2L0l8ObZWOllo="] = "#=qSZw6k4YvSv6oVFnCS7A1I0tUyKEnxM4I4WwYHi5mcJs=",
                    ["#=qoiRIRHj130$WiQqti5bfhg=="] = "#=qaQYraT$D6jkVykTgTlafww==",
                    ["#=qAZ3wxzAm7CT_xK$KXVch5ec3u82k2X1BCLogND9Nmaf2Iik07tVpAHU6JV3UfYxO"] = "#=q$YJrKuz247yAm0YSfxwMDQ0hMwvmNFSw3Ybgx0OgvSXP6ZQsDEJQKwzeLYsa0hZO",
                    ["#=qQsxMYHbpI4_ZV3Fp4uilnUSkm98G4EQkWMdsFkZJASYsrhGaQmc7uJBk941k6Spq"] = "#=qyBO8LIGdn7WroMT40X5SxYagRdOCLnp94hPfS2C25nep2W$AU4_YxBVuEz3FNrAZ",
                    ["#=qoHAbMPVAG00Qp2J0NsFkckbiyflJSk5FXKgtKpa956yLWNxmfY3vOz5IrIjah18n"] = "#=qa869FW$dxJonNlDY7WmEUX6XD76HwJGJhBB5BnNcRbocZoXJMXiaeXciNQfQnlgO"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qi3XsuF5R51X8YxetgXXe$Q=="] = "#=qzJbD28a10QBpDJVWDDnU2w==",
                    ["#=qTHAs5JQuyGOHTQPTjOq7Sw=="] = "#=qOfrQoA$BYNUouiR7zUxDuA==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qjE8OP7jdAKfyxX4bys5ZIufInHBfRRxOQyot1$Xof4I="] = "#=qZ1HsCQv1nhJFljXkCM00l8A4mPlfC1JIkSn9DTiGXTM=",
                    ["#=q0PT76AffEUl9t2fQ5iAuXQ=="] = "#=qZrc2boTEPIKoHo7rmAVwTg==",
                    ["#=qCtXAiTKEgk9Rqpi8y1MFqw=="] = "#=qnFoMIibcO7s5kIh1ktxxLQ==",
                    ["#=qgM33x3_h6kKzfX2dXct9Gg=="] = "#=qyMgn$sGmqQ5f6OCBPoEvyQ=="
                }
            },
            ["#=q8v522zT6VJ1p8oxd37lIiIlW9p9B_MxRvdDIrno3LKTKpK7T3m8rTkvsRKIz5wvn"] = new TypeMapping()
            {
                typeName = "#=qIumR21CjuCp9_5LJMIr18AF9mnarg4LyjRLcvn4hXGKu3k5mrdL60Hh73Q2tTMaz",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qI7fAPDUieEeWz03Rgzkd3A=="] = "#=q5jSO2WCaygiF7Mg$VXHMmA=="
                }
            },
            ["#=q92hEbMwWJAHBnI1OOFNVMfgZTZcBdcobiluEchpymk8="] = new TypeMapping()
            {
                typeName = "#=qA6TfUKriQlRJ6lv8gci67$h7C78N8gNhGhM$3K3nT6U=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qIz59GTKDm_$F_hiCiUKCyA=="] = "#=qunW9eysIE8poICs9Lnr5EA==",
                    ["#=qFMqFZ5P7ocjuWNHWSwZFXg=="] = "#=qZtKIR5c2ZacooAQF_0IiPQ==",
                    ["#=qTnSSo5p_mdB5gxWMBu08Xg=="] = "#=qWMbarZpYxVC$sLwdtfRJWg==",
                    ["#=q81GjBpGiK_G$swk1dvKbiQ=="] = "#=qBxwI6t2I5GPtJyNQiho4nw==",
                    ["#=qR2UG91lLeCUBZUkc7frpzbQD_RXoFwLEY2XuYEhObwc="] = "#=qbuiYOZBQeqXCAEk4NzEpJwiXsZgZ_imnNY_0nVlC9uA="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qBdPakBv808oUx0JcKHhPhQ=="] = "#=q2s3p5XdMck5JjikCbM3Njw==",
                    ["#=qeIEw_iwiRt5oChE8y3Sqjg=="] = "#=q9_tLP_SX_c3GtYyJjbjHlA==",
                    ["#=qcT4DGJDTnMHmnDo5kJqlEQ=="] = "#=qieWbpYi_nEHuKHEpe2J62w=="
                }
            },
            ["#=q9ajPRKzN2R_tduWqS3SKGCYaj5_Zx8xOhGL22BCXRz4="] = new TypeMapping()
            {
                typeName = "#=qzmBMSF_LTshDTaytOo20qTx7aOZzUHtDSRG7eN3ySoI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qfDowbt5gBsVWWt8VpiAUCA=="] = "#=qrYBBmgLzEqfEEj$o1cDFYA==",
                    ["#=qMU_LJI4ZGiujjoPZDO4z2A=="] = "#=qEfozRE0PrqQ3NmC_U_n3Tg==",
                    ["#=q1knvxlbxSGV1V0f_lMvWuA=="] = "#=qmz$wzkjyXcH4u7XGaQv0Yg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qeCo6RqLGx_Px9lek$xUyR$IQ4mQiVWZHG_APwWiPecHk8DkP$7CietrDm1GIw3fx"] = "#=qbqr1zMkp1LGKunyKTNRXS6wqHgecioR2ZfSDvKrOMb3ZLrD5RJbPmLtRY5EiS6yv",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=q9GzKi4zqcf38VoSZmwTW8IxqpnAU4B831QsX$ExIJaE="] = new TypeMapping()
            {
                typeName = "#=qNbg0K052dG6EIYyjRD_w68Md2YsgWO1$A0BHNuntt0I=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRGewlT4bbEwC$PhPypkmFQ=="] = "#=q$7m1oMiHU6WcB85WvEaiwA==",
                    ["#=qhERAz78nI9CV06X0i0OXFx3dJn0c8A3LSzoOGItjfoQ="] = "#=qDcF6QNcdalYGXuFncFp6yDfqcdY4aBPpEn$5iuf_U0Y=",
                    ["#=q0s7kXboULMyDRF6YTgE0qg=="] = "#=qGu4eFykPbgVkpX3dU2QiIQ==",
                    ["#=qHcUHJ7Y$VSAmLRx7GLjX8DgctLCzAs2izvzddesBo_w="] = "#=qxy7t6CgGP7SPFqHuXHY6JEbzv3UNJB9cUqxAhXF0fWc="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qkg99IBSbIOHbUEZyZTuxxQ=="] = "#=qMkRq9K8J5TvO_8XzCohZYQ==",
                    ["#=qiMZt0v6LhRq9GVfVy2EghA=="] = "#=qGRfhn7REHuOplB0hCC3weg==",
                    ["#=qOKOfrmyCOxr2EfjNiUYMLw=="] = "#=qqV6wuutgPK6OS7YAIwj_oA==",
                    ["#=qbo7VUccjMlKgqb22zY2Q3L5iLYtHFImQkSNZQHasEu8="] = "#=qDLokvlY9D0ifODOENBMqV2CspibJYhVwcmuiiGHwypA=",
                    ["#=qB_PfPetFwxtl4JWuxT3bwhdNnYFObEHaEg5Du3nciOM="] = "#=qsAsRHB7SerwVmFcNx5wQhQAxQDRw1cgxIpwDyhTtCcs="
                }
            },
            ["#=q9iRVE_LZLaYXYIKXVuWmu5AHpzAE2yv0BLmlKewcerzwW2Si6MUv6Cs0RQigaWZ17CYjYLlrCUWP5nVsEdu15Q=="] = new TypeMapping()
            {
                typeName = "#=qtt$erVodMGmot0IQD87bCSn8fwtna50A0F9wWyyG1o5beA$ep3XKCedbQweBX2IOaO8iuwg2BXvEiEwCgftslg==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qtrQvRY8e_QM$$uB_8hoJnw=="] = "#=qqoP3Cf9uITEby4Xk1ijJbA=="
                }
            },
            ["#=q9k7Bnj$0OBzRFHk2irpOQ3c9EtF46VzE5P_gsDLRPyDxji4Qeh_Z_YkVbTIw7l7_"] = new TypeMapping()
            {
                typeName = "#=q1DQxvjHXOy59aP3zJszU3juu$vplbiqFuOcnrnpi3l46o6KJpXv$tcVDuMEJMflj",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSVC7ZbNWOwTDmPcsOjzLVA=="] = "#=qMuC9xogBse70ySiA8p9pBg==",
                    ["#=qKod1PG7dJSxmIemDoJqAhw=="] = "#=qkAsBsgRo9ze1sQT$Z7MKqA==",
                    ["#=qP_x_prWdQFFqnKYBcd7o3g=="] = "#=qMVu5OF5dZNFUd6IUb174tw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qBgcFTjnt7reIBAuELET1fw=="] = "#=qhCY_tlFw7qmDOLAkptFLRQ==",
                    ["#=qfXOyqxtlwbjdSzOnacz8_g=="] = "#=q2x381RPRdUSZVre56bGZDQ==",
                    ["#=qZq$79Y5eTrzwgDYtUSO6FA=="] = "#=qUxwKqOGEhk6SNPEWCdSeZA==",
                    ["#=qjGcS2vrQCP8akHhHywi1Eg=="] = "#=qR4oJoYiIhX9k_wUc99AjDw=="
                },
                // added manually
                nestedTypeEquivalences = new Dictionary<string, TypeMapping>()
                {
                    ["#=qHwCDMuNC1JLVlCRXIX6Lfg=="] = new TypeMapping()
                    {
                        typeName = "#=qyXhYe00I7Ey4Nhs3I_eAdQ=="
                    }
                }
            },
            ["#=q9mEsr4XRT4b8am0sDc$1qk6xEReaeddBAYhPk7ewZNWXUj$ex54EEEiWe_Pt11rH"] = new TypeMapping()
            {
                typeName = "#=qXARJXa1OoRmD7uyL6pSUnCg443But0opQDTIkCmAynblbgdETC4yvwBKhRskx7fi",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qjOxJF$jPFti3tU2w_UgnIQ=="] = "#=qrTCZTD8TmISc1T66HdMIUA==",
                    ["#=qZwQ8yqgRG3SBMKzFxgzmgQ=="] = "#=q1R1ImJZ0eeECr2d19OOF8Q==",
                    ["#=qmgq1hZ25M4BEC64Qh6LDHg=="] = "#=qHvKvRLueLCUXAUoyO9mVhw==",
                    ["#=qkYU6eoiSR5QE3aDIjyTI4w=="] = "#=qlGq$RLbU6hZ5_T_FKMZeQg==",
                    ["#=qd6RKhFTENY8gkOwiw7KARA=="] = "#=qSYX0akVLK9SheOFDG8LU1g==",
                    ["#=qVrvXwiAQf8_5kQBCJMT7cA=="] = "#=qyyqwIRM3HaFr2bSvmzfRjg==",
                    ["#=q3GFF_Ilc2TJkaZTZOsyQ7Q=="] = "#=qpm7WqtiqxYmtcfo0sb7poA==",
                    ["#=qTxsCLBAodTSFhWYTDp$wHo49bF2aHdV2b4iNZQiLn_k="] = "#=q8_KxeU0uVJW4XcdNI$zYp3$QaTqBUAT7lZnKo27K3Ys="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q1hFsrGQtFAjC2R7dxsydgg=="] = "#=qxYouMIazFssaasDwYo0BJA==",
                    ["#=qchdXuVa$4RgnCa2BbftHXw=="] = "#=qpAU1drL84DUBR6KEdwbYzg==",
                    ["#=qHBR6EcgnMCFSMxWp9cAwxg=="] = "#=qx5d7QzrjZI_vSAxmdS6o$g=="
                }
            },
            ["#=q9mEsr4XRT4b8am0sDc$1qlxGI$cnSCk1Nkzbu0pSod0rlDusFx3PG78YRU014xh8"] = new TypeMapping()
            {
                typeName = "#=qQ6kA8b3OfmZrmZBE1EqTGI4A2CPD6BKUFRIpW6bAGogUPgo8sKOVD0ifI6Wgv7Bo",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qNui9z0_Um1wVA_TN774$EA=="] = "#=qyvayxUJGBVyojuCEfle_ew==",
                    ["#=qbLIwIuSg5ZHTxc$YYCy6Nw=="] = "#=qh8TEr21Hmf_iLjpD6GWLQg==",
                    ["#=qb6lwteeNOKl1ADVzS69BJQ=="] = "#=qoV2Koa0eWeg5emSqAW6HHw==",
                    ["#=qE8uF$vYQPLbr6cQlHFILJ7R6$1yM2udPd0Dar0cBy2gDTJSPRB$kQ9bqwchusVDS"] = "#=q3UqA7WAox9J$aALjuTnb3$ed796mKVfvbfNIDYT3uuQ5iez2UwT1zS7t29tj5S9n"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qHj_18AiTFaTXAJMaNRk15w=="] = "#=qg6tIB$AkWTE6xMvXhdmF8g=="
                }
            },
            ["#=q9SLsU4Mun7rEkjXLYNzLaEaM4vDdWlClF9b7wxKSlXw="] = new TypeMapping()
            {
                typeName = "#=q0ZOwccxgbP0f4KFv9LQxsdeL_83080Ar4RfNlYzQDKg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qfQMOAW6FLdcdDEvzufgXMg=="] = "#=qDWqDTZoEaRMf97XXopzvGg==",
                    ["#=q6MiP3vNyh$sHGuIYkXt4Mg=="] = "#=qHTyJT_KWAOMkNtoUVHcFOw==",
                    ["#=qx97NLlzD6I3LmX_OZdlUxA=="] = "#=qacg4Il_NUXxLff8j_6W77w==",
                    ["#=qxUvIMUz9HouFe2r4C3Tfvw=="] = "#=qNfLW4JwOAysKh8Rzd_Zubw==",
                    ["#=qQqT_9rwDlQCCW9V2cf6ypg=="] = "#=qUfY07eOsauhecsZp$cebZA==",
                    ["#=qtmgqq2JnomMc1ZzBIgjwGtcW_HocUQhmF_JeamTjC2Q="] = "#=qV2auxshvI_UHh1ex4av$3ca7AzLu1FwKu5HxhGP7fzc="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qn9A$M8yufXkaBrweYCDtsw=="] = "#=q$srDEptr_9LHIABiHVGzKg==",
                    ["#=qsOrDK8L2lItkJTJ6nLt0VQ=="] = "#=q5P_CszGxC6aWrxC8dYKMTA==",
                    ["#=qH_3BLjHyl6WmIAHA3OAGug=="] = "#=q$HQXKZ3vGcxlVEDyDOiM9Q==",
                    ["#=ql4rsTQZDMKiwXbX0QJXJdDL1rrzmyxmTpPyM3XDXNc0="] = "#=qPzm$U0fpXnwoT_DK75bMYKwrM9Vec7BjGH1AsLlaK7A="
                }
            },
            ["#=q9Z7FFHxlhZNA0vl1HzewKiF2AyQGJ9RFp_Pl4LcXJeY="] = new TypeMapping()
            {
                typeName = "#=qSe8xjfc3RBH5pL84MWMYu78xAUXikLUdSyxLxdGzNa4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qCgdRmNURdgS1v5FockYzYw=="] = "#=qB2MRmdQzuPJ8Vh6I$jBQTA==",
                    ["#=qs0tItUe0p6aN8g2ANi21Aw=="] = "#=qVOCfIJxAeEYPioeu1VLJ6Q==",
                    ["#=qT2fuM$oLxMYCFOtqWRRzqg=="] = "#=qlJkJHRe1ANoJp4QKiESa_Q==",
                    ["#=q8Ap91FcxKxbKQT_28f9EYg=="] = "#=qwpVs7_$Jo9d8Hm4BrG$EOg==",
                    ["#=qntkblGZ349lBbvGv2Tk8qw=="] = "#=qX1qCnQmCEFGpPSxDaNqA3A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qh_meGEoHR54TnXSJQ3BkFWYgAiJd3DMYTri9Ly_GwZw="] = "#=q8PWzgB3sWf5WWtU$mh4sCzfA7YRv2_1E3rbpStJdDC8=",
                    ["#=qfmWNMMin3cgMdWU1WXXerA=="] = "#=qHuLEmePrgpFLZDNATBoWiw=="
                }
            },
            ["#=qA_2cydcgSIzOB9sHKDJFYb_UkXvM7kUqsrx_uoFrYuw="] = new TypeMapping()
            {
                typeName = "#=qsRMW1kJULywHR7DfWyolDWlR228F5$s2vnvPvJt5aIs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q366Z0ZzG5a62dMj0z_lWxw=="] = "#=qLf1YBou1PHV$kCznb1E$gg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qcRKzIR3O_rdHopvgNrrfZw=="] = "#=qm9A1vZGePzY9eKkUT2Ujjg==",
                    ["#=qNUqlXU0lsg1PjFG1pmabEA=="] = "#=q1n8n7C1QbBu995GX7qP3Vw==",
                    ["#=qF6W0EuM1_On8_o6GhH8fRjcoVDsCot7cTAY6sshvh1g="] = "#=qWJUgxkmJF1Je_sNixI7h9BC4MXGy8OqmFP89n9ZrllI=",
                    ["#=qLQBra9PI5F4mC6oR5ua6wA=="] = "#=qxfrevN1XbBFzJfAMFtOt_w=="
                }
            },
            ["#=qa3pVnoisAUqS$$CZkFaxsOPdiHpkdnVyWKNr$QRQ5emnVdJscF7kUHuA3Fj1f4aJ"] = new TypeMapping()
            {
                typeName = "#=qbwgZV0EbNTe9PTaiHw_mtW7S3F5246DENmN9yRgreMPvJi1mYHcJgF_jdiWF9d8G",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=quAUiCG0iVpegt_Nx53a9nQ=="] = "#=q0iBkl86UeFHHlTzcRYuQhg==",
                    ["#=q27GLFggBQpBRmxqpzGoSmYHSren0WfM$WTa8xWwai0A="] = "#=qHIaNIhkwqSp7g9fN4siPVM82owEjjvurXe7emxsscEc=",
                    ["#=qRfAz7EkMvr7GSaljUFjNku45U5grS57mK199HJRl0JA="] = "#=qxwY_j9zpGqiw7dsljqKgViMnoJYuHWVml3Ni9rB308E=",
                    ["#=qecPW3VDB23YVsFijydPHHQ=="] = "#=qd0ok08stEI1zuqa9YhGoMQ==",
                    ["#=q_Uza9uAcDDyCQR0vLka_2w=="] = "#=qpDu_$v1dwgEZnpGXzv1PPg==",
                    ["#=qJic0XVa4VnKvlVMQ1ZfJYQ=="] = "#=qzxpIvf0OIXEYbgAWXM6Nhg==",
                    ["#=qV7E6tX__jWIVuPN8$nfIsnDJPVEN$skzSEMKjzr9n5U="] = "#=qRxx6_6GH6yriWds7EeLxzJSvKDqhwTnx8LxkDOqwvjc=",
                    ["#=qRIZVkCFGBb7$em5$YDItGbUqKFHaQGnDiNg1IZEHJKU="] = "#=qiEHbHC1PSYpnkAAkBcTn5tEnuF3JJMPSQo6E6XQ_2KM=",
                    ["#=qDQTK3cSFB0MZlLe3b3zOtjiS880V9wmWXzK5DvQxM0k="] = "#=qpFqCmUOaUSbwNa_YCo_G0AKOT3THYwKWx5wqKNQ3Uzc=",
                    ["#=qX$wdz5A9FDcFemzm8aVb$_tAIEC2IxdUOuKAVE5c3xY="] = "#=qluCZcxV06yJ6Q89rT24uyVSxokkN8HtdMo9k0a2M1MQ=",
                    ["#=qWHP2nwk9stocqPWm72gvMfx4Kyn_hV8sz2BFCBCGVYw="] = "#=qTdS6kLLKBYR2a13Waw16T0kD_hSRKVCHnVk_gUu0T8c=",
                    ["#=qfIxdAcccfGDPpaD0FqjhInPXGnJRT1EHdGD9hYNyj1w="] = "#=q47lE0dSRsDgkgELcNqFVy2GDRxh0mYycRCJ9vf2g6po=",
                    ["#=qf1EVk8FPQ1S5V5XqN2jugQ=="] = "#=q_ufpF7qbl4BKkj_QzdV0xg==",
                    ["#=qq8Xe6NXzjijXX8S4G8GQaTcYuuQidFGb6fm0gEBy6LaA0avlkQ6rhUFb$j_g2477"] = "#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieVQgyDnnw3upmSH0Jt23Og$",
                    ["#=qluBipwaQxOLK7xq9ugc2uc$WIvGyUcmpegFN$gstVALLwq1YeQZ_df8hX0yQGYmK"] = "#=qOEuVdEGoLCltgj4OeiwqPL6aEBWl4yd6dUwVNj1CKY75Y1nav2noWaUJov6plWUJ",
                    ["#=qWiPJQmTxVEl2zmnlhJ1vpgMUw$FMcj3Dz3M7yGzSOK3sJL2VYhfNCJLWMqPvfCTu"] = "#=q_xp8tF0FsBPxhlxs4Carp9N48Si86gBfCEGyGqKkJqE2eieGozoaYhew6t_kmMEG",
                    ["#=qUre4X7XCGT6pCzmmMB5GIZLdcDChd9NtD3SnxXh_K4BkwgVDAVRHL0T8tRfjYpsw"] = "#=qr$wA7P6YKF_2iWqmWrbjiyV94MnGDcMt0Mi$dzLiW4NerTM28YKt1FDTSkZSgK1B",
                    ["#=qPGGQlouQVN6yrB5SAdUwsWVsWFABLQJS1ghiLO6tLAnow3uTuzobVZXT_wkxSm7X"] = "#=qHw_2LO_Nz$Y0vq1cf8uMw_1ypz8qO7kfpX8$nfYpuzX9LljuZNfZANsJ74_SSSFy",
                    ["#=qi2C8rK75fbr7t6PBtDvQf0L_aCXyaO4a18zS64GZgTybfr7_5bNu4tVM0VlJa4Sl"] = "#=qxA1pTzGC1$BAHgsK0KDyGPSan5y95Y68Ua7rf04o5ymcOWmxDXTBHQ8wHKz7Bwnp"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J"] = "#=qdU9ONl7OzTiwqEhiiLIIW6k7u5XTMLHP4q2pu0HMMT0PhXadfwEAYtRzIAtuMGGm",
                    ["#=q9LGToQsDUAJDhHtaseNhvZLfkuCc01ymZYFVpSURgcE="] = "#=qrU7vG3IXHMm2NGUQyPA4xPVP_14aEIyZh3oxKqXMkP8=",
                    ["#=qdF7My9Z0ImSiDeMprbILuA=="] = "#=q$osW7SuAA99n7RqRDnYNow==",
                    ["#=qRlawHPiN44sgztbZacmMpIdNzGZuyjS1r1x7eM4vqLI="] = "#=q1muhmFS8uRZTkv$fzaFmgPBaLd1K73R8po7wBPAz9x0=",
                    ["#=qJh_TOjERTt$Cj5JUQGeYNg=="] = "#=qGwpMwLTanRulyjR$n5PT$Q==",
                    ["#=qROcwT5bDYPHTu0tdgxZe8Q=="] = "#=qLQL31A0Y9nsdQcwqWt35FA==",
                    ["#=qSr6WHehddF$1moXfDyNvig=="] = "#=qGPVlFG92EAWPJz1Ut$i8zg==",
                    ["#=qLimaLCSwr03C02sj9QTZ8Q=="] = "#=qkOQ74y$iknHgN1M6FTvcFg==",
                    ["#=qla7G1YGYcHepJDZBWl$kE7ObtPy1jIOJHHF3IchNYpY="] = "#=qlF$YNVq7ln4JQvFjCgkWbP5pEXOgX3veX165npl$aMY=",
                    ["#=qAe19I2ssh234FH6eq3sOvmDzOdZ37xtNA$wLv$7XHWs="] = "#=qvLc2QR$pYT5XBt9ePh_CbSa$SgfNrFPtqIGADCd8obs=",
                    ["#=qZPmYydp4nsUPaUfSYmgdYnYFvqxaucIoTw9XD3ew0ks="] = "#=qEGN1r6M5_2RzUWD5lyft5mVAHarkMis2jssOIT6ys4o="
                },
                // added manually
                nestedTypeEquivalences = new Dictionary<string, TypeMapping>()
                {
                    ["#=qcez_CIq$Prece1IYRgBagPjNWdrOELrSqsoimig2tUw="] = new TypeMapping()
                    {
                        typeName = "#=qeacSELRdy1UTwmQ5OWwrh2xqckCTfBQxIMFrgQ5nMRw=",
                        fieldEquivalences = new Dictionary<string, string>()
                        {
                            ["#=qgysE6vodnj7hpzFuEko2xA=="] = "#=qNMxnmfPTo0_$WGyirVu7UA==",
                            ["#=qS2uRQ3eDTBeCqRIF$bCBnA=="] = "#=qK3ChqUUS258GZ0GmtBApeA==",
                            ["#=qxPQJoY3zhNrNY_lkkY0S2A=="] = "#=qxlK_uY1Eov_EtGkNRtfv5A==",
                            ["#=qZoO32R4GQH6mn0K0mXX1sA=="] = "#=qdKJprZ9mFkScG5_zYsUbsQ==",
                            ["#=qWHIMSNSJLzP_V6urK1FZFA=="] = "#=qtixYuK$q5LjSVomIbC7PEg=="
                        }
                    }
                }
            },
            ["#=qA4PIHpJy0nAzkmPzXtmdTJ91BUQRuitNR07FVF2cvpU="] = new TypeMapping()
            {
                typeName = "#=qsW4YL_wtj4LuF3edeG6dDSuy4KOb_FiegYUs6Tm4_Y8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["Invoke"] = "Invoke",
                    ["BeginInvoke"] = "BeginInvoke",
                    ["EndInvoke"] = "EndInvoke"
                }
            },
            ["#=qa7SxTwcmGemy$TYd4NhW8ro4BlvoPwkKzT71_ZFBjws="] = new TypeMapping()
            {
                typeName = "#=qXhjXs0sqtRg9aTIokLYTpSsPA3eqt0fSJinrMRHUudM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qa98mJSna$VlR4nKfHvUOyvcVlSB$Q1mttsNbNcl8eac="] = new TypeMapping()
            {
                typeName = "#=qRmUA3T6qMyvvSxEsCvZ1sYYVLF3LnmHpN3onGMAc1K4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlKSb2wbUYbNYwQ4CZNB$wT_oVYxK_8kRAmqjzKrU7GI="] = "#=qt_hwrfZ37tuhTIWCB1xAHyy2xjBIfOtNpy0bAPxUtpY=",
                    ["#=qrE8i$NuGVW3GICewG0Tcql5_jK8m_3uNsTn8Xlq3TqY="] = "#=q9R6AyEGfuWRRt1dtyj3G31DyQdQ0I$Qitb_LhNJTH_E="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qAKWkxwQrhZJJJcm3xwWTeQ=="] = "#=qgKOIO0FXgHZMcq60H7NGWw==",
                    ["#=q5$RC1JR2UwwwMKztAM$w3w=="] = "#=qctTHoxvUHR$wKTchydsgXA==",
                    ["ToString"] = "ToString",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode"
                }
            },
            ["#=qAgllGDAoXpZkad3l0VzxsaPqlYoLbU_2lxDZXIbdmvo="] = new TypeMapping()
            {
                typeName = "#=qN5Nb0u3xazqQvF9p59Nw_ycvmH_YoQ7oIWN7etFbPzA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxlbgbgw44W_OxrRq0llI1rLw7RmMYmw8UcXeGhqfA2g="] = "#=q_FAwUC8EeSY_5Q4aki0X1JW6xwlQ8o40aoh8h3pcG8E=",
                    ["#=qaKFLQS$xy8jp9SozB7I_p$oWInV46lELQDxR3gQKIH0="] = "#=qdq6Cpuk36CrTWfFaKr89YA8TmdeGcyoqkT4ZsQQrpnM="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qhxWBkOaN5Hd5u0xRPbSdxx6VN54WDmQfARo8$cDvnxc="] = "#=q5YkCEh8HOcG3lrRLkHKlNVQ7cWQMQUJZ719aHeuRl_4=",
                    ["#=qVnkOn8faVmEC2FMTxMTuH2BTxSq8oQOFNqdGmZJVi14="] = "#=qQOXY6u6j1b3gKPVvIYEZKalvnkvN5YY8eS5ZX7_4ras=",
                    ["#=qmPCZGjJOQXfYviByGHuop1evgyvg2mLC_M4FhYtdqGY="] = "#=qOOvaw0X44V33ShsS1SPRjYk8n8iD5LUzx2MESduCu64=",
                    ["#=qvJF8yqfMMPJ6wZriK7gKeRd9YbCxMSSOjE6Y$BRRH1U="] = "#=qKcIVc4QfhW1YuwL5oFk6XpSt9dDh65Dy33s7fAQXEKc=",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=q_p$$Qzm8egLV$$7m5A6LZB1soT4TnTq0bmnzjVq3Eig="] = "#=qmUoxitH2Bc6jUc5jlJwXRW0gWBdedsl2LNTHWqz$yII=",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w=="
                }
            },
            ["#=qAHbKMHZxzGaLXmyZ0FGknGPfmc25K0bwkiOkE8W3MK8="] = new TypeMapping()
            {
                typeName = "#=qesm5ttszjgNfphfJlC5C6Rh695A4a0_x4esfYhf8IYg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSvI84lbMDrBPu4T50gJsWxFMUuKoOACDqgYXBPwMpIY="] = "#=qo4KBmturY7R5FZMG2fofS7vEGe4h8_i_99jLRA1MOvo=",
                    ["#=q9JB5WJoNMkrtnN1kbR7UGA=="] = "#=qVFLf8RnBBrvXG9wsbFB5RQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qAjigCqf5C2kWIVj1UZRFpnPIX0K9AKAaLRBV_COZwRQ="] = new TypeMapping()
            {
                typeName = "#=ql$2nCmrnU3lVIQqcrllwYNn3$U1bTo9O8xqceHze8_8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlAKt69MFvRseKjeOTyB5qg=="] = "#=qIVr4Gqa69vlNUzXCRy2Vzg==",
                    ["#=q$y1Ku7sJaltsFTaNHxmyMw=="] = "#=qXMwvHwKaCsTcMXdfF41P8w==",
                    ["#=qcIDezjtyudGnRCSPy9Hs$Q=="] = "#=q6RbI2rAc4zXxYo_jmbLfRQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qYjPJqoyEevdMYHQUHnQwng=="] = "#=qb734c3NszptG71$LHsFmKA==",
                    ["#=q_$To2h8H6s3lskNr7OoXxw=="] = "#=qzNQXkiWrQmol3jjh87Vt5w==",
                    ["#=qiVc67VJb_Cp9ifJgApLezw=="] = "#=qXWcVHC3$t_U5_m1sLnpwvQ=="
                }
            },
            ["#=qaKRyzR9aGEGGOghNO4BNcyQc_L8rh8AUE3Vczz77XDQ="] = new TypeMapping()
            {
                typeName = "#=qqkurasYiaeZum_41OHwBhpF4W09gUCL8t1iJNPfSvnY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsR5mpRulMUE4$KsD5nsl7A=="] = "#=qXX94nBVvhzpu23dolNUdkQ==",
                    ["#=q8h671EFshYThV8ib889crw=="] = "#=q7qBv88v_UyoHzufxH75ChA==",
                    ["#=qsdh8_9A1vJuMn3jXL9C6mg=="] = "#=qNfgI01tRdl_gP6ygDvrHag=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qAnP8Y9juZvX32h9k3eV5TBAIZpK8iQMHZ6miMirhYJVz7DJXkepczPB4os5tboiy"] = new TypeMapping()
            {
                typeName = "#=q9k7Bnj$0OBzRFHk2irpOQ$$6IjezCP7cXWnFwmrxuO_SETntPFX$zWLqY74coQ42",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qOYcu9p5PYfnblu7_i4P5pA=="] = "#=q0E7ZUloGL1DALJ2FLsFZtw==",
                    ["#=qZ7scAfwChG9Li7W63l2U5w=="] = "#=qinCsOHB3pvX5Iixwe8VEhg==",
                    ["#=qW9E1UQCRqRMLN3REdhLQ2BRX7$EoEEEgdu1wHRCJJhQ="] = "#=qPaqCZjDyW6poLGQ7IvzMG8T3KKOKv_c9W0Kr0ptDmTs=",
                    ["#=q5wUaaYMVtt88lxrZ46q7_movqPbMtY3f1R873WrM_$8="] = "#=q$3U$lrJONjvcLtMmOhokXWv1AfxoAn$RLsKe1ggyAH4="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qNvoYBUsJAlWJVYLG2EYXfC_CT08UUL2rZXJYE6$NEaI="] = "#=qDxoKzN0j6mA5Bq4ByPql4hk72PgTUAwL8xfHeZKrlv8=",
                    ["#=qP069DaeyGvt6_d0ELxZXVTJUCZ8RmrUhcJbtC9qHxSQ="] = "#=qoXEflp49wJMrb_58E0038kwwt3CNJ6jRGIp3suE6Gac=",
                    ["#=qKj9ou5Pz5oRAKuccYBPQwg=="] = "#=qzsZXUgVrV76X2bQSnPTUWw==",
                    ["#=q3CaaGOEXiIKBDHQTIdFmasvUUa5eOHE7e7XeH9KcODs="] = "#=qXx1ymrU0IjDMVi$ndkoaf$0ktIot1MvwmrnZrmUTj4E=",
                    ["#=qmKrc41y85KTDftF0D$Q4PUdaE7$9qnUpztJC9jaayN0p2B33V6Rx$sbs16wiT8IB"] = "#=qv5k61Yd58Pwda3$G7suUSKEl1ISMsaNqeBf4Mqdrrx_0qp3Fm76rJQr9jgOknL2C",
                    ["#=qK3JyPcJShLAjrpq1HrLMotKaQU14isJeU3UCV7i05qs="] = "#=q6G6Ya0WKsdkZW5JKcajHlyVFKHjjaI10b3q0ohqJfB4=",
                    ["#=q1Y0mUrg2TtxEZ3kGASERPJ1XQtMUwuz23rpbjJOyG7g="] = "#=qglLEQHVtsFs50jGNp2JYlVeoWJxegPcz6Kc1AE9LNTM=",
                    ["#=qE2hU8wQ$S13bEBLB1bqpqsTwUEsnMWgIIm18UQ8SzgI="] = "#=qjic10Ew_6n7Byb2yNwwuis20U7oD8zH1If7fL3fCh8Y=",
                    ["#=qd4WaJoBCF0ia_XW$0ziHSDznS0_v$Q3tU23WyJBEMB8="] = "#=qLWs8Zv9kX_vMFZkA4WNvXkGHG2Z_VmkO7$K5dzzlEcg=",
                    ["#=q6XycFRS4yhRQ0fPhuyUvlq_QlabhIB5wFfajNRKeZ6E="] = "#=qJUoN8yOxNtFW97wdrAMtvamGl9RVw50K$zCQbym7TxY=",
                    ["#=qDGk6MFVBQCkXv6tEvvRqxj97hVm2avQ_EWMV7z3bRRw="] = "#=qNNZ6TjwLZvzjkaxdROpkAo91SOH2oFTdHoRRr0hR9kc=",
                    ["#=qVho$LHhaANSqN59IzeJLXsyyeBOksueKjfZQSRgOCa8T0G5QYga6c4x44$_o8h3M"] = "#=q5fwHeLygNJtFLDcwTIK3KhRME0SfSCBsOmoDGY$rK4esYANWRWHO8ycLNTno0YTs",
                    ["#=qeMd0Px$gvcT4zNNWUXEVRyKxYRu3LDhUm7gqDRDa_wI="] = "#=q$68DMonyTOodAakZw1jIcQ8GjhuTv5To7$AmJ086WnU=",
                    ["#=qhjOySBXwN8stSjXWVm4PWtpQEaOfuLezB2rMj7kKXyg="] = "#=qg2OL9iTnR_8ErCNKvEGFt2VNsnvM02pAgNVLqOKodFY=",
                    ["#=qhn7Bq3L5nO4IJkJiAIyB0z8sA6kQfQKGOcm_QyZFULY="] = "#=qf_OR5KROKpLoEP_FN4U7dPY0mJ_OUuj5oj3eowrBg$8=",
                    ["#=qU4fG4abvYfssv4m8ff89JBeEaBYOtTv4a81JUKCiTko="] = "#=qu2kihP1_7bIYTtJqOZj8KdNf9t6U0os61ngSYSVx_nU=",
                    ["#=q7UjiVQCkhGmBsFD5vQboWF2ryfJRGa0VCvtFVapNwQ0="] = "#=qT3DBtlmJ8vq8uemIm6gdnKgRVO5DoeQ_n0QGoQIDDGY=",
                    ["#=q6q_O4WzJ23lm3IbxxTmWVB8In5gCOyQuN04FBA4QPm8="] = "#=q6S8$GK8qbCwPtHpfCo54uwE1A_QG1tZac_mt3t1eL8k=",
                    ["#=qXT1iIZNzp1CTff_DeEBkE0WwHRFxAtBKKmZ4Yucjabc="] = "#=qf0GwhCc$opRNq9aZ6f9DNkXxmeUNzCvD6wnpJFOd8aQ=",
                    ["#=q296YbVtJovI_$4o9pC$MyJr6sNYPIqZY7jD64z$0l0s="] = "#=qsUHGSEXKWwu5Lx$tVTrP2L5LziZo1EjH2LMFXhmSUII=",
                    ["#=qHr9wreXbdizObuWwyZ_kaiz_GAP71_4Y1bY9aq6ffhQ="] = "#=qz538UTrlzfTdx0qydUmnhQ5QhtYsOXxjJVXMhbRbmeo=",
                    ["#=q3PFI9NWX92ZsqWGbOl$m4fFi2OO6jLNjpTa0LQOtaBU="] = "#=qrwe1tpf0WW7HU5DjLF3uXZLHOKgq5lK_pTWVg01Qu3o=",
                    ["#=qRu7ckWBOAvdwmRxbVyl84Qe88J6fhlYJi73EVrPkvE0="] = "#=qvc7epqWqhs5AlqcrOw$LSztxhPGm7yj7qz5GlAz6PYQ=",
                    ["#=qyN30k6JDCL8PFKyNWZLt_GnkkHtSXjipfEk25XgNiU0="] = "#=qsqjqZS0Cq1C2WBGmvhLekWUe2EVM7xpjoYHMGcZYI4Y=",
                    ["#=qCvsu5vA6vTS$7T1vx6hS1A=="] = "#=q5$E168t9kZB8qy2cqX1PcA==",
                    ["#=qx$ulU0W96XVLxBBCl3oQ8bgr$miNkgKWzcBDyLXF3Vg="] = "#=qcOktwXPKyLbOC6s_jv6sQQ9RPVKnYA4_aHANgZH$LPQ=",
                    ["#=qfxtFMCm12ckEeLEEeTTFuA=="] = "#=qmwdqHIScJqsojlyhcbrbyA==",
                    ["#=q_ZufCDj29DEKMtuS5ohwTg=="] = "#=qUPWq0sMeByW1wxArcjdTdw==",
                    ["#=qu4fhjlSIaob2APVVz$F54hVz8CDpBbcasJmSmN3E_Sw="] = "#=qYrQgWG$XA5k7gusFHLq1tps$03lRN96LE7RnZHIoymg=",
                    ["#=qJZ_KtXr3JfGj7ge2Sy5w65Grx4b1PfzKrPKUsyy5UcY="] = "#=qCI6tk5o9BYAC_8YbU6Kijujxw6IOLVnpwgmkxkCdzOc=",
                    ["#=qozOH9Yh3u62KWx28F1e6mOYn3Zxnvb0vwTu9WRYadYE="] = "#=qMtsotuJjvewDiFW$syp47IL8CQNTMXbcZ209I8R6Xiw=",
                    ["#=q2sDRC0$52ROkjviqzNrgLZJ_u0F8H4ssCUJjyPr3qtA="] = "#=qjVLeNuDi$IVLPVO4oo8iLE2bpa23GJEQVH1CWNQl50g="
                }
            },
            ["#=qAP3Po52xMvx7_yN0mUJWoiou8MYUu242WGeAF8ACRzo="] = new TypeMapping()
            {
                typeName = "#=q7vQ13rmJksgAp$U2AF3wvObpjnJ7zAvXyVvjVWV7Clk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiR2dHvfn5dFtf9iKAl9j2w=="] = "#=qiTVmjEl1mZZrifeGMTQlgg==",
                    ["#=qbL3KbpTOYpCR1kkVQA3feg=="] = "#=qQCxB3Na_t1IKqpr6aEjJ2g==",
                    ["#=qCs32PJ1oO9BAnLgqfiM4wg=="] = "#=qT$zsZ5ylKUZATUTWOkLlcw==",
                    ["#=qAqAcMURanQIXWwtNU44opA=="] = "#=qd3Ir3sx56E1i0DSUUauXzg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qapAxAmqBlg6hxtjmazYmJk$rxR2TlpjRkfqjFql1cHmPDntBmgOg6RkxRUsTybVl"] = new TypeMapping()
            {
                typeName = "#=qYd6NdFgg8c1kRrKHqep59gqYgLWJ5L4_QiJNSripP17FJn5enHO5OsD1Qn6bTyE8",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qAPy3XyZU$q0nKNPxKiUODhzfbIxKun63Jk5YcjYkZFI0O7bljUAFHZ58THguIWcA"] = new TypeMapping()
            {
                typeName = "#=qTtoqj5e0rBRmRpbGoi5ACtFPWAk$Fs_3iS8yHgS_hdDzNKwlNVoHDkSAI7KLy6ZF",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q7152N6sc9trL3ukyWEKPEQ=="] = "#=q8OKaAGO0_1LKBTCvWb3Nsw==",
                    ["#=qOAott1Amxj45JPYrUkpR6w=="] = "#=qqJR6y$o9QD9z8yTIhMGBFQ==",
                    ["#=qAQUBiZtDQzhA9mD6df7IUg9zBj06Oq8WJ5xmZSV9KnM="] = "#=qB8AMJQeiHpTxf_O7$dl51abNKj5yFXKDJNdZbFID_zs=",
                    ["#=qVP5mu0WXPIKWzxurOZJUsgmueM3s43M_R_fTcLSo16g="] = "#=qG3dtazyiI9Pyn6hluab4BQKibvPqjJxdijCzLeZKrVY=",
                    ["#=qtn6UxtE_Ff849rFC2gedWg=="] = "#=qWXVj9hHD00DxD0T1tv7tHw==",
                    ["#=qYeBJ2blpu8K9tmAQbE$dpFUcSin4KcbqMVssEYGD5OE="] = "#=qYZ9UKerpnHLhJwhAIBczWVrBb0w5rdemyk7hDDORRa8="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qKaZBFCv6rS6eOyW9qc82e$55pcNsgPRsM4YHAAhR2Dc="] = "#=qzx3z9pD$36TCQOsNLiRufGPputekiRamGkCngAGs1H4=",
                    ["#=qGRuW06Q66LA7T97gbAUN5o7zgu4BvcvlKRNn$kBY8rA="] = "#=qwNIrQJ7fm3S7LONK$o2LG9JCTBFg2HcFk6a_EfaNa2E=",
                    ["#=q9CJEzlFkwR6dWD__q_UBSw=="] = "#=quY0Ejg8S0zEi0Xe3mR_LxA==",
                    ["#=q5i5TxP3KR69yKbBuMpBFiA=="] = "#=qwzQUQ$MB9r5bn2_gC55aQQ==",
                    ["#=qwENHr84KfsUBGNLr$d39eg=="] = "#=q7qZXLztUSznZC476lJSycg==",
                    ["#=qVbW_Yq9vR6rdYIi8MrOcnMCrTo9yJksrucuqIQQr0Z8="] = "#=qVbW_Yq9vR6rdYIi8MrOcnMCrTo9yJksrucuqIQQr0Z8=",
                    ["#=qzS3fcjVHr593zATuhpctG2BlmstNz2J_xnj2iHXc6bY="] = "#=qJBHydZmpCaG796EXSgble5IGR1SWfV_wT6pt1Bi88I4=",
                    ["#=q3Zm46PFDtOLvdO3QWGPk1ESNz7b8oD4MjH_rtlJsz$8="] = "#=qID3otDIarxaqA8Wd5E4n48_brtc9l9LDTvNO$sv5CtQ=",
                    ["#=qe1fXzA$JmlssIxKRqa3Hvl0NfdpODrXji$ZUwOesWdo="] = "#=qhOQkwoDuLjcQmi$3nmcPyyx$weSQonnK_6v7b8wL4jA=",
                    ["#=qtLIuNZr_9B6AYuRcOU3KVKNGxmeDFVcBq_1RW$FakD8="] = "#=qAvRgYcKI7dMoSLlOeFZDKILbYv9hNYZ6X2u9NF8iwRg=",
                    ["#=qmi3bzadshn8UJnJX1lyAVwgG6dLVPLtTDjFKwL62zqw="] = "#=q0KkZwm1vMUAtWu3XuOjnZiFPqvKjjAObMasI_EV4HvQ=",
                    ["#=q1ZoWqsSQyY8NUwRhILfC7XDgU2hah0IU5SwY1Oe9LrI="] = "#=qn0B2Fn3Zqs441ZHVGF4TXzuCTJK8leOj67k1ojRCkvc=",
                    ["#=qKpuX1bG5TJXaUS4gu1acI6qf4KtQzAnum9McOpAiUBU="] = "#=q36F2rsP_A5rXmgyOpNv9xFAl5xNmShIpDptbkkyO_qA=",
                    ["#=q_D4pKpy4cu_degFG812T0lYhWv3GNtOlTXhx84nYp7E="] = "#=qbl43VeCFsu2GRj9scX$GKUbMqt11EvRQh0g7Tts1Gf4=",
                    ["#=qyCaQZNLzjdXN7qDsDtXrMksD5M4c02YH2KTO0M7Av9c="] = "#=q0m9TnjpgUPD1NwqXbJ$zQ87gmfFoqfqimbNMzrGbfOk=",
                    ["#=ql5HuWlEzwGudqYL5Eo5S3WWIgKwNKGzJHhFt_JgjCSU="] = "#=qjws35bS$aBFIcGnqAHLQr898ylYgWQlqg1JHrdoNxaw=",
                    ["#=qhEQH5t2Un6hyMQn3fECvNnT05aCsggcH7pgHjuJNWag="] = "#=qJpS_W7VQD89IXUayf3OcptRotcLZaUKAivmjXwqtEQk=",
                    ["#=qCpwBrMKbFDWEHbnwSTiUUWb3_IR_prrtI9C14Rvii_E="] = "#=qLwLyZARH3PNuO6danNv7FNjVwSB7S3uWsBOMcAypcO0=",
                    ["#=qCi1ZFd_o$vt_y4UV3qtsS5eQ86oIeFjwTUW5n1HOrlc="] = "#=qN8plBvnuIQhvX0CrQcAJ8hnQupeNM2FtLpsbG5seUsY=",
                    ["#=qMAgI30ZIUP6cuCKEPNPCvQBeBWPlnGUsLyJQPgafARQ="] = "#=qig1RAmWaZTVuj8BLGpZSqpxuyPGFMY2zjNZndR0Qt1M=",
                    ["#=qYMye7xKYnjCvf9iGXMNtDuLqzZaPMKJwUGwn5Jkruv8="] = "#=qZ45TcXkz_gPq_GcRAsCxiVKR3OhyzqX0$uIH_wQBVhk=",
                    ["#=qT1ouPX9enONMPHrXAE64AA=="] = "#=qftJGuJPU8G1Rdu1oLAXxkw==",
                    ["#=qFHDwPcOqh99zMF_lLDRi3tb2DYmiBiPqws_BHcNoaAY="] = "#=qHrEzVee2SyoEyU_m1xvTQJI2TQMNik07ISiCnoq5Hqg=",
                    ["#=qYXYsC2NH_yqfkjObGrwHqA=="] = "#=quXTBLtXua7sawYXDTvWSQQ==",
                    ["#=qMry3AqaQ2GPhwjF7yHTpjg=="] = "#=q1VP3CdZtiN2kcvhn6aeViA==",
                    ["#=qlkq__Uwau3FJD612f6lru8dHP7CaxP2braRdBDa_kAg="] = "#=qEIlRA0wZ6ZOkDGUamNTcVcxaPgGP19du3Lazogl8XbA=",
                    ["#=qDmzxoCMRHEjTSY3Wj7lMgn9iSi2HYAbTYh60iVsd7Xs="] = "#=qg8kdIbADhYNTFlmkXBF4FfuzlXwOVuher_6ff4QMK3I=",
                    ["#=qCowsXQtAOf12j0Vy8uP7MwQOXN3Gzx52_aazRnZTLWY="] = "#=qshySFojF1Eh1GuRFMfHl$iBUMANSOo4y5oXbYdf4Q0k=",
                    ["#=qIXbOKN5OgMBkjVuzPAthMokLLXDmAkrT3T23edTgj_U="] = "#=qqSrEzhdd07eHYoB3WaZWITiZL8f25U2Qu08buZ20iXc=",
                    ["#=q7jfp$HEog$GY9dkMmmBW$07MpoR6hlmBqFPv7VGlvXI="] = "#=qtzVKkpPu3aMogB43EsSMtwl1oL5SCtovfJSZyFTB8yg=",
                    ["#=qEa75Ow4e2$HwmefYmqIinYBkbjRoHSNhH6kcNB37xy8="] = "#=qDkCeMXBjVrcwAio$rKLmDkgFaIlgPaRAovEs8tQXvfQ=",
                    ["#=qqhAlais4BZ2R$ApvBmzPDk2CkT3dVQJkIIHZeUk6CpU="] = "#=qgU9$YOJtM1JCnrNyWxCgPm03mFekxpqgvPfcusLvZFk="
                }
            },
            ["#=qARU4CwAZ17ZNVfiR0qTKjgZIu92N6DLk3cGw37AyMXU="] = new TypeMapping()
            {
                typeName = "#=qimEOWH5iKGMqXro$MDYtdiNgT7gCM9mQ7tFRvpEMAhc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qy37j21HafazCjsMq$84H5zt_LAKpN$kBsYdSpZZ2kdPbbzV_Rk7o2_fhAC$81gSd"] = "#=qEMRXv8tXfrDC$yMZM6veEgSvCe_FeMRmwWm_3yxwP7bcsCQHwsLvVUU3lShvfqmm",
                    ["#=qldxHUbT2TjDi0gRoUEejH8fSAABqIp6gIpG_geoxHVRFaIL4R1H6uTxStLBgzGTB"] = "#=q4dr1U8prqCvrzV7N0OcR$cJrlVcj14IDrosFPWMSLVLVS654hj4BRKMENx4aB41E",
                    ["#=qWiPJQmTxVEl2zmnlhJ1vpgMUw$FMcj3Dz3M7yGzSOK2uY1Ew7ix3yhz$TamggIVJ"] = "#=qZI3qKA80atATQQL5pUD2m7FSeqvpFCebX_ZFxPbLV13iiM5lJwTIjY20PF_K_7pc",
                    ["#=qEABXFy8Zk6V69V9AJ7xRKTYYSMRmq_WGyb7Tm75pLmKnaVQWjgn32Y_h0Ch8TDcH"] = "#=q5TMIokeivS_tFzY3nEFeHsBJs$MKImDRrb9em105O5BwWEFRknY4Xy6R_Y65F8_D",
                    ["#=qcDuTH4FpCdw60c87xtej7EhxXbEPmXOIY4f4VWUm_TuZcU4WdTZnsbYPyWOdGh77"] = "#=qU1ssvtk$leEsQwmy8XTvZJtViCYsMaBEnn0eSIYi$bbglBvIxRotlinNcF$M1bo$"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qrdt3fGvGghcam55WELoNig=="] = "#=qtVQ222iow92XPiEMDKVvkA==",
                    ["#=qjLdd4NmEXCAT1W1xMtMP1A=="] = "#=q6QoQJi5vMFdWbQbsstW8SQ==",
                    ["#=qWRy8QQMpn$49yK2eRN5U6w=="] = "#=qp8oX7kIkXjCHc7gZedixCA==",
                    ["#=qEeaWGS6CCOdQlE3qzAPGEA=="] = "#=qm2r5qNBpBwp3OucQ2Bel3A==",
                    ["#=qoVIp8TtZUup0l_7gPjRHGg=="] = "#=q$JuYPDuWf4DMRZfrtYlk6w=="
                }
            },
            ["#=qAsjUPozP3DzN1zwVdM2F_AD7qcyjcD8koBmkl8EDMtfxcHAjxlhlh_5WHxfycHr8"] = new TypeMapping()
            {
                typeName = "#=q6N473kcNvqBTehDYCV_EhmhzHIJ3VZqzWvbUtK_sHjIEHsyhvhxerfCcsraWjSnX",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qavKITCz28MDBtYP9I_FBVDTljZlCoOGD0lMpd4iD_8AGs1ekeuYk32LQZIZuJLtQ"] = new TypeMapping()
            {
                typeName = "#=qwcpE3xqjADcb6OLrHJxBrEoK$B16IBAdri$HveNw2eEF0KLvszc1$$L7AVw8HRqM",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qaw4m4kxNcUH7In3HA8$ZfEG5opXxx8J8J489smU6qF0="] = new TypeMapping()
            {
                typeName = "#=qhbGGkYJEedi4UHW2gxjw$Or8BHgIKpctkrt90msnBSA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qAy82ERcJuhz2Tgkg8OCWGw4NYmt5JSaUg13r5PP3Eu4="] = new TypeMapping()
            {
                typeName = "#=qzOPkQVywqtgnYUfgxlklfRI1V71LH3zNzPJPAE3Umo8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qoHn_aGg1RJuE4n4QW9eY1g=="] = "#=qrOChmJAQtKfmDhOBMqGLQg==",
                    ["#=qloaL3flEkxD0C1zQiww_3Q=="] = "#=qmlx59vhzF5FJXonImBTlQg==",
                    ["#=qfpQbWzoxJ$ye5a3QjKCnPw=="] = "#=qDXFxebWvaWUGofZ9RLlNJQ==",
                    ["#=q8K4nBqOqcDqa535PG8aw4g=="] = "#=qAZnjKThajegGS$VxpJHRmA==",
                    ["#=qf9Rf6FBEIuVxoNRXBqzVHw=="] = "#=q$UsVnUTUYxrwzV1RFlgEfg==",
                    ["#=qSeZJ0sN5ioEg3tRrADkj9mout19a8feOEx$hY6in8I4="] = "#=qi3U6ACmGwFkEQ2QDvieZrnuZOnWNZUoaBVyDakcOt5M=",
                    ["#=qFtPAlMBAgbAujkVFYaKG8w=="] = "#=q_t7nWPfbAyz7AbS3nLFfxw==",
                    ["#=qxGvkB$yIRTLnkocwxfHg$HVZZe$WTrlwONGfR4xsfNk="] = "#=q_78LfeMrUZ23oFQLoHZdovk7BzrWbvyMbR25_6yEyX8=",
                    ["#=qnItn3rqan_$uTRqNRBohjA=="] = "#=qLuurBbuwKZ3iZNh6Ug80LA==",
                    ["#=qHzsmBsxKhBSnRbaZhCVbUH7Z$KrCEet0JpWMdI7KfZU="] = "#=qiYe5hzHkKxWY$nss8DZMbv3P_hjDxMiAWKEyHDyLUXA=",
                    ["#=qFXSBAzGCDtRQt5qg0V5joQ=="] = "#=qbUD7X1ok2un60VSbcG1zQQ==",
                    ["#=q6xzwpGGVOW9alIc2rztShA=="] = "#=qhXA4Qc8Hq1frlqBgN4Plew=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qahD_OJprvpiXJTiKCXgDNpr5jxoc6RpUR7Xiup0elPQ="] = "#=q4KIzc1MP0No77vswerCCBmMihutg9oWCdyzFPspI$zs=",
                    ["#=qdRo6j0Y_NhfAmDfZK5ySOqcBH2R3fLX949mGksxCl7I="] = "#=q6hwHUIKRGsMMDrNpSs_hiLTqNmhNIo4rSroFQxsZQBc="
                }
            },
            ["#=qaz7nClJm5lVeos9TTNVixJ0pJ7WK9L7MxOQnnajFB1M="] = new TypeMapping()
            {
                typeName = "#=qfOG4of$erdpTQgBDYDMA9tqGqnErAAlGOLK3u06KSoA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q_6CzLKMbUCzxjx8gGVMmww=="] = "#=qrgNKVyg23et55I57VPwF9g==",
                    ["#=qPSUrby$VZ_jygNLEgfW48g=="] = "#=q18$fyujo8tQhFfpMWwe7KQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qgUko1cpXasqRacYixBs7t5iT0K4C$E0iV812sFEm$D8="] = "#=qCR11mQoLgGOhv92u4lFWfWSJZhCgs7oraziORKmwCEM="
                }
            },
            ["#=qB82POvxYQAlojhql9swHZk6rk3lgHckquLJFr8Upy7nB2FhJFAl1wxfWy6cyLIY9"] = new TypeMapping()
            {
                typeName = "#=qIQJ7nJox8y28uQz1Lkh$M4$IzM25MKLRiudClrAXxtFtfK1o4c2nJsW4M8maJyp6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qei6TprLktDl0jlcQNszo0Q=="] = "#=q4osYRwlTql76W7udMJfY_w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qb8BMTaR4woBSvwUJyoGSZOANknfvOq16gLVzyJYyUkKaWdxd4iUViblWKZpMaqTg"] = new TypeMapping()
            {
                typeName = "#=qaWyE3wGcPQC92CHWX5uxzpkYTBPbMPy0D2Kty0wpE00BWMFa0cMdD$XVBo3Qwcik",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qP_zbfiISOnt8SIHSa5SQyg=="] = "#=qSTFnEvnmlid1db6h79bX1w==",
                    ["#=qvxM9iDES5baUB_oIGLNflQ=="] = "#=qNkT0bYCFKesOgTdPRmIXvg==",
                    ["#=qcP5VH5B2Hp3JLQ3d7aJr7g=="] = "#=qVBBEj_Wa0puntNR0CTP3Hg==",
                    ["#=qaMb2CrmBDqh0UOehhGZ7Cg=="] = "#=q$7rnx$xG7XFYApKUUTTTcg==",
                    ["#=qJl1v7kEiTQGedreR3qC9YzoCNG1d5znT9W5_HYs6SX4="] = "#=qhQNn9oIYqFsmN3gqCWm45j9OOAeDJXKGcwzIV9FjU1I=",
                    ["#=q$lvVBs4M4bjx0$BG0Y4kMBYUZXBj8_iO8ZNbssc_gaI="] = "#=qkMPLSfctBQ$ZXeYJTRI17e9XXMzLojij8iwtf36z8b8=",
                    ["#=q0V5tkf6jIdbqzbsoPN2Srg=="] = "#=qoIuNrKvDmG547DobaSrKQQ==",
                    ["#=qewhLLetiJUEdPF9Z5MRVhA=="] = "#=q3p9hfbqk$o7c1RaD77O83A==",
                    ["#=qA46Aream4fvrUw1a7C5Dhw=="] = "#=qpgypYB6V87wyY6qyxjSvww==",
                    ["#=qBBbDAdvweuSC3zUaElQS6RkmageYGQn1bCEbMsvKu3k="] = "#=q1kXtiELk5088Fc$GLY3SwHCXs2l_Stvlx1nClS1Qs2Y=",
                    ["#=qshxmk0fNE7BQrAXXWa$$dI6BOdMph_VD$pXUg_cj6DY="] = "#=q_bP1vHNsq8KOyn51sB$KsI9FwcshEqukGlIvgiRwcT8=",
                    ["#=qUq78ePJKEx5ZkCmDjUODFg=="] = "#=qvNjb2ytBPKV3LkW6MF6cgg==",
                    ["#=qOnoll_julpBV_XwCh_xTGI8fWNImY_Se8_i0TgE1r28="] = "#=qV$290lMJl96V3lWUKK99gZ9Dz43iPjo2PgzrvPlmDOs=",
                    ["#=qwo6NiiS4wjH5qAIlFSot8TYk8qMHD7yA8lTwGWmaIis="] = "#=qWJrDr_I$t$fDqqJE1RyCTbp11AC6YdVwtGTHCdmU7S4="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qJvXWfHWgkJX5H4tsjSSn$2SnqbUE3e6Eip4PGO5QAIc="] = "#=qL$_IkZjCED7GoOT5ZlOa$rZzCsGT0OcnckEhHm4mBxw=",
                    ["#=q7cvChSN2$ukm9QXKLr7BRBkSGh2RvB6iw4uQIuD7haA="] = "#=qb8eKZlPsOnNkAxdpRh40A5C7Vn0k152UdvFmL$gVKuk=",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=q3DhhaELU_MObp0rayDj9vw=="] = "#=q0_RbJUlHeKg0CRfr0QyZ6A==",
                    ["#=qt0$tSRmkwV6yefhSQcYYag=="] = "#=qlI9vg8PrFtyC0Npgg9lGuw==",
                    ["#=qcMnfSvSXxhW7_a5_PH0Aowho2T92bRVPfFLadk45pqM="] = "#=q4aVndYj82z8t2r0lXXE2wDxwM1eMkETT$wcFl05HeJc=",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qn1KuIHnkz6pjOfCxZWLnzYUiu7KSnNBgruHOWeE8V54="] = "#=qQo4zJ2_KiB6NIgkZnelu61tca_3DwbYAjVqFbZhUiKc=",
                    ["#=q$eXOLQejZUXjwoaRQ9k6UImTwTXLzbKGgwCMon2cnW4="] = "#=q2McxoPaueWFCgJSCG4a4MHHDt6R2lUngrTaJcK_$YlM=",
                    ["#=q94PeHam9imUQjNoI1aM9jQ=="] = "#=qHvR5OcNk0V5VhO42AkWG_A==",
                    ["#=qlC6rGPj$8hjqmHUsKmHGMQ=="] = "#=qMfvdB5J_JF$OKSXAgXeOaQ==",
                    ["#=q6p$diZJj4qg$OQX3DNpx9q887C2F52PGTjfgjmfvP7Q="] = "#=q1SBcbfAv54d78$m_fgd3mwLk5dtoyX4i_GMrXKMBpRY=",
                    ["#=qDMrT_59iLQJztM1wV4o3PvZZnu_MkIQxljZgYYRCxK0="] = "#=qXof1Px3NqQjmiqQrOhmVG$8LeRPqtRRGN0qdC2CgwgI=",
                    ["#=qDOLjcru8zCIJtFI_xR5IT5qfXVksQ607OdXiH15SMQE="] = "#=qYisN$9$QRHQ$6Ipe55$impoVP9jJ$SudRWaeLiczGRU="
                }
            },
            ["#=qbAExfYCexqjsy0TU5ZsL1NyYPsgtcs$qTDUNFAic7fcXq_BwXy_Jnqggac8qMIqT"] = new TypeMapping()
            {
                typeName = "#=qrr$pGkS2zENwNGygIcxIkBkN_S0nao6siOFeR3HLbIFQU5AsnH1wwPsZu3mdlei8",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhmj5GQDLWSz_re179TxM4w=="] = "#=qpgFCgsNPwbCUqM4OGNR6FQ==",
                    ["#=qX3N3vdfD4rQG5aR_8IVf2w=="] = "#=qGwZ1HqiOjbKVeDjh98Q01A==",
                    ["#=qkcDPkFpJImQnNi4SeuwTOg=="] = "#=qugRdAObLe9eYmGxHmAHK6Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qlJO4kHpOtcfBMqeNI5u5DcPStGOGd_CI0HIO3aA$WW8="] = "#=qGmn39fyw2zNoE31Ox1G6CKnSSUlFZzEijoXpwNQyFzg=",
                    ["#=qpa1XbihU8I$brFRc3GkKh_DT1Pb$yXYOJDUi371OQ_g="] = "#=qmbYYYtHlF5b1ZSdFjUtkd8u125Iwe$56CKXYG25p_vw=",
                    ["#=qLLScOj$obrn66cR6Q4aTug=="] = "#=q4HRMCImnVV41VDcDBLSAIw==",
                    ["#=q4hH4$tjZ5202Bd6khJDzkQ=="] = "#=qHBO0_4y3ethnLtNwWKrCNA==",
                    ["GetEnumerator"] = "GetEnumerator"
                }
            },
            ["#=qBBL6X8KSk57qSlgtlcomwVDEhpJ6Ev6VE$QGUxU7awo="] = new TypeMapping()
            {
                typeName = "#=q44uijWe1r4kCd7azu3MpZDQoh6QWRZGvEMrI2_vVGOQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qGHTC2dnOPek335w5sFhONQ=="] = "#=qgruUEVEUqBrJbtoIsLTBug==",
                    ["#=qkxoluDKgTKkCDEX18t9bpg=="] = "#=q39Vcyd0KCqFP6trVY7R7_Q==",
                    ["#=qkZSVWqt5khZ4TDIwCa5vFA=="] = "#=qAUdQp6LFA4AVbYO9rQh9Ig=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qp6PBDCdDnfIs2p4uTyCdSg=="] = "#=qXs2YC0GGWSlikprLl9ihSQ==",
                    ["#=q_1xLXsDIqOY$QyURjF617A=="] = "#=qZkznPicot8Xssxb4fIS$NA=="
                }
            },
            ["#=qBBm23s8LLg_Uck9aJV99270kVOEgT6egt5iy5S$YeIydzkQOdB6DgRU9$WALlEKV"] = new TypeMapping()
            {
                typeName = "#=qRGWvRCp_3pDW58kmwKuXhszBIv1u$bodsoFwFfdLH2p0pIMbOLi5KwyIWY4XMCzf",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3Ue2GxUd56QfawYjUvIPGGBd_alRQPryNEigMzU3L6k="] = "#=qxKCHMJaebhO40PAFhKyD3I_SFubMnk_7D$o0g7HIMH0="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qBBm23s8LLg_Uck9aJV992wSR9dZTyupe1a6plAF1ruBCVtKrnQZSOdJHZL2$KxR$"] = new TypeMapping()
            {
                typeName = "#=qZnLaZO1qYXqDJnq5DeTRW2MN362RdQZEclDh2KaWNsTpy$8pnQfPxVVu1O7WKAfK",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUm5O4q5udLLYTRq8CA5e_xhRYZ1d6f$mBGTWPRSxMRs="] = "#=qIANDXncazldtB2lKc8WDOw6YUw$VsbyBQIQfv6x41Tc=",
                    ["#=qKVY0B2CSV8l6R2gHNbyO8tWMRBZu4v1yqBlkyOONNgQ="] = "#=qLq$SSTBidMuOEY69hapJgd9CQyn4nDvCMewxBSOXVEU=",
                    ["#=q_tB_QV6rIdnFFEkpodsCLRiagAFaKk3vu3Thm8WPvNs="] = "#=q438CFrc8dz9DMpq6OXwfJJjSrXafG0$MK8S_wx3I3is=",
                    ["#=qfQ2v5$qjVvR8f3QpvBm_ve4CPZ41kFEA0iAbXForZ3Y="] = "#=q_$ztPRPPNzutjz2hrIRI_tkDqrus6W6cMgtHPU2mkWQ=",
                    ["#=qCbh4ZYL6mbVrUcOd2dACrL5B6$5J6peLlJIU6lFnXB4="] = "#=qeqxS9_ha93hsexkluUj_e8ddXG02lJ0$Zr2DkyIDakg=",
                    ["#=qAkB4g4NCNKwlZGHbO7HzKJeESkxcTVyPgVmnSX5e9so="] = "#=qOfAIrpx6AKmuRikbMX$uuzHpqcEDnbPRM_MWjj7iCaU=",
                    ["#=qq500wBt3Jq5msqZfTa46svdjalvLNJZJWgS2Ucwhx_E="] = "#=q8xKnbxoq3aFr$__P1e9OTB8LEcKiuzTcvIjx5cftPsI=",
                    ["#=qAm0N3AvWVSWEd3m5Ng8Bv$KWtZucDKsf3wN$6Sh94WY="] = "#=qFh0jbQXxpl9nEaPrlEGtmidhr5fccAaBJlDVOaNFxCI=",
                    ["#=q5UalYnGoPAKxLRm0Rl5nkM7Sxis755IDAJX3z3ffJM4="] = "#=q3KWTh71Bnq4kHY2CqdcLQJWOcpPaVF5JC78RvZQIKKA=",
                    ["#=qhEVCisejoQubEYViL7OXY8q4nnD8KQXlOuCmnYClxYQ="] = "#=q4pg7fKFE7C3T_FvgR9wO6nH46xZkN5lMMwo38jMaLLw=",
                    ["#=qPmCFQahbyFolGtRZzOqYZma047kSqB5dLFlGa070DP8="] = "#=qv85L2fWCTkNjdt09cZsuIzc3Ly9tn0219lHkUJDycao=",
                    ["#=qAjtonySeic8MuYxa6__Zc0sjbpK3V1jcScXWexhDNZo="] = "#=q564cN$1db0UBk0Qj6W1JXHCV6l6FtUyrgxK1uEwehI8=",
                    ["#=q7rjcIRNo9xFFB7C540aAap5FFh5XpEHZ3s$mHApGEE8="] = "#=qpFVvkswwIh0N$F5Q0NJG8VuYQb4DIIqOftRHTFnWxAU=",
                    ["#=qagyF8rwDK3TMg48BUugsO0_VqVnB06BUxTwDr9k6XJY="] = "#=qMUIOBbjuteQ7eqmek5OXSisggaihP3ApN2Qy4AA7LCM=",
                    ["#=q_KGKEZ_hxiT9mwZ7gFDv9We0g6H08vF_Go4ZF4$hFXo="] = "#=qLOBdU2xIZai1Y6p02QXASTMpjn5pvb5SsDp2vMTpQ94="
                }
            },
            ["#=qbBOI2pOLkAPFRNlCid3CC7KbyPRzrxe_bKXEL2wK4_8="] = new TypeMapping()
            {
                typeName = "#=q0DqEduoCTVhbLfxUKB5UkTt3hUFOCy3Lh5KiHjFwCG4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qd947MrA3fd0ufs7BRqzZEw=="] = "#=qWsq85Obc5PVW6Juom28_9A==",
                    ["#=qN9p$Op3w8q$3ibvBq$KPoA=="] = "#=qULmn8aMkiyEFsUz2yl8qrA==",
                    ["#=qRCaTSfJXZ_$hfmuit9_uZqEJ9IrcwNoqFoWdJRt4l7g="] = "#=qn$XAhu5NjRjTStBjoD1RdwsKpyTk$92A0gbn4hKT2IM=",
                    ["#=qtOlMuVNXgCLp4Ip6l12NAg=="] = "#=qiN4lv0mvJEBy6mEUp1h1zA==",
                    ["#=q9hYN$$TfudWFTDGM_VIO3Q=="] = "#=qCJ2Boo8xvMNTKcpswh16XA==",
                    ["#=qm0LvLtYWiriF_lSJGfqN0Q=="] = "#=qxU9oq8Gc53YHm09djtU2FQ==",
                    ["#=qmshqvq5R_JedxcQ3NU1plA=="] = "#=qPrXYOYdkPSbsP9ySqaPacA==",
                    ["#=qtIZJ_84Z8uW_TX8LtuiLjg=="] = "#=qcR2cLGHEkCeaUVzCDrd_4g==",
                    ["#=qlpiPM$qTzbxGZfXQYz7jqA=="] = "#=qAdvC17t0e5qjI0DLY2ky_Q==",
                    ["#=qnRqYsucerMFDyYp3UIjuZQ=="] = "#=qTfYb1oImz7NpVcA34LUKmQ==",
                    ["#=qzELDO7ZQDf090iJ9KFHQ0_DlH1CxKV78stxnuURMCJutn3dQK50CORgED5ltT74m"] = "#=qRePwNS9YYGqHL76akuXi4tQVPyj_VMpiQUO0DOjz6vBzRt1e5NxoGQ$syLSl_Wg_",
                    ["#=qsWuQXf1aTBHOPeMTPKwcWn$Us_dhtc3g357EI_h_LJaTkXPYBFonfPw6fljMvBAB"] = "#=qmFxyYvqDotjpqJEHWO19oLBhZp9KCtVGwEL$W_oA92eQmGu6lFZK39VTHYhDvp7M",
                    ["#=qiMmVVdhsmE679kggC8VOvRJ6by$dtRRTDrmeuW2KqCpJ9OGSl8TLgI1hN_4fkPDJ"] = "#=qIV2M71QOG$Y0dvKzvZsJ6DQZ0PtG1MXcAWyQ8noZc40L6GgLfhEeJRmqFd0$I0D9",
                    ["#=q4DBvflnXrqdVig4$jdtFYb0azr_FKOaUohHilzHFUTy2IBACeG$getJCzs83xPAV"] = "#=qcDuTH4FpCdw60c87xtej7EhxXbEPmXOIY4f4VWUm_Tu$7H9ce$HAGRJO6EVl25VN",
                    ["#=q7jUkHwnblqgzzJaD4oKK7e0glgwQcbdfBrOEbzWRsVeHSvZACUbdJQPZ5mUgbzaJ"] = "#=qcDuTH4FpCdw60c87xtej7EhxXbEPmXOIY4f4VWUm_Tsx$JpiH_U$8Ku3Lswjoyhy",
                    ["#=qwF4fXmtqVePh7UIGjn31qR$MmhaFhbizI9rqgAR9_s7dHlE$KEGmjUey0pVX3qxb"] = "#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaQtpmksu6lp2OQ$IEhwYBn4",
                    ["#=q5UapIxG5NAPrrLunB3C9K2Hd$PT36tOt3HGK6$7NAPvK$fdI06_Gr_4EzdyUHh6N"] = "#=qLLjrrtUIvekoPSjYCuDwGPF4B1ob8cS5ovnC1Zs3WEJw4VvGd9TBiK_u0PQcOsR0",
                    ["#=qWhigvFksIUcGgVTgT5ICS9BbquuaEhGXcwPGSS8BaDAJsAfYhMKXjgiga_2i5qXz"] = "#=qHw_2LO_Nz$Y0vq1cf8uMw_1ypz8qO7kfpX8$nfYpuzWZ_oKacfynXwzxDMDRWtXD",
                    ["#=q40oZZgzKOmzqQdd1Qnpn3dEF9Bf6rRbk1JS2KTnHZ5$slk5SkQP6x_yFpUV4Z2vZ"] = "#=qg1SpeSLDFlfys$AaO5oWVJs2CJUCh4NVEKxFrBOr$lTsJ_r0jZIgDozR_16zUnOD",
                    ["#=qAzTkgudx7JhUWqNHzQjQ8x_WXqe_ZACxJZGaYUbHk0Z6nlqgU_DL4p8gQOqKm_q7"] = "#=q$KSp$23WiyM$l2dhcJ$OESum5K7xcHAGMz9PETkaSHjYJVb3CViB9084DxZRLSLh",
                    ["#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieUbfE72v3V3s$OdqHF8zPot"] = "#=q3UqA7WAox9J$aALjuTnb3$ed796mKVfvbfNIDYT3uuTKgvChYmysAXPxahKif7Sk",
                    ["#=qiwsJoRKMwWdhvT85Sf9k6gP6885hcsbWXIdg6BPvc7ACDIM7zFg6jDwsm0$hTsW_"] = "#=qLcW1h1QRc7tFJrXSLWaJtecsByhcx4CDNwfmZnwdJQ6kMVSdF04seOoKfatMY7ZG"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qND$lk9cgNmN4Id5kTGW_XA=="] = "#=qqhh5miLx3dpZ535oHk5blw==",
                    ["#=qXesKQzq0lrJTIkteFk_yfA=="] = "#=qw1oUes$$bJfpPZcfadfACg==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=q9hIs5pRJrvUbnEPHvioR5A=="] = "#=qWkjSNo0DA2xoO5R2NOv2cw==",
                    ["#=qN3JEg1UJpUb$mhLc4CBfGg=="] = "#=q8m3bTo4z1qC1Asz3Hrmm$g==",
                    ["#=q$2cdvbRDeU$SARHpRkFRTA=="] = "#=qnwPNg1cqS48sBKZbKmCnxA==",
                    ["#=qJv1WjoE_G3U57ndKGTAwsw=="] = "#=qBswvizaxF75Og7DwjB19jg==",
                    ["#=qkMcpoJlk3ZSwg4GNmhaO3A=="] = "#=qCcJsZwDYgmIJI4Ai3YCALA==",
                    ["#=qEd8Ig4SPZ09oZyPR0TL9tg=="] = "#=qYjIXoDHSkYhq6DXVO1dqoQ==",
                    ["#=qxmxkqVo1tpoztf9dgubC$w=="] = "#=qrbyqOSUBGwNpjfKu3jr7cw==",
                    ["#=qpoWnzJ9uXmDnmOdI20_qzg=="] = "#=qOBpEfQRovVioa1wvCKmlLA==",
                    ["#=qV_OMvyu5tZd6$Kuu8Y5hTw=="] = "#=qdM8hEm6oRmj_J00qSt0kmg==",
                    ["#=qaFYN3cfuZAZiL0kZUqHfkg=="] = "#=qX4Sb1cQAm3yBAONNGDMYgQ==",
                    ["#=qI5zna9sEo0fLQ5OTs2j2Rg=="] = "#=qoacL7y2lgqcboiQzVxKA9A==",
                    ["#=qJPjeO61yFkt1AwALVUzpCQ=="] = "#=qQAwgfHrjdhaR$85Tc6gpZw=="
                }
            },
            ["#=qbDHq1QnTdnbI0$5SkMcc5oEC$df9drSchVoPijROKY$5GhnEBHYc6mlU4nn1pbus"] = new TypeMapping()
            {
                typeName = "#=qCOeG5DJD3BimAqbwGbYo_t2sR_sq7jR7jj$v0ffuZw_mYdQq0P35ZD3TGDXPvlIJ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFZ3AG8RlHTr1zbmlX1ihIw=="] = "#=q2TsIpKxex5ZqTzIdguq1lA==",
                    ["#=qvkgogawslSt6UCZXUCFD8g=="] = "#=qgVrNzzSPkgp_Ss7lz0UHkQ==",
                    ["#=qr8BlmdSSe7$ZKagu15FwYg=="] = "#=qGZD4A1tffMe0LlkU9eHcEw==",
                    ["#=qgdeDpu0SFkj2cV_aqtIXtg=="] = "#=qO0eiBs5D_KASs83fZA2$uw==",
                    ["#=qjdZtoovb3PZLrISfZ594HGKU$sPd$YygrB1cgHdNRLM="] = "#=qqClZJR7y93UuES$mdE4Qjmj$CZvXO_1pWo4fc0gG49M=",
                    ["#=qX9hoIS0Qjkc7pJmknayxngwsW5jeHwOlPCye6nyKzy0="] = "#=q0A6UIt_su2$Of9MsfAoa3oPnVuiiW3F3mXcL8QPgCzc=",
                    ["#=qgbTee0S2goGCB3m3eqLO0w=="] = "#=qEcK3Z7eIH$2GCzpkmGcTKQ==",
                    ["#=qohaX6Y9QgXyKjxw3adz7kw=="] = "#=q5ORVDGZ6ngVqhT$oX4E4GA==",
                    ["#=q9eAitfrg9MlS0aZXrqZ5xlhH0HwGjxxjS7r2rmVofPg="] = "#=qELx_DHJewpddDYjC2$qiIUYU2hOryYB6z6bQE$ooQmk=",
                    ["#=qhjQ4u2kecWPQp0T7NurJkg=="] = "#=qyFTiV75Mg6ozIiQ1uvCecA==",
                    ["#=qH57A70$bj2Zv3tftXZRo6gl7ASAQVb4KbBXDuy9DozA="] = "#=qIewo9SIwlaRhG2Pxlo$Ie7WRC8VXk5XZgeoxTimEFKY=",
                    ["#=qvdylndgKnB4E5$C1qp0QKL3JCaT8xUKX1vzCSrd1fgU="] = "#=q6XBSUWYMGlN0tgIHLgNSQCvrDTEIAWic3lgRuWzcYcA=",
                    ["#=qELpgEnSGd0edV4sUEoOMpnk$0wveJoyae8DAgNQeNP8="] = "#=qNzITKRx7xJE4diqgl0ovLoxAk_dltI_iexuaW9XXBvU=",
                    ["#=qMADntT8xcfZNKQsYHABplWeFQqYJPrfStyQEdr8pzII="] = "#=q356pM$wyz7hNf3VqwbC8LWY6H9XFVuMTtM$OTCmCVDU=",
                    ["#=qLch$3$kU1T2B3UptSAOtamdwKWHSvTlvhWlTcmBYT7E="] = "#=qxwQyDab41nqgB7eMPHtYLny0h6Fc0Rjc8WsDQsjPjRU=",
                    ["#=qG3CtpaGQO$3akpYchZmrUU3_f5i_PFykP1HCzydJ4MY="] = "#=qqc87P54OzA8hTqvRQuPTC7jq8O1OwqjJT768H1krpoQ=",
                    ["#=qmM9Wjy5DUB4LdDKqlw3j1FPTHuYD_VsQF7GseXSnVRU="] = "#=qtJh2UC$_Y41_qONA$V6Kpe6od5ytL0mOBYeaOOEDAf0=",
                    ["#=qKhHSAMCbvh$ZKMj_68RNl2FavScrlpwSII7ETYXcEwA="] = "#=qNth8JP3GE368H8ERAoERXXmSqTXaTxJH4u7DB2Kk45A=",
                    ["#=q9Og7snuhO34l66eFYji8bApWDPMKH6zlmeC4C3PXeSc="] = "#=qkBKJYKrrtyQMjcLyjSz1rxUZiQuNzGn24iWGbD$uFzg=",
                    ["#=q_YYKP5P5cNn11TK6qDI0wyyGtUTCqzQFTFVSX2fDZMQLtVapVEjynstaEx7rP5vC"] = "#=qk4Ev2HPNBpuW1EEDKdjlFzFP9VIU7G$QH5na_afbYu4ZtbLl9LV0fkRCPLcgNRSP",
                    ["#=qD51mro16aSbZEsNkQYGRczNbiGVNj5BK$fTc0yhNAJt3w7JxC1HgFkA6eq0J6rnl"] = "#=qwON2A7_cCTiCSIgbhomCx9YWaHLhLPEnpLTbDSdZS4E_F_0EilGlLW0qII5oMnML"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qUhUi1uojn3GCSqo3ZI1W5Bkop9NIGtcA8wxsnDK2XWE="] = "#=qX8dTO6P2s124lyggD5_EdqeAHh9qGSCCJHY9pvmvtCs=",
                    ["#=qidL69m2QLX$FFJ_ccEW2UIKu0cRZzNGHxrXYUQrMFrA="] = "#=qlpFd9J0Yc0Q6yxwd8YOf63eEIkd4EP9d2IeWhYkyzQs=",
                    ["#=q6C1eGVRYZHqGBJTi2h08e8xttiZ3f8T_Ha9OtGcDWus="] = "#=qVjQkKSm61htGU11n$EKtu5kGBP1IEL2JTFKIFbImpL4=",
                    ["#=qFkWl$Z18Th7_WkyqYQZ7fHmYFY_ua1RVHQR6tKL_RTc="] = "#=qwn06CY3oG3WAKb07sFslzuAim5NFcPPr6qqlINsScqY=",
                    ["#=qYQCAyrHAwyBPWZkHnAkq7onCfjZzszkovxcadc_55a4="] = "#=qCJDUqsttdDKhfSyS3Ads2cRn3_TdR4bSg0xlzw9Er3I=",
                    ["#=q6xGH3XU3HHSQVMrHazMNZWtv5HqOMnUlyQPb_GEEmMc="] = "#=qS_v7QOhrVe3d$rg2onNWB5e8QWc76gKVz0cVoQ0RJcU=",
                    ["#=qTk_BrNko617AO_FAGdPS9BMzcg4rvG_ulbytGXarlhGHYbvONRpNlufqswy5C6Xq"] = "#=q$6$juZsxr42R6wRgfEvPGJYtn2d$kWUklLsiWD0GKP_zI6tLEAVqgqvOqvTLdEoa",
                    ["#=qLpL5yvhRW1Gg27K6KFWsELBILDtJfh9XZP6T6FZtrYnSyRyW4xZsh52wrOP2F$N9"] = "#=qXK7opsxPxre9z_WmA$bug7e3La7mpi_ky3rHiLRcIpTTM9V7nK3ZT_51FiLn9QZq",
                    ["#=qlInGf2ovaGiWKTE0m7Qtz2bg6nBcLC_WbsLq38sAf04="] = "#=qXFTtuxqnkBFm3GNzVAuB6N7H3lqh1Ou7lKBD_0LHSqw=",
                    ["#=qyTKqSkiaktE5VAGnPxlzrTp3FlTNPM6jSnmkuQjQM20="] = "#=qTUm822XyLU$aHhLjAzX$N0saVWmP5GKzJrmQogfy4Qk=",
                    ["#=q7ZFhEJVAp28X6cHIxe7oVpW9vYdOZ85RQGcCqZ76W7Y="] = "#=qrlNNtMmzJ0N$68FMA_A8d8UIexTExS2wpN1k73pPc8U=",
                    ["#=q3PxRQrRxd97WOmhFiN0V6Ju8QJEmM7Tgul0mx5ZEBRc="] = "#=qalj$l3tXsvVaBjqtE_wf1wBU9MtbUXzlWmfpXsipycQ="
                }
            },
            ["#=qBdkKGWictHDMwxeo8bJsHoB9ItTZsqp4pJcUslpzUQq2GtiWj7VD1hz8yfy943iq"] = new TypeMapping()
            {
                typeName = "#=qaujql6scPzhHMC9v4wWkrRUcJ_zb3Zo5CLmjj1h2LxAatqkXIMoFehyXfhvjlgdT",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvLdwtLps354HcCd_QGnqmg=="] = "#=qdgheVj4kZYma624$7mr2gA==",
                    ["#=qPDsWtN11J8qH_0kFTkFhRw=="] = "#=qwOU8pJUrONoKxjsL3DDBmQ==",
                    ["#=qyM7mz5O0eoc$f9SpUy0Pzg=="] = "#=qjMu5Ghp4rZxp73J9WftLmw==",
                    ["#=qGgv6HTvjLM$FgBaHDKEweA=="] = "#=q5vXZlaRaiiHUanwlKR_2_g==",
                    ["#=q0OOliYogTr6LDt1jf0I4Ew=="] = "#=qzh0hpohjPQMbhLs9Gfib$A==",
                    ["#=qKg029D8oYh48Y0GLYQsqEw=="] = "#=qqOrWYlArD6PycTIWxsJ67w==",
                    ["#=qphHCxyHxgNBYR0wDMPZeTA=="] = "#=qdZ0ZuWtY5qq5ZBeN33wLNg==",
                    ["#=q779K9ZiOvMcT0L_HC5aRyGRlxhMWo$Niqq2Q8ElmX30="] = "#=q6tlABB6MAWJambYNbUlbMQrKxAPt0zj12VDj1zaX5cg=",
                    ["#=qSKX1leZNnSOn6ahGsvhiewQki2$EmopU2nRJGjdFMpE="] = "#=qQeH9A7CRaWJTKDcIWps_1GzXRkWaaoilmcaqr5cWg7Y=",
                    ["#=qRkodSyH4eYY3Kc7GqJpaFQ=="] = "#=qrfrKGJNs697u1OMI8WuQVQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qo6K6TCaUgW5PGLHVJ0zMig=="] = "#=qWQ2QWGfNBqueZ5WeVUMpag==",
                    ["#=quPMJzhqxEiQzldfuEfZkcQ=="] = "#=qlGUdbfL1hrkDxW32Aw95iA==",
                    ["#=qPyTV6ED7qEyGENL$3FfBa141FeUQQnZFSvDZkig_3DM="] = "#=qNlC_fNcmbdXBACddYeCm1yIFyUSGuT7yqYKdZ_945IY=",
                    ["#=q6htdcg9vPHtUPeLQfysa7Q=="] = "#=qP0jfL6TXeC5qf0g1m77zEQ==",
                    ["#=qIX0HrwfMGJM9q8zf9dh0nIOJXqrUwAYqTZnxe$S1Hl4="] = "#=qdWgkUljnZYJQruWjXxrqE11imjNLbOsoDrjj0IJtOQ0=",
                    ["#=qRzBNFsc9x3OKuCI0p8sV$A=="] = "#=qeaQ0HTz92VoaL6h$U_990A=="
                }
            },
            ["#=qBdZH3s$0tgZPTixd15e15lQhRDZlmNZAXXwqfix$TRwl4kw7ZmZXbqlDHA8KgbQT"] = new TypeMapping()
            {
                typeName = "#=qRASgsVFA0nXmOCucoudH5lazxpF$tkV8U7dmE$$a7kQTGKaQTeJvqTRDRqNXfvij",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qnXVrWmE8u7m_B7xK1_Wscw=="] = "#=qaa$Rq4R4JzBIQXXDvqiOPw==",
                    ["#=qUygRjYjwnhxiCylYi5sCBOBtgDGDWOEgmDeFGc$8$x0Pt60KBju0qZc9t6wLWy3g"] = "#=qt1wst_0K0nz__ayd5_tLP6Hl6VoZKN0RQ6nMvt1dKeRoyXwb5c6MiJwm7Ljg7QUk",
                    ["#=qiwsJoRKMwWdhvT85Sf9k6gP6885hcsbWXIdg6BPvc7ARCNFUebPBIrJeJCVEXxPg"] = "#=qQBc$lxQV40hgUjM_QdanrLDhBtsod0wLwtcixkEm3v6P$0iHDkFiWWrLV0$_H9oC"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qbg3M_iL$4kJVPB2Q5LgznA=="] = "#=q9wjU5HUlEy0vRBc0mfV5VQ==",
                    ["#=qO36GLobh2ZCJj3dw4rvVtw=="] = "#=qIM_UHv76wG3wE1jtoH4Zgw=="
                }
            },
            ["#=qbeVJh2MnSypEjYI2pYJng_gY6JFR3$A3dBUG98UkkjA="] = new TypeMapping()
            {
                typeName = "#=qSOn8n8yhlk9PMUUZjk$TcO4Y4oRIZqQUB40Op73UyPg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qBhCLIlSRug9CnSQDfJO5$TdxdS0O6Dfd3dcBMqEf3m9TVGactxQ7TBaG2_wtEr62"] = new TypeMapping()
            {
                typeName = "#=q8kFrR0JpoK4H_5N6a0lyEga4ss6aWbiuZ0pqivnVB0M0kCelOakwBmjjL4wKjHHa",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSZqfelCAEeFligFwpaBuwQ=="] = "#=q2$jsvf5E$qrnIHLtrsVZrw==",
                    ["#=qkR89griUg9Go3xtE7PQmDw=="] = "#=qxTn6SW3beUcElk9Tzss6xw==",
                    ["#=qKgNrlYrHvasTCliGJT0X0g=="] = "#=qNn$5_2fPIPHM81C7LScvNQ==",
                    ["#=qeyWUvfhyORP7hCDO2fp5IA=="] = "#=q0kdd5cNxQWgm$JUVJGyfgw==",
                    ["#=qhOZvHZYYINlMlHvAqPhW5Q=="] = "#=q7ORaSMkRcCV6uYQpHLRC$w==",
                    ["#=q$YJrKuz247yAm0YSfxwMDQ0hMwvmNFSw3Ybgx0OgvSW26qth6p0gqpMl4wa60_dW"] = "#=qxRUiIZwE5GYuCc6l6vC6iX6gPYCRJo2IVY8679D$PzVeaHUC$Gr4dQkxV_kmbq7b"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=q9$9M5WW1AgZM7m$TXNl78i8OkNlAkrFMVha2ZH8KmcM="] = "#=qB$5qEJM1Qr6c_pQbDbh13CgITx3kyjptACMvph3rRtY=",
                    ["#=qqy23bCyoCVK_zbI1ZnSkRQublD2qaP4eZiJNokbhemE="] = "#=qTrT5syyx5c2owgUgPoHj5TeeXjQ0UhKxZZF8T1Z3BmU=",
                    ["#=qJ1XuUxHWKTb8dqvXVefHmQLynSSQGUcpauGjCnNMsvg="] = "#=quuLdMYYAjSFy1m5dEE4RxYoEa_ZaJ70IPKJ$guafNXo=",
                    ["#=qrWcCC4f1VzH2tazFu0hTNYOKsn_IUiyIv3lMC12AKJs="] = "#=qLCJY9pJFCuGmKZBVnJqutzAb3cjqw_ePLst$clWZ4x4=",
                    ["#=qFTD73D2S7xksjpziGL4AeEBMF9CzqqkwwIDuiuBy0r0="] = "#=qnXNIFqaKziBT1jGmGe1z$M7PROiMykFzS210N2Ookm4=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=q28UjuLZIrP8u66k$EbtSLpF6lypDWfXAdYK9axSkRnI="] = "#=q6APtkBCKSZa$qYdaBLo0Ov7PXp3lotWpr_UybiCSTqs="
                }
            },
            ["#=qbhELBB_MKCPr2IiP072oUXr9V0W2FZBDS9fuO6$2i0g="] = new TypeMapping()
            {
                typeName = "#=qMp6I3VO3byRy4VKVHyKFjJzs8mRyFzv6MAHuh4p$7Bw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qt8gWAyVM45mQs7IPr2ElnQAicgjO7nNCledtfXO74gU="] = "#=qfRMF2vMV5jNZsJg677$Me2qyRXvKbSsWxxne4V_F6oQ=",
                    ["#=qWbI6BxALjeGfZ1IqImxSqB34lhKt8AdAMlktmU2Js1U="] = "#=qaeOOI5wTiNCFBYzZCrBkRF2u8g12IdjhXToK_Q5j3LA=",
                    ["#=qOu3Zmt2WP1$ddZKw2V6eGTwWuibyd9Mf_vdI4UcdHRY="] = "#=qVD2gb1Puh6PfVo_dSbOecuoIPjoxaudWUcotUjGeBvs=",
                    ["#=qJoAS_955ZIzB$Z4RJNgsVtRrTWz1vMjP803oxCLjtVM="] = "#=qEbN1JPGrzHHkuDx$MQ2xxJPN6MQJwvyIhiuI6qDdS0I=",
                    ["#=q$2GGDgYH5rlC8YUYaPUBz7IaQS9_$$UQbUg9pBOWOCA="] = "#=qvebyldWrwwAC6NzpmLRRL7BYYqkKhmpaC40qKBUyRL8=",
                    ["#=qXSfSy0soce4Hh5wH58TPHaXMDJLQqHlTiscWDWwj1nE="] = "#=qcM2wMMRdviPwpL_Hkcwosim01tE8yZ_A7pgBcpsKS2E=",
                    ["#=q6VtP7HNLkMH$8$tnSxAtvg=="] = "#=qljaCy1tm$q3s4aYF7Z41yg==",
                    ["#=qR4T6KNrRuhbr1EeKmfoneQ=="] = "#=qZH9TRPBKWV$gidpUI3p_Vw==",
                    ["#=qAVgoDunjFkrS0_NBYGhD3w=="] = "#=qWlcjdWrVxN5OVLpwGqPsaw==",
                    ["#=qec1M1VyVOf62Q0YeXNMMLg=="] = "#=qKHfRH$KN5zICAlVnv5n6Gw==",
                    ["#=qtrjIiby7wX5jLa559WD_7Q=="] = "#=qi5yB4HuvlBRAr6zCQXPz_w==",
                    ["#=qXWn7Zt3EQ$pG5db1uNpS6Q=="] = "#=qj73G_V8EDPXLw8z_hIfLXQ==",
                    ["#=qwgzoxw8LCX9Kenl9QPMyHUCWVQHL7ZgBr4h2Q3rknZ0="] = "#=quPh8enXk7JzqGatel5k$n3NpoK7CafxKQLGtckbpVqc=",
                    ["#=qTnVqI9ztJiIbg0cj7xUo2Aazis2UQ$TNPHKj$_X8HxY="] = "#=qMUpBlZ7Cu1fEnvja_CWg2qja1EU4kJayTdJxOi0$1XM="
                }
            },
            ["#=qbJ$cMp4nRUF3yTVSOVk$fl_WG1KS1jP1PITWW4P_d$Q="] = new TypeMapping()
            {
                typeName = "#=qmKiZ117r6SFV$DqLKKmzWBh25YQ_cUUEWmSArZ8mCEM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSv6g0jPwU5vU$z_Wi0ByQw=="] = "#=q9Vybh2s7QL6SPPFqhKpCQw==",
                    ["#=q3oLN$n2fkBes3woey0XhNA=="] = "#=qLhzX7IbNa7vw33bEka1KVA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qu1sm0oIqPNWStL1Nz$7oBg=="] = "#=qyZlFz6CqApMpckNBmVnMEA=="
                }
            },
            ["#=qBJzEjnR_LdKmpQeuondivEfABaNGqtTP_w4F0B0v32Y="] = new TypeMapping()
            {
                typeName = "#=q6WW1iAINsNGbM7RbbzoDyoMYS$VNedrdL98UEDnpVhY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qqeV0vTsjfz3UhvTs5p6MjQ=="] = "#=qIKFmgK8zBRFb7C$SmEYeCA==",
                    ["#=qgmFTkbJjSBkoBE7B0XKCxw=="] = "#=qgmFTkbJjSBkoBE7B0XKCxw==",
                    ["#=q4MTZw66o$wsemA2WRmWQDA=="] = "#=qcOaPuvup4oGxA8HElTEN0A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qJcZ3OAAbESzjUlXOA6F2Cg=="] = "#=qg$KJxr3a8qJM7TVAHqmxUg==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qbK5_XE_dlrA2scPR9bpMMPhYbSsdmWXJbO9_OKWCWww="] = new TypeMapping()
            {
                typeName = "#=q4MaUQHhedSCwrP3aXyYFmrdQW5gYiQSmB5zjFS6RTnc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qMslj3_Y4LZJAlkPFSYfsqg=="] = "#=qDqngmLDBtBJ8oAvV2YKQxw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q8X9GEDrEe2EJB5aEy6tW$A=="] = "#=qPLam9ED5$JqkdaHYJ27qHA==",
                    ["#=qe6qoBZ_vqgAil1EX5G7Ijw=="] = "#=qNePzOL4FPvBlbNcpVL8cLA==",
                    ["#=qfvcCM_vlMUur_KU8AESFiA=="] = "#=qTXCdIgaiPns6mwYqYeRDjQ==",
                    ["#=qjzPzznW3hf$A1mXti04vPw=="] = "#=qSNB6UdCDRDTlN7$7rhySmQ=="
                }
            },
            ["#=qBKeqEw3YjIWRaVlcuy4nJhfJbmxnCo99nlJuCwNwJHE="] = new TypeMapping()
            {
                typeName = "#=qnLUYvkwmrava6anPZMrLftUo930EVPfJWBtnr07T8wY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qfI9YxORdL_DxQKyMYl4WbA=="] = "#=qpEuZSZYsleHTMcfbMy663A==",
                    ["#=qi_LmZYS8guXuxnNTJVU9Lw=="] = "#=qqAkKHVjnrMEN1mWb$wxsug==",
                    ["#=qOg3M6oeMaTvEOcE8y7dmEw=="] = "#=qmDrkvDam1QLqFLxt6lN7gw==",
                    ["#=q5FkCs7M5t780hTYYkAo2Eg=="] = "#=q14pUbo60I4nPmlYb7rMXiA==",
                    ["#=qzfIR3iIw8eSnrobY05kCoQ=="] = "#=qEg0V7N1fQ0Thi4VcibuGFQ==",
                    ["#=qf2a2522titHP0244p_FzGA=="] = "#=qvAsRgHFiDnlB3eIIEWdnsg==",
                    ["#=qAJb3N9l3DGcTL_7Gh9YvOQ=="] = "#=q$KCLy69B$cWHPZYZLTk0sQ==",
                    ["#=q61b7AtCn$H1FOseZlEMwZw=="] = "#=q$OBGfQN$PYgaWjrki2qFaQ==",
                    ["#=qk7Ne29RDRiUbvJh9JEqkKSBIZzcGykP8UZ8ao7YHKdk="] = "#=qCNTQ9kze_wZ1Pfv5MXJit68KLVs4kbZPE44HeelVE_E=",
                    ["#=qgj4aQzvjho3qbQqZ6grmyw=="] = "#=qiBZPRvqt1H2chmMhgBpmgw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=quCMLn1xd5C4fC9q8w24U2A=="] = "#=q$dCFQnrOWGaXvWsfxvRwpA==",
                    ["#=q142bE$9c0JjwgXSwgfhT3QUT7CyqaGJX01St5I3sREI="] = "#=qlJR5Cm2opoBASyZFms46jbb_8ocxOoyxP5jfPRWEVaA=",
                    ["#=qLe6kZpt86mnCcV81Y8iUFiYt5ooxTmtIvrjrXppTzI8="] = "#=qI0iJmJWAaJI1zQLx1T9fRpH__uPXZUb_oCD0130_LOM=",
                    ["#=qNcAD6qe_wXiNGuXMdrwCJA=="] = "#=qLJoUZ3FM2oLGjr2$wh9sKg==",
                    ["#=qlRYziqBJVFKbzD4BpIDglw=="] = "#=qtvd34006XtwYJC4omXMIgg==",
                    ["#=qy86C6L99_7I4ZbNy_sI2ZA=="] = "#=qAB$zW4EH68LIwfgfO6m8VA==",
                    ["#=qORUNlnDpX7dNZ46mNv7hwA=="] = "#=qja07mycWnWOZvPduzx3dCg=="
                }
            },
            ["#=qBKk_pBZhvvc0Q3Ul7$ic5ezkAgZoUdp9BqxarOpWEdY="] = new TypeMapping()
            {
                typeName = "#=qzC2JMydEDbj4oBdzG42EG5xREE8KqNFEzoGAs6Mka0A=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qBky7nGcuWJt8tyjD0Mqyl9w0c9m89fWX_TULfoTaU0CuyOhecehxxvtuVxV78_zi"] = new TypeMapping()
            {
                typeName = "#=qJpvwkt1T47Ngvmpr71fGGlvwogC4cc2QfmUCx7xSEMGty1YQ8_nF$5q4rIAfOaPq",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qQx52P3Dp6SaMrhwOIdFYrqmLBj$6T_jlyrd$_dFhEn8="] = "#=q_ek0rJB9qIaqc6mVnHVXu$JrpQgHJK7a1GIijZbC5fQ=",
                    ["#=qzV7CUBlXnxDMhiK7WQbntygVFv1VM1e$1FmGbuXEAGw="] = "#=qyw1adVgR0Dn3Crm04EbkjKSz$7TjxnsWGrLwXhy8mpM=",
                    ["#=qd1wXQaIiew6Hgtl6IYDPsg=="] = "#=qPwzcjCnhtINDZqLCks80$Q==",
                    ["#=qNJVzEAWqjHkRrZp2cMc_2Q=="] = "#=qwrkKsKXAPn1PowmcLoGP9g==",
                    ["#=qOe69$nZBC_WCOnGOFoYpEw=="] = "#=q$Q0BbrIpw8J8feWqYVq4QQ==",
                    ["#=q$AGqU2bBpLCQC0bO48FXvg=="] = "#=qqHwe2Hd_IytPgeXasdhOiw==",
                    ["#=q9Bt00CijS0m$wZa6fGcD1Q=="] = "#=q6ErrHy0bHWep6cAeUunV_w==",
                    ["#=qpWvhoGTEYlOMw_jSLbnnOA=="] = "#=qKXi1ENDT24dvdUDSxbtVpQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q72vDKXZ_GnpIbR18KUuIrw=="] = "#=q4w3t1Ve8lTClzxCNt0qwIw==",
                    ["#=qHIPybHAFdY80dZ$hcSPPLw=="] = "#=qhEN6xc5nO01_zy8mIDCzzw==",
                    ["#=q2OfuDpAKckUEob0ZL6YCuX5Ysjvqkbxzy54myBSgIRY="] = "#=q9w$kzMonp54FxZOcMSZwstRKUjec6Q05jKrP1_aSbR8=",
                    ["#=qPY5cUqQnnizp4gcVGFzA2g=="] = "#=qtVgAADzWCZMRj9$ioLun7A==",
                    ["#=q6$R32K$PN6jJdWLeabf5MYd27goOMO$RI_Lu7qKrChk="] = "#=q$Rg7DzyYsKOvkVnVi0bJogxPU7QOUt$D0V$M2OFsoXk=",
                    ["#=qeTJrVJ78d1UwV8US5zM7Eg=="] = "#=qi0Mid2wxYZcgBNnlPkdplA==",
                    ["#=qmnlIAE_MooC5laPOjUdhSLHXqrZqXYeUigTztDHCXsw="] = "#=qCiYNPleLYqWQUEmiTdpVA9Gb87qFY7pRdw9NR4UZGUc=",
                    ["#=qIG9yiH0rZngYHgvU89MpteUVCKgxVVUe9iNfBI1GFDc="] = "#=qsQDyrjyVdTCDsv7nn2RYzleL_SZvmJAgTgugICF$j5A=",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qrCV1Hb2i64oEnIlD2mkU6WJoA557zwIcYhkz1lizLEM="] = "#=qwZa832qjif5rAg4_ixq72NXht_Ek$XIBb_TOl1$l2jw=",
                    ["#=qoZbhXLTHMzZzcRiRW$INbQ=="] = "#=q1AEUnpJ_M5P8jcSdrhc6iw==",
                    ["#=qSQ8yPzmvU11HhkHBW6fPrg=="] = "#=qE$7_tew234YIA1Gkpa22ow==",
                    ["#=qp1kxRbRVjj94yChRmI43SA=="] = "#=qXNNzXPKnZ6DSJKYKWtSOzg==",
                    ["#=qylJt1xIz6wcxrOYJz6fD6w=="] = "#=qBQc0JsKnJoyoTk0sGP9fsQ==",
                    ["#=q4n8QHgDWtP9DlExR7ESz7g=="] = "#=qThEhEg9pMiTg2SoLOzKD5A==",
                    ["#=qc7r5vUDldyED$sYe_rnExg=="] = "#=qZyuSstfLM2$NzlBuoaf1CQ=="
                }
            },
            ["#=qBnCIqLf_1ZgpoF$i2eA6diMBwFyZFr0wq2zuiGy50Iw="] = new TypeMapping()
            {
                typeName = "#=qWikBcckUIfjL0CZC1Yqk2Rz7KrczevXaanBEH2gdDVY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qBUrqNBXESIySJpE3n9Z28A=="] = "#=qXca$Xvf1ZeAdEtqDBZKJCA==",
                    ["#=qXT91hMiLdSSrXY$XnsuBHBwaxrrDnP9O5v5X3x$KSEc="] = "#=qdVEB6t8obCVGKURVzzB4tKagJ2VmicyS6gjl5ocLzRQ=",
                    ["#=qXUtc5Cgdj3Ewvqtdd2kkVw=="] = "#=qS4nXx$a2PWo4V1s9Wwt3tw==",
                    ["#=q_KADlYbXpyh9lmRDoXW$mg=="] = "#=qZ2WbJcctuzz8IHyoNe0Msw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qSpWMhxTriM0LuPVZ24vkJz63tvGzFxl3E2OdRK9WHe8TuTNKKp6Zd30FMXdXxBRI"] = "#=q6D113FIIQc0B9YppMaHy54ki0s6gbOQazXe4lgxVJo18HMtc$cg19CXo3QKKPsuF",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=qbOdrLIRO_tcg0__kGmg_wQ=="] = new TypeMapping()
            {
                typeName = "#=qK7HU7BDV7yNZ6oVPB7Sl3A==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiStj8U4JZ2wlQtREO8VN0A=="] = "#=q$qiGf50A2wj_wKDy8iRNvg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qcwYayZXplw_sOXuvSCJrfdIR8R$9ScAY8gD9qC1lAz8="] = "#=qk_kx9bYzbCb9D2VW2JYkS5GkrKUkcE3f4uW5Y328p2o=",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A==",
                    ["#=qRkmW13mlp0Kt7d6XTdiQPg=="] = "#=qERrhpHafICKgNj$hMbYnGA==",
                    ["#=qQAzB2dJbyUsaI79cfA0P$g=="] = "#=qyOUU_LCuPJ4o76EvRMtx4w==",
                    ["#=q5BEjc3rtur9m$Sfwxm0dDA=="] = "#=q5MGCAwRboa7HOfNO8ThMOg==",
                    ["#=qEHp9BcIqHEV$e4wXIDPcDQ=="] = "#=qDOjxtuuELq4KYHlRum$lGw==",
                    ["#=qVmBjwA_dpOvlyY4TLsCQ1w=="] = "#=q0xM9qHc5BQisQWFvxYJvHA==",
                    ["#=qRpT7W6SDXrKS7LLqtj3A4g=="] = "#=q37ZF2zhgOEOsLbngc9u$fQ==",
                    ["#=qJcZ3OAAbESzjUlXOA6F2Cg=="] = "#=qg$KJxr3a8qJM7TVAHqmxUg==",
                    ["#=qedibsGLShIzRSXZ1OScamA=="] = "#=qkBzdR4gD8NXc$Wnct_ZS_g==",
                    ["#=qGx3GpBiFJkMtT0mZEuqC0MsBRQJAmo_sq$zZmphuoy8="] = "#=qt6Va$9Y4F6bMP6v248q4Z6xX_TlEaYyTEkHzY9NUUhM=",
                    ["#=qvD7U9vGQJA9u6M3H7xGVmg=="] = "#=qk4X03CP9dpOKk4uKFAVX8A==",
                    ["#=qOxnFDbKrOuIgr26kLrf9CQ=="] = "#=q0432yTBkrYY$TNT8dwn6ag==",
                    ["#=q9SjrznTM3JD8Ik500veQwg=="] = "#=qTf2DROhcXtrZYmHfZHKa1g==",
                    ["#=qJuAKwrEtFYjlg4rq$jqNFJk5I9CpsWGlFZJxHtOZQYU="] = "#=qadE_iRAngf1Q1qqu3nv9tUaD96ecUJUF2IexxyXFqUA=",
                    ["#=qOMR5j_yJSDCzqpF5dtNEqQ=="] = "#=qtNPjXu_sShrkgm1361ETkA==",
                    ["#=qLcx6VWPMK0Rh9WT0chhHNw=="] = "#=qoB2AcT4eqceiY28n2WYEDQ==",
                    ["#=qvmb5aGdtamiBrTjp$WsbMF7lE2N8KgMo$Ae_KEo69uA="] = "#=qq40wZ1neGmwFNJtOcl2ZLAi19VNPTZnGov94lAca_B0=",
                    ["#=qSuYa8kPPo8Js804ms0A2BVtzNuOq5R7guOihVgPW8bI="] = "#=qWSNveoXnTP2ulhNlu47sRy_OdBHNSLHuVpbl6SqFnAM=",
                    ["#=qGQF9KKMKINzrne2DKV5vSvUs3P$WfTsQAgUwxn2sKQI="] = "#=qGldUe4EMlPY4xb8Q2QMCBgsk90cTTn2rZV_1dyLVuVQ=",
                    ["#=qEURq16$r$UCXmQ_$T_oUdw=="] = "#=qGUfCLcIcQZHj_8WDt2Y4rw==",
                    ["#=q4ugzacNk6h9WVZq$VL3w_Q=="] = "#=qNNsFD3xlF0aEuE4wU6z0zA==",
                    ["#=q9Tfd1TfPjNdly76p3csX6A=="] = "#=qKX8IV55pKd7EiuPbfBZAJA==",
                    ["#=q$e6RFw048wsSeT4yI0vmXQ=="] = "#=qgfA3WmApgvPiI245y5TN3w==",
                    ["#=qjKpxqj4E$KFAeuZbPsUN8w=="] = "#=qzd5YTim908cauXbTi9ZjMA==",
                    ["#=q0MU52aKj9WYjgrCsJ33gog=="] = "#=qkvSQ6wJL_ktyQaTYayzYtw==",
                    ["#=qQppdTwOSIwkp3cSQL9hF7A=="] = "#=qF$nbyxQMhRmgiY$MagoUng==",
                    ["#=qSBtIGxoTXFx5RkyfWIUSyw=="] = "#=qJH4aX$9j6KzrTrvGqKhVwA==",
                    ["#=qFND2l8DIAnq3H9LlJUpf2w=="] = "#=qXLcXots6plzGC3B9x19h_A==",
                    ["#=qQOO2qUGaxDnOKRPebNO_PA=="] = "#=qhtq9sK5ZX417lILQtmlyKQ==",
                    ["#=qcWvYmlzeSCXd3dvNUFFQnQ=="] = "#=q$yf1fEJB1HTKwBhJetw9Uw==",
                    ["#=qtgLcOt77HvOV$ZRcbFT6Gg=="] = "#=q89BevnT$sqITOz$CigbtMw==",
                    ["#=q6a7cGRAU4BmKVd3ycGhZYg=="] = "#=qZg6yO9iWMAmuMtBSbekZ3A==",
                    ["#=qXjIKETCVqATu$RPbJqHuBg=="] = "#=qDYYHtL7K13UV06iWlrEmVA==",
                    ["#=qoxH7V8RFsLqbZBCIGEcckrWLrgVBm1IUx9aS19KDW0c="] = "#=qisdKZEXULt5tkT5qu_dHHtQWoEx7DkJRx4zsxlUeacE=",
                    ["#=qD_M7_V8NtYHBWDm02TIxbg=="] = "#=q1q_U3a5SZpgQ3QcGjPBWuQ==",
                    ["#=q8iSNeH0$gCiWaApfKC8Xqg=="] = "#=qIgnNp$nT9OpWBOslxf6n4A==",
                    ["#=q7kGP4pSRp2PhJWhq6gqT9w=="] = "#=qwsrqKxft$93qrYb0HDHZuw==",
                    ["#=quKm_ty432Yipl9cvzfLEIw=="] = "#=qAFwDiXY8BVoyNmKA5xEDrA==",
                    ["#=qUrnhTIM2b2mVM7mP6LAgeA=="] = "#=qTrdPkYWCJC1bS4XEQcYYOQ==",
                    ["#=qnKfs5QofFmD6wCa$_uIVtw=="] = "#=qas6ksCMxD8YHmXRhOzr$5A==",
                    ["#=qpSOA471bMKhFjg1wJ0sQzw=="] = "#=qDIZcjikJ7RW0u1MbhI6AcQ==",
                    ["#=qTEznGkRRpTWXHZYrtMMxOw=="] = "#=q1eKcQ2U5D0A6j83PJcVEXA==",
                    ["#=qj6crdasflXI9ZTuw3a9KkA=="] = "#=qm_iIncp_EJBJ2s8LyswFtw==",
                    ["#=qB3wR2Cci50lPgEP$Gktzgg=="] = "#=qB3wR2Cci50lPgEP$Gktzgg==",
                    ["#=qM_FOMN5MqYm2lHt5tEfmHA=="] = "#=qLnMVOgw2oKyweiBdq5KzeA==",
                    ["#=q$QK6aPuw$c85xKsFAVElsA=="] = "#=q7nqbYacTUswUOpXVTQg2Rw==",
                    ["#=qewQ1sbM7OsDy79Dwg1UAaw=="] = "#=qNhofa5ijSj$UR283B2Pcbg==",
                    ["#=qFOYJNuQ58NPhfAIS68bXhw=="] = "#=qmeL0TjRrGINs9wI$M9lDOw==",
                    ["#=qTLifiY4GmGLCmEWwNPNytw=="] = "#=qjuf0LaUx2fcsWFSTLrD2LA==",
                    ["#=qrtfgsXRYwNeh6fMxHSBgAw=="] = "#=qilXsSarHpiD5iREmWD4Xlg=="
                }
            },
            ["#=qbOX3fvZdG8$Bigb6wHxFeJdt8HQtYs4JPenQWoi5v7s="] = new TypeMapping()
            {
                typeName = "#=q0jI2ZLaWCip98DYoB2Ztby$F1nBbX8tzrwKox7$hBwU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["op_Addition"] = "op_Addition"
                }
            },
            ["#=qBqYP3e3D6rA9I$9xZ7geJjrUcxnidLbguCOJnLszr8I="] = new TypeMapping()
            {
                typeName = "#=qMbKpMZ8otuFcMlV0xldJSgR0Tl$Gl6UDnz4E9sb$$l4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qf198kF9pVNivn1mtOX2I_g=="] = "#=qn0d0bg3cLmxRkVsEKSPSdQ==",
                    ["#=qjK9hICj5hh28kDl75qmrrQ=="] = "#=qxsIJEabVvunmUyUtkMK0yw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkAnnVvmWTM4fMsbCwRgPxw=="] = "#=qgX2J7Izb_4dRqkL750KBdA=="
                }
            },
            ["#=qBsbyG_7cARxY$F2CTZY8svTdNFeZuFVcMjF099dZ5outdgKILSofI3xW$17CH4FU"] = new TypeMapping()
            {
                typeName = "#=qa9tfWBINswrD7$DhiqWC60gFAqrlbCEdhZR8cLNF56m$XzC0ZLID1czKqvUaqIhJ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUcNXHQ_$V6yQoIGD9u3n7g=="] = "#=q8$zaMM7hvy4MKRf4fQro0w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qBSfFdX_Ew7f0VU57sf5JAvXM7jwlZWiU7Kdx7DB2pCw="] = new TypeMapping()
            {
                typeName = "#=qn78Ri9iGGV4Ad_RO2E03O$5Vb2I4pGj5btmzrE3n3m0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiOsEOQfljnk7oGGC3yuxNA=="] = "#=q_8_0yha$AxZu3Xvb5vYVMg==",
                    ["#=q4TPrHDWi_oYBv1x5HgUt_w=="] = "#=q80eIBN1NAg31OSWl$f6lpw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qbT1thBIeLPuxqMmp$pqGK03U_vf8D5WKLVgjXQlZbnmQvLFwGOeFt9J$gQcYFfCN"] = new TypeMapping()
            {
                typeName = "#=qrN8FTf4zsIFKC$3MYN22uvzek1XDUBWtoO4heceuvzVjXE4wo24A4Ch_pkb$fQTx",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qBtOIIaml5MuKlkzPo$Zt1g=="] = new TypeMapping()
            {
                typeName = "#=qxhxZG9mEVHASoIICjwa7EQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEoZNCs7jYs7dIh6tTRRt5w=="] = "#=qiT6eAnr0XEZu9ooxq1udlw==",
                    ["#=qx42pLhTxBircB873l_rm3g=="] = "#=qDYnywnLIXj$2nHytZp3mdg==",
                    ["#=qwOCk8HO5LjCQcWfPWmOr$w=="] = "#=qSZxTvVMZi52wNKcJNN13kA==",
                    ["#=qt1TwlAKg0nG4MX_Rsn6esA=="] = "#=qTAG4pnMgO0uedBb2uODm5w==",
                    ["#=q3QDm8Zi3xIx9ATwZ033Bpw=="] = "#=qoP2WN_OFYiI_I0XeIsV_eg==",
                    ["#=qYPExPunioh$g2BfPiPSf6A=="] = "#=qn7n9uoj4ozmsFhon67G4QA==",
                    ["#=qJbtBhTCPyVggv0eLAkAa7g=="] = "#=qTbuLEEmqUcCx1APHQZX0Wg==",
                    ["#=qlCQoX5NGxfYoGoLagshCoA=="] = "#=qXytl9X8JR$Ar9atQU6j1DA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPYAIbUiAboHoNrxSgu4BBw=="] = "#=qAZhxDusde30hSxcYfI8_Vg=="
                }
            },
            ["#=qbWyx3Pss7ShWk_CrQyTUO1LuoJcuvzllaPH3pPAEeVo="] = new TypeMapping()
            {
                typeName = "#=qhUb3wd$XoQyHNjod7eC58iTUe3wj0XDyvWeGfuOVtNE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qb_g_sXJ8EqfHx4v9LzkO0Q=="] = "#=qut$0c8OR1tXvbn4tM9hhcg==",
                    ["#=qNe1UZLyiWg9YTb3dOiDNCA=="] = "#=qIHXxPDU$3p$kjNlZTNExuw==",
                    ["#=qTiPDO7Dy6MIhPS2JbGz_cA=="] = "#=q$zbojT$EH1wUjx$$yi3j4A=="
                }
            },
            ["#=qc1fJmaUKluYjaxr7lTKtjNBMLGosGEkwq1AFT9L5_ykj6XZBJWpp1QdV6sUj_OWc"] = new TypeMapping()
            {
                typeName = "#=qJjdy25dt4OUOH8coEEiTSkWsHBRR8OCwPpZSFe6m3H4cvLFJRUNZn_bI4ERuUZ4o",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qrVTryQPxkRnnObhh$0IIAw=="] = "#=qhtEK2NoKAJFtjpKqgiNRSw==",
                    ["#=qa0kAhCiRsvHOA5PCnHzLNQ=="] = "#=qZLFst3UASufFJqg3u43MHA==",
                    ["#=q9eF2uj5Jxiw1dB64KSbKuSyX3pgrfnFF8TmRNLMDi0PFc0yyk3$xkCFGyQX2oEdv"] = "#=qxlrUH$F2nxy$NdnTyPdpfW8WBs$aLdvJ_fGnjT1fFtvAeXp3hHHnF0Bm2MXcS1td",
                    ["#=qWaYqNNc6Lg8fpyEMm3C0amyG3H_ES4vRgihuXEZMFaC9LN62fQPTPrVh9rrXH3bi"] = "#=q0HLiEgCVmDgt4$dwdRMVVDkL6vI2FObjNrFJwZetsy2rYhYMH2oU9$2_u8fyzzrp"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qnICHgemeFDm6sDYeRO0fUA=="] = "#=qanC74deE2fK1pVoMsBDkhA==",
                    ["#=qqwDVJB_YbSR6j52K9b0eqQ=="] = "#=quPNR6GbrgWMJ4BZWLRDnCg=="
                }
            },
            ["#=qcCs3L90rtXy9ecth4qsk57huRDo0QJyoIMh4p1R3kvs="] = new TypeMapping()
            {
                typeName = "#=qhC9JpP8cxEwtodkJ6oGpyrtyPRqaCgwauTRXOblS1Zg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZE5IkeZ0AnBEF5fmR0NPKK5amESbioRuT7Bw_RIDrIw="] = "#=qR2S_PUL4n1_6$XhS6RgM77bz0kGbO4Uo$qLPqHw0ezE=",
                    ["#=qU5tjawI3O_oIxLtLYXpB5w=="] = "#=qo48vxk9Aj1eTbA8_EwH79Q==",
                    ["#=qz5YXNBJWATSzGaGmJZOpTg=="] = "#=qwZwiq2gdXNRN_v4iaOpsgQ==",
                    ["#=qvYlBPdkl7KfLpdIH4h9bzw=="] = "#=q5zt$6fQeBM0oZPfZCoAHgw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w=="
                }
            },
            ["#=qCeBiRfsRpwWP93rQ0WkZ2cT8o96LJcqSuf8C$Lib0AM="] = new TypeMapping()
            {
                typeName = "#=qymcDjUAqOSvNSA7Q9SfM1G4jj6CwiUkDHEU7bSdmpms=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRm_6JnE6nMqNTWZZWefqxA=="] = "#=qwQfppZZqTXSOVUYggydahg==",
                    ["#=qwrr2LyX$jh9FCxX8$NQXFw=="] = "#=qv5lqNR2xEPuvJFjMI05qtg==",
                    ["#=qqRu0tLo$WC8ipfWrWDrsSw=="] = "#=qkEJ9d3bhEvXsf5goNFLfDw==",
                    ["#=qnlIwsXB16O3JlsIgPE4ELw=="] = "#=q5sZdX7HPD2sFbtcJc5ncMA==",
                    ["#=qQUtODims5C0Pg_n3vJCQW9mmsWEgLndjXRxN7r03rBI="] = "#=qIZ_3Jlzv4c1Y9$QlzciLvx$$UN8hjYJ1jScUD$yPzs0=",
                    ["#=qD_eS98_4eQWgeEsneGVA_w=="] = "#=q$dU4vEFQH1SC$6rgmB2qSg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qCh9VWZ5rtqIQM5A0tHFVLUBdparU2HUoR8nCmvBY_NM="] = new TypeMapping()
            {
                typeName = "#=quHecR8oQnVB3obb_FR4LU6kMWUCsSnLhZDUQpyAcB98=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qY7pVgG9LZTmO2Dz8xDELDg=="] = "#=qCA40xcNN4odhth_nb1i3BQ==",
                    ["#=qzYsjW0b$YYYX5ZQe6SAhYIkDMLob2txASEMCvzlcWG8="] = "#=qN6lv8D6RHgoQ39hUhhEhp8nC_cfARbYP0N93IhXEYQw=",
                    ["#=qg5nGehc1RCvQzgMCEXoeeVGz5bB$_GlDPLJk4IKQw0Q="] = "#=q$_KCaqiZ6HK4vbS75CXXBGMd2puVKd7YfLxr0K3d19Q=",
                    ["#=qepm$18PmTgARCFSHUvLe0g=="] = "#=qRCEMOp$0miDHcQaFXjwXfw==",
                    ["#=qF0Aftz4ge5$kxpDNdVIYTH05jQnl$nz9vTtPFZ9Txdg="] = "#=qQoHEUAR92$lPVgtSU0CiabERdrChnJwD7OgArhWUjEs=",
                    ["#=qGZiH$epQRtUKI21HivHLVbgj5Ip8OeWKX94hz6bnvUc="] = "#=qRKdvr7kmFzXoVFoBMdBDLrod0vIgBg$prC6nnu15ItI=",
                    ["#=q5tlhPAUc_lOg1HUl_n9a1KKsTrArcjxDKD9N9p6x0yc="] = "#=qjC$0tmxRAwJWANuAHBEvQ3hns$Q0yROqmMDNQWTIL8I=",
                    ["#=qymtwz0cgEUbP2l6qzvo_FA=="] = "#=qeSTE1lrF8g9Bmqkoj4sHvw==",
                    ["#=qDE21hOlkwEYpZJE2$R1ePw=="] = "#=qN2LhP3$kxX$5jv9lJJK_dg==",
                    ["#=qlfOlgjWLZm7klZqd32eNgw=="] = "#=q34b_Xo7qUxBt8drgPjnPQA==",
                    ["#=qN6Z5i5Zg5WInvzftSIBjNg=="] = "#=qn$OZOET6uXvMU9tJuzAHvg==",
                    ["#=q0D1_ldofrwa0I8SaECbW6g=="] = "#=qun6BV7dr5o9iNXj7SKltig==",
                    ["#=qi_Rv5MyJqStt9zcr2NOZkQ=="] = "#=qza0lJMDFmj3b6pQJqrXb$Q==",
                    ["#=q3wvquU9KXS$tHp2djuIfQXEDe37OE4$_hlskVXrX0z8="] = "#=qc$3Q9Nyha9fVEaZS0Pn4FNCy1TLO2$FmB9rjFZ7l$J4=",
                    ["#=qg1H_nsLq$ghDcFoLfPPImA=="] = "#=qVNOWWkExzJSdwDEF1VeAZw==",
                    ["#=qRKd5_Wt1kULOtb7rLwsTyw=="] = "#=qxI4kz$7mMHKBviQeQxv_vQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qNhHGos3OsMZEDGetf50e2sWRgnJ65Qz12TbUVCoiKN8="] = "#=qGKmderUHDOcthwx5sesw4WKHR17ebk4NJBtj77shxiE=",
                    ["#=q0Wl2iouaeu_cIKWzKpS6iCCc4usq8OrtbkgK5aNDkfM="] = "#=qwZ$Mn5eD59gB48v0yX1e1D4xQ82DNhvamgFiaq$4awk=",
                    ["#=qCrfyWH83F1E02wdTnzu0tg=="] = "#=qb7YLE58OnCrIlH11bJsUdg==",
                    ["#=qw3xJJbb2Ril0qPancnV$Tg=="] = "#=qS52dhVRixJZxaz1A4mBsmA==",
                    ["#=q2Xoa9RMieiTWX4DZiAjZeQ=="] = "#=qZtt$cntlIqaRn9abAGEMxQ==",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qOrQYE9LJr$9baTcJpnAxrQ=="] = "#=qXsTJv1veRSm51TEq88u4Sw==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qeGBBKeb2NzBiJBDq11RQKg=="] = "#=qYcmdN$ur7xRF8cFHVbycnw==",
                    ["#=q0kRoAYZWnqMp5DOr5Etj5g=="] = "#=qyVtM7i1FbgZCMb9VSEf0Ww=="
                }
            },
            ["#=qcJA8gadtSF5t5XaQKYGoBQ=="] = new TypeMapping()
            {
                typeName = "#=qUO8TjBp39j$ZBRKnDt50tA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qXhUPU4QL9aBQ3XLHUUpXGA=="] = "#=qjggEQmLpUFId8PTbjWel7w==",
                    ["#=qJJso63_DGgOjYlqQUmJtAw=="] = "#=qwJGlDZQuXZ7CKJMTE1fAqg=="
                }
            },
            ["#=qclDJMrde0Rd5$tpRsWtTiworpt0$EzoImD4P$DiR8sU="] = new TypeMapping()
            {
                typeName = "#=qb7bFJWSsoZiVZ_H0UmcaGbXdfRbu7SYhQ7bqZTg8jhw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsIP96awbTo6scvXAbaQ_ezDKGrrp9Xbf6Y47ld4vRfk="] = "#=qpe8T3sotT0VrsPqmSuG2PDEjT2HT9YdplG2Tsyqet3U=",
                    ["#=q_14HSvGu1LPszyAqSQdQhFR_FdLmvYAZA485hskiIks="] = "#=qym8pzEXUHTiR6zvz3y1YKwd8KOWiyC4VgEMIZzla4uA="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q8FKbMYtCZK7YENji9rw6sDk8tYIAg$8qOSUg59SAu_c="] = "#=qDEb7Qsb99Xc6P0vYoQkAhxHhf70M5bEDVULiVRPgiuo=",
                    ["#=q1dOahQtNFQ8gXWfI7zQfvBYyTRBTJrdUhFj9ejUkals="] = "#=qkot685i2DeqPWT4pKJ89rKR4k9tMO4fpBdUGxbldrO8="
                }
            },
            ["#=qCpxXwlwwK05lTQzpYsiXL2vHd8DYg_0UUudbNZr9XiE="] = new TypeMapping()
            {
                typeName = "#=qoTlVjqpSQvw3nUja$ubgR7ElkjrPomimE9cUzY_xdHM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFFpT1KDHE49ovnBxE0dgUA=="] = "#=qrLo4o3AjA9kpjC2VeManLg==",
                    ["#=qrJc4wwhPJ9X8YNJ2pVnFDQ=="] = "#=qw146Ga8vimAEPANApVk5mA==",
                    ["#=qG3IfMPO_cCgb_wr4FgbxMg=="] = "#=qAzF1Le0xEuEniCs72TFFAQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qCqi3mTWHzP4W3Y9Rck6OoK6hQU1MKgh3sReIx4h6EYg="] = new TypeMapping()
            {
                typeName = "#=qAs6XNweKWAT6T8pUwFj62XAR9EtOp6krhqKoTfjdIgM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qL$34b6Yw9SgdPAIejyHvBA=="] = "#=qr1jYYIjpLKel5qXEpsJpKA==",
                    ["#=qQScLp3yfUtOeKDVQimrLHQ=="] = "#=qUX25cStK3Nd9mAYNYBCk0A==",
                    ["#=qD5JCAtFDPS1X15iFtwyeBQ=="] = "#=q$6X0a5na70xF6BaaE81QSw==",
                    ["#=qpbbP2kVc7a5XtdVwQEHCpA=="] = "#=qEeIFdMt__owQspgbzl2CgQ==",
                    ["#=q3Y3_UGfsyq4YGBNhMSVrAg=="] = "#=qekwq1g25RAX7R2BF3e0EBQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qFMkrpM_PI220sKsBJfgt5Q=="] = "#=qKunnMRZHRHijD4dXDRbB0w==",
                    ["#=qHkBgoyIDSijR2A4MTMLI2Q=="] = "#=qEeDrApVIK26JCRa7hshs9Q=="
                }
            },
            ["#=qCRx4opvFol1SP4VXGzZ6cpL90qc5kajHdf_MPDdz85bAD$_YputipNc5Txs4Uiz4"] = new TypeMapping()
            {
                typeName = "#=qia7Ayh4SFqb0UFLwsSQzKKNZhwjn2OvT$EouJqAYbj6tNYfqgK_iS3DTkHeI$$_O",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qctrEaRcpj3Z1qjbsQ2tZCA=="] = new TypeMapping()
            {
                typeName = "#=qKpxtLtKoI$U0rt3eAienSw==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qyxABli30K0_ipDDX5ugGRg=="] = "#=qxXEdMiDS7wKxs0tKFfFiyg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor"
                }
            },
            ["#=qd$NHgyE25bphJ9$pmpAnjfF11zg$usxAgkO4r2nIeqTi0z_m2POTj$ZG8xGRngjk"] = new TypeMapping()
            {
                typeName = "#=qlDyA8RZND3Df0voMv8w7KivD19JPyJkApnBCFs523ePd4OoJEIDSxoyKmfDoDUsV",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qiyaGMtDuin2e9ZEtGbOq1A=="] = "#=qWxHqhxXuw6PtRUt5SfnjWA==",
                    ["#=qmKqfvClvL2YQP0FHQZcmVA=="] = "#=qzzIOhPMqiOlx3XEwauAb9A==",
                    ["#=qeKVIuhn9WxGPm_wPNSGGSwa9o7IwVANoIImnxlcNHxM="] = "#=qfGgdFG4PwKvV30pgFq2klZr6IrPFsSO4FSoj3DXzVSs=",
                    ["#=q130Q3jhj5CHe12$4tvkusw=="] = "#=q1enhW8jFC74tsfW_sWjV$w==",
                    ["#=qiKIhYGuQHMGvh$luAKBZlg=="] = "#=qzU7O_vqsT0gejGynTApM4Q==",
                    ["#=quzl7rjguVuOP4Qcu539$AQ=="] = "#=qR35kb0NAlKaU44G4Qnla9A==",
                    ["#=qgYspt3r2gWp8QlSxQdsPuw=="] = "#=qlstbR3JKZwuXo67_aofYjg=="
                }
            },
            ["#=qdD1KZirMr1sLYN2dQ7DUYulEEqLV2wz4GTKSyGqvI9Sd4s5sbQ$qNHUBvJDR4g$m"] = new TypeMapping()
            {
                typeName = "#=qB82POvxYQAlojhql9swHZvCNMzHsbW4P9WJab3X$VtC3o7kjHjoghYRMOLT_rzI4",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qDfFDwthPMstmAtZ_nSzAjaxOcj51XcnBD49igb$ME7w="] = new TypeMapping()
            {
                typeName = "#=qbPeT52YH$8zE2H2wpUqFMjHFwztjLWcalTOQZm1f5E4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qXfCJCWqNDw2BjmqE3qN4Ag=="] = "#=qXst_NHSSfceyeR1viPRlrA==",
                    ["#=qRoOg3c0PBG9uOSOqlMiQtg=="] = "#=qUi6rFo3Hrn5EQZUzvG9lZA==",
                    ["#=qtxuANjL23y3hPGaXKeGm_A=="] = "#=qyCUUg8q62wXt62TvkFhd7g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qqudsU3fsoiOmFVJtl1_I5g=="] = "#=qgqHcjR8rivzIjvZaIO2$eQ==",
                    ["#=qdgtZcHMOnAH5ZPpp_sgg2wHXikW6r3AYKKSPyKV6NPM="] = "#=qtSqTAD3H_XDYVPmA9rAxs2q8jVQC7X00NkfYyzxxLZg=",
                    ["#=qL_2oD4sol5KsB7jNGZhXkQ=="] = "#=qMKDIjtrzzRykwcF5e42Jcg==",
                    ["#=qn0ZkkSh5ZrEOXwoVZfO09g=="] = "#=qLjxyrdVYehOiHxsfeTfCsw==",
                    ["#=qOXu6iDvQfUT1jYN_29$j1Q=="] = "#=q6JGRej$GlpAV1CzXzQgHGw==",
                    ["#=qJ5U_fuDhizS7oMjl0NZEPM_EKbfzHZcbiRtUVq2X4dU="] = "#=qsXy$QHkaDnrZail6s2O8luSN59fLkJCwOay9MxTJrfk=",
                    ["Dispose"] = "Dispose",
                    ["#=qLMPACBG1vS9mme7e0JqN_w=="] = "#=qhXGALv3nnxiIODwTdNfktg==",
                    ["#=q5hZK4tgP15DuNMXp3L$0dw=="] = "#=qzMnttI6JlfuNmsXBFpQ4PQ==",
                    ["#=qpHN0cMVjDWCc9HojFwhLqwPXUSRijVei9Ji7KBQKHok="] = "#=qC_9dhQFXxMlpwJ_F1LGDOKYukthwQmxNsNYx8fohu1U=",
                    ["#=qEdkrb1VvZ9wfRfUN4Mw8xQ=="] = "#=qKX6UMCQdpzgRCpqS_Dhz$Q=="
                }
            },
            ["#=qdKGLnt2KfTK9zD4G7oVABoHPmqWKuNs4WSYAqh1HVZ3susdV5V8wUWO$qRFxovFL"] = new TypeMapping()
            {
                typeName = "#=qxekidwiAcpeyFO1u9PWSBsflyLhwBWUGAeVBQIT5f8w6Z71uphxS7jPbcALZ9Ec3",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qa0QxpVhmfLS1WO91plaUCRamQlwOY23o$ibhDoTuNdA="] = "#=qHu43lJoImqn9cSKWDeVZkt2$wP37VLX9hTYS4opm9KI=",
                    ["#=q$oFzzpLeoVaQf2rMVZ9VhjxEwUGRWlvsOkhduy1HgKc="] = "#=qxeYpYt$tZn2jcIuICt_0f0cuErocIhkHH6KVxe$zVRo=",
                    ["#=qCSmVWrSkoLd8f$CUQXaBUmLSrRPIc0dAryo6JVWtZ6E="] = "#=qmJXGS2zRBcar$JhaksA6d4V7f2NO3h6Ck3Z7gjmLovM=",
                    ["#=qFu4mEDQvnqlq4CBjtaC2Fg=="] = "#=qAA8oUap_BBL1jjaHbXAmTQ==",
                    ["#=qkKoib5RaKQToazAaWPQntX2MPC_keofu24lxbOAbw_k="] = "#=qu6Cqsi$KmCHFbzYxKbRtXBsygrn9gFGc$c77QtWpNcI=",
                    ["#=q1w52cJ$$hD1OQ$W3Z5eerg=="] = "#=qW0n3EAnDhrwgGSsmapwlng==",
                    ["#=qOJ3iyYwoOzM3NMn9cDaUAw=="] = "#=qG5zq_W5iIsRsX6SXgIuTJQ==",
                    ["#=qmEsHp4ypq94Kde6x5jy$KQ=="] = "#=qGQmzXpaqJrr58D_oKL9WZw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qI06nyL1WVgy2Ys$lzQ9oSBmOl2PDEMrXVuLi5FeDVf4="] = "#=qXCtL1MxCm0$s0OrSFOxiosht$IPcngAh7c35nfMgQf0=",
                    ["#=qeNhC8QdFCxzKODPkPKLu8Q=="] = "#=qKE1xPLtbgLN9G0RbZej3pQ==",
                    ["#=qIX0HrwfMGJM9q8zf9dh0nIOJXqrUwAYqTZnxe$S1Hl4="] = "#=qdWgkUljnZYJQruWjXxrqE11imjNLbOsoDrjj0IJtOQ0=",
                    ["#=qRzBNFsc9x3OKuCI0p8sV$A=="] = "#=qeaQ0HTz92VoaL6h$U_990A==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw=="
                }
            },
            ["#=qdPitHj12X_czmZkbXRni6lEeOmSE6G1pfP405ryPYls="] = new TypeMapping()
            {
                typeName = "#=qNXTwa2Th8Yf3gtfqHsStJ0g2etWJaz6GVkbP0AS4jwo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qYNMWq8GurT4aS1QiXgqHOg=="] = "#=qfkHkGOTRu3VQMUvcsNMlIg=="
                }
            },
            ["#=qDqtE19lxN9D6JdOGDO29yICH8wmIFYBKPdjlEwO_zDo="] = new TypeMapping()
            {
                typeName = "#=qGiVFKb7tqhHBlxRtFIvv2RM_GO5qSXw$cZDoU8kSw08=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qT0iHDlv5lLtO$WNG7cesdA=="] = "#=qvZSM$mbMuXtjR3d2nqhfhQ==",
                    ["#=q5aVWFj1HIF0jiAmPMVKmLw=="] = "#=q6t8dOR7NWJju8ptCAj1n3w==",
                    ["#=q9ve6zNHqYmKbYyinghwvfQ=="] = "#=qAFjT42K5jtvgII9QT0yofg==",
                    ["#=qGWgK4WgCMszzmNyHC4xU1A=="] = "#=qG1tk9Rsovdb53pOCynEmZg==",
                    ["#=qg2Z1DP5hCb8u2tKvB1Z$gw=="] = "#=qxuayVJMytIuHZmwyJs$fUg==",
                    ["#=q8wNvMkYHvLtHNMOoft1fJw=="] = "#=q$V1_1cpvubY5DCdVLr0OIg==",
                    ["#=qslaA_A$Ccj1GkmFVw0x_Lw=="] = "#=qojdOLMgyrDcQzrLpjd6i4A==",
                    ["#=qs49OYZuGqT0PlUUurDffgA=="] = "#=qwW855vYL7iRZDYge_hN07A==",
                    ["#=qauJzZsXtiXiP6RAbhF_M9A=="] = "#=qhsifE9ElLhBU$DPzUTmwXQ==",
                    ["#=qOqtwLGVyDBdW9o7wzqyhJBpVuv8KoygC9r85hAodZRA="] = "#=qEiIKE1X9WC2Qe54_AgMRlmb5DBiGcdw7LZxb3UfLQKk="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=qRSNnwIUkbj046katTUNenAEcZqtcx$9LDzBMjsLz_tQ="] = "#=qk0kaqTxN$OR$d1tBatr0FEQKM6rRAs9IRo9PC3aqVIE="
                }
            },
            ["#=qDqtE19lxN9D6JdOGDO29yLhNDjgpwTYizK2R0LLn6fJUj2IR9hHIDD4bNSKDnfQ6"] = new TypeMapping()
            {
                typeName = "#=qg43VcHQS0U086AHVkfwhscT2j1B77DtK$$$hXb2EGOzPdBj6RtxH6BOOowxkEFpn",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUHPNe13CX4IYnj9lr$TD4w=="] = "#=qPyNfU4adaVzVVG6Yb2ndIA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw=="
                }
            },
            ["#=qDr0qWP_Cp2NyiV9kjGpBmIVaEf4FuNu2ktaLZ1aG500="] = new TypeMapping()
            {
                typeName = "#=qJ_866tZ8I0NI$e5LSp7vHKwrOCMlWfiMC66P3YD9GVE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvAWh_m7c311HrJr$ldM82g=="] = "#=qrE8P4XOBy4VwTC3qv0ZASQ==",
                    ["#=qrQ6x7D6t42np0xABJv0tWwG0dSTTQiSX3DrWEziOpGE="] = "#=q49sVOjIoXq7S6aNDA3pHdhjcebI64G4DeiT4Lgyjr5A=",
                    ["#=qKH9vobGLvdMvt2CJB84Yzg=="] = "#=qbZo5oBVarXk79ApNqzK5aQ==",
                    ["#=qBxyB6biYYqmXD4Pw500OgQ=="] = "#=qfZZxt5Dr4cHijA1_q8Zy7w==",
                    ["#=q1bJQtuQ1MH3tU7wNRovq9g=="] = "#=qbcgng4cJ$6zWSpDJv$xjpw==",
                    ["#=qSc4ZjCEuClHXK1Fd7pU5vQ=="] = "#=qE41opn9FI0628ulijKpuxg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qUJvQW24ASkOcKQ2UDawVcg=="] = "#=qkBj8p0GLF6cWYasMfNEhtQ==",
                    ["#=qgpTX9kOQ7c0CWsLxYc70EA=="] = "#=qdEHG93YavLoART40bBOrKg==",
                    ["#=qqFhB5sLviYX42RMX2qGH2g=="] = "#=qbxhrQFk5EPc6Z9yW4mljyQ==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qPZgbY6Kn3OM$9Yl_ST3xGg=="] = "#=qz1scTMOAdAVQjCINHi9GnQ==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qlZMb3Raz21BRU_mkbbXw2g=="] = "#=qlZMb3Raz21BRU_mkbbXw2g=="
                }
            },
            ["#=qDryTBdw9ksiCmdWq_V8cUzjAI8dHfog8SbhYCIMeCt4="] = new TypeMapping()
            {
                typeName = "#=qgOk8KKogUVMQPDqPbiq9sBh63$hFqEOR$sS_ooKPC80=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qGw3yGV55twUhD0NcUpGc6g=="] = "#=qZdNrZvYna1XSZ1zguAD6Cg==",
                    ["#=qVH0RkEdnzHSv$kuuCngZSg=="] = "#=q_KVbnKrSvwQfFPnl_SihGA==",
                    ["#=qZbx9rOCzdrQiv3tyPAc08NjN5i6aqx0bre8bC7DGrsc="] = "#=qU6jaHtHWAbBNh67yieLln6emLd6Jm7iPTIvHh6kQddQ="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=qDtNO7y_DRVkQpcWjGhLXRpQOg1e2RaSmgyvljE6iIk6hcnS8_njaGqdOEYlRr6JG"] = new TypeMapping()
            {
                typeName = "#=qRbOwFJFvgADsv83MUDDH31znlBF0Un7hFrW_g0Iy1nEwRNTraYMsg$YbvV972z13",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qQLCAxsglN3eFvAGcOD4fAA=="] = "#=q3g_b$5t9h_wKebkEkjDrhQ==",
                    ["#=qSeP7vHwNi8dC$tf2B4t30Q=="] = "#=qLCXIwvBnIYyBkyw4qoPEww==",
                    ["#=qwCOVuA6wAhfc$JWBLKZsvg=="] = "#=qjFZHVy8ioi1OjqbAKK$E1A==",
                    ["#=qFr5uLUaghM53gRVMYB9uQA=="] = "#=qpIwamUIISwGXjtbuegUAsQ==",
                    ["#=qCbns$5HWITuj5Qd5nnp$vWjfoJECFDOrrK_00BF$LcYouTWbveTYj9hDSZWi2dW5"] = "#=qxvXsEjr3Ov1NQOVfAPcyyPmMJnGTSYb9$Sof18kNXI9aQnFmv_3A8FCOHx$jEZU6"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qxBEcP4lqpk9mch2FN0XaQA=="] = "#=qbe0k1$rrRJH6p9zOplWphA==",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qtnGWyVbEj_ttqk$5zHnAJQ=="] = "#=qrCc3ZmJcokQeGpTa$8gtNQ=="
                }
            },
            ["#=qdV4VjzCtWXVdyvykxllTXcaOJtEpqYyuviC2kQzmeFU="] = new TypeMapping()
            {
                typeName = "#=qnroGPKy78Vxf7n2SZipK1ZHPqFCtxXNnOcXCWRSyIU0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qK5FrIDefdita5Im97AKGJw=="] = "#=qn4ZJuBZrkCkqH0GcsLhlyg==",
                    ["#=qMGEh27Hd6HYFCSP$ToQGAQ=="] = "#=q1p72UjBeQayQO6T8RdYiTA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6fdbYi0Pcx4sJaV3mKQ9Tg=="] = "#=q$P5YycPH6XGGglQte4SrJw==",
                    ["#=q9ESaBx$k4dfLBb9X3VOKvg=="] = "#=q$V_gATHJDQh21y8KzEQ8kQ==",
                    ["#=q7IYRgpjO9xNvPkEfnm093Q=="] = "#=q1yn35$gOoRW6JnxtHGx8IA==",
                    ["#=qyM88ud_ZXXnPI4il8dyEow=="] = "#=qa31cl_$KjOfiIUsE8ZIGbw==",
                    ["#=q5Q6pn87riuUp$AKzoRiP4w=="] = "#=qxY63fb2CvJaez9_NuZh$wQ==",
                    ["#=q86ryNYpi1oYiBjWx4K9J1Q=="] = "#=qPQhdFFSAxNSAMR8TDM8Nog==",
                    ["#=qLkuJN1KJxDyYLPu201mOyA=="] = "#=qSwQb8i2akxmqcqbpC6CNtg==",
                    ["Dispose"] = "Dispose"
                }
            },
            ["#=qDxFXU71tYys6169zzsC8OE7D7Chg3std9GGDncmqDcI="] = new TypeMapping()
            {
                typeName = "#=qLwQ9VlytdeVoSqs655Fj9aqWYfjAZsodjNGi__fk6g8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qDZ400SyrBNGwVxORbKlkj_dO$mXPCacJIkSKGB31mWwC_gwlsRAldr3AuNfyU40P"] = new TypeMapping()
            {
                typeName = "#=qa7GhxX4Xs7kvLPZQgfjiLEmjDdnE8fJqhSCe$9MINLWisyNGxNy1uUeAh9jtwaf_",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZENqwC6I4z$aIyynVUG17g=="] = "#=qO13rgouCvisfHkb1emngSA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qwAIApOijP91XHXutAHr2Lg=="] = "#=q$E0Wvgk_kjk5Vi67d8sgKQ==",
                    ["#=qMRM5VhM_IOTmk9DPELWfQQ=="] = "#=qpmuyRKhpLiL3$RJ_TjQghQ==",
                    ["#=q2oipjPd9FAsvCE_ZI5V84w=="] = "#=qBvpw$hNMOrSBVtcmWoJcOg=="
                }
            },
            ["#=qDZBd7Muh$FA2KbA6BX36ROrRuI9bk$JQCR87GQHHZAr8MlO8CURqizh$khd4Eea_"] = new TypeMapping()
            {
                typeName = "#=qmiWrikFDHCX0VzieQPK0rDHKtuLEUVGqKlas9jA9l3gK12mTM_SmIJLh1E$NeW_f",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qdYD4eUFI9LH16v24Nb0LeQ=="] = "#=qMEAGoMWro$MctRsVAnzWvw==",
                    ["#=qTeJV$l9XU3rvEZLASrEVKg=="] = "#=qr_OKi00OvMt7_wFKu3zKxA==",
                    ["#=qOSB1cI5cJmRSshrophJtNQ=="] = "#=q5MaWVwrt3Rec5JRPj5oCWQ==",
                    ["#=qIVlvkWX6Jgdwf1Q9kO209A=="] = "#=q499HT8IeWOFTKXJpc4c28A==",
                    ["#=qL9iadDUJfINZYiGdrIo_Yw=="] = "#=q8_sD8F7jVAMR$QXLTGYkng=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qa_YECF5LG2pd1AFQCElHPcPPKGQft21X7VISpeeZQBc="] = "#=qObx3NaaIIg78x0XRifNQzfEx1jiU0DCBGuGXGFgrYvg=",
                    ["#=qEw5G8M7Kan680nmwTVLef_5nsd3PTJKGC1b$zU2Z0sk="] = "#=qxGyZjTdPx_Y8N66A2tXtgacjU7H5OSzBVZFynVK9EcU=",
                    ["#=q3gSsKueCFyhOBb6x$hdtqu9_YlO6BZppEMds$$D3118="] = "#=qdQL3QRPBvl70wKKzhuaDJVHboSbcSGQRIytldq59Zig=",
                    ["#=q6W6iTAkjXGfj0FX$9SQFPFpS$JJpmfdiGbU_eUsg$Zg="] = "#=q7121L72NQ8338PQQaaBXpKo7bCE5eNI9kJtdw9achQY=",
                    ["#=qN6yTH7eDfsZb$3ajlcTc05Onok0eoyTvhLHod52eQoY="] = "#=qnbUlnaq6HooB_BF5j87oOadP2fQuTLqGWMSspr5NQJc=",
                    ["#=qg6I4o00OrhNBA0KNh16IqZ$czjzsFFKzUAp9OWQQRmQ="] = "#=qhae0BxewaXa5iNPpQYk025_ZKMCV9iDPzd67pYAAjkE=",
                    ["#=qqDXFjniFxWDxj3kuXxAAxolrP$v$nxx7mEyXvaMVrIo="] = "#=qXfWesxLlOSwhvztolgJpZhJ5kHb0AM6VicOVYHZm5u4=",
                    ["#=qGmz8hNI2dLzXQP_YaeVmUV7Wsvh0rqglSECq7mv4cM0="] = "#=q23DNcQcoKUVQPVBaG8AWuglANbFcwDHrXKBjJICQXTU=",
                    ["#=q8KHe2NxDIxEeQuHrBptC8PfzBnjXyuLaQTt_hfise_k="] = "#=qHjGH$HDI7P7LWL$vfdiXH5I5SU6OQeaHFBEutpxfQo4=",
                    ["#=qWeGmqkH99_g5bomQylFOyQ=="] = "#=qg4gvRZECX4XUNSUQy6jxeg==",
                    ["#=qLp3cuW3ZrU7MlfipLc7aew=="] = "#=qsQfb5MrHO$4DtZVRMmnEsQ==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=q8X$uuLj5n$blT1h7mjAupA=="] = "#=qAE_rv4QHsVM9$QDiYHNttg==",
                    ["#=qmCHwzz0O2O182nUwCXJsnA=="] = "#=qUwvi4eGkJYXlxYLWENZ6Xw==",
                    ["#=qenB2iOhatBkCHmE__xRCvg=="] = "#=q9WTmSUO5ZFYPaXkKMg8i1Q==",
                    ["#=qaOxVJ7wrWEnOZn5j9r6bWw=="] = "#=qUGL$K_H7AKQaS_wwWiX60Q==",
                    ["#=qa0ICil9$Kx1edQqNVbxUmA=="] = "#=qUnkm8K6ChyERvEZcXtHJOA==",
                    ["#=qLlba0Yb$iczjSg9mD7D6Rg=="] = "#=qSRDFWX0puGd3JvBvnxojvw=="
                }
            },
            ["#=qE_EbpOIfxb0TvAg_OjJMkDLuUII5_GtWNHCp8926OvM="] = new TypeMapping()
            {
                typeName = "#=qpONcwI8Y10hTKfG40JTj1gY1TRms6Yr3zePPL$HOYZA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q7VzE7e$YZAU$j52PQC9Rmw=="] = "#=qWPyz8xIFm$U50NmdKriwZQ==",
                    ["#=qe2lrUKs_OVHeJAHFaISmktclP_lQkrvCeYkKSxVUOqE="] = "#=qUyUt57hvj_u_cI3D_NYjsjyDO1aVC8mLnfKxY22CQ3Q=",
                    ["#=qD5q0IhAAXeb0GjvSPcwp3TeEjdGD0rJoxwnXfyMWYZs="] = "#=q6G2lSFGwLPKHJ4i6MJD69lACg9fS3eyORpPa_MEs9RM=",
                    ["#=qrZCu1r5qCEtuSvBEEgZXY66vrwB2YK1UBCMR1o18ma5JNu3iG0oBwglD_ygfAGcJ"] = "#=qdAPkmw3arHKm1Sn$jxIokrq1krlvlBNCqKKTsPDZz7xPD6ZmABLjw605OHm0pJMY"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q8BTC4CEKbmDP9VYyK1U5N5lHANNP0tgCXF5fGhxjwMM="] = "#=q0FaQgt25TxN8JHhODGgMBuwl7dV02E4UTkNvqXZWRZ4=",
                    ["#=qABggC1Vr7ngNtALayIRqMg=="] = "#=qzdz1k$vOySJI4s9al2vsJA==",
                    ["#=qaQX3Zv9qsD0Yjs0_S8kxNQ=="] = "#=qkVqA7rPKYmrIV$E2F3BGXQ==",
                    ["#=qC_3M_hWLKoQMW6dhYxhkgoA61kyYHtof0ULUMsPEfMY="] = "#=q8YhdGqxDO4Nj6gYLQRE7tklcy7YC5sKoe6gKscmyW20=",
                    ["#=q1Yp6NJ_pUcjPIhMVcn9LC$5QkUb0nDC6jJzAjwCg1gc="] = "#=qikhIKSlCmLM$PXDWL1g6Q$_mEUllwRqHx80R58XMZMo=",
                    ["#=qJCMzpLjoOfl4E8k0t2i7Jg=="] = "#=qIvBDGAPX1GkhXAbuHbd6Gw==",
                    ["#=q7c5p8rgKTDykTHMiT9I9xQ=="] = "#=qENaECjWTyGGbRQckFqy3lg==",
                    ["#=q138BP9GXcUCND9lglHebeA=="] = "#=qeCgTifTCHQ6tZ94z5YN8Zw==",
                    ["#=qjAbIO68y_rmb3P$laj_v$Q=="] = "#=qtv8UNC_gRBj7uzSXAo3q6Q==",
                    ["#=qcmmq2XCly2Rc0HV6VVVGjA=="] = "#=qi1$AE5cWzxUMBfu9qST0GQ==",
                    ["#=qJCn9qp9eRyeWVFHzx2wuHQ33D1f8HZuF5bFAvKG0zdQ="] = "#=qFITJHZZeu16aY_fbwLvuLfRRt5Jk2m6P31piva9sBiU=",
                    ["#=qKxhJc7nJOO$VR7e1o0qHHApPmlkP34ofjRMhwRekhfs="] = "#=qP_e9N24YP07B473tjLcruCiBGbu_IjRj0Wh8toUJ5eg="
                }
            },
            ["#=qe_isvAJEJ1HEnC6KWOWQu8BOqiUmhc0JXLqzOBrMYIEw8LeJZcXMnIJKXI3j$v4C"] = new TypeMapping()
            {
                typeName = "#=qTr45Urir2ZZ4dhj9YiPkKWeq3yf70f$13qfSBslMeMMx3ElD89KgGOiH3VOa2emB",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlGG223nliqonw9_3LRl5BA=="] = "#=q7918XJ$FYjIFT4EVYAi86A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qX$36CHdAJ7_QbiKxc8QV_w=="] = "#=qohUVmxi3XplBSenhh3HR5w==",
                    ["#=qFQKWIotwwkD7rczoirRCQw=="] = "#=qpcLRCcKgnv8DqH5bL6Nw2A=="
                }
            },
            ["#=qe1O1keWQ09kGcz_5LCTZJval7_kjeElDVM3ceFcz_VQ="] = new TypeMapping()
            {
                typeName = "#=qiZKYBVYcRx_o7yRjBOeoUg3Q$rr1Q9LTO_1ETQDQFgw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qU73SJryNjDpjxx5alPtLgw=="] = "#=q$0Lp5ubV9TE7YuNfx7tOpA==",
                    ["#=qr15zFQRtlH1gy6tJyTWC3g=="] = "#=qxVbgKwIHZSQPCMkIGhaoWQ==",
                    ["#=qkcnavgeoVJUx6dBsYf9vWEYjdmhRBUjD7G5YPxVrIg8="] = "#=qD2G8hjm0zKhRW1li71YwU4FtSCK5wPFyIEOuCCMiB_Q=",
                    ["#=qHeWeUKZmmtP6tjcwhERQ_PolzVnFBDtqBLBoT5cvvOs="] = "#=q0zkDZpyfhpOxTRKB1ZTRjAuQ2Blovo_bbiTRoVdQWbE=",
                    ["#=qK$ldsz$Lmc67gKVEyzYeVg=="] = "#=q73LznuU86gzqLPF92VsQRA==",
                    ["#=qmPQMTzs$iLhznQuJtEMEJa56dwaRtNSqmYqjXkcPwe8="] = "#=q6u84DQjHv7VR1PnHEmY_JCRXV9h0vVNqt$R8$oMDn1o=",
                    ["#=qvrxaY0oIvi6e0bBi8PGqWA=="] = "#=qlusF65SMvHBEIy$_F$hvUg==",
                    ["#=qd79VEwm44frZLSCtb2sCCw=="] = "#=qQAcllFYc8I9a24iq1o2_uA==",
                    ["#=qXnVn2qN3rJ6NhZiwn84cVA=="] = "#=qJKZoHouDPDou3dR6_7G1WA==",
                    ["#=qKYWszcP$MWOT5sO8XsFtFA=="] = "#=q7wwIEYfwI3UzAPO10GDsXA==",
                    ["#=q6WdoHtzpQeJ1P5TTWWn0T6vDRkiSnGaLElfNVGSiMIK9SbkxrWb9rke6p2sz1eoU"] = "#=qH5dwz_iUIF2lUDbzQBRMYwHcivjD_SKrzKHriW553w1iAa4uzFL6GfDvkxlAjbOU"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qCvoMTd3qDDvgXr4nVkkq2Q=="] = "#=qUFKFqRqbwg_6fi9RTcuHdw==",
                    ["#=qhwe6Wau1uZwTWMJAZ9VqVQ=="] = "#=qzZSh9eP3lCmv5eT4_FLkLA==",
                    ["#=ql$LTIEwRmhPrsRPwtTr_rw7tgC7MeZb$h0rLZupgNMM="] = "#=q_sxC9tHROB1zt1S5yYCh9KND7SF0kaiBET2TSqZC4Q4=",
                    ["#=qhJbmGdLvoCLlup_wFHqcR8Tfr0DvylbeR$5nyio0gb0="] = "#=qn1POSw2Kh7A42vbumLQjlMI1t_YhdssTWA9QiWhKbzk=",
                    ["#=qAVs$00XT$vzU0dxGnWAbA8zJv7q2pMw$voPCJBpeUoo="] = "#=qR5gxojeXTtVld6kYRgXWZXYbu2GyJRtu6yw6Od_XtPk=",
                    ["#=qy84aON6ee8t8Vr84mZ0l5g=="] = "#=qv49CPQIPRGjUz8rf1qoKUw==",
                    ["#=qeOZjmwHmZ_JbSug8IQArCg=="] = "#=qgiE4xP$TmEK8gkI6wth$5g==",
                    ["#=qoIews0euNrZhgs6$lLTKsiC8UOBFzXykiVOQRxFIkfY="] = "#=qkGm8SP8hy34Kq8ue4iH66_C8QKphnR7AXE3j9eMxabE=",
                    ["#=qpRLkQ5sgG9Cw$h1SaQY9ZQVpcUhEN71dQOTXxOLQLZs="] = "#=qfc9iRc4F8QZR_ljgNl$e8iRzgxCPqBq3vWcK1kp0gNs=",
                    ["#=qB04XMzOYJnaOBmOKw5$k3sQeLjV7VL$mayQ3QAQOhHs="] = "#=qIXYSRvqzkBVZNJvWtpxhM$s3YodJ4$vbb4IbxxLlXbo=",
                    ["#=qvTX98bBujHLJGYHCE3kvfmRMfqDD3qAuH6y8ihV_NXo="] = "#=qgtDBjKQlF4qqAfi14pCaW0klAlVc9iJviAlyuMHwecA=",
                    ["#=qN4sZBplHpEFMvxxdT$MPGA=="] = "#=qNhhTmypFDJbS1LYMoyemLQ==",
                    ["#=qaZfQsua61CmebuBifhDaVw=="] = "#=qJ8NJIXOsxwLcz6KzhX3pfw==",
                    ["#=q_iAay2aM0K2$Eo6V0n7SZPJkaO2F8xjPMxafqmLTffE="] = "#=qN3uaxa3yskfhDjRyZq$Dd6rViQniKb8MO6mSDSNj1$g=",
                    ["#=qhMtHY2xy72mZNGmTQLitaA=="] = "#=qJDkXqcDW0tSWSLLIlwH74Q==",
                    ["#=qUeipm3uExpoOEUNr33ZB0A=="] = "#=qJPLuVA6v_tB$6Kw87VSGIw==",
                    ["#=q0Jyou$Fnsbz08j1KidhQhA=="] = "#=q6FQ1czUdUqhkSq5KVSHFTw==",
                    ["#=qXsNun4BRumVyTIXpukyO7Q=="] = "#=qetFjknhDDnWqo1YNrV6AFw==",
                    ["#=qc21xSdALTXhoQqBteH8XdCJwxgS44GnvT9$zic8J4Dc="] = "#=qptnqJquK3QiYPjeBnjawnFOolD_N3grVngQmNsogDho="
                }
            },
            ["#=qe5TxOR5qYCiOxjF$$wHsdc9y5yQzOEATGJv_H00A8Xs="] = new TypeMapping()
            {
                typeName = "#=q6LuOO0mn6Dnnb0uSbunfd$mYsBAx$tlc868V2HDOgbs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=quB21AbRlY39qmWabzKQPAw=="] = "#=qeLmgf1x0m5RlVGPfpJha7A==",
                    ["#=qc40WoDIWdePuuP3KNdU52w=="] = "#=q0SNJd$S6n4f1OD0gx2nJHg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["op_Addition"] = "op_Addition",
                    ["GetHashCode"] = "GetHashCode",
                    ["ToString"] = "ToString"
                }
            },
            ["#=qe6q0trBerH0MPeEiyQpYSkozMIBiQ0kpG_BDMb8m7tE="] = new TypeMapping()
            {
                typeName = "#=q7RScaoZQqDvKHv$cPJE8j2kshRbS0z2x5f5aW_LbdMM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmu$tZ$h24g_IbDJqgX_TwA=="] = "#=qAwFtsWisce1rKK9VOxRViQ==",
                    ["#=qCnThCiY16Yc5EwGViFaYMQ=="] = "#=q46eZgepBH9vuXlac6SPScA==",
                    ["#=q7v0H1rXkvuqEU89JXaTk7g=="] = "#=qBoF1fcppr7pRakwzDd$E_Q==",
                    ["#=qVvRN4mdEkv6p20nkbs7X9Q=="] = "#=q93pKcOBOsPk460tLK0n$7g==",
                    ["#=qOkIVsQxP1h$wl5WY6Jjt6g=="] = "#=q36bfpYUvtfYsC9jeZ8pH_w==",
                    ["#=q8QGK4WwytF28awrJizHLeQ=="] = "#=qbYZM$Hkb6KQHeC0A2PtY2w==",
                    ["#=qR5jkR5uOPCFIHqO3ChVMmA=="] = "#=qJKQ1Xm_tny4goNAoMtIVFA==",
                    ["#=q$7g7IuwcadA1SpI9GoWNeg=="] = "#=qh51_yY9yyN5eYjcY_2p_9w==",
                    ["#=qrnQ9W6u0FvkiCMdQEvilkO1L8qKmuGjl33D8LmkPuhA="] = "#=qlL6EyY$hCbHaIsNoBo5AY0PAnSdC$IkxeL1axy_j6is=",
                    ["#=qgUNLK6tSfosHo2yDxXPYug=="] = "#=qkS5j5Nk0B81UpBZijvq0zA==",
                    ["#=quH8Gu6v53G7Gsl9Zgvhy6PkVY7AkmWCg_LmI6jeFrBsFQEWXbalkni7SNtltW0XK"] = "#=q5f35OFP0SB29ZVRS1DWeWO0dFVeqJLZMn8aq8$7J7KYl7X5c_EnqM8LNEXIWsIwN",
                    ["#=qSQmOYNPlnIFPzEBKglSnG8BHZUs1Env3SJ4vP48KWhJYeXbCsNSrSUoXctL8VlyB"] = "#=q0zs_goJjyMCWBGkqp1Ib__WgRPM4xeeSjwtNKapXy$72t$3W_B7nr8XEjRJ5NE7J",
                    ["#=qf8eChw1TWdNbs8uu65EZDoC2Mh3wXZGNSpsa_rtPqeJoIPQAvTei9hBgaWOxKI4Q"] = "#=qsLZXYNDe6JFj_8qaypi5dzo_vOFyLMNjuqVpKVzuU7NRnM0flaWvc2gzdx$Z96Km"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPlRISg$iUlBm9tvoNmxd5g=="] = "#=q6z8aNhAlK53XQx_qSq$tzg==",
                    ["#=qVPKFBlRnMgo_u4B0gkcqJQ=="] = "#=qnS6wkm1lvq0XwI0kOVZ67Q==",
                    ["#=qtrSm8A0ozKu1sAwqHQ$yUw=="] = "#=qMa3lY1cOrBJkYI_dvOsL1w==",
                    ["#=q1n8n7C1QbBu995GX7qP3Vw=="] = "#=qCaZyX4916r1WTQ4t11XP8w==",
                    ["#=qkV0vgWFk3yKruZWHsc5iLQ=="] = "#=qm9A1vZGePzY9eKkUT2Ujjg==",
                    ["#=qldX1gxbzF3kXWMcdnoqHOw=="] = "#=q5RbVZJkHuXkjVWsHJ1TIPQ==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qgvc40b3hOroAgIPbVBFAr1kxyfDG6N067cE548fHxPM="] = "#=q9td$b75uUCtQMnnp$L7XVhjWdwwZTJpuHxEmlE51PUw=",
                    ["#=qdb5mZw1yEL1CQPRY7VZFHQvTeWLtYvOEzDubVRb6w9w="] = "#=qznKeNCwmZhuytrgVABZQiV$2TwpBrzmE5ceXc5RF1do=",
                    ["#=qyGlqpfGRWLEFjZCr6oltNtFqv0O1_LptZtxPkOULpOk="] = "#=qMP2h9Tc92BgWoVSK8gaLeB$NoAfqunlS7K3HOD0P_eQ=",
                    ["#=qPkOX8htagazkz1GPEsdb6B$bDp11UI$vvioxp$PF8bk="] = "#=qUc4p59J$B7j20PxikIwUoAjTsZYRPazocM0bAA7uxO4=",
                    ["#=qvfmgYWcwhzep5O7TTT6jgA=="] = "#=qUXByua5gTNjTX5VOBaH8Hg==",
                    ["#=qIA1y188Td7$rqr1ZeRV2$g=="] = "#=qycQ0fCMsYeEpk8nrb_0gIA==",
                    ["#=qNie4MqokUSO9EKSl8eyFR4RdhefHT_H7HQGUd8f2JHQ="] = "#=qzWNOGuKtO5kr1vX2mJfn6kDdBkqru_v9nLGIJoEI6gY=",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qhGHXPdtulBFU4QimDE7N3w=="] = "#=qxo5wkZfuDkunNL_lvLQWxg==",
                    ["#=qkjyfN5lrWRLfnxWvrT54Ug=="] = "#=qgY0Ypatx2Ae$k5Mfvucpmw==",
                    ["#=qWQOaP3dOJorpHmmJjSLdeA=="] = "#=qXlEAaJnZnUjWV72ndxDL1A==",
                    ["#=qPjHU2DKU481_78OpmYgWKw=="] = "#=qTS8Fntr6UloL9aMZqGk07Q==",
                    ["#=qoX67tNBq6rVeIST0_p9qLQ=="] = "#=qn11rln0GhUDC0z8l4pX4gg==",
                    ["#=qKuh4p5czvINuecfirp9O2g=="] = "#=qumdwa$XBFvONdSZtyV_2RQ==",
                    ["#=qo7SIZZKyieIu4WOTEJUhUhhpolgaVcxT2_KYqKxmeAI="] = "#=qazu75Jk1YJX4QHPWepbOET7Mkf4VQ3Th3t8EFrcJB5g="
                }
            },
            ["#=qeBnMIK_kw$OK7cAEGIwh4aS1$ABmBOizPwmyXcK12Bo="] = new TypeMapping()
            {
                typeName = "#=qsV9BaoSTHdIvpRlyAL583Xn_xT8eaqJlvbgeVUFPlUU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFZ3VeVH_F6N5FesFtGfpQfmVgu$4Ijo8xW8hw7x7mzE="] = "#=q9TiXKZY4XT$Z6fU6e8g8pJRsFcIsjULeRM1x3LeJTDQ="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qeBnMIK_kw$OK7cAEGIwh4QKrywq0NJPD2PrOjzB5b8g="] = new TypeMapping()
            {
                typeName = "#=qyI6BCZWLY2a1ImeuEBIyhGfmiCyvp$t$WQHi$GzVRSY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qeEZNexmpHmY3SQfCDlimkPFQ0h9fDIwEfIdTBuiNhSPEAssSsa6vPV82Q2WPa6yq"] = new TypeMapping()
            {
                typeName = "#=qJVtpUidt8RuGRTLKiayfG2C7GDWy_TgRcaWUJKLmtq0YLkgW3k25yGHtrEwEY$io",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["ReadJson"] = "ReadJson",
                    ["Create"] = "Create"
                }
            },
            ["#=qeGd6ZR$rRWpSLJm$JVDgN1EZdmqdLXBrSCxQXqZdPY0="] = new TypeMapping()
            {
                typeName = "#=qn7qTu$TjKjaTeseU8ZXqOljAQZKkSRfhcMJqszCJzmU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qOYc3uwG53Jv89vaO6uhZX6J4y3zmSL8pVu7ncTjR3WQ="] = "#=qepLXVyqGI50STU_7lp58v3KS8sFVQg0JrVQAO35zZOM=",
                    ["#=q0o7Azcq5RwjzKxee81$jXg=="] = "#=qj00Qi7wDJyyBm9OYQ6Y3sA==",
                    ["#=q_k4$7S$0TBWBq62VKM2eEg=="] = "#=qdv8D4SZ9x6g40SP8SwvvbQ==",
                    ["#=qM4BqAuHUC_niPGTBulBJOxg0YFXpeubTKkKvBeEefu8="] = "#=qoTsKa7Z0dNlRrQwlcrXqk79MLuM8IOc5WQM75COSoRI=",
                    ["#=q7DHdghmqGT3EkU3LrzN8QA=="] = "#=qHys__1t$z5yOcPCJKx$JsQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6SoEnIIYjVzC4VL65h4u5A=="] = "#=qzw2$6xJokgkJw_zWpuX7cw=="
                }
            },
            ["#=qEh8VOMYLCNQYd8HeCpcL4R3To97fYXU9_wxlB8Gc03a8TyxCEiA5du1UDRT56A2i1ys1MCfyGd_8MzlLgGDdhA=="] = new TypeMapping()
            {
                typeName = "#=qmm7ACtxjOWKxCREWIoGtHr$k9laBr6JUG_2a5Er7G$sqjL4g2CzNdxcXyVLC2$g0tPJ01Qt_AreK$OrLzo4Q1g==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qakvIE16ZCS5eKyXS0IBu6Q=="] = "#=qefAIrJUjQcUb77R1$zxDxQ==",
                    ["#=qBmAlaHJIYBvXG2xevxR1UQ=="] = "#=quD9T6thtAiG2CBtWiX8uvA==",
                    ["#=qK5BAbhw7HJuZ9DD5_1Revg=="] = "#=qbEnWDDnVV_MafqdwUEmoYg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qeJLu7TLy7V7_d0tKFhCJXIwF8yPflK1HtZywjqpOnvE="] = new TypeMapping()
            {
                typeName = "#=qY7C6EW43R3hbDNvJxb8AFs$xtj6hG_K1uZW7YW$Lm5s=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qInNw1MxCKjYdsdiCHicm3A=="] = "#=qhZAnvMjJTaaDRwDRyfDTiw==",
                    ["#=qdtwp0dmw0IK8inZXJ01Wuw=="] = "#=q0aesPhTUlO5VPERp$Fo5gQ==",
                    ["#=qx0_l8pnI2JruIsOcenadpyL70K6t1xDvi08bU9Vr9EtgSLIJlQiJ5Lrm4NJ7QNoS"] = "#=qRo2RSCVTwC8kVm3KRjt1lrqEBVa$HrQcWKtyQ6cakyavCviMDAr_Lke3AN56_a3o",
                    ["#=qrZCu1r5qCEtuSvBEEgZXY66vrwB2YK1UBCMR1o18ma4C4PxSLW$RCMcRgnYokQRo"] = "#=qxRUiIZwE5GYuCc6l6vC6iX6gPYCRJo2IVY8679D$PzWd7ybleHoECXAckFG$WyPh"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qo9kSg$HZwCmKoRPYIe70WEuI5_8E_gmWBNpN25WBNpk="] = "#=q2k3wPZakplaEzDDHZoh3U2kAmfVDxaBzecD1BKY3a5U=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=q2VDSalZqEDaMOZme68EiNg=="] = "#=qj0fFr2LGdM8sp_TZIBx9Wg==",
                    ["#=qZrKvTx6eGErp32izkDTZxQ=="] = "#=qGrTDpyqAtOmGMmn9Tx5cKQ=="
                }
            },
            ["#=qejS46NNA1ZSHHI2HASr6FLT1bkw4YU_A8O7PgSuz5Ib_Y8zZsPJMKqe5ZEEDEuLt_Tb_q6gfVLoN33QqzZAhXg=="] = new TypeMapping()
            {
                typeName = "#=q4YQA5FQELKUqcnP0suqYAmBaUOj09lZK8zUXJ1gKqxHnGbQDL2vu7El2sqDk43Kq3Qhkw2IZSfDZgDusu2G31Q==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=qeKAJk$eVD4Ww0ROicTfICHLvKFA6F1ZtYeLCdlaPZmVFipP0ApDs$sSSae0oTLLH"] = new TypeMapping()
            {
                typeName = "#=qCRx4opvFol1SP4VXGzZ6cq_g2B5zWt7FX5ZtjOR1323e_WkC61DEKo4ibDF1cyBz",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qtg4kkcj$aZarNDXTyA4YHsAZ1HSg0K23wvfJqYcMCgw="] = "#=qHxRNs3hHNIFId8ewJpWaxWJJ44xIi6rKXuR1mucPJK4=",
                    ["#=qLRw0eztr9_R4BtcVxTD49g=="] = "#=q0ANMy7EJfGiUghtEjNuPNw==",
                    ["#=qvfJteKCj$aQlURLjAqBrEg=="] = "#=qRGPT32XRFDGSUzo57yC2bQ==",
                    ["#=qTJNie3PormsoeeG6GNNssRt4ZjJZatVe7k9SG6KFiCU="] = "#=qNDZvCbTSe9uvxepDv$XrEEkR1aiZR5eLwWKI1sQWcqc=",
                    ["#=qmkHv1G$N9KhPheYvfNOxbQ=="] = "#=qf3MVtYPlwgFMnb$BXULDDg==",
                    ["#=qGIecOYFBRqMrJywi9wspxF0s08p4epKu_nvUEeQA0R8="] = "#=qUN6zuzN$67uF7CZZfiK8wkqzISxvy1Sf9xs8t0UwjrI=",
                    ["#=qu8eWLpc6CZh3aH1GOQdL0deFtGP6Uy0V3qfpx3bK3yw="] = "#=qYfQe5raUihNgFOIScTJNo8oYfWwgStDaWw_D_zwpl9c=",
                    ["#=qoK6JnaT3_72DBJKVpLU0cA=="] = "#=qWeh2OR5fCAw53lrEsAYB0w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q0hzcSAYbaws$B6exZrMsGn0OEGHCk9X2JhHB0qwxzHE="] = "#=q1ky8KJyBJshKhwv2R2_0_8AgwqBXxVvPMw9MjuAUums=",
                    ["#=qn_8nCF9$4L19pl8ruXchvpgBOtsOvxlZqN87ucl8Jlk="] = "#=qyPBLbIsXw22QAnFGUO21pNEEexvpR3EOlJdpXTxurJ4=",
                    ["#=qgUVtbGwZnu1L$htMhOFj2Q=="] = "#=qc9FoZl5RYeoVVvLUneoSNw==",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=qeL6jnDsaoJ22ir_JE7B3jlmLH3SoKnFNzDrdbj3N0Dc="] = new TypeMapping()
            {
                typeName = "#=qfWCRBfNFCtuRrn9k8KzmVJ1cDyrzix5IYG71Lm7Qf1Q=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qZpGauInog$2EievYnD$PUcxl_Ojm574kzM9zURZGP7U="] = "#=qgwbwH9$DCYVYRcDvoQzk1ta4VwRwsyMTYvBZ5MKxymM=",
                    ["#=qkiTbgnBFWz9tyRHONCEmcZcSfD5PC_NUhNd1fXm36Zs="] = "#=ql0v1SqfUhMw8a6SoECf1gyMp4A6070IkSYgfKN8PMfk=",
                    ["#=q8mL51Jv$BmsdIeuqMiWy7JKRXEoi1WVgGEvU0sCJ3OY="] = "#=qIE$Dc6gtgZpcEmbfKBbOiRVAstH8qxeZNeie5EiKLe8=",
                    ["#=qAUmZzLGHTcyC8MmWg6i2oaVCkgXFoGjZTir36ZzuoUI="] = "#=qKa$8V7IalDLi1IrewajM6pPLofZpu$fmFqJ6qabaDj4=",
                    ["#=qRzajZ7BSNEfh58MlEo7Oua9bUY8QaofcfpjBrRPgij0="] = "#=qHkcIyM6F_$u95uTilWBvuwC8T8X9WyAnnsEi82JvYRQ="
                }
            },
            ["#=qeMkxR7vaaTlQEKn3e3$h8aYHI9cwaFN$5ZslOd5Rsf0="] = new TypeMapping()
            {
                typeName = "#=q7QsxErjJ1ZbDcvLp9$CpV3_eCptJRoc15Zq4JnyCUdE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAMqtiQZPeZVF4vBhYm1YfA=="] = "#=qmo4AbGjycc5KBdWZ98XcJA==",
                    ["#=qxLDstlDAFLoAT$PuP5el5A=="] = "#=qpxLLatB60tBGMPgO$HpQxw==",
                    ["#=qSILAmO29qwyX7F5qy9yPrQ=="] = "#=qm09rKJIRVwtIk4Rit0TbBw==",
                    ["#=qtWo_GX2KrE11RsulBVj07g=="] = "#=qIcSYsC4THe9yZBKwzcxCOA==",
                    ["#=qvGWDX2_p5dHh9ADMjvII6g=="] = "#=qO1eY50Bc8hrGDn2UTHlWWw==",
                    ["#=qXqYNNXHa1EshR_DUpzQTAw=="] = "#=qOgbxZeSPQCQkt0nTvYTq8Q==",
                    ["#=qWTkmFSjTtQHwt09O$k22AQ=="] = "#=q$2T3Au$Y4U4U2yMqZntePQ==",
                    ["#=qwU8KHRzlGPCy0f_JazUY6g=="] = "#=q_VFfP69nEq_f3m2lXTcNWg==",
                    ["#=qajw2ytdJhEbNkDt2zAjQ3Q=="] = "#=qAIsJg1c7VmdddFrY5k3D1A==",
                    ["#=qS8IZwmlJo4cROhW$s8LVcw=="] = "#=qXtriz2ZxhgTPsD3fOU0_Nw==",
                    ["#=qNsKHf_LaRXE21IlmwRCRKg=="] = "#=qLkua054UX3GRm6OluIiVMg==",
                    ["#=q8SkGy0Us0c0Tm2sfolvmMw=="] = "#=qGlxfGwfpm23Gq1Xt6d0u1g==",
                    ["#=qKst6760c2wrEQcIQ7$_lnfFqRo30i1KnEWJyD0IdCa0="] = "#=qq2tPPRVctGSZAaOUocTMqo4XkDv8R_mx$BAT3Vlpbj8=",
                    ["#=q2EFFSSATZEqIYslIzTR92Q=="] = "#=q$H0tXq7sO4Zboo94SF0wPA==",
                    ["#=qYUiGbZIMET1EMoXsxRAmyw=="] = "#=qyFZcqQLdE$5vLsTlUsWHCA==",
                    ["#=qyNxCnvHxHkCwXPytDR$06g=="] = "#=qT8t5sewuqHZCPYxEkAWYQA==",
                    ["#=q6uzRWG5qpp3DpRvGqc$K5g=="] = "#=qKTRK04Mnhb1F0w2B8gGqEg==",
                    ["#=qUuS9yf3FG8B_MmeH16lkr9UluQ0S5ea2jpZeOjTBhBFZLxJzrBfPj7CrP7EzxNb4"] = "#=qPEHBaZZtGwQGLyafG6OpE34sZ4JfJfANDA3oLadmnc3sKTStOsNAyogH$iLS5h8I",
                    ["#=q5TMIokeivS_tFzY3nEFeHsBJs$MKImDRrb9em105O5APv7n5tSVX909QsMJi9Sqq"] = "#=qGPmX2qijA1cQEYAULpUSrYT8sYRuBtFIbBEpTtcj3_JSN0efpMXChXEyLBO3Zba6"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q8c12My1kgNi0MLOP_zOe7w=="] = "#=qYOEhfv0tkoOBYnGBk5nImQ==",
                    ["#=qtrfNZEqemibLg6gEQAyrpQ=="] = "#=qUeHd_OAA9RSiMH6jBw5$Ow==",
                    ["#=qh0t9yw35841pXxCCf_Zh1qLIOlY1Ba6RsTC4ebM87es="] = "#=qogRKt58wsmwIWlFCNlJcIldTFcvsJ4fL9tAoTf4KFJA=",
                    ["#=qBO$nOp7_sWyNclXNHIzxPQ=="] = "#=qe4HjaFHqt9Js2TwLm8fSiQ==",
                    ["#=qKpPmt2R$rW50aKIO4JPYdg=="] = "#=qsqFrvvuSaKHCL2maP3ffGQ==",
                    ["#=qT5fhGoZiL9rldLqf_Ydisg=="] = "#=qBlXF8aZf6pPZHWW1DEMIQQ==",
                    ["#=q97MhQmmdrAlEF_8EOYsC0w=="] = "#=qqayUWbADV7MZm8XTM9TcMA==",
                    ["#=qmRwo8BofkfN_AqDks7IeGw=="] = "#=q8iirplM9BLRe8QO_V55i6g==",
                    ["#=qWqRn$d2cMZ0ammWF3dC_9Q=="] = "#=q8PkzY$M7U7ufaazTrYy3uA==",
                    ["#=qLRNI7kIue8ZCO2VY9sBMKQ=="] = "#=qSj82PhhRzY98M0Jt6x8ODw==",
                    ["#=qclpDnFqEpGBx0h1ozj_BnQ=="] = "#=qlJz6Lyz0RTAHQLT7k0zGcg==",
                    ["#=q5fcm61k7LrdfiMQp06xlFA=="] = "#=qSkkafNkc3RIu59uXkqXI8g==",
                    ["#=qHXbVF_vVpmi$T$Fvyf9AdA=="] = "#=q_FvH143RbnjMuixHXVcrvg==",
                    ["#=qf5CjhwLAMANylAB3VbtqHw=="] = "#=qUgjNlZ8SZjgZgQ1Knb09IQ==",
                    ["#=qo1kqEBqr2jHRZHCLJRWbdg=="] = "#=q3yCt81IRsMpoevyvQ911IQ==",
                    ["#=q2zUKBRRxwu0Ec8lGfJ0mTQ=="] = "#=q0ZzDwuM3ckIcv2SExRRVRA==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qn3FrUrxVW_0wwjeqY1OiK2GaALghURucj96NG9KYgIa$vlwhYSqdJMuh1FPjGsc5"] = "#=qojaJhKlXXa3Az6kJeCa_S59MRKcy4WgzfjsyLTUqnCrYWU7fxWbl$pioqp1r_Uev",
                    ["#=qA_Tcgk_OoH0yQeNHNyWzxKpCikA$WlxXZdvAqJrae6Y="] = "#=qUHcETDKMyTmSNjyT44SihmN1Tf3GQYr1jtbNRWYGNzY=",
                    ["#=qSKNJEvkaPHNRJAsfx7cOhw=="] = "#=qOJv3pDJiQI3eMqmjn51XpQ==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ==",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qbxgHP_JF9O_1MPlgzzh1HA=="] = "#=qbJug1vN2VC823003namU7g==",
                    ["#=qh0sUTwjJWn4Ekz7APWaSxw=="] = "#=qPVCVa4w8mrqwp537UDvBeQ==",
                    ["#=qZMoJsyWjqkNIS39dni7wnQ=="] = "#=qYoS0OpOSyHzZ6Rdr9PhhMQ==",
                    ["#=qQvYQSCFG3JQw6HSZCnuhAQ=="] = "#=qmhjsE2tld$9Nit2_aVGdxQ==",
                    ["#=q5K81FODeIMYpY7CHHAWxYQ=="] = "#=qhhlsFrdvG4LVpFkqOskkaA==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qdPSM$XhmdSeIJsFSlPsAkA=="] = "#=qYbsPvY0ngToawrp4ZaWTcw==",
                    ["#=qLLScOj$obrn66cR6Q4aTug=="] = "#=q4HRMCImnVV41VDcDBLSAIw==",
                    ["#=q_rKTlntlJmkIAnzj3v8jwWocRPnTP6SCM$DxwK7qjyw="] = "#=qe_QdJJvmNe3tsZnFPBzds3QivFV7lygrqXk2o80qWRw=",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU=",
                    ["#=q6hCFzUJTqdp8c4BKGMNTsG$vOP1WUOTSymVgMzIiMJg="] = "#=qg3fAnTZF_CBeRk8xdIPkVM4fcYfDfXn_385Ohj$SESQ=",
                    ["#=qbsZHkFF9f0xIn2ws0ZbNyHJ3p7gpGKHneccXi9iFaxQ="] = "#=qMAycosFymtKWztiAe3euZF$m_14vdYlXKLXD5g24na8=",
                    ["#=qkWLPHHJmKGqTx6UV4zExHG0RIyAqdBsNWom3GGOvobc="] = "#=q4fHSl0xTbmDxts0z7wIDb3G1kOgSFciTK3XS88kyq$E="
                }
            },
            ["#=qEnUk_aFapc_5NjZBNA4KKlrriSseF3tmJ_$LxcAbpCE="] = new TypeMapping()
            {
                typeName = "#=qyET7JqVXFX$Z98vLBkEd4Q5BCuRh2zXqrDSSURJt0UU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmrsk7RA5lfEVczB7rmwFsw=="] = "#=qjMq8sJx6ZgkGmIBLey_p2g==",
                    ["#=qBqB8mqXkmpICviYGbDM76Q=="] = "#=qmLCCTBXJAr8nlqdihusRlw==",
                    ["#=q2ztBBu8$pdDAzYz6sZ_JHQ=="] = "#=q8aggqYgqWBcU4LubK7jnmQ==",
                    ["#=qtE21ceK5Q035BlKzB7bMxg=="] = "#=qPfa5eBj4WhA5Z07b$x6SBA==",
                    ["#=q86SgH7R7x7ZU4Y3VBRPGwg=="] = "#=qTX0eZJqFoaQspNZTmjbx1w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qvuX5STZFyY2yOA03lS3bZw=="] = "#=qLAytGLU1qcVJcNqNZWs3dg==",
                    ["#=qmjzngvqp0hcmI0IEUkNPcg=="] = "#=qWaXXAc_$B8MIldiaFXgWgg==",
                    ["#=qEY$fK88u0WhT0rDw_t_1BA=="] = "#=qeyWswdBurUlrrNMsAs1aow==",
                    ["#=qvyZ_TL5rdDAjdlBblSNVgw=="] = "#=qD0pqL3WoR2NvUiQYK0VtzQ==",
                    ["#=q8QMDK5pk3Z48yqF2oqZKMg=="] = "#=q3EiZHy_B1eN1nscScQ76Xg==",
                    ["#=qNv6ikv0Fh6sT1$DbcNkD6g=="] = "#=qN9N$0uGl$nJWSOHiST9SWw==",
                    ["#=q5Irdbj5rb5hhawfxMrKixA=="] = "#=qpQM$YuCC$2WlIHHxl0tDjw==",
                    ["#=qDM4YvoMOp9MqgYvhQtY10hlRFAorFTTiGeIGbxOHIvU="] = "#=q35oyXDY9I2EMG_A5_LWLoadFJspzO23TUTE2TfeQ1Vs=",
                    ["#=qRALfRZ04IA0ew8XiqoZr0ep6oVaZRh5Ia_90wgsMy9U="] = "#=qQ4HP88KAf1DX5qlW4s3Yv1wR9vXU1wi5KIJ6RHeUJoA="
                }
            },
            ["#=qEoZ1Pp$NhwXaRNPt_DfxV1lj5iopKeSa4ZRF$Y6gtmNqE9Z8MbaarH4GVejLNrbV"] = new TypeMapping()
            {
                typeName = "#=q6TKcgEezdHCUxbm6GfMN1k5EFB9IyXzdLJ$rvSqK0y2iW_YzKojfcOBRPmYN4Pz8",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgSDO0IP98B7q$4s6$CgM9w=="] = "#=qtOAza4odFWuMKp_4vixG4g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ=="
                }
            },
            ["#=qEoZ1Pp$NhwXaRNPt_DfxVy$DElRWWKLOPSlECqwpyJU="] = new TypeMapping()
            {
                typeName = "#=qSNKE9tAir1iGKTqNNRXcAZWYa9VtBBvPRVlW6CF7HwE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qs5neCHrOrTgcuJPAgcEIJQ=="] = "#=qZXvajZzHnc0X2gG1Zq74uQ==",
                    ["#=qKdkAgDdLTq0IGGl77Vb4IA=="] = "#=q4tWVYFYvEHrPfJoaZb5s$A==",
                    ["#=qiL4jJKNBr5jJXdSywOf8mw=="] = "#=qTqyDYE_HXTC4Jf788mJ5Sw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=ql7qYJefRTiVsxSlwJQTS9g=="] = "#=qFnQ5o8sxFqRnUu176G3cxw==",
                    ["#=qgI7lUxh79VGC42nPnKR60Q=="] = "#=qfSp_MLmnA4HblMs7uLBD9A=="
                }
            },
            ["#=qEP587kDjwwrEz6S1pE6aItuaW6a8gYi1LZ6PincejWE="] = new TypeMapping()
            {
                typeName = "#=qAKH2u85OXECw68NRfD8HTyImkrsKILR3xP6xq0um8eI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qcMRoTjXZ_SHzPA7Q1pmIkX$yYRUHEScUhLQdf_83mEE="] = "#=qRjzeJ7ZaCMdnEJIHt6pnQx4agcIaaugIKd2qxiOXP7w=",
                    ["#=qPOW72kNtA7ZrfasAvHHmf5891trwpefolmNzyMcNCHc="] = "#=qu8bQmvid7CWiLmlWcxa4CWrk0NkLUEG8aZLf3uAbwm0=",
                    ["#=qa$CugheRTv65yB3Bmw4vlQ=="] = "#=qPqs6ngDObqOIFiaz3eMHoQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qPbTotRccGS8agPHFAGUkDzS9qQi6nqdsO9lc4_Usm9w="] = "#=q_7lCxfS6GImCPTAZj1qFtFheyuvVO51AHo$K1xfi7cQ=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qiv0Gb_domsviNN1Lnfc$xg=="] = "#=qmUxUj2XMOwaIzUGDjWZYLA==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qf4a1rC7b_pteq82uSrkhyttEDjJTFgWB2dQcC1ZZslwdWT5Re$NOAB8YTnVCiW_u"] = new TypeMapping()
            {
                typeName = "#=qfHCpINVluc4ExN5NhaBxyOFMoPfGQaXz0M49c7EauuQzeyQj83vE_EshlGmUCSBu",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qPMuci4vQsMxFcl6_GIC1_5MJDPddX0XjbVOj0_AzaG8="] = "#=qfBmGaoHcvRlW3VJBu$vgXcKBKNpDCQXYdPzU8sMTYLs=",
                    ["#=qVc63vfRcDz1mxuS$cO3g8w=="] = "#=qL4RGrcPAcdaUj$3wrCtFQA==",
                    ["#=qKIvsyklcD0GtLH_dhHRnUaGImx4O41XpEQGfwmazUiY="] = "#=qjib5E3KwBczgcAvneFM5AFyw5aAnGHRE6jNQGr7UIcA=",
                    ["#=qQCqAqQKtoljcx59HYUiACQ=="] = "#=qq5GlnAIzZgU_842LgWKEwQ==",
                    ["#=q0XYSZO$u28_lpW1RArju5IAHhz8ruc5K3QkNeMkgC3A="] = "#=qlxAxVuLM$Ht7vTVclPXRUDbySLCFy5rhfAruxPYknkA=",
                    ["#=qVUqTvGf8mrzc6AxQjaG9LQ=="] = "#=q34NBr6783vUgFEgvYjsqDw==",
                    ["#=qx7nqYIsWEGmQ09tTYFPp8g=="] = "#=qLVBLW15zWlxN18fiGJYWsA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qMPL9fC6NpHZ9h0YV_79FnhU2Y_EVhyU9wvUoHrgU1Ps="] = "#=q5DEMR6YOECILiyP5XZIIDjgZnbl7EjaV$BqL0$hy6L4=",
                    ["#=qdTIU62z8Kcu1YJO46LW8gdWPY5mKOWsJNfhg_Xyyzs8="] = "#=qLdEMhflLX2Wn7LTPHi9M_OagSsqyk8lxpsEeORXT4Xw=",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w=",
                    ["#=qhoMjSeCqGr5cMkipRvaHcg=="] = "#=qVPKa_hum38pPnOngXxJVZg==",
                    ["#=qjZ$QsT_EmKpOq5FcdxcF5w=="] = "#=qZcCHciPi1Bmt_h9DnkozkQ==",
                    ["#=qQkosfFdQtrKnqXVGzpKr9A=="] = "#=q9BlZawzg8ZLEPsyhhYj8LA==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ=="
                }
            },
            ["#=qfCokyoKco_oQeYG9BYAR1GGPwt7dSLfIbcryqeB17fg="] = new TypeMapping()
            {
                typeName = "#=qLQUxt5TyxUzCRXW00cTq3HgXlEsOEIWo5Rt4aSiKKc4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qT1HW9XKhibm1p35ZCsIJNA=="] = "#=qjYa4wx8gLH_iX8FeTqnGpw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6ILMBj_mlp31wZ4XY$GWPZlRTBZoWRgn_YuHJCqRrp0="] = "#=qXA7ucsT_UlYxlwSftKjamFRU7Uuy9AqnXmtiIejeIN0=",
                    ["#=qXzI1DGARWTgeV4lXv35wOA=="] = "#=q4nIm8Fm1$TB2fCoAfARfJQ=="
                }
            },
            ["#=qFcTbn_Yte5xkyDkSHGpKKHiKVaR4JxvPlIj8FYKEnnE="] = new TypeMapping()
            {
                typeName = "#=qI3NoJLVU$zq07HbMbgAs5b9QoZ1C_RczteHVFO5OTe4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmiyKXMFdemimZPg3AvazvU7wOkU0ULNWV8MhhPF1Its="] = "#=qAqkEC7UrxNaeac7ktAttqMpGUIBNR7SKsXRmzaAwYBE=",
                    ["#=qKzww_jr2Oztwk63j9hAHIa7Zx9vzlS1_IwGRN8MYDo0="] = "#=qkwxYjhH5mdcEf70YqDnZwFoPFzj7ggwnEe6IqA_fEq8="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qFcTbn_Yte5xkyDkSHGpKKOgSujBV_uZHwcPG$4r2Nlg="] = new TypeMapping()
            {
                typeName = "#=qoj7UdI1$2xDV_H5XPQZx8RTNHP$R6ZtHCb0XtR2JI4g=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qS0V2NeO8WpiaMiAfSaLKVQ=="] = "#=qMrljTpdQI2fc2V4ZpAidYw==",
                    ["#=qXASuejgHFLRAEdmQ9cfTtQ=="] = "#=qoX$4mSpoMKMU0Knl_MMiPg==",
                    ["#=qwsbkIipCjHmiEk0ZQ7Wx$QdhxMqhuL_8QwvaS0SB2uw="] = "#=qs8xIvIma6sAz_GnrtMzN6OTtF8sj9lcUISV3MhCLCBc=",
                    ["#=q9o1R38L8RbRSpv1_e$NCkA=="] = "#=qYz$UkhNAqT7HmhMBie2WDQ==",
                    ["#=ql_yhtEpTGDFOkQAkUQumwg=="] = "#=qiTNqeIrdc01yO9tDKWifsA==",
                    ["#=qox4SVb8Sryn7KAePQI$_LQ=="] = "#=qgQNOeYSAkXIu1qCvDdF0Sw==",
                    ["#=qLpuYxBlewkjPN0KZ7o0vJgBeBt$65suLZe9smj6u2pg="] = "#=qusm2yg28SLAGn1BB51m5AqIcRWegPIXuSOfYzMpgBBo=",
                    ["#=qGEEYsElJ0IHFPT_Y76ncmw=="] = "#=qGihwqh6zn1rrd_kxr0advQ==",
                    ["#=qwqjIU0I_NRDpx2L7aytdAMM$yafKfqnz6hhF6zKbaoI="] = "#=qnUSo$u4OhQJGInjZSMHLagpYursko_kPCf3nkoKL6S8=",
                    ["#=qcYbGNJgvRHN7lsLa7Dgrfku2EGrSsxGCCDktvZyZlZw="] = "#=q2ceVUD91MezDlnTGLkX68D7BZ7SiQ2HBsmGxpqExb8s=",
                    ["#=qcqXU1gngN7JZl1gfyC7HGA=="] = "#=qGB9gClJ4w0Hnw5SoRdJYCQ==",
                    ["#=qqYsPmdU42r_jiaFGeKkAzA=="] = "#=q6XZ1E5ZMAB$dhORUGvSC$Q==",
                    ["#=qYBW0Zqrv2F5hz1C5aKfc7rA72mBJPUl8Y184Jx70w_c="] = "#=qhG5mIPFuDDxDKTuKQSAsuhnQGImSTxzCd7ceiqpbnuU=",
                    ["#=qSTK6DcitlObaHJX0rQd15g=="] = "#=qg1fqQ$cfVuTFssld7EPHeA==",
                    ["#=qDrWPqH3oJQjmVN3reHdmAQ=="] = "#=qGIv$$6ZY8PVCLxs$55BzWg==",
                    ["#=qbbRthwxvz0IBm5bMKaSGoA=="] = "#=q2PSp_sD6zVoH3s1DZH8tzw==",
                    ["#=qUqo6mNJUH3sAZtIlPUH$Fssm0C77zWwDoAyw$OGsetY="] = "#=q6UKsyPXJ7VuDKhQypeOPUZzj4fnFkaDHxq8euXzd$Jc=",
                    ["#=qTUQXcL4octxMsO43GgT1uw=="] = "#=qJ5ZnNAKEflPDD3sYota75Q==",
                    ["#=qmfVtWSJL5sBfmstcd1CY8A=="] = "#=qjVxoJFFjtrW7QNdb5f3yRw==",
                    ["#=qC$X8_Q6x0G$yrdIuOGc_tSwH3tYTVV6jB7S8tMfy$iM="] = "#=qq$OIsglSjADEEniL9V1whcrK6psktzfbcTkyl1pSwJk=",
                    ["#=q7KyNuIA3DavumwqqzEUfIQ=="] = "#=qPRFsvnvLsjNvV_IaN_zgug==",
                    ["#=qmppAEr28fCRnD7AWDfN1Eg=="] = "#=qDPtfpz3c$ZOC9WYqZAfUCA==",
                    ["#=qqkX3zd$0TutW2DePmnSbvg=="] = "#=qOXZBTM$bVv_PJYgCPJeysA==",
                    ["#=qom9IHAFk2olqEsZDdimMpvcEk_$qRkm4qwP1pBYNlZQ="] = "#=qUKgtgD$QxncTRaVV5ZqVYY9898z6OMUySSeunezF6kM=",
                    ["#=qSF76Fc7gPT2mi1YZgUvg4Q8Xie0iV33OzNMd7Vw2$x4="] = "#=qTFFTr3zz7zkQnm7uNbaQIIniZkSWkOdJYhnvDvXQ9T4=",
                    ["#=qhDsC6_U8c5Zhriufq4NTnlrcYsA28$TmqtahQxfYfBY="] = "#=qJcTl2Cu8Jj7O0nLWWm4Jklql4OR4Q0BYLg$9uwV$F$8=",
                    ["#=q645od0LSOUbe6J7NH8qprtPHJLVQMMqC2RJ3xrNtONw="] = "#=qYsBQRscMiJnElkWXTHPIb1G3_S$Gm3_$1Rx3RIaRrtA=",
                    ["#=qztvvkwhHL768nz0IakF15A=="] = "#=q$IAEh$05hY2gX5TE_j21SQ==",
                    ["#=qj26$W2b1aS6QCK3goAe8JA=="] = "#=qu9pSFOAdv1drD_PRQakWMg==",
                    ["#=q9sDZHYUAyk72mF2HRi9dJQ=="] = "#=qwUx0A4A$yb_VXnnPwaBUaQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qcHYERFpq8VUoIX8ZX7NRiG552iVTYKgu1uDqtMhnYUeKL82xQyJgH5aZBMMmg6Vu"] = "#=qdyNlKte36nzBvh_E$G6gTbrBSVsTERkqAMRAgR0ef8zI9z2$_hC0GwZA2CzycMfY",
                    ["#=qm2ecip8lKAf_PEw0WJd8QwRm7xsSIabKksHxJkibnA8="] = "#=qA7KGs8uWoKXcso28dqa7Uwbk5LZt2BOSkMRER1sMGVo=",
                    ["#=qsdoTUYnCG3HRWL6Qa_f9ogV388dc73PNCWGo2VpwC$hj1ldSmLWHV4xF88chXUbz"] = "#=qPv1bfFqEyK1I_E6h42CU3YbrU3J4NBz$T3ieG13$pf681pT2RYYEzzuwUEUKBRMu",
                    ["#=qtPKtPGHQ8Gm7QXNfe3KJx9QbLlWenzdrJYJ9Z6rurb0cyIaNYQv9TlMe34DmHmkf"] = "#=qJU2PmW$olLMZW6p5OGAR1zw1KsKqYG5T8SyMNfpbpaqnyVauYxSQyRAB5HZX3vXl",
                    ["#=qb28vMm9Ni5$Bm8dNYls9BbHYZ7XlTqX_eNv8mf645tM="] = "#=qkzNhufSKy$NHpXXHxmfRKDSR5pfLqVnmULNQU6fZaAc=",
                    ["#=qovlGoA9$JudU0vegjTKuQ_umOtLWHe$GsEoIXcxGFeU5W16YMvNz59Yp8BqIIf$U"] = "#=q$uX_qX5r8JBMZeGjoAfdp5Hmgy5WrZ9c80H$v8IhNTyIgAEtnI4pXvgftJ1pWnOi",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=q4gpRv1ZB1d8EK33SuBdNtllekYAc4hodaavgkXHrMms="] = "#=qOr8bQEKgxFCs4xa8UZcw20IbwF$TXcGocqdZ1VKFcRE=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=qFcTbn_Yte5xkyDkSHGpKKOiv9r9wVnIG11H5RlHoZsw="] = new TypeMapping()
            {
                typeName = "#=qZBoyrzQj20R8rdULQBRXM0RiTQjnRJVRjl6KvTe6g_w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qFDy6lG9S8rlJAdy4lfeM2idZIa0Eir3pAx9CNKXnoVs="] = new TypeMapping()
            {
                typeName = "#=qbq56Oldgqlq3PCsWyxz8FIZQ8ZDQ62rQ42GDX6jZ_5A=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qyrRoxlLkcp9M4Bn1TBNhVAc5HiTFMjhfvjDBKNrADBk="] = "#=qo$5aFDhhNBiO6cYTKzKq7ptZlYDen3ajhMiotuKJyuI="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qFUxjWZlkttIcf1_obHIG8QSSbIYKECIcu1ak4FnBzX8="] = new TypeMapping()
            {
                typeName = "#=qRgikAfHbdcaZeMmN4k1Qix1K2qycK1c1KidSvvXAcUk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9R0xs$ZjpAS9clLp5nyVmA=="] = "#=qhA8k$6kD6bv3DTT93sCQlA==",
                    ["#=q0VtusuYRFOvEP3Ju8Vs$6A=="] = "#=qyDkGAQU6oa6kvkPU8Ek3XA==",
                    ["#=q2WQNjLhw2E7Slwj$9ZrktQ=="] = "#=qbvnty$7oISI11uX1CTJrYA==",
                    ["#=qjUajuOBQR_8SEXDJm$1Oxg=="] = "#=qE$FwtSDswATeS0EUbe3Gzg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q$Mxz7$KGpHu4Oue06mnjMQ=="] = "#=qJcyi1lsgnJFnOdGe63XlfA==",
                    ["#=qoMk6ul_EP6mgWNwuiWn1Jg=="] = "#=qptkhK2hH06AFX5RYgZ0K4Q==",
                    ["#=qGghcXoDMzcDs7O9jOolXjw=="] = "#=qnPIOxVR9TrMD0Y3S0QxLCA==",
                    ["#=qhBrhbMNn9CZkhWdAPS7evgCchYQT2omUcLuAaxQtHgM="] = "#=qQX2sEk87xqrnBzPEU0JonXSeIfeM6wU13mFonq0c3cM="
                }
            },
            ["#=qG_DPWDxQ1Ats2oRCzI62JQO9Gu$EwvvilX3mdoqyW63mhHegLiMJdG4f5e4bhGp8"] = new TypeMapping()
            {
                typeName = "#=qu1jVDQ7CzB$Hsor2mIzlb75kq1v1InUPLHq$lp0TVtGf7phHWw41gOfl3sx7mEiq",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qafSpVaTgvlww8c5YbYF12w=="] = "#=qCJd4HrkjRmzDbQaAxyOyPA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw="
                }
            },
            ["#=qg3aY06GnoxoCnfwa4iCsKkS5klTj_Cbe8jv8X9gK2S_OEl7DOAaHMCMkJCxnfAw7"] = new TypeMapping()
            {
                typeName = "#=qBnXHYl_aqyXAy41bfDkoeI5EKJWzcaPjl1iZXskGIKiY1E9TB1L$nxbznKDCq$h6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRHhDNs3C5milcibCEvzv7w=="] = "#=qPX_jQRG3FYoO0wklEnMBZQ==",
                    ["#=qpPIXj5lZ$A9j6KjHCOVNkaJh7Tx_YL5QNh6VZbiD$759nOVcTTsAhHYgIv799Bg7"] = "#=q4yAczr21d9SMmYI01i91RIkmIi1gbJPQ2byqzbZuOZLuAnKkYtmLDScGO_dJPkIU",
                    ["#=qqETA7cxTl_J1Kyp2MAXblhpwMzruDfw0gSm$bbz3Yq3PuKkdeEZxUm4fnxcULsXS"] = "#=qnWCLNgluEWH1RwzG7nUrvwQouTU85TWOYMJK4rgyqRAgOkX6NxkuY6IU4IQPLZmF"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qt59iKnp55GVM0csMvtc6ug=="] = "#=qWH3HwvLLGLsMWBWCfJuZsA==",
                    ["#=qgC7pxsa4EbmDQnV3aBbo6Q=="] = "#=qsJeC8subu9l7PJbVwlNnXA=="
                }
            },
            ["#=qG74pi4zz622kvCFqu3BO2Ahqnb3V1xEVUz3vBXANGc01hb73nHKLveoz4b7Ktp9p"] = new TypeMapping()
            {
                typeName = "#=q6Lj2GICZUdr10tbGmYHIRT5F9KjZgp9QIw$1Prrts24yhNHUJVHXloYFwFzAu2k5",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qG74pi4zz622kvCFqu3BO2LAWCNE3OwcdIx__Ktnj$3w="] = new TypeMapping()
            {
                typeName = "#=qhCoKxDzUAkUKsOn7GfZeAbdetw_w3scjWU9aIRPPk20=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qG74pi4zz622kvCFqu3BO2Pa1Cl0seBEh$6xUYTMxyBhXwNpP9JoLvvFJRg5KVU6D"] = new TypeMapping()
            {
                typeName = "#=qzmBMSF_LTshDTaytOo20qYi3RulbLExfg4h4u1Y5n8D6IbUFrBSqkYhamu49Dssf",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qg7O_IVp0jCcgDagXoe6qmEDB76O316fMjds8i_29RtS$OSY1_b2i_FcRg7GN_14rZ3hzYvphUWv_G_yuDuTTlQ=="] = new TypeMapping()
            {
                typeName = "#=qkG6uUlRv4NI_D6uj7xCq_D8Sjv5F4y$8yAq6agh5O0TCxW28zVLOKfDm5QS8jBx1rE$ObEzn9jFvt3VNkZp3cg==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q7SnwyQe6PoVhBABIsHqnDA=="] = "#=q$S1m$9421FGXu$G5q9S5lw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qg7O_IVp0jCcgDagXoe6qmLUYT4YX_fdkVU5xB7lBLhuZBoMhrC95eQ77JIuZkYcV"] = new TypeMapping()
            {
                typeName = "#=qwbC9P6ZCv0yCgZK1gM$g5lBTQX5hBIGRRQn3JBIgOJHRpZz305Pl8RlMqHl$cVPV",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qCB0s_JWmmUnr1ifvWpBBOFCGD$A_GnGQEBUUnrVbjwI="] = "#=qMGMAqDX7Ubm3itN2w0olpDGN3LuuOoFmOyNcOx7y2cg=",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA=="
                }
            },
            ["#=qgb_1dBoxJTxMr57bMeIXeThMSy7VcbiYQtte9Drmlz4="] = new TypeMapping()
            {
                typeName = "#=quH6NZz8owN$gXLWhTI6CgtbXOhRmhjkCF7puIzmG9uw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qiFZlqGh193RpUQvGLBRUdQ=="] = "#=q3SLStW98ZC7eOQ6G9Oh8eg==",
                    ["#=qtD6kgdu9EwC_DwPWSsoSRw=="] = "#=q$V8jWy1N_Z21AK$uJn2ptA==",
                    ["#=qHZVsCFMnFKIpa4J8$1Sm9A=="] = "#=q0ut9O1gTJxl3ijESa3QYxg==",
                    ["#=qBlwtQMl5uglVsao8ZCHREA=="] = "#=qKsX_ZnkLMIoicSQx5oIghA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qOi_c4IWfK23et2OR8yoGuA=="] = "#=qiCJcq5ZtWJMXwGgCZwx1xg==",
                    ["#=qGORM34Ngp6m6faep9UreKg=="] = "#=qHO4aLwJC3boa8qj2BWTflg==",
                    ["#=qgWVq$OayohPGH1D7YKouMQ=="] = "#=quI8sZkVGAbJofyMf7ULRww==",
                    ["#=qce8rjuCkRRJJCMxXuayVcQ=="] = "#=qDkUGNbwD$oe2WrF_qx6Jdw==",
                    ["#=qx2OJwfvc9RO3$kqomDtl4Q=="] = "#=qlnJp55RCUj0JRFqNTI5v6g==",
                    ["#=qsVIZdOj2f2kGYtRZK_h_UrupBSGZFrLPwQtmyzWj5To="] = "#=qidVh59OARudm5L96T8SmhIkoLYXgXo_4k9IM$Gf7vJg=",
                    ["#=qZvyo_NAQAFC6OF5eyHgSGz1$Knpeykc$CaK8Nloskcc="] = "#=qhsGF7FfA7opl9ZJ_MnzWSCasntx9YxOmZuSWked8eDQ=",
                    ["#=qLhvWGJ5_bIji7Xr4fvz2DM5G3ZPkRpBVb3DtiaNkZQY="] = "#=qsDuweV5TVrQ2vWCt$CGcX82sC68qK$8SgAE1gYtH1_c=",
                    ["#=qTEXyfPNksdgGL0jjreGO2g=="] = "#=qctBnFDBmGs7U2GH5APVN4w==",
                    ["#=qPtKtDvVy80np9FhmRnTvvQ=="] = "#=q1u5NaVBYtrFx$xFRrq3UZQ==",
                    ["#=qzZCFhMSRiU$M7Tzmtv$20w=="] = "#=qqQPxcqlRN4HSJ$dMwfjfAw==",
                    ["#=q9_g2WM9feTBELmxdv0qj4A=="] = "#=qcHsUcVk4GGXW329Zjf7nSw==",
                    ["#=q8iOVsvCxISy9HoXUuDIlSw=="] = "#=qjAh2PSl9it1EdRvHFq06UA==",
                    ["#=qYYSLcbFRtwDjIb4NjN5DCQ=="] = "#=q$jbVKe0A2dWVgIeND3Rslg==",
                    ["#=qm9zjocZnDfcyMnGlpCpNYg=="] = "#=qs6LDmMOVf45jWswloyYLnw==",
                    ["#=qfit_$eyHph$Z3M7BxmCdBQ=="] = "#=qDKQONVn2U_M$u3ZFmz3QJA==",
                    ["#=qYeff4ZpaeMJqvNRGaHzJ_A=="] = "#=q40SBek5EmM$oJkZVYOuF1w==",
                    ["#=qvg4NfHdBrHvshqZpryNnLlRx4k_NKM0LxGNAyqdhM1w="] = "#=qVYmR9qGfKPxeMupzfk5JYrLUt3WMpYMKHCTekZi3Gc4=",
                    ["#=q9WD$wbf9H1OcrbFWajmkCA=="] = "#=qUSQhckx2i0MxdZ27dU8BRg==",
                    ["#=qHGwEhsa0rVjvSJrMe2$DHA=="] = "#=q9S2LZFbaBmyOT0AlVJ_clQ==",
                    ["#=qJvj46OOJtNwSXxpZHOGtVQ=="] = "#=q0udmhIIEEhbc3KONEh96xQ==",
                    ["#=qaKJtS_6JAyZgOvLt_vXoog=="] = "#=qwIS6vciCp5FYJbI3lnRcSQ==",
                    ["#=qTbNMzMA0$IwcGrloSJVIJr$$DHWt82Mw20d6vD2XbsY="] = "#=qSwZfWZb8FqpYAnweTTajt2BtHuSbL4gT3hQEQllfYFM=",
                    ["#=qIyGlqmocxDkCrw_QqqYwGQ=="] = "#=qCUWKGrEUwc9qiBwynvkmog==",
                    ["#=qd3m_bmB6BotKYyfM3nfDSg=="] = "#=qRXu4NoKgh9lrQRI22yLFfA==",
                    ["#=qIyxg9U7fjWHG$z_fln7wYQ=="] = "#=qojolSbOzzw6PXymiTXjggA==",
                    ["#=qygD60xp3s0tNcJzbq64JAQ=="] = "#=q1ZHT6qEzeIccD9i3oaqzfw==",
                    ["#=qV$tKRJV$gNCsjp24xK_ylQ=="] = "#=qbQI7F14EjtfTTnhYadfsDw==",
                    ["#=qlayd0iZZCYgWLISZW12nEA=="] = "#=q$oPtkXBoDPVi6N3nMg6JUw==",
                    ["#=q_utTtgcFiKucHBUkgW3tow=="] = "#=qBef23rV5jw3c3LopjqOXQA==",
                    ["#=qJo1O9m15nkuJn$8qGC8vQw=="] = "#=qjA6H2A1sru2z0WYRolU48g==",
                    ["#=qSI5fTNMkVC0Ljh8OiQ9SnA=="] = "#=qRGeSmiYJnD91xvXTPBWh1A==",
                    ["#=q2d8s9S5hC6bzBasdKugQTA=="] = "#=qAtY3zbKG2JuACLTx1iF5iQ==",
                    ["ToString"] = "ToString",
                    ["#=qvDZPDBafvk1XvsqZUN3fdA=="] = "#=qSRk9282hE3BOCPEjxVNylw==",
                    ["#=qpsilwxWqzOz6nXGT0TraYw=="] = "#=qnsGgaQzCZhTK1OhsrWrdaQ==",
                    ["#=qsgd_sJigHm$dEFXAX$VnUA=="] = "#=qB1N2tgCe5FPkJ4S1e9pOpA==",
                    ["#=qdD4iLGKxsj7dd_DcPgyWbg=="] = "#=q9D$8eKcp_iMgJnBVuabAlw==",
                    ["#=qKxTtJiMRZY6dcD2jDRvUMQ=="] = "#=qGecSAprUv94n1X2LIWzwmw==",
                    ["#=q8KXZA5MWciiU4d9gZY9rSA=="] = "#=qgWFzstCmt0$7PKRUlWuvSQ==",
                    ["#=q5z5E88MlJ39tzXYwLWIDSS5dTSVTprsIXJog7QyEVBg="] = "#=q3qvA$IL2OLGileqoC5KDhCctaA0BIIZwgDkI95mD1gA=",
                    ["#=qaZhAvW3dN4uAPqEjjwbSEQ=="] = "#=qAo786fAvcIp2IPAkOMzwSw==",
                    ["#=qjOoQmM_34lxlzy6LujM1lA=="] = "#=qjJcox7w3xijjD4XQLWBs_Q==",
                    ["#=q6qbL_I8QfrPPaPz_YZY0_A=="] = "#=q7UOUg1_LwQr_p1iF_KG5Eg==",
                    ["#=qCbfK$dxBfIvihwRP_jqlQQ=="] = "#=q4q5cmb8oQxcpLs6$ms$wWg==",
                    ["#=qGnD0PcV6bk1lxJCuIBT2VA=="] = "#=qXg8OV$pMh1Khz4xkwYKh0g==",
                    ["op_Addition"] = "op_Addition",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_GreaterThanOrEqual"] = "op_GreaterThanOrEqual",
                    ["op_LessThanOrEqual"] = "op_LessThanOrEqual",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode",
                    ["CompareTo"] = "CompareTo",
                    ["#=qOgs12ImTHZv4TREn2NEY_YXoBG$AHTBMN1h2Yj4haBUSDWsWEUe8J2iL67T33dPb"] = "#=qR_QRmzdxLg6YZ39khga8F4LvrJFUO$DYI_uTpj1LbBYIpxVT31M6pdgZ5Sd8YuAb",
                    ["GetEnumerator"] = "GetEnumerator"
                }
            },
            ["#=qGFmXda0DGfsN_R6S6HxvRx9TpD2tzEjOUV6oJ6yI4IHD83BcU8A48Idyd5rN_h$2"] = new TypeMapping()
            {
                typeName = "#=qqCr3A16xLBek2FveImAD0d2JoLUedtgoql$d0w_ed7MVv6Rn7JQUbkbyUe7Mmy3b",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qERVoRRlfCxUgYgkOsmY5sA=="] = "#=q6rI0_jbF5HYRai4jtQ9MrQ==",
                    ["#=qrrJJAR7_DyawLv7lY1AIpH8xUaaXMCZhYubf09t5Q$68B74_6uN$HzdsI47MOiZu"] = "#=q_F3qX11kCPydANJg1sGn5Q$6GhqYS9voXepGYei$4pOa8O_0yT8thEq0VEdzTFqp",
                    ["#=qfq6oqXN04tnqgaP$Vuf8udZ0Fw_VWKQ1velq6NFEgP52L461CpHD9TLwP7DRzJ61"] = "#=qh_Z2LSglb7zr21oyF8Bshj8tY4Pp89lY8lpUhE0l0ePrJPhX54ttpIyYeXer4qqz",
                    ["#=qP7gvWXQg5y_$14E88OWtWPfG01PWNXBUZp7lFL8oql4QzJ51eeAPHmpXZvC$kdyO"] = "#=qfLD7j7ju6ogoElPkK_pwrJaRlvwSx3kx1tNhjzl8yhwgfDidAfdicPXHYQO_glia",
                    ["#=qzyzjuPcZHQvqXiJAAQJiRCfDvGjPEEeU9eDZrb2g4QlPhR9FSgG2P6Xa3hJo9Axe"] = "#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaRfGdGOXbrMTEtBixUq_YvJ"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=qUFHzgYQMvsWwkRxZHSw$SQ=="] = "#=qux$axXZJo4NahfDcIbpx6g==",
                    ["#=qMsyX5dUs5rZ4vBGu4lqZqw=="] = "#=qSnjfJWJDO7y5i_I4IRhUFw==",
                    ["#=qtojga3cY9Zv_zUQnqx5_iQ=="] = "#=qnlUz1SIXDbg8COrEQT47lw==",
                    ["#=qXqnsTH0$dx_jCB5UzUob1g=="] = "#=q0r6p9Zby2C5fMG8p4Dm4oA=="
                }
            },
            ["#=qgFytapVfH93pCe4iJfI8vl0eaWKeu3AlSk7rAwsUEXoMLGiqCXTg5SdiR56Pd4OJ"] = new TypeMapping()
            {
                typeName = "#=q3861lQLPEcHpRf2sZcWd3jgZ9bhygiSjzgMY9n4cyYFPMVtVwaffNB30VnFcKhI5",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=quLc9mPEum$O3I$uTmTy0uQ=="] = "#=qszZDgP$No8iAxOM3ty3Mjw==",
                    ["#=qbLnXEGivjek9G22khfQwkg=="] = "#=qmA3JYHO06jW7SaH_6gvA7w==",
                    ["#=qZxdoQNqYRuZJzrw2Kyq8tAmiIjs_31CY0Crp1n5m$ZE="] = "#=qeftapBMa9KbNcDNKL2KXHFr3GRPQTJOfgNowxvymumw=",
                    ["#=qp5ZlfHYsLbWvKIMtatsZ9g=="] = "#=qCgWeToKGwXvf_9DNYV1Wyw==",
                    ["#=qUHqrWpQXxSTJfnMdiYvs7mssML2rrHd07Ili46Qgeg8="] = "#=q_OPIfEuAPL8OAJuGUKNDQpZQQndgCKKIat0QvyOzfBc=",
                    ["#=qc0OSaEvQRpSzaxzLZvzgdg=="] = "#=qGeWJgpt24IFN9Do3eigOWQ==",
                    ["#=qGZk4$i82IWvkBkzcPO70dA=="] = "#=qC2qIVRWPY23FqQqMXHE2KQ==",
                    ["#=qGIysFshY8pTiVeSqypAzGA=="] = "#=qLNWpcuEQWXq4sZ$rkIEtzg==",
                    ["#=qjufNOlLbUmM_Bfu_H28Spg=="] = "#=qr44fJJUyRIYNcYXgRmuNkQ==",
                    ["#=qWq5ybtcciVW80AlQicPDAg=="] = "#=qTJC4OfwiQAImNh6$Nh2_BA==",
                    ["#=qyctA8XHUUUrzmqEypj96Pg=="] = "#=qjvy3nwcrEshuwv5$PqwN2Q==",
                    ["#=qZQ5yqNTqV63HdUK6ZZ_TRQ=="] = "#=qlthauwHf3wDYlcQdKw9kdg==",
                    ["#=qvTp6BQUDF2_fgYDr6xmzKg=="] = "#=q8hTd3wvCSL$M4xVwMmgj2w==",
                    ["#=qJGRxZitjzCeZcR_V35mmbj0pHuh0A_RYBAHWZtA4QaU="] = "#=qgw9qL5ddZMqJT0j1G2GMz9CXwpxLtMEmWtNTUHgFScQ=",
                    ["#=qpRwxPpUmXnISaXOUuFD4Vg=="] = "#=qUH9aH0jZiznDcq1E6I0SFQ==",
                    ["#=qWMB_rxsdRhZrD5BeA_OYKw=="] = "#=q$58QxmlZ0BAVWTrc4L7mhA==",
                    ["#=qBhsqiY1gAXfiL2rpi4P0rQ_3RJKYI5bouS41uVU42zY="] = "#=q8hG9cdXEUNcThV6EaiR$NQYfovFD1QA7JIy_IZisyTY=",
                    ["#=qRRXrYHLvHKJrtFT4GWlYwQ=="] = "#=qiyqg19WD0JHHuRGfSHD$ww=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor"
                }
            },
            ["#=qGhPOG3sW1lHBzy4KhUQ4rGaBCk8xHXOyN2RaNu4QcmZ5VS0kASfBglqCrzbO1yB7"] = new TypeMapping()
            {
                typeName = "#=qmzk$RQI1oI2tAfDYJVYemqoM6XfeTPNmbPWhcz$3DR1Nq7J3UWoJtn35$pV$Qrpk",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qGjG8GNYhOHiSsU$T27at4LG8zf7kp4kAGP3XXgbCEp8="] = new TypeMapping()
            {
                typeName = "#=q_NFT_aSDKAUq7ouQ3iFvRoSBiPU4ddnVGsJcc6SIjV8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=qgT340MTE75M56_fJ5l8WwpsZiwvhHcLPyP60OOVlFv87mf3DAl3uI0bI69c5bWEU"] = new TypeMapping()
            {
                typeName = "#=qe8ZSXmdxzg7Tm_QlTFJpkJiO7wXxQjVEoVZTOOa6TC8xyt7JlRSmyksJNKeEKtPi",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDlvCDl8i_W5ECO7VPnm_DbzhyUTHHDyo$figW5bDCHg="] = "#=qAoxNfIzZ6fXpoJzpiQYNu9ETCYuGBApjf1Vcxiwaiik="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qgsvUj5CQIPruUHzas$YfUxuUPA_1$lwxJTS2lYMit$o="] = "#=qNW8DYSA5CGxio9s6JM2fckfcIQLhaiGsKMWlTLBEwIY=",
                    ["#=q$N51$tvB5kAm1asIBmn3kA=="] = "#=qSW2tvgJWEHqT17z6967x2g==",
                    ["#=qUTZDeYAhOnglZowZPXr9Cg=="] = "#=qVm0TDmJQbSGPqEEqd39T3A==",
                    ["#=q4eNtnVljS3WqGpZh74w50Q=="] = "#=qvBWO1LvBXnS$Kgx4YElGPQ==",
                    ["#=qvh2jP0GCjbits9gp3dJqGA=="] = "#=q$NKq4urMZeoe75817BTlzA==",
                    ["#=qMci3N4ee7BDKGbWrTa3CpQ=="] = "#=qLO1meZgsFcvJoxir5n9thA==",
                    ["#=qnUKzHNiz0kmX1lc9G9VJ$A=="] = "#=qnF$vGwewolJ$LffRRD2WOA==",
                    ["#=qthPUotqL5PjMrnQmEmoEsA=="] = "#=qaHYGioCM2w1ajnnPN8R$CA=="
                }
            },
            ["#=qgwhoFhaIYUigRLDdFvNRUw=="] = new TypeMapping()
            {
                typeName = "#=qa$9_M0gD8ib4D$z7rzKC0A==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qK9hRVrbfBxDtYZfUAeVHng=="] = "#=qU8n6P3XwHCcH$9IlXYyXQw==",
                    ["#=qtxq7$r8vMX7pj79ykE3t6A=="] = "#=q7sIXkoiZUbCUBwiHNk37VA==",
                    ["#=qZ081zKiKETcu3ImEOehLCQ=="] = "#=q2cs13w4uiWKkP_fQ1gXzdg==",
                    ["#=q3GpeeY7aZYlxjtVtptXoow=="] = "#=qMLSt77sfi6PtYCaUb_wdnA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qsGn3J90$fSqF5zLl6gXA4w=="] = "#=q6xxOuMXbzNV6qAPiL$f_ig==",
                    ["#=qFaRc95WRzKhl6XCinkooFg=="] = "#=qmLH7va$7RcTtbpm12MiK3g==",
                    ["#=qVGPRDv9b8muLuIPHMDpLUQ=="] = "#=qBDfMow2v31MyU$PuMs1ndA==",
                    ["#=qNQFfrmK_XwWaN6nacZGcvgWEazsnmPpLRxecqw5A_ws="] = "#=qU$2sJWW1T7KA$VHIxtqYFNskNzcrq4xtQMXB6ik6620=",
                    ["#=qzqgHxuRXlz3Zogl2vquPJw=="] = "#=qsgnod6flSA51JgAQYb2Ucg==",
                    ["#=q8$KwiEDEjcvlLlU5cVuZFQ=="] = "#=qGOqXs43aKyE2MS_p5I$aQQ=="
                }
            },
            ["#=qGYlE_$RdD$djNcff_jTQPxQ9KdrkDigSKzOWXOH1ZkuyoFJdJrwBxCLk8qEmHzYN"] = new TypeMapping()
            {
                typeName = "#=qwiCbT1mUdW4bgvyHiv9bs$Q$IzJMxCEEnlrFj1U_lT55sOB6u12nnmrRps7xJ2QU",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qM2AiMzVvR6AIeuOWG0qgAA=="] = "#=qrGDbbiqcfRpYvkQmB5ZtHA==",
                    ["#=qEskBIx1IPjPYWtgLQWicTQ=="] = "#=q0bFNDUlQZ4bUo$gNaX_mcA==",
                    ["#=qH_yLGptMY0aneF_ArjdhJw=="] = "#=qPARKMkAOOeDTn84SD3kdzA==",
                    ["#=qSqTehDtG0tOO9zxst7JPAFcNsuTdNzK$AM7PJ4R6TAA="] = "#=q21iQpnkSiqClj2BGbIaMVBvkZzneO2sJ1jr_3jn0LU0=",
                    ["#=q9trsfDtwhL6bTyvVrrScyQ=="] = "#=qJPZBQuAgJrGfzbG$5MrOsg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qoFXahUa6K49D6Qiqc5rChr7wMVLOunS7rItmYfbafKE="] = "#=qt0Js47vCAOHJIgtQgP1puujZm2JY$VdtyB2zwI_b5Ok=",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg=="
                }
            },
            ["#=qgzeHVXJwODq1TxZsqRkOe004M6V9012uXQiMuS71FNg="] = new TypeMapping()
            {
                typeName = "#=q5ojOVxkCEy1RwCvOt0XK8PgXv0$0A_w4UEKn59ZErOY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qgzHipmDcx3HZysEPbyZ65owSDNj_n4nLq06$WE8QB4I="] = new TypeMapping()
            {
                typeName = "#=q2RSsPTnOsQ$MMjH8_plxIsmC2rcpP1SsKaVxaDB_AWg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q7fgsuzfL_Kv5TaGp85$iIBR2ZeY_L48i$KXNEpxy$T4="] = "#=qxoIvfVdB_bnEdb2BZtuAiTmzwrVO5lZ89mZdMfMK_$8="
                }
            },
            ["#=qH$Tj31UdqF3a6L3mdG7E_P_6$Khp27qRyVbKuPLLLLs="] = new TypeMapping()
            {
                typeName = "#=q$e3Fx_2yeY_SJjNdoQDQYKXgRVld4P$hkamMZssQbN0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qn51$HnaqmlmIaen7axiKig=="] = "#=qGwbh86cRaSRl$nZwpGylJA==",
                    ["#=qRCwFqSCqte76EEPxr$2SMQ=="] = "#=q_EXnJNDMvZPX$xl2iRvHqQ==",
                    ["#=quhcSEqqTojXjELlMkqU5Ww=="] = "#=qGjiJfAu5mAcL1dBYKqIctQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qE7ovXWVF5_HojnPCLTh8nA=="] = "#=q_CQOWZtdbfFLxWOZ2uAahA==",
                    ["#=qT4j3WrKiczTqBzCRCz9Ljw=="] = "#=qhtRjQnB$gstRX35KycR0eA==",
                    ["op_Implicit"] = "op_Implicit",
                    ["op_Implicit"] = "op_Implicit",
                    ["#=qNthG6XVEXULS85M$TIsrVg=="] = "#=q7PrN0mtNPgYmI8Ho4v4oyQ==",
                    ["#=qQJEpYwf3408of2Az_pzvhw=="] = "#=qOVgff6V7xaY54BqNONqFng==",
                    ["#=qeaVLXgkSmLzVtO2USJc_mA=="] = "#=qXyL9t3gwJLfxla6qXxKLcw==",
                    ["#=qlBxHrgCjtWGhQv19sAWzSA=="] = "#=qvmn8ViztGO4MEsJidk424A==",
                    ["#=qr93aq3DjDXh75HBXjf_BkA=="] = "#=qns8JDJPbfNRcVRxmFqUBPg=="
                }
            },
            ["#=qh4LYo2OQea0$PxWIArNnl2ZhdYJHucjJThH9OR1MDzk="] = new TypeMapping()
            {
                typeName = "#=qr8mbMkmNZH6X3JvJ494hFOy0ZrF245kmpDqvqWDRshU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qh9yW80CfSXW9IIjfoIBLEgS5cR6L527ts0$wjzQ9j$4="] = new TypeMapping()
            {
                typeName = "#=qtC4$pojoeTKjm4Q5YHPJOasWdDbMCzU9Vn9lhPAwqVg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qhBqxmjc_aXydlTFb4X$OW4VW6wyQO2gHk3hZfPKwiS8="] = new TypeMapping()
            {
                typeName = "#=qMX6$iZBEiHwFQYvb_MY_iJ6ERglbfpEfu8bie06D9_0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qHG1A6wKHegdQp1srD$7LnwJUi3K3HxwMazWEWbml4RQ="] = new TypeMapping()
            {
                typeName = "#=qTiYpXV4cyAzBuR7adYWL2NLwpmxpTyfsUvQNYsnHy_E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qHJg2xw0fr7h0yuWckbuYE_bIzYF932S2B6k6hebkSdrXJ24WpXkGkM6FfoO7P_fg"] = new TypeMapping()
            {
                typeName = "#=qA1JaE3CtiLYzBpvOYE0rXdb994EEZ6qYbiW6NlOeYcIXq0yy3XsjZhTu66UGzGd7",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlrkKlldnThqgfgucUWJ1Ow=="] = "#=qU56AGokPcgD4KXTLSdpkRQ==",
                    ["#=qse7XwupTBPPdxuy1VBotVQ=="] = "#=q2EVEldHEvmGiIDRTwjXV3A==",
                    ["#=qvRIcsfXje1I6O$_kVhlsUw=="] = "#=q4X$Td6Hyp3Vs_IyJ$SvY6A==",
                    ["#=qz5YVBocJAqdYoXw5r_8DFOrEaZFouqAkdNe9K1JMTzQ="] = "#=qKo7uDm20xkR1keVyqFIn259OXdcsoCCfzCnKFCsJHDo=",
                    ["#=qOtJVuETuW_qVboE2q441rQ=="] = "#=qbGWBk_sCPc52R_XckgsY2w==",
                    ["#=qpUOCQbgzsKjIUGuBv09iqw=="] = "#=q5rt2lyrZBJeaI31HAEvLPg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qMtdRBgMSaqfYNIho4d_6_CEedy5BwWXkT0x9TR4qss8="] = "#=qb30ltlRIyMUhhyhBdA7bflqdwCOIgcEq23ug9LX0TL0=",
                    ["#=qXJFLvbo8hTjNk5SpuYSZiP832kbEybEu1zdzf4RlCHs="] = "#=qB6nPAXCIyWHtr2IwNPAH1I_N8ngbLAq3YHfYmHqXc00=",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qeQ6qZnDUluxf3jmyqIM79Q=="] = "#=qBpMytHZfE5$0FBuVmb8TUg==",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qn3FrUrxVW_0wwjeqY1OiK2GaALghURucj96NG9KYgIa$vlwhYSqdJMuh1FPjGsc5"] = "#=qojaJhKlXXa3Az6kJeCa_S59MRKcy4WgzfjsyLTUqnCrYWU7fxWbl$pioqp1r_Uev"
                }
            },
            ["#=qhkF0CmcrJUkV9xkX5gPBlzOuBZy_PoMwnFmfNaACw98="] = new TypeMapping()
            {
                typeName = "#=qxomY1Y2SmfKI6PMY9y9EVJ_HpaJM7nReuMk8lSzXmfo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q$CSsyW114TxaAcrJV_WPxQ=="] = "#=qnEurYBawV_BjbwmCaSaAhg==",
                    ["#=qyW79j2b0RyiqdycBo9XMjw=="] = "#=q1hpYXl2Ke6lyWSfJKUo6wA==",
                    ["#=qR5RErFMD4xn6FUwgZ2wX3g=="] = "#=qFdv1KnOnoQYJpOkzBKvIJg==",
                    ["#=q$fi9BsKS6eldvSTh8t14IA=="] = "#=qFxVamikpHSvoQt5jzVmCxw==",
                    ["#=qOCYVYqqB3CHKmL0PvC$U6_TotJfTO$KKHvCJJQlu5Fg="] = "#=q_QLMopntNxoo_Vk58bs4Ce5$WKFkbyM8JpK9TjRM1Ig=",
                    ["#=qjzezg3UgUOqUBQ9j7jZ39OnqqiY8V5q7bWVG1PxuBdQ="] = "#=qLnSWDStqD267gAL_s00FzWfRmT3go7YgMhzFgwjB9IY=",
                    ["#=qByuQ2Yzhb_kqWUHTrYx8j5XFQ0yNC9zuLF9h282aSpo="] = "#=qgVERfzL$gmNl46f5$W7aZT0RWKPlWxOuoRUbZveinVw=",
                    ["#=qtx6VAwrgSk9leHij7Wnx5w=="] = "#=qhk0V7M7buvhG7SxbmyZemg==",
                    ["#=qVPs7qUBscolbMB_1tBs$Kiar6bv73SHpTxtMSnTBuOM="] = "#=q6hH17zlUv$LDC5M$siJg9w_eI35ym7HNlP3UENyOASk=",
                    ["#=qa94IyBM5a4OAThG7nyHZ7Cee4HO7QVfh9mUyovzW1$c="] = "#=qHgQ7J5ly2WYDuYXOH3LLFfdJ7apLHIBuAYhH8kXzH8E=",
                    ["#=qNFAjCEFWJKoXWtRXIBzsA$TltxuWThl$MVqEzqMkt8U="] = "#=qG9NS$3TQ4YunsUhFvpYL4CJyO6rkKRxShojQKgTCjNI=",
                    ["#=qMtSxDe0RGBc89w9U0iLshA=="] = "#=qVn0dURCGl6eQdFEq0hzTMQ==",
                    ["#=qEYRVXJRmz6ELemFV5forcA=="] = "#=qG8Km7JS2qfcWxYurStwDLQ==",
                    ["#=qV1kIWwuN_JVPEMo$GtDXZESP1blOZwARt$C3Jv8HuSU="] = "#=qeACssHDKvQmGtoI9RcQneESyYT6Cd4wgCGmghZhy9qI=",
                    ["#=qFYDbqjQHWeeMExWhXupuKUl1yMT7SYdNoP4mRMZ8JoY="] = "#=q03mvf1FINQVv50nqf0yYyElJEctYkZ9zTM8Jl3_Pav4=",
                    ["#=qqXSqo7B$GGbh6mNh171ftIiwengRu0fa17sGgXkzAEg="] = "#=qxAlVFFtOJjFOdjeBvmVjqWMpr68XCthFZiIvBgzZPUI=",
                    ["#=q69XRN_P8sWmbKvEb0UtV5A=="] = "#=qm7j1Eig9XV$eGCtr7fjC3g==",
                    ["#=qtDorNo7FoBLq_QpXDivtHZR5XcrQu0ufBZqnZwXLJHE="] = "#=q9cxD56$1db_ghyMsLsT64CvJDh4KwPE6iShykhqDiBA=",
                    ["#=q0HLiEgCVmDgt4$dwdRMVVDkL6vI2FObjNrFJwZetsy2hHiilILcpLox_BsdvC9S3"] = "#=q_xp8tF0FsBPxhlxs4Carp9N48Si86gBfCEGyGqKkJqEekMXoir4MNx7Fii9Nf$4N",
                    ["#=qzyp7iYLhBpLt$_dsnFug5Z8VjIXtjowaG12jJjqaZWLSdaQVoM1TrbRY5ZDsoGuG"] = "#=qeDsY2lcjabPOJKADBRrEOKbCcH3jaiKwgohUyutbD$Hs4rPN_dBjoOnbCGiqp9fN"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qnxpscc20yGTkythpRJ3bfg=="] = "#=qKZZoZ9LVcMddwBYIlZIuOw==",
                    ["#=qZK33s_Y8SIvAx6kqlvt9Hd$I1T4biGd4ihMAb_zkNfs="] = "#=qaMPN5Zpx$Azo0wrSojwXv_p49VryOik_CfxmA61JGtE=",
                    ["#=qOCZYiIko0mI05FIEcXOhbPxTWIiHT5e9RX_CZQsX24s="] = "#=qSq5zk8veCDAWsTsnMPlP86W7s21p90UUQJby4eyqbB0=",
                    ["#=qnrFQrgVQj$TL7kg0UMYODA=="] = "#=qPXt93SMNfGfIEGwRwQUYGA==",
                    ["#=q1rMITklRHIlmPynshQZgWp2tbFSJS2p0oaWXCPyiCuM="] = "#=qavsXTqZl232lpKI$ibssiqYBu3m2$$lQ0TEsKJ$B9PM=",
                    ["#=qe75$PKDs1F8lH79e6_g2lE3ceVEI6$XVUjMOBGzhrMU="] = "#=qGmjFb3UKKiPVq4puLjM6T3GtChBHb2G0PJDEo8AdSng="
                }
            },
            ["#=qHm2tIz0zbxi_g2$8CjLOAEOtWVPko4YnW7EZSqi_jA8="] = new TypeMapping()
            {
                typeName = "#=qyKGqhDoz6P2j2$wLIplBI2j7q6mhUGDPPzjtKq1WR2o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAex9Ik6_Oh1crvta3r9lsw=="] = "#=qJbtd6fQ92jdRDJpIeAXBjQ==",
                    ["#=qyCDWOMfHEthQlvCuO974Uo4vjOYIeETdEt5QSVCbgJ0="] = "#=qr$jyNWd6hMxj2DBa94Vihv8vieWBNRY2Jo4jrood75g=",
                    ["#=qNdzV4jVPAH59uHjrfxdLaQ=="] = "#=qGmdnwpzPwajmD2m760K6DQ==",
                    ["#=qQS3FvLLwVgc_tXHj9h61SA=="] = "#=qD_rd3NyL85VZZEdC1ZY8TQ==",
                    ["#=qMjvr2ssfcRigoov3zkQiqg=="] = "#=q54ZpSgmLPlv7J9EBmosNhQ==",
                    ["#=qGZWMBYBKwS7$XBbZH1WwCA=="] = "#=qcS3w$g3cgJvdAbkiEF6c9Q==",
                    ["#=qdgymaNDClSZBDILSZY0o3A=="] = "#=q7ufQlCrYFqh31EbwvjUUdg==",
                    ["#=qZMhBofaj9ic9etX$wZqc$w=="] = "#=q6aasZDylQpAu46F8ed5BXw==",
                    ["#=qMj7OvsJ1X3Igt34MsrgsyrS8gfKxfvDHtsnoXRSA6bRI$lfhOD1Ku7Hb64eCJSpn"] = "#=qeDsY2lcjabPOJKADBRrEOKbCcH3jaiKwgohUyutbD$F8tbDeA$WwY7uv4a7NCnd0"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qGBdwQTVmbZ2eEsEyq6PjYA=="] = "#=qtLzZjopV$zDJxftKTnR3yg==",
                    ["#=q$2dBFsFtiM$Cy4AJ5GUkuIq40aOX9dDOB5zSg6YCTVc="] = "#=qEPuzzK$$sdqi4gwIV7jhNkhsKLj6FTx2W_$HIQnUKfA=",
                    ["#=qmRtp3c6nrm1GdDj9OC5Www=="] = "#=qx2F6EZozwq_sDWfuM8uwvw==",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qd3zJ4LDHNl7CalMdSYkSZGxrh1VSPYiOYGO7z3_95A8="] = "#=quAK3Bkg7NX4Dv3ETLW2$OT$jSo8cgCwhEqLBLvoWbUE=",
                    ["#=q$mxGIIIhBqc2CC2hWnBGFJquABIF$zYFdvkspaiLgGs="] = "#=qYNVEbKjb30oeYV6kY1jSFBLrHnDbO7a77kNklFY2Y1E=",
                    ["#=qcatmX43Kjzi7CJaGTdVWyXTA60M6G1f3hnd1pEEWP2U="] = "#=q5h8CSfsUTlqBE9XfrkcmKLKpmCkbfUscdBoIVf7EhG4=",
                    ["#=qLLFHkZfbw0rXndg_xALUVXH7NmhLbqeR40YZgmoPgdI="] = "#=qQ7ukRUzupGg8Cv0rtg5rv9g0iaCA50B_XNwvD_lV0zQ=",
                    ["#=qWTlRVaNEMvHo6tfhT73$vQ4vF$zdLOwtvNAWMX7zZ80="] = "#=qX4vzpSwlPQ_JEsnVLEj2tg8HoafKbNOkwIulBcNvHbg=",
                    ["#=qKr2bHNFgsSWSSkSB6TUgM461pfdzEotaH4rUlRGvlgI="] = "#=qd0jS2nE$SV8U7nMEJRA81_COXSHTiG1l804VI$tXXbo=",
                    ["#=qhWXB6gQh7AAOFLj91vvwkw=="] = "#=q0FpeWks3wB0PwYVDNX5Z7g==",
                    ["#=q6VHfbtZrgxnJoWEnysZMwg=="] = "#=qGJkS0zm8NZ1YejMYhqreYw==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qLb_XFEWiOE0zBvgfu6oGMEDhuze0VG9Y3h28ym0dKEo="] = "#=qhCLuBO46BiPgeZNqM9gws3plbzfLtie1lGG3iEAkhN8="
                }
            },
            ["#=qHMT6oBwGjomCLy8C48ZND0_P1eqXpM7MFY87JWjQGYc="] = new TypeMapping()
            {
                typeName = "#=qMDBZHM7ZGbibJGMmkNdRWinzH9GPAb8lPdIa_by827k=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q6epYv5hvPEF72bclM6dcEg=="] = "#=qJyShdY47IZL4Wn_$gCcV_Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6SoEnIIYjVzC4VL65h4u5A=="] = "#=qzw2$6xJokgkJw_zWpuX7cw=="
                }
            },
            ["#=qHqvyR6qZLhOAP_dZGVDj8BBjFYqxXWAZ7StjyVJVC$w="] = new TypeMapping()
            {
                typeName = "#=qqR9RGGKgRRrP8OjXqg8nCuUoC6tCSPgmicyrzLoyQfE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSYcjEY3VYkL2gIngmhaATA=="] = "#=qyetKE0CUQXiDGSz96MY5Og=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qhRW$HoGnOxv5EBzQBz_TTpYp8wy0Wd2fvXrSqW7mnOI="] = new TypeMapping()
            {
                typeName = "#=qlkl5MKRDoM5KoGEj8hR09H7t$Cjd1OdjV$$JG_WLLKM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qyillBO8St4O5pOLj7pVXZg=="] = "#=qOlR_Tdd79mYXUKBEGd7bZg==",
                    ["#=qxscTPjAPNr_r7q4aGGrAWw=="] = "#=qrqW$rGAVKjAaAU53VujRhQ==",
                    ["#=qvRUyrOdK_u$cCw1LfOw0pw=="] = "#=qcqYSKgD6NRDMVe_NfYdeRw==",
                    ["#=q1S7attLraJvXv$uXY54KuQ=="] = "#=q_IuCUplH5mTnT95Ow0UzjA==",
                    ["#=qGM_jQYBpl5QT_bPoerISzg=="] = "#=qjE6u3PgLSPLlpczvAL0YLw=="
                }
            },
            ["#=qhTQvc5LsAga6L59pCRVu4ui5HOwY0R9cJtxi3$cY$cA="] = new TypeMapping()
            {
                typeName = "#=qWGXo7CWjri14kL1KpjFWXuikcwaBpIk5afE$EfPv$h0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qqHwPuE$t9vJ8hQYqXTABkw=="] = "#=qY0P_VGMEEpndgpFyYM91kw==",
                    ["#=qEgHn5mw5vsxl1XnlFlGaWw=="] = "#=qJd5066KdWzCY04O5gDcvwA==",
                    ["#=q2iE$tCruAcMfXx4w0JhEPw=="] = "#=qhRYHA3K4NRRRCcxzP6ldCw==",
                    ["#=qVzMVZ2YlXLznD8fFG45B1w=="] = "#=qFhZvtfaxeM$_hk1DO9bjmg==",
                    ["#=qNcvb$VKJg35ZByAp99prQA=="] = "#=q5S3VNZeyUlbZU$nyMRcGiA==",
                    ["#=qtjVT4taZOi29T5wf2v3f6g=="] = "#=qnh9cxgwQlm3ozLanWt9w9g==",
                    ["#=qZUOuX6oob1UjrjJ1T0OWwQTUX47hbe7V71pPrPMgWJ4="] = "#=qd0$Z9MlwwWbJMxWhq5zCkFVTYkeLnHFBAOcULSgJhIY=",
                    ["#=qmmuFvEV4TIlqO58GIqYM6lfj_wPWFCvMyBV4CfGZORc="] = "#=qbyfs83TW13mw_iOi64IAaqBGmOItvMUPfLRfIb4BSmA=",
                    ["#=qQP2i0lIJCRhvA$49cSVT$6w0CDMin2DeixYvr_vgiAQ="] = "#=qnQQUWTbE3RGizBxiRwrcdRYgUrVqlZxEuI36QW5A$fU=",
                    ["#=qkir3qSzPPI2aQsVR8IrcqQ=="] = "#=q59kbn0skJxeWxtrqTmDpPQ==",
                    ["#=qtv3L1kEd0$lI7GXUGR6DpA=="] = "#=qduo862y3f8fHzv3AO9WyXQ==",
                    ["#=q9CXpE7Ap1RErRsgBW8fr2w=="] = "#=qcKQR1vuDRgaN7YTnS_i9lQ==",
                    ["#=qKTCaCVD6u6SorcJ4e3$ZxA=="] = "#=qx5qrOvnbOkqrjbur6LMPCg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qVxgtU_f6GsLrWBFQLYtePw=="] = "#=qcxpBl8p87CX2K32jbkpnNw==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qWoy1yK0pZciCsNtmq_k8rUtl8dPkfucV7P7S9KMRvGs="] = "#=q_BzF2pdLN7PAyYGSlDKjqK0qCyg4D3go1p$d0mUpqJM=",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=q2mgeozL4XrpSFMMwyG7jSpzudhV7e9HU4fJjF7MWYV4="] = "#=qamev9WUMr3h4yGvOeUSHXYV5MpktD0v9MxB7X5b6uP8="
                }
            },
            ["#=qhUk7cH94ZTA3SgUB0mx_u8S$3nxPXEOe_v7vO7DyLX4="] = new TypeMapping()
            {
                typeName = "#=qZBoyrzQj20R8rdULQBRXM_GthaP40Ep6xDNTDp4IrZ4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qhVBR35qndLmjkxYti0r6Pp7DWoOioLGxKxZSIxbV1N8="] = new TypeMapping()
            {
                typeName = "#=q6yF1nIZx8ySh9vUZ5N7VFRcaCvd58ueVgD_BPPVi5Pg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFjRlbs$wEGL9CbQV6WBk2A=="] = "#=q97n0CpIUIn1rbz1WZKpabQ==",
                    ["#=qBolYm4fNLRy5nzknZ1Ozmg=="] = "#=qIEAPBCVXmyfxSBp7Mhrc$g==",
                    ["#=qr68j9HbQG0BJfEF24Hj1pQ=="] = "#=qqt63TrEmuh5VDdMybyvkFg==",
                    ["#=qnhIThwJbH3vd3HG9XvVHqw=="] = "#=quC6RJZt9mG9lBn2PEzm5LA==",
                    ["#=qvs4sh_LVsn7MMtb5lsgq_Q=="] = "#=qnbdbnATuq8b2uoZ0ieAXjw==",
                    ["#=qSs1OtStSVjz5$xZvt0Li1w=="] = "#=qJA4nFutiS4awga$anEB46Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qdEOOFs4QOpixLJPx2LAbXBkuQbvMV_lGyuCbE6OQzUc="] = "#=qorRPjCHz$SGg98P69DbKR$hl1QirllREIgdklbMS_4I=",
                    ["#=qZCqe3i7bsbgIl9_Z7wHbSg=="] = "#=qmznDHlL1DRN$o4XEjlm_MA==",
                    ["#=qiMrZ6g_Fcm4DEf7jdImgeg=="] = "#=qySELteAZam7n8K7fioa9gg==",
                    ["#=qv8E9uDiEFNX8KNPweCexjw=="] = "#=qFIDp4GZ1OcjQw9XwugPX0w==",
                    ["#=qTKStJEJGzGTZzw9$WmWJgg=="] = "#=qrg5hixraHx5I4V8$y7fgHw==",
                    ["#=qoYtVL69INvDPQs2N_kU3yA=="] = "#=q9peVbKDevfIRe_ypSTpI9A==",
                    ["#=qhjuxqS7olLINq49UI48s8w=="] = "#=q5m5ApEkyvZ9ynP6QjRxayA=="
                }
            },
            ["#=qHy$TLIRV3w4ZJbmWJjX91djlJZ5fKcq6U9WC7ltNpno="] = new TypeMapping()
            {
                typeName = "#=qSUtGfaESiDXPc2$wB9klQmh2MGKkiTTHWbbW4GAgAWU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qhyeuBaWdIu66PI2vr_CFX1tZT$K2oUvFLNP2qArTv_MxQzW5E9z4S4nHK_7gcPPw"] = new TypeMapping()
            {
                typeName = "#=qUK$LQIc0oiii$4lJuRJl6fHOdI_lfUk5je5ezKBP4zGm2qOkrbhpR_n4P6Qhi2PH",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlBSvEPs9P2pK7d$fAPL1og=="] = "#=qWFwOrS8VnHJNPJovqulp7g==",
                    ["#=q_U9ynsRBdo4ksmj7Zf$bxIAxzSq4Q$setqzJAEweGfs="] = "#=qHuT3ZzVC8mwOy44p7dxea8UceqlGJ3icrJKHaiZpAI8="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qaIqb7oAxlAPHCj2Ote$WqctTTpb6LJFR_8I5frMMKn8="] = "#=qUX182_Kpupj9m9njOddw$l6UEjkagjhMXhvzYyGaYrQ=",
                    ["#=qi2RuUYefxUjexFOKBUlJE2WPpaMeddGFKyFyAe3xiPI="] = "#=q$pPXZ3MDJTlY_f3aZCcW4FcNXmHE0fwJi4y1KvgIMoQ=",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qukT0ZcGUk$s4Cz7NxZ02zsZ7MFq2GfrMWuX9r3ncBNg="] = "#=qPLT8kDkkmA_7mBVtxbDs$xff9br_sA8K$ufUEhbCzoA=",
                    ["#=qykSMfDxgooLAkrXz_cZ7vzDQ66esIAJFI_gjvlwx0Us="] = "#=q9nLh2P$qyXP8gbBQ6RzeQWL0gbmAy$KbXF9$MxTclCc=",
                    ["#=qN6a2G5blk9UHanPbGCAsQw=="] = "#=qOwBEX9JNmYEsKuPqsDQnHg==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ=="
                }
            },
            ["#=qHz9jEEwGv7b3DoCIuLHNMjS14mBxXQbm7iBMT9anJLY="] = new TypeMapping()
            {
                typeName = "#=qloh2co0efGI56Ykec8tVZZalRxJ_vg3fXw3BOJzufCA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qei_J7i_dhc49XHtvO8u6_A=="] = "#=q2Xggdv3GSMJr3XVHREZXfg==",
                    ["#=qQumiUpr7GKvJf6hXeAWzyg=="] = "#=qKMQkYTyi_catC69A8N_lTQ==",
                    ["#=qwtr1xbftLygKZcbyUnWWXQ=="] = "#=q6$j8wC$e4b3nZ9EGsV10AA==",
                    ["#=qPaLTBO5QiK7xly6LZ1lXM0V2seeElYgv5WI8Hynyc00="] = "#=qH6AAV0DGQUbf6AEYdOxXQNsNEFGdrsxFKwdSTwCZ__o=",
                    ["#=qPmivLv5TX9XkWstZyiTqLrBO8KSM6UaTtxuRT2zqUZ0="] = "#=q7$Xch71WwiMHe9IrJ$Ct6Vro5moyiJjdDvesAyWRFlc=",
                    ["#=qO1I2$03Q6Eq1zK16LWJg2nRWXFuOK0J7pTdGP3GsjS4="] = "#=qAsGOpbSAIWGxFsQ$QMfSRK4rDXf2G_MT$AjJLBaZb0Y=",
                    ["#=qQNHuwM9ulDARDk7VS82_mZKeheVE6n0SO9tN2FkH_DA="] = "#=qKw$lXW10rHOFvmxpFLTO3JBQK31cpJZPKXpdonTYucg=",
                    ["#=qHy4Bu6KvbuDPPxeFT007UxC7URwsoRlnyC6lqpHe5EY="] = "#=qhS92ZHzjKKj_XBzJP9S72HOB2UKIxVB76KpM0ISjQgY=",
                    ["#=q12K83LUhnC$H8H4AvnomCw=="] = "#=qs$qqKmcWzfIcFZ69BoTFEg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qTAJIxXL3KWYUCkmHS86zVkjv_u3IKF$I1K$l97ioYeQ="] = "#=qWA9L4Z7O7na1WNloApIgwDbCMMLVyn34G6WJwiBmTkI=",
                    ["#=qVqb_0dQiFVDRmR$9uE13Yg=="] = "#=qD4YKDNJOpSljNP3Cuk2Ang==",
                    ["#=q$1S8k$o_YAUVvNo118yDpzmUEPPtXBkxz5mDwGolPBM="] = "#=qhCir9R1jRQOxCRm18Kq9to9TQRivD5LkaP8r7KDziDE=",
                    ["#=qCLFEwbMaWmwwwVDKPNEtFQ=="] = "#=qlTrXq93fEl8zHP5nTHsuqg==",
                    ["#=q1EQmwWfEkNkUCTEkwbxK3A=="] = "#=qwvDUfYgaIfmhk4yFggHVdg==",
                    ["#=q0rgjm3Q615jaAaS0owOcLduE99jhOsYtN573HDoInL0="] = "#=qr3EiHPFzbwwP0WH851do6oPVldjXAo$63tN3her4jJg=",
                    ["#=qQiRK_XNNORp7dfrJwLWVuLcIs9p7xPSFk3lsEYf48aQ="] = "#=q6d_kh41oCCGdwlINZw8NkbEP$nsCi_7VzbHG5Gz1xKA=",
                    ["#=qfRnLfK7HHNUn40pePvWqDg=="] = "#=q5oFLlzgPiARQkVWEtDdO1Q==",
                    ["#=qBEGpros0d0I7iofulRe23nD57480nIbc526efGBt9eQ="] = "#=qgyMw9Wwh_pVYiBh2s$mtFFTgRjf1doTcRU6M5W7yV90=",
                    ["#=qyZbiltWEl2s2e9uHBpbMIBzlwt8NIBl0cyHXsJNgrMc="] = "#=qspFyG$XRSH0F082fOQP5D_gLKseevupCNmSsWM8_jWQ="
                }
            },
            ["#=qhZFXs46iXFB4SkW5JFnOrh3mLosM2w_8NXQjz6lXj3w="] = new TypeMapping()
            {
                typeName = "#=q5RXMj3_N3cwIw2dr_E9QXnVO7TKfD8Lnwm5AjuIA6J8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q1GFiynRt1alecpfy1WvAig=="] = "#=q9eICyBLYcdpT76Tc1yDrdQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qt6juVp7tygDbbGPFRT9hUA=="] = "#=qF2DxReRr4HnJnCrgLK0oQA==",
                    ["#=q3QfZ7gXT5sh33LlpQEfgo2JsiajzXYARZ6v68esowGw="] = "#=qrBOa89qELB4TVU0Vc46U$tiXZKpQ9_zDSb2lf3m6qVs=",
                    ["#=qUlRcP6f8V7wFjrjryxzs5A=="] = "#=qkpfkVnki_YTiMLM0KgoVgw==",
                    ["#=qSlhQ$wdEy$PmcvaOMn7QA$seXXSJPFMKtDYwpnsLLSM="] = "#=qTxF5bJxWE6JcFiTY9239J67MeKVwbprymEuwFSfJVF8=",
                    ["#=qKML29Z$$PwKl2koJsiMc$C7gwhjkNZrBKQIRh4o2uSs="] = "#=qZbbth_iD$Q$YpQrufy8kkFBJMYCTNYoWfAYaQP6tMVc="
                }
            },
            ["#=qI$YOKhSXqtsl4zUue_AYS4gjikaEA9wribs9Bb$h_KI="] = new TypeMapping()
            {
                typeName = "#=q2_92$TS92wnOmQtl17RQiJoMFdV_jU5c_8OTEfuUy2Y=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmjufsSmqQxaCSXC2bQ6cLFxRQc2tDLA0xJxZl8F6Krw="] = "#=qGZ8wz94Wez2K5FJNA51b$CXE4dWUIyylOHcwEqnoCZA=",
                    ["#=qzJmcR$jRhcP$lz$g9meVXA=="] = "#=qVDv38I2xzEDNQG1YXieQxg==",
                    ["#=qGUfC4eV5N3tI89$ZCJmEuA=="] = "#=qIDut5p7trudsJXHa_UMY1Q==",
                    ["#=qcLRHlYOV4ufQpqNC35_5Wg=="] = "#=qifu2zRSzziQNadmlE32G$A==",
                    ["#=qkB$QCbwFMIAJf$mFWZgiSw=="] = "#=qINxBropucPy4EwRp5R8z5w==",
                    ["#=qVBW6gNxKNozZK4Q$p7m8hw=="] = "#=q72WPE1vAAXPGo78puNoFgw==",
                    ["#=q9MmVBjDAPSVPSIzBGwwm8A=="] = "#=q8YBTMq2cUKjU0u6YwZ3ebg==",
                    ["#=qEJceaYkDpzxr5uXTZsHdQg=="] = "#=qY$qt0Nb_Ue8Ghftm4Y$Oqw==",
                    ["#=qzhIQW9rIFdap2OVufCuhlg=="] = "#=qm5zbwF2HYoEwM2_NpbP03g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qaXzQlpCJ$OIP6mvR3BICFA=="] = "#=qg7H2aXT5yt49z6g9JRsyQg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q9KehRu0Jf$ljiLsorkOppw=="] = "#=qy4kHVjR5LdGSvSbitAni6g==",
                    ["#=qyhZptpS2urzEuhVuN9JkVQ=="] = "#=qhGiCpGNkJN59Y37cBU0daQ==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw=="
                }
            },
            ["#=qI1NzGmEupD_qrvbm3UT2I8T$7hZLJOXJWTEVOee9e6I="] = new TypeMapping()
            {
                typeName = "#=qEn$84$$dDSlLluFM1ADYLbLa4ssXTZ7guub_0FUhpTA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q828ogtB55vgw1tZ0EzX6wQpigK0ZeZbooFiEk0nJYoQ="] = "#=qAGnjlCgo$OmKKNOi43qZjOIbSbb$hG1jDlomAn_V7gs="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q6PZKksshDCObmccpKX3fCg=="] = "#=qkA78Z5RWgaeJ_brWhB6Z6w==",
                    ["#=q_s6qTQpAZcLAzdq1W8q$Hc_dElURScU9x$3n27Mm8vk="] = "#=qdP6IcRQwsKw9lDyRUWmZT0ILRygadB3u68$t_LOCglI=",
                    ["#=qumKJzld5fzK4dqiQOCRNCtB2wO6Fl$hu4AkBfXfpExY="] = "#=qxtbtIeyZ0dDufMAT4iD0vazg6HUN6n8peb1WLcOvjmE=",
                    ["#=qraGnxTLIDL2MYTyPy_6FjwYTp5vdJ_ueYUNAa85JdPc="] = "#=qzINjRrwB7CJ1Cxq28bbR1MGYZHZBT91kXpUn7jBwmIM="
                }
            },
            ["#=qi6Zm$FKBwdofXCoI75N95O$ZX6hIu34sFkFXfbk6jC9ujGtIbEw_3ogBQ9MvbVqn"] = new TypeMapping()
            {
                typeName = "#=qQFz6QvAwt5TUilMN1SjrxwBwvLUITgFjGIBYobG4YKlSVMKYRu6$KtKjbf37a0qX",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9V_kl_L0veLAd76TsKyPnw=="] = "#=qSvmISFe978jb5VNwsYxuNg==",
                    ["#=qdEXa52ewe5_cU99oFEf0tw=="] = "#=qaXPbDZrqR1gNt5YoSrD5pg==",
                    ["#=qV009dIeKkG3FyLHtl$nFqw=="] = "#=q6P4WWrKXAUZlt2JpGTY8Hw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qia7Ayh4SFqb0UFLwsSQzKCCaO$RdvCpzzorjWBDJPwm21p0dlJH4AfvjM$8X0Tos"] = new TypeMapping()
            {
                typeName = "#=q3Nz8NAuMsjsqQ3Y29d0MfkwMGWL7RzlXKNmcsS0LvmiiXz_pklCsPtaC5AbxZ7zx",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qia7Ayh4SFqb0UFLwsSQzKK8YxkkCt48XxUyCuh$hPBSytpKGUW7KZBFXiUYqMj5u"] = new TypeMapping()
            {
                typeName = "#=qcRCFP$OezKnuxTWRSt5O$fP2w0uPpL65klczNpWE9VGODhoyFpaVPwbyRP85GSOT",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3GYpRy61soXh550LEZDYfg=="] = "#=qawDk9wlegNe3CqPfhQFong==",
                    ["#=qksKHl4lRUJxWjKXfkenY5g=="] = "#=qvZfO7AJdmzkz_p$cqUdYEA==",
                    ["#=qYVWrKJeUcMLCHP81n$VOfGwkSpQzX7kIwEkqaWrZpK4="] = "#=qakEzdCXURzBZt7uD6Gcfk6GIDtWf$reaMfiOrZeKZZg=",
                    ["#=qhyzNyt7GJEEemGwFp245l3$gJb9hdIXcGZzffDUHo34="] = "#=qUmgO5s4GWrya9qTXiYQ9Unpqj7X8wyDUkK8YZ8TV8ps=",
                    ["#=q$C_8VHy8cXZ_yQ5kjFHl98MIjFXe4wQwsx6S34ITogE="] = "#=qcXgEZ3mFBouz7d3_DlVSePASuqxem$sBkeDeOj3f7_Y=",
                    ["#=qf26nfXdfxcqM7obNVopDWg=="] = "#=q4ExGGdCBX$4uxuTl9jo4Vw==",
                    ["#=qhrqFH_G2CavR1Of31ArCPA=="] = "#=qmr7MVOgMBx$hj6Z45mSiIg==",
                    ["#=qu5G2vciBHMhaBPiLL4M4Gw=="] = "#=qf48TweD1KCP7xyU2609pRQ==",
                    ["#=q602MKI9F6yTdoL6pGP4eww=="] = "#=q4t67WScwu12Gf8Xdgh0KRg==",
                    ["#=qPgqAzgZx4yWdUM_PuV9hlg=="] = "#=q_dmzrVgxYHVLQ18Sw$kvvA==",
                    ["#=qtCcFaUoFGR7c9WRiAvnj8Q=="] = "#=qjGqZxu7unB7lx45rkuq6wQ==",
                    ["#=qpEQnHyVidfCwv9iUo6pfohmuUPwYznj_vuBVU7aN$q64f5pItAGg5_h_oA819ksQ"] = "#=qm1fTiztmRDWIFReCKkF1_a2Q_EhnErtFzqeE3ZKHRYtX70lM2yn_zez0eoOVOgW$",
                    ["#=qWZT_poIO4yS6b3F7gILl_bYpEBo$ZO8uSxubpqOINQybJ7d1oqJ$bb7j2eUrpqVk"] = "#=qXDII$PccFynpJSanqkMBpE1xiEdKNY6zLtlNLt4oij0fjdN5eSnJxko0dB5iMy_8",
                    ["#=qy37j21HafazCjsMq$84H5zt_LAKpN$kBsYdSpZZ2kdMsEqZ1DR1pFvaFndHV0FOR"] = "#=q9euTVRrjoX_EM1HLkNK_OJvwBYNrJWHBpBlA$NlhNnd$UT33VdbdPaXoChpxhMAb",
                    ["#=qm1fTiztmRDWIFReCKkF1_a2Q_EhnErtFzqeE3ZKHRYsX4xrvMyhCGXwiXul$KhoD"] = "#=qIo3X7JaY0lkrWBcr3XzHh$nMSHWLQ5WqeCdC$VwFgW28XqTNoyegr5lBVBR0IISj"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkn4wodhprkSU$kugDdrwzQ=="] = "#=qmprLlOiktmouEgsdfk1a8A==",
                    ["#=qxBEcP4lqpk9mch2FN0XaQA=="] = "#=qbe0k1$rrRJH6p9zOplWphA==",
                    ["#=qEDsFPvYHPdpzOTRKf1lrxg=="] = "#=q2AKE$ESFLpudzcnMlsjtag==",
                    ["#=qay_S5RPvtpM9xAa_IiU4FQ=="] = "#=qeYcGEyJwiMis0nECJfftdg==",
                    ["#=q1zn5RFPK8iUgGRm__lOxR3JJhgz2qVjkKZ$ZYuMSWv4="] = "#=qfFAVAzaGCrua4YOMSdjiD9gzfIkmzHKA8dyCzG48yVs=",
                    ["#=qpbmOoolja6c4hN$jAo5JxXt7Yy7H48i_aeayNtCyO5A="] = "#=qPZOcr3i4nTeqn4gCEVJ6bCwIHzuOlFR$ZDs2EEhRkuw=",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qBlQT4cviONSPv8rzSRk2iNX1W2iY7pa4rGh$T7SQzjY="] = "#=qFJafjwWGXrg_kVfbHai0gxXu5MbzSW2PzBISWwMKx8M=",
                    ["#=q9UXIQ81SMQ38Y0$D3RROULx$TO1uXXvh4eoCSgzfJvY="] = "#=qkc2TpNeSEIliCM05rtdst0BAdJeUpb3O2uE69x7F184=",
                    ["#=qYwxE3rcjFaqoP$I7_C9BeNS$q1wukKgx37W9yH3LTOY="] = "#=qQVkQGUhYbysLYtSdHfhxCOYvkJk5qW56DbAGIQZWc_M=",
                    ["#=qf$SOKy5hZluXpY_iSjMnHeHpCqxhn3q0ytWK_r56L_Y="] = "#=qGRUAWV97GsC68$l_Y6XAJw6PwmLd0G3jCWNkiv1Y2kI=",
                    ["#=qncvH84hjdZmQdNQfAc6g$Gbyqfzx37RexjXD4ikA8lE="] = "#=qz9YodwacT4mOjgtp0ITcjx57s3KiKrcO9RZygIXnd5A="
                }
            },
            ["#=qIaWCxSm39gK0y$yITd5OB5kH1P1QnywhDfUPbtTGmEWpWD8WeVf9BHZg5EO6rieP"] = new TypeMapping()
            {
                typeName = "#=qsb5i$Z3Kn6_0UWHjt4CeKD_hsH9mARCUDGesCCMKl_r8ichtXcNtoEr0PMlHHMpW",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qiB5cTsnhpRsLq9JzqNEKOfdr81cQLdqW6YCoxkk5Uj$GVwe7AaiSBmofb3gjMxt1"] = new TypeMapping()
            {
                typeName = "#=qvGwQltWt5piV2GN6LA_CbaNNWE_f1_5cI5D4zEtXchfhVQyCakQeLvx60vzcw8ym",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qKidl36YuP2tLS2JsPLmKyw=="] = "#=qd9WK4l3WZjud8LvahS3pcQ==",
                    ["#=q2VyXPJLAFAKjgg0TVIH3ig=="] = "#=qWgcyx7VXoTGrjS_p7MmUwA==",
                    ["#=qnGhv5Qn4p7Zz395M87E$dTrz$FluS6um6yrfEJUwzUZSH$qQwkrJcpXTHKNNWKDN"] = "#=qbcsHo8ZXkEnL$1TzyYbMbWVaPth9cWV94NgtN$W98mzKiKD5Nk1d1HROh45i6Wks",
                    ["#=qeJ2zxR_2B_LD_dOVmw75TiaWtmcIbLLA_u$EW0XWtliMvTmgpwGbD4SyFl0nbBq$"] = "#=qrrJJAR7_DyawLv7lY1AIpH8xUaaXMCZhYubf09t5Q$4EEzEht4nlZjybwedz2iyT",
                    ["#=qg1SpeSLDFlfys$AaO5oWVJs2CJUCh4NVEKxFrBOr$lSUDw5zS4RnrdDV0I$ob62o"] = "#=qARX7N7tvRJoVy$hETbVXSC9ua6UmglaJyHSsMEC7p$1hjx01yfuT9k91fiU2jGL4"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q2hfluxH_AsGFO4gTZw2tCA=="] = "#=qXw87wHWyVf72eb0VSEhPyw==",
                    ["#=qjk7eMQsbamCDH02RVR84w6JnpBFpJZQFE2SsI$0ZVEasPzHDvWrLOcLwQFlu2PIQ"] = "#=qDIiBvCGEvxiEPmpW25Y6vGhEsKpCXdKdbd6C5gO4de9dqmC0OsKn7asOW7ajteWJ",
                    ["#=qdwAtr7qlRNAfucU2OkYf$AYCMZXlxW$GKUqVWACfmPU="] = "#=qNLk_blCDNtWfqM$Y1hHg_0o0i0bup41qGCUfsQlbsWI=",
                    ["#=q7lfWz4_vGUCK31Ut8rue1Du4bSbTKZZxSj7rK2gyAqo="] = "#=qKW6V7kmggJgK02lye7nLJjnciY4HzXzXRfvxAAX9RLg=",
                    ["#=qkGW6TwAiuCuSI6XgEySlaKQtBTbqBN65dZgWS2wz2tE="] = "#=qmm6dPX$OX8egTGZpwq7lGWrHH1BGO8_Re0FMCfKxI5E=",
                    ["#=qCbGWtH4USdM3E$OF6BEwKYPrMPgXPu_gEe7qr_SAvGU="] = "#=qefEDScxVVETH5e9$ltJOi2jSZ7j0KbzLkEE0OHDMR$U=",
                    ["#=qJEdILSE8kopWlRkEBONkTYVYbfSRaLLo2b6GCQ0LDyU="] = "#=qiNrcxX18MnRtGJF4b9YA5DRtYUBvfn8cZbbDLA$ONiE=",
                    ["#=qvFm655lgGGRQEZMxSdjDS6GT5Z19mFdVDdlE3M4cf$c="] = "#=qYjNfdx6KpsLxRSWVBMkIyLZpY6NLCUgZRSM9dOym$$0=",
                    ["#=q3Qht0qlvKYNro8AdZkHaPypo$ywXbUqEO92nmpD9gH4="] = "#=qKAf0gUgLxv0sP$ZxZBcDMNp2LBJk$JeJuc273TKiPUU="
                }
            },
            ["#=qIDBpAPCIVzMn6fy_WLfItrQT9uviFhsosYbfYi4FeBQ="] = new TypeMapping()
            {
                typeName = "#=qPZTDE_y8Br2sy$OC02ItiyZa7Au1LtICOr5rHqrqO70=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qIDXrtVje14ZzeXnnZiM32mkax$aEF7r2tv8jvzWLtSr8GuLrcl_subPyqNpKa2Xb"] = new TypeMapping()
            {
                typeName = "#=qeRPxz4drvqpiVYHKWgeigKGKmW1MgTPLvvwZY1pcvvY$d1_RCQFs3DiDbmtKNpl7",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxc3$lzdRlz09xLyNYXOOfg=="] = "#=q8s271Sat47PoHGNBkr2A1Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg=="
                }
            },
            ["#=qipfTsJgrSwxOysRrWf058PcgLsWlSWDbSfXVMSXZtTw="] = new TypeMapping()
            {
                typeName = "#=qAWWqz$GiMGpcbic903xiqrAKCiBlycnF1Gt65vnKF0s=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qp1rxRx4OItgoIfOgsaWj8g=="] = "#=qOI7SmbMcyzmSCRayBHqPNA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q6ILMBj_mlp31wZ4XY$GWPZlRTBZoWRgn_YuHJCqRrp0="] = "#=qXA7ucsT_UlYxlwSftKjamFRU7Uuy9AqnXmtiIejeIN0=",
                    ["#=qXzI1DGARWTgeV4lXv35wOA=="] = "#=q4nIm8Fm1$TB2fCoAfARfJQ=="
                }
            },
            ["#=qIpvi1Wv355CGDb5l9YJLogv$$4Zjh3CDjc3cu_ahihg="] = new TypeMapping()
            {
                typeName = "#=qbH9OD8X_FVz$ZxU33SZRE$uQ2lwU17oWv8cphismt40=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgGv9d8WexjZjXkoiqGlt_w=="] = "#=qpqfSpBFizAmD$c16kKCmJA==",
                    ["#=qX3$o2KfoZzKE$Rp8meXY8A=="] = "#=qGX1w$L5Yx38iIMmRRkT6ag==",
                    ["#=q7Td4DSnXnrkg0QaMkiOgOA=="] = "#=q8FyR6ZAN9aXE0TK_x2m5iQ==",
                    ["#=qBDJw$KMLpGpXtr$NmJVrLQ=="] = "#=qD8BfJ5UFcIDr53j_nmLKwQ==",
                    ["#=qRD1GoKpDyVyudWB25rjD8Q=="] = "#=q9Ne12VcLW46dcTZQLNJX_Q==",
                    ["#=qepddMAbQgQpinZdPdh6vBhVGNRO8kVb_AboRK9kLN4I="] = "#=qrRUT34uB9Ut6Wpa_6reVFr8QHjLV_ejNg9i3EyIlIEI=",
                    ["#=qIrFPUQhT4koL2$drX7wjPitRX_mrxp5d0xQRM5Lbf0c="] = "#=q7hccoaE$WBdmeQldRF4UgRXvjXBs03z2oXXB69wv6rY="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qmqHTMHivLjA6iuFFtXtOTw=="] = "#=qmsjoMIO7JtGtBxKWd0OQrg==",
                    ["#=qlEhbYRGUGuTC2mYPd10pNw=="] = "#=qqC1QGJ6SyxjOfxVIFw6$bQ==",
                    ["#=qiJph9m98iZbDwbj9Na5O7Q=="] = "#=qu18NQH2As1EoECj21qmv5A==",
                    ["#=qvW74Zme8nhsz_lOKXDW0EnprcXjduXSSej3Muc6PwXipwDNJMoYGDaMkMshp7rU9"] = "#=qsmeUi7BlH7fF9xuaTcCo2AKtg_z$A83EXT9LzjndPJo3gpqzWhEETj29S5lGcgKq",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qeudjPRTxgxUAgsGc2JFUbQ=="] = "#=q48eD_Lu66NCiwnzdyKsFhQ==",
                    ["#=qASlSNbcfvdKB4Ysr7EzuEEHQEafGKLXJk6rvOCf51b0="] = "#=q5f64nl$mmQ4Y_CHkCP62a1qniYza3CWMYovtf1I6tS4=",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qZHCG29boNiYaWhVaB3MUAA=="] = "#=qlZq6z2sW5pz16SxcJ7cQIQ=="
                }
            },
            ["#=qiwUf8Xh4mGhLAMsR83Gv84P3VLgCXbHxRIlF1Ihlg4s="] = new TypeMapping()
            {
                typeName = "#=q7XbTwTHrVYCcYRUI43rahTnYuyl$zcF4lwDpPV0kbLg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qXca$Xvf1ZeAdEtqDBZKJCA=="] = "#=q68cBeYSm6e9ydU_dp6GHSw==",
                    ["#=qQW8P0LutXTE8NIkvay385Q=="] = "#=qavvipneWgsXJpR4JniOZWQ==",
                    ["#=q9YOplJlx$pRmjRTJ8Doh2w=="] = "#=qPfC1ubVsO9MTe$hdGmYEzg==",
                    ["#=qDC1wJ8HZ$BLyTuHI6bu3jw=="] = "#=qzwkr6ZNsTt6B$fWGS4Byhw==",
                    ["#=qBjdJqCRGTf9c6lzF8J6_JQ=="] = "#=qhb0QzOZSxTi3bmfpPbBiag==",
                    ["#=qtiRUPf52Qv2sxXilJD0icg=="] = "#=qS4qHX9arLsaSOgA4Zxxneg==",
                    ["#=q9_Vx52gtzzY$ZBU3c5$gUQ=="] = "#=qURAKhevJDRSHdGF5t111gQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q3rHJWxdWg7Bbb2OUKxpvPvU84nyvz7wJ1u7oqiCopCc="] = "#=qz1Ok2_42QRvLT_GPinAyVqaAqy1gfHmUzGeiEMxLgSE=",
                    ["#=qcA8bqgVri_niDV7nhY1NDt1E5_fxUgirp6nVPqrohWE="] = "#=qBieBEepB8R5dg7PpfxiFTdYYQm_4tKsVKQjmrIZfdNk=",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=qiZ5BVC1pPvBOEyYUS2Mt3l2DCHgbjvLxOL0Skgr_tSg="] = new TypeMapping()
            {
                typeName = "#=q5zA1iYN7O01jZVVuvM5f9u5ZzpREixDdCnUsNMIKcdQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qrkmEygiq2GmNLsbakaBfSg=="] = "#=qxZhl3ArAJYak6ViWWcG13g==",
                    ["#=qldxHUbT2TjDi0gRoUEejH8fSAABqIp6gIpG_geoxHVQXbaftJ7WTBv6W4zwNO57b"] = "#=qzyp7iYLhBpLt$_dsnFug5Z8VjIXtjowaG12jJjqaZWKpydVsEEQo3BLLS$EQLl20",
                    ["#=qAh8mm8vj65_AFSbLhxu$2fvMvlqDSDPiE$_DmLCQmJPU4Oud_e6WPLgZP7u2afou"] = "#=qJvlTpM8ynPMKhRIJmEm1hR3UYeFAj5K6Xm0gicczRRb4YYTun_BVLMHoxS55XwDB",
                    ["#=qvOwOwTD_m2SGC2_yGlanTubfHPlsPw_btabnBNAKPOhTrtk$wpmmpP5Jl399LSh9"] = "#=qQFdwjYV$uY$RRMgiDYEDON6Nn_FyG7cYvM63Hy4Whp2eMPnxiJH0pmnruds8iFLi",
                    ["#=qlzxzY9rHkKxTJOrjFExoC3rCsUjKzXHtyyX$g_m7qaHIQQIE40rBl87tjegafPKm"] = "#=qTi906m0U$DHtFOoegjuhD3LC3uESJWtXnzSD1c3TlximxoHA5KjiU5a3A3n82Y0D",
                    ["#=q0zs_goJjyMCWBGkqp1Ib__WgRPM4xeeSjwtNKapXy$6o7d8ZfIn3pfP8Uuq6iGbA"] = "#=qTvvOmfxcHd2$zgh13Pt3AhqODUBOXXW1K8_bG3P8F2xrF$Ob2NGwfCafIKG8nwKa",
                    ["#=qC97zwAbh$AK4rZ54FAVB_sBtjsHLAIFWdeuFjPM6uD$5QbLgDzH6d6tRAP5wr3nR"] = "#=qN$om529ZUSoCjabusYWphp5_zhBd4LZIWtLbCPHPlbws_KoTLxZfDjNZA7Cn3BNQ",
                    ["#=qUq5kaYedOhm47WYdhjyQcBNBzf_$H5Q0v11fvI4NcBS48jualitS8O7ISB42RVkX"] = "#=qX3bn7uaptDlzEPgPu24jhkddOvo6LZ3QpYneY6h7CYphrfQDL3wNJG$o0q0V6SxB",
                    ["#=qzyzjuPcZHQvqXiJAAQJiRCfDvGjPEEeU9eDZrb2g4Qmi2Z_AqnSygXCrguyr6zVs"] = "#=qiIgBLxbUnVNACfr8AcklsBYNxE_85TMXgzmr7UDquY6kIb1meVEs5m_2d9DVAgyI",
                    ["#=q5TMIokeivS_tFzY3nEFeHsBJs$MKImDRrb9em105O5Bn2RpMNmoC2p1BsMeafpWe"] = "#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieV_2igllleIuabiXNkpjq9Q",
                    ["#=qDHmpAW54ppEOLpaO$XlNsXNDIMCtjKObpOadzP_J3IimkXMJjasRT6tzcnEUjedD"] = "#=qWZT_poIO4yS6b3F7gILl_bYpEBo$ZO8uSxubpqOINQzZfs01q8$0OXAEc$uMtf$Y",
                    ["#=qEfSql$libJGfo5lNoMiuS1unM0VvUAlILVHWmcmpFmjjfzI$hZZbduRrcZOxo1Ux"] = "#=qvoq9q_IyRQ3l09XUh5sQB89KR23DjyU2OdLea9wgEMvoDbRjR3N8vWbGqIpDW_HX",
                    ["#=qk7M1VdLORU4dadfPbpIqTlxbfFXm2zRkP2OnipAcG96SjT8Mo0VQEzZdxTW_Th$N"] = "#=qsrgaFLuO1LZvnkQzW1vxIVpTWc_VVhh5TAxvnrmepg57WLd_ILa4s0JzFUfGIz5i",
                    ["#=qnadJWwRPcz16c1tx$x5T_7eFyyD_Gmn4QUMnxP_RcpoQJYWXkPlbxi6AwSj2ZnSw"] = "#=qeDsY2lcjabPOJKADBRrEOKbCcH3jaiKwgohUyutbD$HWfkktVWSPoKQMlEJ_jyfR",
                    ["#=q4TCP9VVxWi1Ubo2EWeJPe0kwz4XV$umur0Jz2$jkY907_95rHTi8XEOCy0E8ZDW$"] = "#=qWaYqNNc6Lg8fpyEMm3C0amyG3H_ES4vRgihuXEZMFaBK9_F_eOyrxFKNygk0cM$Y",
                    ["#=qTBQZBDOrlrseU6y1UiQCIw2A2fzxdG5$HR6y6QvP5Rt2Kex3NMJTtJRVR7am$5iM"] = "#=qJYJM4$BJaKiGaRePS19W03huV48uKCn6A0HGZcsTycugPZHfWQLTaJrCi0F49aYL",
                    ["#=q6WdoHtzpQeJ1P5TTWWn0T6vDRkiSnGaLElfNVGSiMILFelUMlWlqOc7TONcmFB5n"] = "#=qfq6oqXN04tnqgaP$Vuf8udZ0Fw_VWKQ1velq6NFEgP4GOiS3p6kWj2uvyA_F4op5",
                    ["#=qRpBCJryDqe12TUuQiehIINyNK9lw5oc8tojtlDroukBzF4dh$LYcl2XlP9i09HrL"] = "#=qz8meAf3GVdQRzTimQuLEz9diJhpQzgZZ1l2ubNmJbJ9ICubDO5q9ohTBuI9O9qxD",
                    ["#=qr$O5k$cR4WJXDNf_rbN9XgCgCcecUIy37ocySZfsUzX3DFDr2FIjGhzDP5E1ZJXY"] = "#=qoN8R34xxKqRVMHGy4RSVhCBzQrNNoF84tzF02L99xF4DrR6ckROy8QZmSS9XDjJ$",
                    ["#=qvYM3C9$wP3C1Ba4bBsQkJLX9WLIgSsp7kQMzGw6XCwdoHcnbhqE_B8x5YmcMrHL0"] = "#=qeDsY2lcjabPOJKADBRrEOKbCcH3jaiKwgohUyutbD$E94cYJlA3NMTVJQL6p1jdI",
                    ["#=qH5dwz_iUIF2lUDbzQBRMYwHcivjD_SKrzKHriW553w39eOWElKYG8Y0ve$Oc9ae$"] = "#=qUuS9yf3FG8B_MmeH16lkr9UluQ0S5ea2jpZeOjTBhBGzGpdPz8jXY_jmvEIAz5RJ",
                    ["#=q_o7wf8B_ZoHiol8Q9haiDOggisyWAKZ6koWmtZBgCfxLJE1z48X71Q1dHDjPUn3s"] = "#=qAZ3wxzAm7CT_xK$KXVch5ec3u82k2X1BCLogND9NmafgSwDsShvU$tRdPWIAAufk",
                    ["#=qg7HLJZAjxQ9KE4qhs6vqFOEfiKUDazhIJC08cJbcQgcrqJdm6dsObZDS78eSaP6U"] = "#=qh_Z2LSglb7zr21oyF8Bshj8tY4Pp89lY8lpUhE0l0eNoU937QfwLA9kS5jVeQSPu",
                    ["#=qq4gPuDwY_5u0M53SAf48Hi3tVjDd3CHfosuTzkxffrVqJSnK4y226G9O$JB4HiTz"] = "#=q_xp8tF0FsBPxhlxs4Carp9N48Si86gBfCEGyGqKkJqF50sWl0y8M$1PJivesYEm2",
                    ["#=qsqRhztglKqoDHg$6hXmmnlxTfBSkDjNgu$Ew8v3ax1$Zb0dr3cu6dwL06JOg_NTb"] = "#=q1GwEnnBt572bcrb4GGOM_PecYmP60zFTbrHe1hFUBHxvjPPO9tRNfI17ARTRX12R",
                    ["#=qsqRhztglKqoDHg$6hXmmnlxTfBSkDjNgu$Ew8v3ax18RGVlAKuKDsUf2M97wOtsA"] = "#=qaNnK66AGcDyEINxX6C_wTAqSnC_drL$0AHmXZsyh3dcFAr9nV0jDxdvF0NE7HLGj",
                    ["#=qO0enzOde072x5XBOqPtw5itarIfiuqbx$RPKWMgO4RkIY4XRVLBdYqqnLjUqz9sd"] = "#=q_F3qX11kCPydANJg1sGn5Q$6GhqYS9voXepGYei$4pOuhClo0yBLiZwC_v0rZONF",
                    ["#=qdZpoWgC$a8YzSfRlP3cpDubkRiiUsbcJKiIkVLMRc6v7yVTgQsW_Wknz8W7m1S6q"] = "#=qI3$R9zYGDvEtUAUJ11$EHHiQgTU41aZnz_dserBfW6afdljR$VE7U385Atd0TaLF",
                    ["#=qv36bjNy3i3nLv6gGnHcV_sGblMBZSKynRTJmsvzJVbtNaKzbcwx_Qu_KeyNM66oR"] = "#=quINxe0P7lPm8WSYjWgjwxT74Zb1k92i$$sJJUCYmbSUykAP9XF81KZMUDKbwMQfl",
                    ["#=q0HLiEgCVmDgt4$dwdRMVVDkL6vI2FObjNrFJwZetsy2qjp_i2ZAXDGLVwcEL31Kz"] = "#=qZbP2CdS4$tl5gjaQGIiTACHXQYN1HJVuX_dr4VnvF73HPiSnX1JKyp2QmKQU26BR",
                    ["#=qBL3WkhvL0nZ6vYS4_cZy3iggkKfKg_WE6AFjSdpC9H7ql2JWiHGFlDaZGu1CS_sH"] = "#=qx0_l8pnI2JruIsOcenadpyL70K6t1xDvi08bU9Vr9EuDnA7ILuq$1oZMvoCbD53k",
                    ["#=qE8r0yLGpl8hOTzThLtFItETbMoRAiGYMKZVWP2ykG8bX6sAUK23wE9dCIHqudgEx"] = "#=qw5vOGPTMG6jxVetDnwSa2ArfPExJYcqGq1jyEgE6GsQXeOebfHVkU9mwKJZIotGT",
                    ["#=qrZCu1r5qCEtuSvBEEgZXY66vrwB2YK1UBCMR1o18ma46WccLDnZtb$$OiHpwgoW1"] = "#=qE8uF$vYQPLbr6cQlHFILJ7R6$1yM2udPd0Dar0cBy2iYslIfPcGuPHEaHzSeosgR",
                    ["#=qpPIXj5lZ$A9j6KjHCOVNkaJh7Tx_YL5QNh6VZbiD$769JXT5sJA_Y_X$fKz2iyhg"] = "#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$ANAP5Iu5PXBDK35BvsZ$v88",
                    ["#=qyBO8LIGdn7WroMT40X5SxYagRdOCLnp94hPfS2C25nesfSGJBoOnurCLeBxdPLI$"] = "#=qth055X1pC5HXa5h5wK4sGtmwFOYGrSutKmF5v2Ob4YO3yTg8_spEkejO1WUw3kjt",
                    ["#=q6jNOZZdAmsSMGVRZdAQ5VGqk_eAXjLCiHLtQqvivviymojh9NKkSx6Z4BjmFg3bW"] = "#=q$KSp$23WiyM$l2dhcJ$OESum5K7xcHAGMz9PETkaSHhcizC7ZnwygPRdtrzm17S4",
                    ["#=qtO8wr8p2_Wn33m_IkgBsapqcV4oPJh93VlpL6Elpo8yrXscz_9onwDGTXD0jCm96"] = "#=qeVe2A62DSzpHy2UGqcdGNNESTgkZZam$LNHK7Z3$KQsLzO_BzaKjD1uMF8i$NotJ",
                    ["#=q2_kaUYS5zU7S2TLbuTV5NKZ0ZOH6n2yr3URohrgi7T$CqMery1vYbm_5UXEZPHGf"] = "#=qWhigvFksIUcGgVTgT5ICS9BbquuaEhGXcwPGSS8BaDDUwalg3y8mkdY4HTxwPghi",
                    ["#=qUre4X7XCGT6pCzmmMB5GIZLdcDChd9NtD3SnxXh_K4CBZzXTg1WEwDLYDdo$DtLe"] = "#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieUPqtpeFnYgQRyUjpxbcWz7",
                    ["#=qhTqBvopw_6RxU__BVi47xn62HxHJ6lQqU6rmgTU$EoIOSkwY8nJuw5NWqkT2O5uy"] = "#=qU53JD3veqyKspWS5iOfjfh9jSqSo0AFs8vh_jaBqxG7PSAfzUZedDXZjlQ0GkYFy"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qkKFWGcf$ylFsWw1lpcUisA=="] = "#=qitX5JX6f4bbPoASii6xV2g==",
                    ["#=qDygN0FKmcX89w9ai8EV1FQ=="] = "#=quPyZakoo9gMtHXZ7QVaNgA==",
                    ["#=q0ODRnPExi5xprMnD2SCg3g=="] = "#=qNyQmFQsrNsPUrM2XZhnn9w==",
                    ["#=qHUDF_pij61Ja3Qb5F60azw=="] = "#=q_2q8Ob3JThUzEZUGo08gLg==",
                    ["#=qNO7f$yCIsMovRYF35VGB7w=="] = "#=qHNLcRbKQnf4Wzmt87VILMA==",
                    ["#=qJbqP$ffvmKfnavEJH4cDEg=="] = "#=qOV24SYryBTrjtyEQZlLv8w==",
                    ["#=qkeLUy5uxWk1vD$6lHd3PmA=="] = "#=qb5CFN_gNdmzKF3vBzbKakQ==",
                    ["#=qPSqk5Y11muLmMDhJNQG2sg=="] = "#=q5b8oMFaY5iymjE0E_g_PEA==",
                    ["#=qN3xrJnl6qq9Q1r9zVI5gdQ=="] = "#=q_YgSkGK0tx$eBvVSViQHNQ==",
                    ["#=qCwl8R1SaGa6jwurX8NLPqA=="] = "#=qrh1RwvGU$cXTCP3g04$_oQ==",
                    ["#=q4yg8UTmRUvmgsU4JVjiz3Q=="] = "#=qMos8ZAnVIcDN9UoxR$r3$A==",
                    ["#=qnwqRGTv9VudZh4$9nBlqVg=="] = "#=qi1ZB771uwEq91g_BXdWrxg==",
                    ["#=qzgUsfhDATlLInh83sJZVbQ=="] = "#=qqSYBM5wKtk6QZxYnK7cH8g==",
                    ["#=q_H2J9uI32qpEIwA3WdZPWg=="] = "#=qIiPxgtKyHD9tV1VBtAQ1CQ==",
                    ["#=qkgizv6FkF7oB$3iEyFVZww=="] = "#=qTNvMqbnNbwHt_fqFIEAFcg==",
                    ["#=q07q1PQUkUc4OL_r0Xl5alg=="] = "#=qapq3egN$yKyD3H05nY1Dsg==",
                    ["#=qwNyrj8QAsvv$wRmDkSJ1og=="] = "#=qeLDAIB85pmT5LTWvQzZfjg==",
                    ["#=q6oIdK2YoN$2bUKRNPQWHug=="] = "#=qEvR0u_2ApRBOuOTji0ie5g==",
                    ["#=qHEWR8xXbqbl0fQbmGSPTPg=="] = "#=qnESF8Hru9u0jAkyG1FZ2JA==",
                    ["#=qDrDAHSCbZGPezHsXk0CNGg=="] = "#=qt$tbVZ$QC5FxJXW$aNJ$Sw==",
                    ["#=qlthWnrZqbbzcRqUPz6LubQ=="] = "#=qJRWIkn0rYxZFk8xAkxUYMQ==",
                    ["#=q2L1BxJarype8TWaBVh0UHg=="] = "#=qjFjVGMOKVcRljjQqG4b90g==",
                    ["#=qQhLfqvjTIgcZEgCKYjgo3g=="] = "#=qNSW1ZDWx$RAUKWilSbaC1A==",
                    ["#=qAoZsMC_x_0aR0PqyUDgi0Q=="] = "#=q2Pe8TcWxgYB69H7zJFnDyg==",
                    ["#=q1969kCUWQ35rsOLo52Y6YQ=="] = "#=qASTtFFyK$RPtVW4Q21S7Ig==",
                    ["#=qF6EyUaVCuUo733UAel_Rmg=="] = "#=qpFIZZGwMR6Ro5C0j9A8LcQ==",
                    ["#=q6oZPmKfnaob5l$J9bsYHCA=="] = "#=qIVvcl2c_t$7F7ZhydYP63g==",
                    ["#=qjCnHlL5J8I1IAo08QtXctw=="] = "#=q11iKFwqxPFu2gP1f0YTl3g==",
                    ["#=qaBoAckIFh9M3HS3hokroLA=="] = "#=qD9FhoL3FP$3A7eBnESDxOg==",
                    ["#=q$LHaWA4Rekvo1cX9_mJz8Q=="] = "#=qTG7vKxCNgme0dIRqK6gPZA==",
                    ["#=qMwwgi_zB7TLCKTI0rL$Sqg=="] = "#=qK$eDiNvBBHSRomaKCNzNyg==",
                    ["#=q$TYZhWFyf$nL823d8fuByw=="] = "#=qCcPwlu7r2Rk96DzsZ_9Q$A==",
                    ["#=qLkXg8pgABWGrHItJY7H3hA=="] = "#=qxiipmihZ1mwWOksuRly7Jg==",
                    ["#=q5ra9POLojEhzg8eQysSdlQ=="] = "#=qoTZywQovHES3VyhSgwpQqw==",
                    ["#=qXhfJKJ7AxltzGP2ZT24Keg=="] = "#=q6SybQqNM7fpM48JPfNajoA==",
                    ["#=qKK4cBeQJsnR3cPRO7aH8CQ=="] = "#=qFz0gFOT3i9CrMK9tv1o_XA==",
                    ["#=q_jIrev30WdA42Md68ME6Jg=="] = "#=qPa8cwSLP7y7lOSFF0pB5Lw==",
                    ["#=q2XstdvZZ2eYH8jaqdASJ5g=="] = "#=q6D4AtPlTXYbj1uGF6Vgwcw==",
                    ["#=qARTg9tc4Qgsj2gEfn3Vlxg=="] = "#=qnVs$W7VOR0HDzBZFEhh_Pg=="
                }
            },
            ["#=qizm4ojOwvlTMpLo$a0WBiCtBqI8HXvlnqWAOG4kqA1CxBzyu3$y4DebuBfVWxRKQ"] = new TypeMapping()
            {
                typeName = "#=qL$zOJj9sSCCFT_BpSZdhWrubTl9RvxbyVggg$lYCp3DLBhn6_qQQqzEVZ6Ffb0f5",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qPsJbBbMDcJn4Ar7AfcO$8w=="] = "#=qkufDwVh_A3jtjRar8pqN0A==",
                    ["#=qTcr1toiWAgU88wGH$AFENoFQFnIxYBvFCprJJ0f2i9o="] = "#=qawibQ4ophr94Ev4DQ6Vw8qnIU8QHxHemalvEUhT78uo=",
                    ["#=quqdUMpFv5IkUup9ZqXmqOw=="] = "#=qFZ3AG8RlHTr1zbmlX1ihIw==",
                    ["#=qgR5VK14h3Yp403MYY236_w=="] = "#=qKkfyobZlegxkoXKePJdqvg==",
                    ["#=qZegCpDqLTVO5WtwqWc8RsIB32YXVHRmNz5S2JfjO7Cg="] = "#=qlylu8T4Hb7ho8Y$l9F3juXoCTgHiJV67yBV_tgfdZ_s=",
                    ["#=qEL8VT0TS5ckDIsNZTvh3zw=="] = "#=qXr0sB9cBkDl6UFeabEw0NA==",
                    ["#=q1OTEsEl91bUqUDbvkZxS2W65x5DBnhJg6U2iKT6Mv8A="] = "#=qoNY8Tv82$6UCl2Vu9R_UnISSmmZVsHvW4AyI02441nw=",
                    ["#=qWi2OhrVnNvQqy1WqLBZh7zpregvm3THlQl4kS5r2WrA="] = "#=qqB_9Li6qiQGdILfKK8jpX8zC6Idu0avJw_EeOvg_d10=",
                    ["#=qt5ouyJcdQjv91qgSJ9MQhHzQ7ifvu2CJ6Bw6ySajKDI="] = "#=q7CnQJbYhlg_lnh2heTjg$gtU7JhEqP$G7kzmeog$yfo=",
                    ["#=qrykaQ4fnB5KqHbFYJuPc$akHutYvfelQjpodKxYeLvQ="] = "#=qEX$wBIX8BFOw7$PRWMa5LbNRW35hzSIPJkCTNteOLKk=",
                    ["#=qsLZXYNDe6JFj_8qaypi5dzo_vOFyLMNjuqVpKVzuU7PtsF92eBq55Vtk0FDJJtSr"] = "#=qVszN_4ekM6G21tPDKlgSPd8F1bq7ZNOOXhJ7ufjk5dbh3rpkvNKgVkTg3sY6n_jv"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qslHI69O0AAH0YOVSpRbOpA=="] = "#=qqmHw1X21Rwf0ex8DrK$7gg==",
                    ["#=qL6Nuwwwh6jps_vF3StZHFncL6tiUOXmPC3UOA$OFgIM="] = "#=qk8RbJDjZ5X6DLICCvJSJBAYue$7aCx3rpc0wca$Zvuk=",
                    ["#=q$6$juZsxr42R6wRgfEvPGJYtn2d$kWUklLsiWD0GKP_zI6tLEAVqgqvOqvTLdEoa"] = "#=q1tHPXTaQj_DsA2B$etviiC_rMbMfKOcTMaK_y$Bs$X07TVfEEiIm4xcp8s_nHNZQ",
                    ["#=q4nlDVsrTq3gfrwSU3cOeA2M81kuZbUBEVjkQ28jR6m5bvz4pTmP9QgcAjSu$xzuK"] = "#=qXK7opsxPxre9z_WmA$bug7e3La7mpi_ky3rHiLRcIpTTM9V7nK3ZT_51FiLn9QZq",
                    ["#=qr9vddWRxcPFEJqhKI0anrOZ90d_qchdlwo9TvMVnDnU="] = "#=qgYzn9EXN7pa1PZZxVZmpknHujM39VjKXF3rYC_FiMWE=",
                    ["#=q$1wKHnlKWd1vC$9nMbpt$iOyBvc3_6cKJpVXZ8c7Fa4="] = "#=qpLBAUFYhvhWFqchD_oEaMyjaV$xMwsrhSX0_T6IXd3o=",
                    ["#=qg2JZYegnq_uVuG9XB1ThekCZ3EiyOclwFSF0aRN7ePQ="] = "#=qQOS4h8FXspfxsynFQpQIwZB2MQHv7UOXFUH7exVvfQo="
                }
            },
            ["#=qj9QE1Tcl8tpezf5F61l2rg=="] = new TypeMapping()
            {
                typeName = "#=qfnxOj9Hwg0r6PqkFq3k0cg==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qIN6n1VmEwmmZ6RjRZinu6Q=="] = "#=qis_MBetm_Xa0m2mmgWWLRg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    [".ctor"] = ".ctor",
                    ["#=qMu2MaMWtR8SBMkdzvOI0LQ=="] = "#=qAJrkkBZXnStFUDVw$YxEsA=="
                }
            },
            ["#=qjb5Ljxc0Pc8gW93GS_EmMC0dA9W8KTT4xSXOazGwL9xupqxCtInPhwXcEOELzqPu"] = new TypeMapping()
            {
                typeName = "#=qyg1hBv52SlRwoZnMjPWJzmJxJdhYQR5M7Oke3dJd7ZMVswOWJcei8Z10Q0llT2vz",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qWYL9HtmxWG8xLB3NLFcwAw=="] = "#=qW7llFrW7n56pI3K7tjDxug==",
                    ["#=qc3cpODWlxju1eMjVZh66wA=="] = "#=qIyu9DflKTHXvhk3gAt4iVw==",
                    ["#=qrMb8BtSyUZ$YzqB2RX3dPg=="] = "#=qhML8fx36az0xIYhrDNGOJQ==",
                    ["#=q_Jc$tkZh7aBU7lzd7Yj6og=="] = "#=qsfUHZQ7Uo8znpIAk8HMpWw==",
                    ["#=q4yw0w2l$BFc9uZV3odRN8w=="] = "#=qban_rVhOnEnU0zP5FGbSMw==",
                    ["#=qI0odQYHbEfBUHTB_JpAF3g=="] = "#=q8sE$sA02IYGOv7qH_Zgptg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qqUmNo$37urnEQFFO1UPAjAabOZRq052vPBxTU_7zdkQ="] = "#=qAPzPkU5wrr5Kef9_pFAJ3ANzr2gZdaTXZF_R2fAsk3k=",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w=="
                }
            },
            ["#=qjb5Ljxc0Pc8gW93GS_EmMEX$Jit$fDEpOA_lpw__fyM="] = new TypeMapping()
            {
                typeName = "#=qU68fA6Fzg997DZagno2LkHhq0ncwrnkaHwXcy_w0FWs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qo3t_UFTb6mf5d399ZUK8R6mEivQzVjZSMAGyde0sR_4="] = "#=qe52bKHiycFjMVLHJML2qFBVpkU7Dk2XKNprjT$knSlc="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qjCNHF3S7LYJlaixkuhtdF9Z$gMnBtKgOCKI69KBsBgo="] = new TypeMapping()
            {
                typeName = "#=qFdhZ74vrSAYLwgkB8r3yPRGxpArqdZF3xxkcE1X1$XE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qJdfUDndm16tQ97LF6Pmukw=="] = new TypeMapping()
            {
                typeName = "#=qURwjnhSLId_IbUvLLTfUSA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qs$QkBvEhIqSR1bh$0xGrVw=="] = "#=qC0oHIlhlVai5rSvcAFcmlQ==",
                    ["#=qva5vSKNtqdYC309FMfGh4A=="] = "#=qyT9rhN13S7m8eOwd677_yQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qIQe0utYfiGz9z_rKnd1VKg=="] = "#=q_$TKO8dmkNNGPyAPngMc4A==",
                    ["#=qZfigkI__Af1OGpGnQ6c3VA=="] = "#=qeN$a6xFR_ZTG627kblhWRQ==",
                    ["#=qp2$OKo1hc4Ks9zSQhLJJdQ=="] = "#=qm7Rh9vENJdl9Eecyg6CiEg=="
                }
            },
            ["#=qjfnbF9hECjJVuppsfSqyW$qVOgCgFUhe0XOoht8wZnM="] = new TypeMapping()
            {
                typeName = "#=qlYURbI7ZkDOgFmYksZ2kWQvNew1hGsLrwkWfJt30DcQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q4s_18XIgoyCCLb1nTaschQ=="] = "#=q9pAa0PdtBgQqX8_T_mk5gQ==",
                    ["#=q3CVh1ZGFhwQImzJctmvxWQ=="] = "#=qJWbs_fQgKFsu9r9$D8w7Hw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["op_Implicit"] = "op_Implicit",
                    ["Dispose"] = "Dispose"
                }
            },
            ["#=qjIvdTBihOdcfDOF05hcL0uH4M5hi1F8VpZ15UV3NClPO4$XHmerzqv47QtHEUbTV"] = new TypeMapping()
            {
                typeName = "#=qfHCpINVluc4ExN5NhaBxyArnfFqXRTq6z4C8OWUCDVHbmuIsTy3DhOxg6AvR5pqf",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qktLFgqkZW1REn6ebTr5Zog=="] = "#=q8MW$ylp0XVeSUSgrD4Mb_Q==",
                    ["#=qzgu3O9WbfqVPOIks_W9lubuYcxLV$GF$xFcXB0DhIHU="] = "#=q9EmkE7iFFVVwckQkhEngb0ZrBDNc3IA79XKMsS0wQzg=",
                    ["#=qKlssQorz4xh7uoL0CYgbFQ=="] = "#=qHCJzfUe6b_MSal4$DJ1Z$g==",
                    ["#=qZ4iDddC2KzjZmWQSoVBkaQ=="] = "#=qMGPa_73L320EaY2pGiN04A==",
                    ["#=qiNowPJfljrn0xa0SvZuECQ=="] = "#=q2qVS5hvBAyRaBMxICvKf2w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qFT_8o17Kmjn_nzD6XqRl8Bc_s70OL$N3hLnPWRtSAuk="] = "#=qwiCmgSnsWADPF308_kOMVm22P0Qzb_KCroJA23i_4UA=",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qY7Now4fnMVXHsukYfinv4hUo2iHHLK81hU3tc7Qsz0k="] = "#=qfq3r0sW1xo88V3hP14aBwGvssaDCy$O1ifwIDMkJjW8=",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA=="
                }
            },
            ["#=qJKp047zYxjJW3jBufnVWiMYwwMBsNSShcG2wRL2nrnFPP9Hzn8nBpXDZcGIlVTl7"] = new TypeMapping()
            {
                typeName = "#=qDCVDQf01UuskMUht1ThZYDvzR7pWj1LyetsK6RsmHYgdC0EeH5YCVDE6s0OU9g_u",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qI7Agf5OIijmrbOrRPAayKg=="] = "#=qEO2JbBsuZAaRT8KUr_$69g=="
                }
            },
            ["#=qjKUl4SL4SR82r9gwhNA_OOkCODquklogqqU4BPXkPKU="] = new TypeMapping()
            {
                typeName = "#=qG2w$10ZrmZwE$Hri0wTtkPAbcBDnokD8pwA7kFjt6kM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvZ28Mdc1piO1oiRmjSR4Pg=="] = "#=qFLiAR0QcIb0uYOCFJWvZ$Q==",
                    ["#=q1K9Eojq1UNflvzEVg8JAnw=="] = "#=qjBDFcHkErNXUzGnzK38juw==",
                    ["#=q8rCqR0egB00SPDZp0fOQsw=="] = "#=qMbnVnZ_LJL$Y7MgVtosJ0w==",
                    ["#=qNty41OmQNhk1V1w9yEFiuQ=="] = "#=qk7mc3TCTXZ86oB7brAroUQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qkL0gjd9QPUcxSbVyE6_z1A=="] = "#=qtcxKtN2CGWiRqBVWon7K9w==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qhOvhnAv06GTt_DdEysPDXA=="] = "#=qHK7bZBoh5lZhgASLnn_jbA=="
                }
            },
            ["#=qJnHc6qNgn49brPqtcdyKbM2YtcXEEwHwMt6XeHm2i$I="] = new TypeMapping()
            {
                typeName = "#=qCjqO$frUC5TlD7w4Mj6tV3oCxVhanPIuK1cTZQ9ixsk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qBlHEVIk$KX9SdGGHcZ5vpVaysZrAZ_5CEICNdOjuixw="] = "#=qQM_Q7n6iFMgMeSiMQISRg3Kg5zQMrnZzhLaitcy9Gqc=",
                    ["#=qbDZozw5ydxaz2NgITcbi5xysXx72Bxv5kEnW_mkoS9g="] = "#=qBExfI8EsTZDpLmTM9fRR3kwR6VbXlXV78ywVcnp2ZEc=",
                    ["#=qNOa7uOKVObKwBNEX6x4tUC8HRaEOq7vD8i1YvVo28iM="] = "#=qyBRpvqCbWKRm2ZJCHlMoePJuYa8qmkFYFIoJ0aSLa7Q=",
                    ["#=qtRa7fmrWkgDbEXoq09Nfb4M1N2PHKG3I_3alSUW13dU="] = "#=qAyvw2tzmgj8dIYrhC4oEKEgEQZgzsmYHV8wdzg3DqJs=",
                    ["#=qYSI0$Q9TjtEXEnCdDTkM0yEvT3Pvc1EabI65qWqSIVo="] = "#=qYN3nCdXZYDouPJUKgun4hf5tTIrNQwuviIHmhXIMMl0=",
                    ["#=qXSNxJ6wwRIFAUiCzyj5qhafPvJUdS8K1tbhCZ4Kj_Y4="] = "#=q3wP05CyfosxFHN$6j_OsrYkqiiWDZc5dUrdTvS4NQ6c=",
                    ["#=qZpzFrMZ0241SZ_MYAIWzD0w7tDDTAFIW2rdqT3UiWLc="] = "#=quuKnQkZYEghDeG2GeVXPRDlWrrr8dFbV1TMYQC$SJIA=",
                    ["#=qyViaV3mqLG4FJfn6uyYXQQ=="] = "#=qGYkEEFu0$vLBZpSKALy6fg==",
                    ["#=qWmsPFvgc0p6zw_k6Gj3Ohg=="] = "#=qB_r2k1jdM64zDBKLQSZswA==",
                    ["#=q2UP_6PZQh$mPyqwyGxNfxg=="] = "#=qT_1fmiBVtDbKfaqSXezDKA==",
                    ["#=qbbRAjFxV3X9tFSuibcz6_g=="] = "#=q$cw4NFGQji2SinCfow6zcA==",
                    ["#=quXJFz3DHIJyjbQEJ4ybg_A=="] = "#=qB_36jlr$qtSqqNH70cpRFQ==",
                    ["#=qOb8xSCKbo2GBS_$RCbrwPqtyPJauSToAk61t9I2ggPs="] = "#=qRg0hbrp5XWMWQKNOcdIv_75M_jxhdTVytYHVWYaGnts=",
                    ["#=qdoYQ8yAcK1aqcmNAjtEvmA=="] = "#=qbb$le8i5iLOKrGNZEWjbMA==",
                    ["#=qmdFBYlZATrZKUZrAwaVaGw=="] = "#=qlNG8ZST3KPbTb6$L_RLSwQ==",
                    ["#=qcLydS0PSx3o6sQmdZQn1mg=="] = "#=qlDA1F$Wt0yO$iV7X5MbA5w==",
                    ["#=qbLZaB7$QKdz5MubiQDWDag=="] = "#=qQvTrH4bIx12PqLb6wdBI8A==",
                    ["#=q$n2F5nzhbV4BKLUe8DggKrfNAsjIAficbjY8279m59o="] = "#=qRlCvVzX7QsQIXYIuKm198PYmQvSnoffwT_sYeyLvyyc=",
                    ["#=qMzwZLKptOjH2mEbh_1ORTw=="] = "#=qiyFr0oNzyNG0TFaXJ7hniQ==",
                    ["#=qtkSWMfvTdqCKwlKdFPcPSA=="] = "#=qVnw9GqmP0luvyuyDYV56ww==",
                    ["#=qrCc3BSFFI5UIr2yhGZm67g=="] = "#=qwLh7Wa9ajdi5nUZ2fxwrxw==",
                    ["#=qbGhq1mR7bsNmcFc52mjLPg=="] = "#=qyeOq5oHltFUUkkFt9MuNUw==",
                    ["#=qq5H3QYbFOkWWlynAph0oVg=="] = "#=qrz8DCWRD$VozHX_1SaO99A==",
                    ["#=qZwx2GMGtc8Rd_8ORY7VTBJsAzaBryoz8VW6hHB8WJlk="] = "#=qrXadWylTMxGVzksrv1P1dhjWGr0OeBmXhdpwIAWEmIQ=",
                    ["#=qW03EpUH9iFMLedy6nr5RdCRPAL9Q60yB_ij4efZK_CE="] = "#=q$M$ecuw54QwGH$iUg_MKRK4y6ekTN2ZL14vxOF4tJxw=",
                    ["#=qrN$KH2OhnOw2LLnBk3pv4w=="] = "#=qVKEE8$pqfUzt9BH0kdgDfw==",
                    ["#=qPodC_ZWchdd8$WNJrNPMK5dtyIvg1hD8vpJtxcNVLZY="] = "#=quyE_YLoHWqSOA03e4HTjEplluMqXLVXmVihS99sqcgY=",
                    ["#=q4wNks32A8Hdw0ZPI7MITtA=="] = "#=qPjmsSG1zc2DRrkuMH$ehmA==",
                    ["#=qlnChOdp3w7ir8bfRWLNvd0ZevlYg36M8bSvTmj2$HDc="] = "#=qiT7Zk7mh7UYCeA75gRRwAPNz3_KqwG5ACd7Sbkk8Fhg=",
                    ["#=qvuZLQSREfAenB6qW$qqCXcV5eHWJDniTHUVwhV2kKZ8="] = "#=qZNB3uBwXlrJY2N2ydBOr_o1Bs6MekmHJp685VsWPt28=",
                    ["#=qeeWaYO7SyVo$38Gcg_WH6$GpixGJb3t$RMuX4D2qGng="] = "#=qGuqzN0PD1n5_nGdQriM7MoKlt1A7hiOdAd_82arkktc=",
                    ["#=qC0mDqhIERaq7ao40d3hKZA=="] = "#=qJAjdSwt6EhllP6XncRS$5g==",
                    ["#=qSdTlcgHamIJ73zK39YnZEg=="] = "#=qFZlQTLxE2GVIM20iFr00IA==",
                    ["#=qTk7n_Om_I_0XFSHcjNfngA=="] = "#=ql8_eWE26eztVnufYzY9BaQ==",
                    ["#=qGcNpldga3xY0ooEC5Zg6wQ=="] = "#=q2C5J_ED5VoxamlQnR5ww4A==",
                    ["#=q6B3E0GIyGmutRGLMQGzyJA=="] = "#=qTN8zU0CViga3uVETblVEYw==",
                    ["#=qh3FiRc3yRq3VoLtVIXAFUQ=="] = "#=qd4pNsLKxqK5GelJkfxNxaQ==",
                    ["#=qiU_Tr$O0_GapuYYuLDUzHXby3Oouvsncw8SaCBbDtPs="] = "#=qAkeeb15rh6t7G1fvZgLZGB348E_KID0k4ffq3S1P7Ak=",
                    ["#=qP4zzk9o6KH8m7AI4TSuH_g=="] = "#=qPKb5th8IphOg5C9xICRORA==",
                    ["#=qS3g010mb7pixzJzmBNH33w=="] = "#=qfM9jWTPerzDpCB0jtbtCdA==",
                    ["#=qpMlGfDxFbnXXYOQKn_a7BpJZUhVDok35stQWNHaUpjw="] = "#=q4_N4Xj29U3j$vaCZhYfV5a5wLPHLiDdgfJWziwrpN_I=",
                    ["#=qCw16K_0W2rY7DM$WpFpo9w=="] = "#=qd3STuNGlRKz2sWrZ9LV3MQ==",
                    ["#=qSbEGnqFc94Q1xyV8q891Ow=="] = "#=qyFTXdHaWqwffI5QBZCffDg==",
                    ["#=qB3wr7dv_9sUfIhJWLAUu1g=="] = "#=qaycD$sN99c5zxzZeCzye1g==",
                    ["#=qS6k4QJ4HShC9CQBMA1y3AQ=="] = "#=qS4$qdXtcoIA_KeBTp$Je8w==",
                    ["#=qdz6zhitSPNY8CHrIb5BCxg=="] = "#=qsMfGpfUIz0dlEcup0P4g7A==",
                    ["#=qOX1WDUtP_33HDw$9vxcxjCuwyxNt4DD6d8YUDyblhgw="] = "#=qBPV3jKFeiwnMruQ9AyHnYiJzpW$LWPNT_S2A5w71AR0=",
                    ["#=qP3WJeHRRQoEYRarYQ28WaQ=="] = "#=qZnFU7bHcbLr8r6PRwkEyJg==",
                    ["#=qQIyxd84ajvDcM9prVnBMRg=="] = "#=qjRcH1BNIS7diZDgrpXJoaQ==",
                    ["#=q6plIzHNbTbeFgg2r3skdAw=="] = "#=qSasOAsBrbykAFke0DL2f8Q==",
                    ["#=qnSb_fZv5mvGCL8VczMEDvA=="] = "#=q3d$Anqe8WWo2KIA3RDQY2g==",
                    ["#=qllMEj3gtm3YSpBLsjNOnfQ=="] = "#=qXIhLFjtwK9Z1PBU2$N5K8Q==",
                    ["#=qAxN2v0BsstMf96T2OCWtDA=="] = "#=q_fZrnj4Y9Q41NcfYckBDMg==",
                    ["#=q8ZoBNPQVfZZulVwG8htWpcBlf10wC7kwLscEHVtf7h4="] = "#=qWeMYirw162m8_RtweLbFHh2Z2BUNklfbWBAqlsUgSXQ=",
                    ["#=qcqNnGvFHhvSK1mMJmPIsKg=="] = "#=qn7CtdMygOKpN_5axOvJQzg==",
                    ["#=qwO6OyuVX8Zu27JuHfiEZKw=="] = "#=qiGVSabFrf_HEDHEIJ$SZUg==",
                    ["#=qFJwTpvBH92Imd3kxjTLjiw=="] = "#=qxzQkGsnjcM$6UJT$Rcr_Tw==",
                    ["#=qr7PrzQSjJ6WSeb7KpUDljw=="] = "#=qJbfkusxkCvirK3B69L7hfw==",
                    ["#=qMNRbKuEC$43an_5BbcmVCw=="] = "#=qDAv9Bk9e3cKtA4J4hVlEYQ==",
                    ["#=qnSindAP8PFDOubU62I1BrQ=="] = "#=qcmIDbOdH2xo2am$kDbFOpg==",
                    ["#=qJcQhHg1OmbSlsPj19LB9Hw=="] = "#=q0SHdUkdQHYZ6QxSo6ZQjXQ==",
                    ["#=qzp069DTmRRZNqPhZvpxAuA=="] = "#=qgK1VOygEnHu_QWbgmH9LEQ==",
                    ["#=qeJm7YCwWLt_2spZlGKaXx9MgstCP_0y6_GWRRsQK1ZY="] = "#=qlr5XZzmXTdzViY$FYdv9llFl5DVU4wVLFp2tkXp8V$c=",
                    ["#=qwHLhQSE2zgzg_yDVU5JXqg=="] = "#=qkvpO_CPSiAbrTNpFgjxdZQ==",
                    ["#=q8SmrJT_sw$I02hfwpbYoxA=="] = "#=qYM$OWTXxuWVOH0zUM0wg_g==",
                    ["#=qXbqPP32iSxZhH2eNd79eEk6CD4QZmXzKcRq9CRHb2vs="] = "#=qRDN_KiOHwZ2LtrJF8VpweVvpicx6DJtjFRn5sAOFUPI=",
                    ["#=qhxiOPC47SMshk7M1YRgFeg=="] = "#=qika2ZYmPSmYs8KlGElU66g==",
                    ["#=qe2GKwZvPIL8n2Zgm74iAaQuJn$auwy7Yz4sBFOpluMI="] = "#=qevg0s3GeAn_hMZclnviyjW05JEK7vEEpfaIYwyKFLUY=",
                    ["#=qvpFqQC5ZD3lJp7_ubE1k2w=="] = "#=qnN4nJ78meLuUytqGNID4mQ==",
                    ["#=qSGUCBxVp3Dt7X4RLxBWJcxe7KP5cpzfu$YxkSWwr79c="] = "#=qdZeLNl468_W8pBdXVGY8lxI1ewR19QCUF2Gfd3wxR8c=",
                    ["#=q_6NyPhKc5c_sAtzoO14Yj1c4EBlOhfIGHWnAHNagolw="] = "#=qH5A0dSdz8JduMLlc9MMJsPhYJphB_q4cXehcZKMSCCo=",
                    ["#=q5ulMMYLh95V3s2p157AUnQ=="] = "#=qsRtBHwmJ1Mvr_LsOGY$niw==",
                    ["#=qHzCcSkRr7FZ2oYUXG0vXwQ=="] = "#=qLZ1BpPc_BxXKGieiVhsXgw==",
                    ["#=q5f3RrsDjl01DGORbOKUieaD5CM9uROBCZtkEVBdi0x4="] = "#=qqgY3Xhez997BHoNfOKct2pUKtHFoMTsBIW0sz1yViIo=",
                    ["#=q1mJuGOOIe7CdWVThNKFpqQ=="] = "#=qwgUAU82gHUJGuSqKeXmw5A==",
                    ["#=qH$Adm$1heJXZ$s1nzaHlcnAjCodlJrfc4K5vQanhlak="] = "#=qg69j$OFfNdIZBRr2Ig3Mzsk_lx2mZG$DHNxshG$qrTs=",
                    ["#=qFyr$Qm0k_8y32pVUcjdVNQ=="] = "#=q1mzNbqyBhXWk9CusOxCW6Q==",
                    ["#=qEqSjWFvao6i5BPYaUxU_LA=="] = "#=q1t1zWxyvym0ktOuonWt7oA==",
                    ["#=q2C1_g3meZauvPjcdklIrUEdb46Dc_zbPwDrvq4_MHww="] = "#=qXQPuBN4VwM8pOWRaGwZjyjcBUCJnxbaTN9ALbi_R4gE=",
                    ["#=q_2kxeSDVJIwasrVbHesqSM0f8HCKYmztgAZFA0rQogk="] = "#=qWm28Mot4JmmE4GhyO3PbjxXDl$NCA2sSx1_JzL1QZTE=",
                    ["#=qCgCG4bZJqpRXMJK00vtNeA=="] = "#=qYSdfdaiJKJz87Ob$NMjmlA==",
                    ["#=q7XPMO3LDeQlWm61aCvfsKg=="] = "#=qC7Xy2noAeluVj7OcJ$s00g==",
                    ["#=q0b1Ckvb2cdtqB6_yQbZbNQ=="] = "#=qWwYlGnyKlsNo6ZilnwzVMg==",
                    ["#=qkv9gKG5JOI6ndExCUlo0rw=="] = "#=qYAOj98bWotQow1sZzGr6Wg==",
                    ["#=qPVHCwh2WykX5LX7RnILVUQ=="] = "#=qMuc4jlDCW4WimPwsfzyh3Q==",
                    ["#=qV9VFQvhz$YvMz3nlmLfKuw=="] = "#=qaRvRC4kNhEqr54et1OaEOA==",
                    ["#=qlcrwdCoUuQbSqed1_1BQGQ=="] = "#=q10Z26xDwSC2C34CP_VQ81w==",
                    ["#=qt9TlutT3td2HOOOUVYU8pg=="] = "#=qQCBX85pMhjmSioe5KAf8Vg==",
                    ["#=qxsX2_I5KFGc15SGi1g7Exz9e69fiB7Hchtn6AjRIlzA="] = "#=qMgEm8fEUBbrIU9rP8piPkyGtsTG_QkcUs37F05Gg1fU=",
                    ["#=q082TX3a6HilZuwj278mwnZQehNCp$xeWx_pb2q0Wuts="] = "#=qY5kkmrehLkp2uwRrLi9boJvFlejMkYFjZNHJJYxWurg=",
                    ["#=q9GFprAMRugmn5CchLZzkOU1CjwYb0FJDDAa4EUu672g="] = "#=qLlz9ktdoY_2TdCpTCyBk0UIGe$m71SxT3W6moeb2ueo=",
                    ["#=qXLEqXceavJxfYm8bBCry6w=="] = "#=qhSebZhzIjw1SswnmeKbNUA==",
                    ["#=q3A4Q$aoi60rbE3HvlxvHbQ=="] = "#=qpwpOKPpCI1vTMIrnbAWgFw==",
                    ["#=q51G64VhlPWSx$pWud02Cw$Oz9Tv0J3PnTlBgmNfiyt0="] = "#=qeNJ6IJ2MtENJKxY7Daw2Ok4YW692OIh4fTZWTlSyDK8=",
                    ["#=qoKsTTcPceDzj_Aa7kVMT4Q=="] = "#=qCNCSMAXGyal92xpMUnHVUg==",
                    ["#=qp$EIsFwoaMCk8k3dusDQ2w=="] = "#=qf2uX$HbHTwYmYpIU5jtOjw==",
                    ["#=qE$jO615rrGWfB6Z1hk7Xv86qqsz9mzkWPagj8F69oiM="] = "#=qZEEv2HFFAaIKV8nejMpb1oiZr5Hi3Pqe$aF_iGWNV0Y=",
                    ["#=qN0YdgxE1Q2dTKkVs$zHRC2xrEg3VCsewU2lvvjJG6M4="] = "#=qGNLfkarQhdxtsnNB8DEaQVShhlKZa2bss$BqiOql2Lo=",
                    ["#=q7iN_wY3MnNJ5RgjTq2_THZyHA0MIqQbApuOVKjrI8dQ="] = "#=qRbIPWHPlcnDNqB9Ax353WLzxi$aI1MxME4e07su2W90=",
                    ["#=qa9NaO0PtO9s1MLgqmdQGRg=="] = "#=qm6Uk9IxLu5GrT$2p0wisVg==",
                    ["#=qtgb$dSFpvou3onYsyne4VA=="] = "#=qUhkQcQaTdFbs6h5Y$WDCrQ==",
                    ["#=qA1UQrp16GAcEXTgDTL8OyQ=="] = "#=qO2LSM6gT7ar2vU4aOSAAzQ==",
                    ["#=qWV_10pGCcDKHbMsBcexZ5A=="] = "#=qrC2THVcAByvq$XIMv0n_8w==",
                    ["#=qmiwT4s4q6uKeAyQCDMrLuSNCxxxAMSZvaHWSfBFYsEQ="] = "#=qFw6DC5m2$JpNBCjohVluy2DzIiBogFh6VDXkQzsMnqA=",
                    ["#=qjrr$H53LJoa05H6ioIs1Fwb1iaq4tH$P7txTiA$7pTQ="] = "#=qlM7nQYzAZRSrO0DZJyr0F0WO8uD$8tC_USNURNAAn54=",
                    ["#=qZmzn1R0Ti_3MT8DGUk6ZuA=="] = "#=qfy7u0CzhKg_Ip4HWs2ubqg==",
                    ["#=qgnNj5Nf750USNp7i8Ih1Sw=="] = "#=qdYTv$wtW$N3FmM2$DgD4Rw==",
                    ["#=q_8vP65NaHunXoYaFUdnOeFLiG4PwPY1uWgDKgByTnfA="] = "#=qql2OSwItlzmTncVp5fHq6yfnszXZrPhMavGw1iQ623M="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qi3T9H6MsQKuyAEL3D1al9bd9lJMzkp_bsILxjyik5Cg="] = "#=qZxBegj8tbcwQCsUlau$jBWgIW9Y4XT0DGBJdCUFJiS4=",
                    ["#=qNo6iFhNA0FZoM8XDHHWuvg=="] = "#=qDPM11wx6vdxf2KyIMFjSyw==",
                    ["#=qRe3G7PJYGu28aO3a_0FFUw=="] = "#=qGlTLChvBvT27rJgnGM4bPQ==",
                    ["#=qm0jKIW4_Ojwhm3snuHXks1Fj8q4RIGZfYEwWHfqCn8g="] = "#=q_KgyCSHBHr0581yczcHFxKXNu5g0TeOPKcNmlg64Vag=",
                    ["#=qyF1VCGrRR3bLzFeYaaK3g3NGwYkmohL4TA1CI9ILIIg="] = "#=qpZINKEWsbKjfVPAixwqHkXs_V6LIa645r3e_YdMtx9A=",
                    ["#=qjWcyLGUam748dQty$v3NNmZSZiWuVgOiAQwYQFcWYhk="] = "#=q1jBIqX2s7w2B2yeSpU6Qwakxz6524nHbrT5ONmCSzxI=",
                    ["#=qVosR9VXbR5jjHn6JApoW6vEjpbCZBza4DJV1l34JpQI="] = "#=qDGc_xL5J322IihlLcAVJBM43FofpLVcE65itFi6hHIA=",
                    ["#=qFEACM7YBX4V_8Vo_VEN6BfWsPTp28inNyT2HMmwQ2iU="] = "#=qKUK1fT4L65G6kndNDHhl2mTdZoexj3Go5xOtQbJNIO0="
                }
            },
            ["#=qjo849yRG3aaCEOUy83YnewtG2EpvAXCQrrFcotE_H4maY4GYnU1WkR5WlZ_fKoRd"] = new TypeMapping()
            {
                typeName = "#=qoQD78rkpHOvEoYDnOEhKzO_K7RTPnqQRYh8p4uNp0AMJcU5P_MsytJHVm7vqsTXR",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qjpigy0kwz2un5sP1rJ3$jDdbSThH9NpBNNaSqW99skw="] = new TypeMapping()
            {
                typeName = "#=qAyyQ_F__9_lArItlLh9aCg4FrXeeGS9NFPN9dbTmFdQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qeUo2XOeiDQhJ_yrCUpaCDA=="] = "#=qLEqoam2pT5zZIUH3QL4X$A==",
                    ["#=qfEF4kXQiJkycl6$$3WADyQ=="] = "#=qU9oTHrnP5j4Jvetqh4lyZQ==",
                    ["#=qbkneAtUtgEn9UMQCuUFdSg=="] = "#=qbY2xJe91J9bMaWNtSKE0Cw==",
                    ["#=qCUqwPt0ArEjBI$W4iqkbNQ=="] = "#=qmQyOLI3ckrPQYC$y01rUhA==",
                    ["#=qXL$SmVo6V1WxhQ7hHuYcvw=="] = "#=qxlc1IGERz6izjs$rJ3R1tw==",
                    ["#=qLDd29TKhIHLCgxIvKYJqTw=="] = "#=qqDnjJ5Rl8v3luC8uylwqJg==",
                    ["#=qCeNYQTK5lUzkldIflLYPXg=="] = "#=qM16YmHxNeb8_RxAPmeqbAA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q1dOahQtNFQ8gXWfI7zQfvBYyTRBTJrdUhFj9ejUkals="] = "#=qkot685i2DeqPWT4pKJ89rKR4k9tMO4fpBdUGxbldrO8="
                }
            },
            ["#=qJQ0Sh9KXL$1YPVIj7Y3K3TRkyl3GZ4SgCTTKK33F05o="] = new TypeMapping()
            {
                typeName = "#=qeEBoXrTPDCyw3BYRYTq4Gov5oo$iyBQ1NCMxxYug2A4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6SoEnIIYjVzC4VL65h4u5A=="] = "#=qzw2$6xJokgkJw_zWpuX7cw=="
                }
            },
            ["#=qjtkaL9XOMfxT9LJNuytDG$iEf0irrJwwOnVcUGQFyBI="] = new TypeMapping()
            {
                typeName = "#=qXPw9sk78xrUlx_ZnOmYK9p76f5GH9Dx5I0LW2AiYoLk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qLb_fWO3w9EhYVzvc10rICw=="] = "#=qMJi4i896SDyvHVZzENKnpw==",
                    ["#=qvJe7aLHdH1eCJc_9OS6qVQ=="] = "#=qFt2qTg6e_UjhADps1rFRRg==",
                    ["#=qck4$cy7ea5iBg0CB6bUi_Q=="] = "#=qgGRhhEMZJjZsD0dHW2ARNA==",
                    ["#=qOzp_ukgLY5FMOneJ3rzZIg=="] = "#=qxkBbO6oFAOnCbNeruoO5VQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qjTLaLAk14n_Ifeqdry_DxbGQ8H4HBz5aNSv8wEUE_0BDOD6I9F1eo1m7B8ejmxqW"] = new TypeMapping()
            {
                typeName = "#=qypnS5yZuWBcurKUQiMNU0UfjXFI4lOa14LyYvf1yhZLJrP2jB3ELZSuJMxzYt6Nr",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qtd$vkkVy7f03p3Tg8YbKDRNE0pfmo_7_SQrOBfYTP3A="] = "#=qcaSom7Vhfaj60Ip3KamE4YuGgm1hF8ggTemI4nNRAMw=",
                    ["#=qY7Wa5673nqax_3BDwXQZOQ=="] = "#=qxUVjX31bxK__ahprTZ19Lg==",
                    ["#=qqEI_SnlXYIfVHrI_bvuvvw=="] = "#=qKonUy$vpUsU5lEh2n7F9rw==",
                    ["#=qrS3JUuzX89VlWU9a653EitFFX6u6dVW$YHAZcxNU7SY="] = "#=qUgmX9SBVPVN2Urvlg1fmYovwcw5485RQLcHkx$boozs=",
                    ["#=q2s3$RV1OL8zbbyPyhtwevQ=="] = "#=q452nAfw6vy_nhBxi7jGMxw==",
                    ["#=qkgB6tkD6$3vmOfM9fD$RWsVZe$Wu_Xxv8gfiM_Bkb7o="] = "#=qwIj02zMdQIOc1WJg8xyicVJ_rIZSw30mI9AicKQZaKc=",
                    ["#=qN4BHqcuU4T7Frw36AUKFzA=="] = "#=qdPdcAEXjFzo7PmUAMOlDBA==",
                    ["#=qU27ij5fQijngKkZdv9E_7D58TGVeFAGDr9h2DFr7J_6BiVJm$CbACl8fuZHHximI"] = "#=qVszN_4ekM6G21tPDKlgSPd8F1bq7ZNOOXhJ7ufjk5dbiNjNwz04CmtNZhIMxQoFw",
                    ["#=qlzxzY9rHkKxTJOrjFExoC3rCsUjKzXHtyyX$g_m7qaEXAFNz7zKazZidYwjSZzuZ"] = "#=qzyp7iYLhBpLt$_dsnFug5Z8VjIXtjowaG12jJjqaZWJMTPV3wzzSveEn3BDZOYwv",
                    ["#=qFlENpslbMeN3Q1O9AbJ0PkVE6PyGlKVd7EkjJewVZ1lyvK1N__ysdCtvz_nmOmp6"] = "#=qt6Y0y1hkPutBBIFH4yVjD6xRltNI3MCvDMNWlDJvDwGRxxxn1IaOIEt5qTpgj0HR"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qjOBxxUsRM_78xVrszdKETAR0omo1K1qVyJ9wS2uwC1o="] = "#=qlu8oEUzSBLgyfHo$20MdUz0NqSIRF$taqYhjZqvOfuo=",
                    ["#=qOV9Xk3CwtA0Mlrl6xq5wZfbeRYo2zHhfnehuPcSHojY="] = "#=q1uH2caz5aGcspLiOm1gb0ROATXBvNgIVOWnkqPGpA$g=",
                    ["#=qV_5anGnlSQt8t5BrToW49qOOIGL5Iae48JlZuzCi8gk="] = "#=qNRBAatnBySwElnanQDxjcQiaLr8Ow_ScrrCQjETSA9s=",
                    ["#=qtJUmLw6WGtIsvv$GvwL3QOdDYgnEJbN5uVu2f3s3fEE="] = "#=qslU6FC3jAuLyCbKtWdSmYykcLAhaOOhMgYI1diKcxhc=",
                    ["#=qE_WkOaGMV05_QxrS53$xEMJ4hbv5_WRLzXdpnba58_Y="] = "#=qugIuwfzpYy1xWM$MYIPNhYPbsfe0MhAvvlJ1ZQ_rBuc=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=qpOAqFWrUg96htq5fvc1_Ix1FeoFBy4FTxKR_9AJVLMI="] = "#=qfcLUtrvZDhC33xU5FbAog_i3Js0X5F$6zuhg6ERMEQA=",
                    ["#=qQGxEA77Et$B5N56t3SGhSXR7QAD2TWfRqmKw$a043JE="] = "#=qwwPtlAKIagqAtPbHKEq1ikqQ42x4cPf9Tm0A$XbHXPI=",
                    ["#=qYyknyvmXwIYLVqdwrJCQl$8kHfW_Fs0myrbj23Itj8s="] = "#=qdnV6rkcFFNWwQRfDE0O91V$lhXYOfqC7NuZp3TQHYOM="
                }
            },
            ["#=qjuBepJ4KD72P7Nab6YVMhv_jEwvj$PC9ZFBqs1Vndww="] = new TypeMapping()
            {
                typeName = "#=qZl4bhconeMsyKSEVSoFqkrkLxgUFX6kkrGgmKmN0VCQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qWbqnLU0yHudIgEalk3OcHw=="] = "#=qnSIgFBoT_J72HwtTIO5aQA=="
                }
            },
            ["#=qjv5jVyVZizltYIimVpYgodvm3GpbcBbeJySHEa4bqrMLjbVVpjpxETmzRUPE$omW"] = new TypeMapping()
            {
                typeName = "#=qrylfF2arFNr7fcp6fmSbuVr6SVrQQPS3RmnWWwc_0zF3JoXqxh3zAeIoICUrD44Y",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhLiIoAzjxTOQ1k5T7lPCdg=="] = "#=qsIi6_qKml32EMQw6FQOn5g==",
                    ["#=qDUpd5y_stp5TdrUVUONpPw=="] = "#=q4$JdPH5pNKJa0uvu2dZcDA==",
                    ["#=qnk7r2yoGSvwErD54sHpmpg=="] = "#=qVEBPu3OqsGBJT_IyTjk2LQ=="
                }
            },
            ["#=qK$OtwlFco3SSAvU6TD0PfXI81zA2wq_Vh91ze5ZKJeA="] = new TypeMapping()
            {
                typeName = "#=qC6j7JZePDEDZfW5ge49RDhgbcNSr83pjNxTSi279ER0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qv4I18UADSHZ3JO6_1dxJDw=="] = "#=qAArgWW0Anls$Wvr7CGE2lQ==",
                    ["#=qvSSuDAbF7QeFuF6CTj_GqQ=="] = "#=qAmo$jof0P0p6PXt_jOKTLw==",
                    ["#=qzKjft8AxN3SXebPL6aPyFw=="] = "#=q_yJQG6Fi3vPxl1yTMww6Hg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qVAZKTcRKpr06C9fWND43zw=="] = "#=qBOE83Ihxfi52CPq8Ua9Tgw==",
                    ["#=q$Fdw113wx5nTfQ9Xmbl3lA=="] = "#=qBDY$b638SNkpua1iNlQrbQ==",
                    ["#=q0XfaYRETiQY6sNyNcRfyXg=="] = "#=qUcMTxyX19NFCB4LKPTm5EA==",
                    ["#=qpf1xuOqNB9tR9YFIwsdrIg=="] = "#=qV3s0uKhv9fVqgShdlj6nYA==",
                    ["#=qwV1yfLypQUuljS8wbCK3ig=="] = "#=qS1HTNjhCKhh55oqEHAzlsg==",
                    ["#=qYIAkvwJJFbTqEcQcxb$dzQ=="] = "#=qBtmMKQO9qobk_ipElaR_hg==",
                    ["#=qT7KzWKb5DBRTWRQAKEaiYg=="] = "#=q1hqx$owScd5wQ3Cnpe0_3g==",
                    ["#=qgpaGKLzUTL$xUX2gXvNj4g=="] = "#=qnOT9gxss7dP2p9iQ0rDu$g=="
                }
            },
            ["#=qk_PTOViVJRnjNEOP96yIC4ylkGOjlzwXOeqKuYwrisU="] = new TypeMapping()
            {
                typeName = "#=q1wzGY$3tF7nBaN6SZDoHxydr2UaaBBuIyDxo8ZRxUZc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qKwaVSTtRLxMPCSf8n5eZQQ=="] = "#=qcC2Uu3$WXB38YexIyBL$Yg==",
                    ["#=qilj4HXqA1YLw9uJc4XLJuA=="] = "#=qA8WS$yYP$qsS5AdWuNLSmA==",
                    ["#=qJ1vLmVtftP3LeYIQIU78OQ=="] = "#=qAfKONnZvLhv_tMr8JyxnJw==",
                    ["#=qctRIagh7osAl_cpCagnFYXK9L0ezAjaAJsb$1ktVwuE="] = "#=qJ5mJMwR4qVvsqb1I6Yq54a3uSLpg$7SR6$U24o5rfd8=",
                    ["#=qKD9rlWPwrG9uQMBZqFVLBQ=="] = "#=q9qRGHkLGZcRUtsPZY8Ikmw==",
                    ["#=q4Lnxm42UM$u8ot1tf2HETrfKsKBJFazIHuxkvTn76Go="] = "#=qhmRJRgzO68jGEoTDj8m3ZIgfnjbiGOM1FFOUvC3QO0s="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlCHxn19_k7ycZEI7Jkqnbw=="] = "#=qlbvmhQJ0ETXljp93de_h4A==",
                    ["#=q_r6ZbmxQvnWUSFw5kRsMEw=="] = "#=qbdp9$3ZDjeMECq0hJELWtg==",
                    ["#=qdajY6_KQBnWTEmrzQTNEKE5TR1O_PKltkbW7PekG3AA="] = "#=q77MT6$VCf1IAT1ekjKIpCQro7pbBzSEuKROcqBgiC8Q=",
                    ["#=qsVNZDnpHh3NnekW3zcTAu99BhdNfSYst3od3gayw5Q4="] = "#=q7rn3rJVl5Kl$rsV9v3eN1kSM6IwU8GdWB8tYod$0j$I=",
                    ["#=q8DAeNOxVp0EXZa9sNl6jqSpQwjgCQ2$5neKzrhP9Jyw="] = "#=qTTkap5Xq51mMIRa58$HhCUXiqDSe5BflX3Ot0OciVsM=",
                    ["#=qvYI$XeguX85yLneeVW4itx1V9PEJ0SJJhF0U55rV47w="] = "#=qk2yfsNOGEIacurhb_OC6u0wwApPxaR45kLyn99MwC3M=",
                    ["#=qvb2GxplkZ2BB1QrQkc2gqA=="] = "#=qox7ogGUNzsEWfcJTeSG5Bg==",
                    ["#=qhBIUF1TZjZO17axT7$pGAg=="] = "#=q$dnY2qC7UgE2tySxYBs_gg==",
                    ["#=qHihiTQu_ucMj56_aSriayA=="] = "#=qiRFLxDOS0Xnk5$BcFVZbVg==",
                    ["#=qjk2gds_6a9_ujkhIEJRamg=="] = "#=qCFqzy3o3e_2DvfkvjUIOew==",
                    ["#=q7BFlAoaGaEOXzBtvgv0LIg=="] = "#=q6MKjCw4RqV_IaZIGonsMmw==",
                    ["#=qNyeb9fqY$mzJbEJTO0ZhZBMIgYbbEusDdIeBOCOIqkc="] = "#=qGNa$WY2CCBAzR_SC1qWPgAJ3_L4ljrFqEY6at5NgKWc=",
                    ["#=qwnpikPFUlpfPUKdtCIPdxA=="] = "#=qIYkGJnpsdvenD3ZGygI05A==",
                    ["#=q0Jzc30_9h2X0GkwQbfLp7A=="] = "#=qKpXUFgdW2zYU2Pfio8LEhA==",
                    ["#=q09kByDg2CIRu1QOvC5Wu8Q=="] = "#=qiyxxjb3k4rDtkkwxD3FuaQ==",
                    ["#=qO5GSX1WjWFN11KsZrlfAG7ztcAxutfjBxSqimYfSoAc="] = "#=qJi7eLfOJkkvIX$R9neizB5$4aPkEovk08dB6ZOzG2fM=",
                    ["#=qddNA$sUZF0csJyV$qeUbrA6ADEjEZ2k_FQ2Q1o9yzBE="] = "#=qsaCbfqPF5zmCi3P9qOQAZt3E_TZaeCMCwhY4I4_gjZc=",
                    ["#=q6Ju$zpfDvK3MPuI9Jhiugw=="] = "#=q1kGrryyXaIistveu9iB5WA==",
                    ["#=qyrXW63neY4vZbrFrbJVVXg=="] = "#=q_Cd_cwwT9YZU18JkYPr8eA==",
                    ["#=qFVZjWvvHcuUCkr_OZ4EDpzgfRunFRIBhkj3II0DlDj4="] = "#=qU0dkJzfOesx8kfYsURNAeuc8LnYJY4j7GuHPRj3BfRg=",
                    ["#=qgInLI2ojgheuoHs2yst6wQ=="] = "#=qTPe$sfuuozpFNNQmQFk$xQ=="
                }
            },
            ["#=qK2RFoTjRNITZZ33QNcQlMroK$uMcRhqsqBCdwyn2K2I="] = new TypeMapping()
            {
                typeName = "#=q0CQTqdcveyvBf1eMPL8sxVPfMA47pK82i7lMootDK4g=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qVG10hWJn7YCB0h$gQagi$w=="] = "#=qVHP3iEMg3hOlKPq6ur8eQA==",
                    ["#=qbTsDSG4uOAJzYrITdHs7bg=="] = "#=qCM9NiWN$_ksPLNHtTBlLkQ==",
                    ["#=qtnB0ZyoW65IX8jq4SpMZT33UcB0DznjLOjZ7caDPsqo="] = "#=qxWh$BoymnZKxK7Xe0q8kzGMZhdYZWHwzNg8BBsj8PMU="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q$_3Gqpnjpv4ZEfqWMUv1rQ=="] = "#=qc3eXXVgMgFF9BA36LT_B5A==",
                    ["#=qM0wJCXj5YN5s8vDbl595jA=="] = "#=qwyWmRDY25PWMznrX4mArlQ==",
                    ["#=qEzZXHvHkaIC43M0NlgOsWg=="] = "#=qYWKPf4aMGp10HbMh3IclAw==",
                    ["#=q1HwnI$j1OJrBFSWZrDDtGLhHVhrvntzjkQ8$YqHNXOk="] = "#=qiAPMrWS6xigV$VbXrWDUXRRjVqknxb5Rk5WwFuF68sQ=",
                    ["#=qDbL1BYpeKJnDSB3cGj2_cA=="] = "#=qJM8RYoum2F44SpyeNAU2tA==",
                    ["#=qWlAIn1beQEffnE7t3wi6yw=="] = "#=qT47vrR__NrV3t1EqJhgQAA==",
                    ["#=qUp3XDcaGK_oG7EvDSxSQYQ=="] = "#=qMS6pJAVDNOXD1chlk2cfsA==",
                    ["#=qGEKXIOPqf3hRJX7VEQfn$A=="] = "#=qtXiYjUAn_d2y6H1ArI_XFQ=="
                }
            },
            ["#=qk3xRvDLfvBpELdeUzNXqzXBcudj8P_7$6JvpuKj_d_o="] = new TypeMapping()
            {
                typeName = "#=qlxkwV27rmFHyJp45IfxuC16aMxfgsgVWKMlv828n1_8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0c5lXAKYoF5tfxSgN$Kkvg=="] = "#=qlKNe1dxZHQMKrp$UNgkm9w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qK7REXqjFoctHiNbBzz3hDwJ5QFh$2$co00zhmlp_rRk="] = new TypeMapping()
            {
                typeName = "#=qvrSKw1Jib0uEV_QpzkSytk_5kwbcc0CRhR8OInq15FY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qG9VBUB9hNHNji8G7SBjBww=="] = "#=qVosQs83QZktWlyXf8NyMWA==",
                    ["#=q2bxg3dBSITIaIecRJ_$xXA=="] = "#=qYIXOh8IQ7xeg8LqnV0Pxcw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qCoodQ6zeH8kYt9$OSwT51g=="] = "#=qPFC3WlIFEmdLgK6uIR1_Xw==",
                    ["#=q6Rt_BBreTivWqf7fr1bQPA=="] = "#=q5IpKuGlEbQWyUB2ZSzCBAQ==",
                    ["#=qOQ$kikdZD7GkviVblI37_A=="] = "#=qG$FKaRUh_QBzNxbYAVhi$A==",
                    ["#=qCcC2k$o6Cd4UYNo8p5Sw7w=="] = "#=qyTVC$R$CybDTkwt99s$BDw==",
                    ["#=qHjeJ7qjX_koyzO9dLcNhlw=="] = "#=qVekiTAFAOdIS0R22evhzMQ==",
                    ["#=qCoHMu1Jr087R3LAlUT5XiA=="] = "#=qpHiFn9kJVSk_7heypdHcmA=="
                }
            },
            ["#=qKaZJw_teisFij8SARhkraSgkSbEH6ybhRVRfPMrnwIg="] = new TypeMapping()
            {
                typeName = "#=qxd_hrLV7wvyjfqGuOlg$Gdts$vswiOExaIUQrvXIjd8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmeHWge3YqhEnray8u4pg4A=="] = "#=qXDOQUa5Rn_d_SAF1pf44FQ==",
                    ["#=qivw5kN7qmouSOkhmTCi$sf0TZyXyJgBStkP2G4_kqgS6CAl$vF3Aat_YjZ3nsW2X"] = "#=qf8eChw1TWdNbs8uu65EZDoC2Mh3wXZGNSpsa_rtPqeLpGAneSOPqk6EalwiTvgSH"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qoISx0mz57Fby9lL_YixL7Q=="] = "#=qDEevDyulYbEoUnhMlcEUMg==",
                    ["#=q12XUNBAkQhxvv9_BGfQBio7tq2JMPvWYnXDp3gPoO0w="] = "#=qw7ouo0QU_pvncjdKVKT3DJOkBEfB1KzkB6wAqo0a4c0=",
                    ["#=qHk20pYHE2xLBOCF0dZmSVK5DYSvvcC87Q5wMDRKtrnE="] = "#=qhyVGZ$87R28YEFhivuaQFOvytKMltqPkya4IS$AY3ps=",
                    ["#=qwPjOBd8FPJtIeKLQZhSWf8lDWCiw33iU2pbiOXr3grM="] = "#=qTrqpGFgwnKWqWUdzqyMSjvXwZhPqoH8uXTYGWEgcP8I="
                }
            },
            ["#=qkBBIX2wQxPJH$IxIDEN6K7YieiiYf2KIyudbm0u8zBucH8VvY6etif1Xc4kmPwcf"] = new TypeMapping()
            {
                typeName = "#=q3qC9qnS6GH07e2h5$6pXSohNkdyhV9iyLjjdFdVrbAYdXqmNELg8ucb4eQPuNK4Y",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qkBNGtuloO7yDIijZ$uMn30EzUcR69t8r1KyIquDSn4Q="] = new TypeMapping()
            {
                typeName = "#=qnQ9DzO7rLkHdiFlWK8nVs$ZnL0fVF44rBN2V1_GQwys=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qKccVm8XGOthWa3kaX5NXTi$8oQJS_BDqwpzY4A$ndp6Bj9gcCwrqVWHxOni0ENo6"] = new TypeMapping()
            {
                typeName = "#=qkVDC7Zo2W8PnoCjMgXtJaoGTYIV1Vn_XaTSyTxp$Nfn0WwUEkxRDqr7mXfj2Lko9",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qkcWkQvO2Yp6U6rKKLWS$l8ZvYsgeUwmmr1uWH1s197mvtwI7rLFp8A7KYIvt0ixF"] = new TypeMapping()
            {
                typeName = "#=qoZNMQgKSIE97bwPOl$qZgqtSRihk0xHSopST1v_2_d4wXHhE1yB8CCfjKlYFTg$m",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8eJ6Qck__bY_kaxDzDzT3w=="] = "#=ql4QHlEtX0_nbDjghwK4Eiw==",
                    ["#=qepDPjOMoqM97bhnunLuRgkbl1XO38n0o6U_43pBktmE="] = "#=q7dVLQVATYj_eWSjPeINGqp0LDd5AwhxKh4G2zuZUwqs=",
                    ["#=qQ3sCRDolu8mk$nDbWWgseQ=="] = "#=qeB6nGZ5Mp0kStCxM2NHBmg==",
                    ["#=qPf9rsxVDvRl6ggjoWhZaig=="] = "#=qjiLiPXLsP4CnAXNFb00WPw==",
                    ["#=qJ8E4LDJ_BsmFlZKYBkKtAA=="] = "#=q6tou0uRtyG5wyXjBRmCXSg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=qkcWkQvO2Yp6U6rKKLWS$lzj7WQl_$yS7HYZQSchwhfmJ67CL5oKRpi1dTPqKadb3"] = new TypeMapping()
            {
                typeName = "#=qyW4UpAEspw_yXm72zq74xsLJASqrgFDjVM3kfw3XcjH1ACBC2$88MgsXEMb1tnWo",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9aLgVXX_kaPK6nR9GdBhHw=="] = "#=qTi$wHywdIRncjKdpqWvUFA==",
                    ["#=qXfVRUQhkA0EDo56ycOrsQQ=="] = "#=qw7mA04ftXz3jNF2m6HkxVg==",
                    ["#=qWoqNBLuVxrasj_3tGSZY$A=="] = "#=q_yb2beIQbGTc5J$fZl3JEg==",
                    ["#=qhB3ZGUSFw1WLM_qawrQg1g=="] = "#=qHa2rWoZu7Em5UnGrqVDo_A==",
                    ["#=qM75NTjOkprEu2fhFBRNvDw=="] = "#=q8ZBeD7s5ijrEtvbu769NoQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qFdqUJ2nmVhoo8cobgT67UA=="] = "#=qS5pEb5EUUUppIDR8E7x04w=="
                }
            },
            ["#=qKdekdZR_yE2XK2EIuoyd$lpsYrcIR6cLd03hAd8T3d8="] = new TypeMapping()
            {
                typeName = "#=qfMsLHnpgVGP0y$0DS$W$aRozASCQ7IkKnclGA2EwH7Y=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qALI8KROdjM44hM9DGhgnng=="] = "#=q6F6wpB2i9tmYLR8D7nVA0A==",
                    ["#=q_cy3qpaf7wILKd8wv6A_aQ=="] = "#=qAJZaBIVrxhreniLwPS54Yg==",
                    ["#=qmOF0LxlXCd7p9Q1IwYlI3A=="] = "#=qWi1DBHVefCtPtJoGw0IIag==",
                    ["#=qe7B3kEXRgzScQMapXRO0vg=="] = "#=qRRDXSAidT11W8DeGCsu4LQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q2hfluxH_AsGFO4gTZw2tCA=="] = "#=qXw87wHWyVf72eb0VSEhPyw==",
                    ["#=qQ68r_ES20D_f7UsJfGwDXeCeIs03Va_7mXgrTzogcsk="] = "#=qXiBw1KCl1fFvvvIEl$pCbxAfw9JvUd_2G3OhaswpK3k="
                }
            },
            ["#=qkeTQEx0VL9Sg_bMEN6P475nAhPY14RCu2qSK4xvk18sWl_JA$Gpnhggin14EYQ_b"] = new TypeMapping()
            {
                typeName = "#=q3uln4LSIWXdzKWPtMsaB7J8q3gR3ZyKAH9hT$AvLNqADrGj1pIKA_pxYSwTSiozU",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qfOu6htlR6AhOraphq6OGyBaDZh7HNgAIyz8UkRAO_SI="] = "#=qrgT0R0UfAkmBRa1yBYL84OIBQLXE1zmAPpROxOiOTbs="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qv2ZolCwbg3j9ejDXsiJByg=="] = "#=qGGBe1rwushg6jVD9yeGJnQ==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA=="
                }
            },
            ["#=qKhMuJvTmWg8pfv8rCZDQB9WEnXEwEmwgFeSAKoehUJg="] = new TypeMapping()
            {
                typeName = "#=q9OJ5cSKPryE3bB1jEyWu2MrRgXxJNZjX7mxbsbJOurA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qe9cEKxZegGgEZAwAOl_wHw=="] = "#=q$enTJXxYGCtfn7UTK11byw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["op_Implicit"] = "op_Implicit",
                    ["op_Implicit"] = "op_Implicit",
                    ["op_Explicit"] = "op_Explicit",
                    ["op_Explicit"] = "op_Explicit",
                    ["#=qwhBJe8DVwfm3bsbCN$O4iw=="] = "#=qgd6IDFiS7OYtX2NMbd7xSw==",
                    ["#=qBNYvBeqvfhjQrJ9mTVlqPQ=="] = "#=qk96pA6QDhCPPk2eW5oD0Eg==",
                    ["#=qY5w3ijG0gjnsHoRAZ1ocYQ=="] = "#=qqYDPHu75w0S7hvHbhWtB6Q==",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode",
                    ["op_UnaryNegation"] = "op_UnaryNegation",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Modulus"] = "op_Modulus",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_LessThan"] = "op_LessThan",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_LessThan"] = "op_LessThan"
                }
            },
            ["#=qKHntAJ9TP7UKJlIOurhQ4VM6RHbtxilgfFibMaJMI7KNLz4rLbcTnjPFyvKUw7gF"] = new TypeMapping()
            {
                typeName = "#=qow$cPA3EVFPHz_F2Kg0P$vGHm6gUm9IMA4QU9C7nASnhbgUGXMemneTnZqpijQnN",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qS0g$fCL1lb7p78N45OnNBg=="] = "#=qukC255xZBE8KIS93dfM45Q==",
                    ["#=qeXxBBhHbssOfMTU87Xhx$g=="] = "#=qL5OpiqoafxlrVnpFb_KJVg==",
                    ["#=qVffLB04$EJm3UpW76pxv20zZNeS77$MNKpZ1DPM4OF0="] = "#=queQPMtYgMEqOIepFHQfRBlGs_aJ2VrdNCJ7pcxswnk0=",
                    ["#=qhN5kaP6YLADyNGoFlC1ueFKjkRuDK95DINjcTZ63GWE="] = "#=q_9Jh7dXXF8DHI53BUGwmckRB7u0dbSX3Gx5KT52iycI=",
                    ["#=qMREaVEgxDpw$hoQPod2ZMhIb6gDEoZclfxwHC7AnR_g="] = "#=qZScVUJcbkJN9ji2FD5wQWEGbaevivuzEtBVbzrJpGvQ=",
                    ["#=qIcH5reqDTiOLejgLaiiZGQ=="] = "#=qOPm$$DQOdQj1dFihyX$N9g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q7$vXLNqOZ$FOfeGXMHiyd8bFUrBxRccPi_oPHnxN5Eo="] = "#=q1GATFuTWln4hm4n_e1uICvqvGLe9mkLdh45x9MHxDmA=",
                    ["#=qVDoE5FhWTjRzzhFPTDeh2g=="] = "#=qUIy1TmAX4xMrMq_k0ehu_A==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qKjUHcuPVxFQSzTVztnZslDZb9m1CapVO0e8SuNHXn3bw1Ouf96Ku2hUOgASwxiv2"] = new TypeMapping()
            {
                typeName = "#=qWrWIp0dOBZk_0Oy1bHUYw9tfHWHLlbG1gBg2PMP2YMSiMnHdMJ9RfFgdYv6ZyamW",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpAfNmq1do58yC8Rj9$w_jQ=="] = "#=qioNrekCpH$r4g8g_Nx3SRQ==",
                    ["#=qTzYEg2Q2kiysbBTiXeW_bQ=="] = "#=qWnZIphefGPqOyT$fBuOCvA==",
                    ["#=q8mCYldYjrg3WhU3utmvZUA=="] = "#=qJ8pO5BHtjWNK3_tjgbSGfQ==",
                    ["#=q58U1Nk6MUAxjDCk7vAo0Ag=="] = "#=qzq9lLoOk$MpKnk0y6UjJCw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qJ4bDNrGFUFmFTcgPJ1s3IQ=="] = "#=qc671XJMM8LU1UxC1tg3cww==",
                    ["#=qLvubPDP4CuNIK3QqxJXITq4C9D1nngvHGP27SpZPoaE="] = "#=qfJ8EuyrAIUgd4lJ_9eMwGxWNj4B3YBHNgJ_61$WWzyY="
                }
            },
            ["#=qKQj5hB83ywzGQgWBykekinchtKSyyzUxPdqc0y$3KVo="] = new TypeMapping()
            {
                typeName = "#=qzc38n6hiipJk4uMexU$cozxByTxKg3KiWdSY$9M1oTw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qla4yfYsWunGUATOBpyHdRw=="] = "#=qvbIuRTyFDsJExRlUVNCq9w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qK9u5AsbE7znOYpd1DmSbhA=="] = "#=qFBq8SBgXltUyEzVlJMOr4A==",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qcVx_yZN2zlSi_5kF15GuXtwSs_O0K_$fW6xWWk89$zI="] = "#=qvhfwhM7AH2ab9LTM22IQEzOzcGQa9_MQASvhMHW6Abg=",
                    ["#=qLk5P1Da9GLJMjSU$G4ttezQPbA2xkXzPKS9Ib6b4Row="] = "#=qwwbst4mqO3225meRwEKq6xbzFR2eNDXypmTPamObZdc=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qkT0tBhXp89DGtszojsdeygN$RoLg7fOF$VWNqDzaPu0="] = new TypeMapping()
            {
                typeName = "#=qBYLtovv8VgEnCBXronTobNvIAOiKHBIbggnvD2V4Xyk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qopKeQLvmvVgU79Ivj3cliw=="] = "#=qaoWMep2ke8gQmZK28c8KJQ==",
                    ["#=qN85BBv5BtgVob53wtn0t7w=="] = "#=qN85BBv5BtgVob53wtn0t7w==",
                    ["#=qo3H$7mUJD1EswzADUK_sWA=="] = "#=qRUzb4MK8RSp0cZAgPsiv4g==",
                    ["#=qzewGc1Vt8RUJHaMdzx8POA=="] = "#=qMb1GuqO4lhDTzQX$8CEx5A==",
                    ["#=q7kq2ks5Lxryd4v9zBDQVKA=="] = "#=qIdSCfdHFI2U9qIxDxMr5qA==",
                    ["#=qgJp4ztoMTmBYvAmsDWmkyA=="] = "#=qqgBehjt94II4MOWqgUk4Zg==",
                    ["#=qYPmGqlkTcaiXowcneKz3Kbeer63pUo9W0rse$26mfZ0="] = "#=qsxj3djTLBOgCSIpzYprejuNac0w7Isdhiq8S_K1Ms_8=",
                    ["#=qf8eChw1TWdNbs8uu65EZDoC2Mh3wXZGNSpsa_rtPqeLpGAneSOPqk6EalwiTvgSH"] = "#=q3UqA7WAox9J$aALjuTnb3$ed796mKVfvbfNIDYT3uuQ5iez2UwT1zS7t29tj5S9n",
                    ["#=qiYWi$$$iBfxQp$iNnIhP4P2ZJCI663r$M0fgzdtH9cVn_cfrg7WLN0$vdFldo5ax"] = "#=qH5dwz_iUIF2lUDbzQBRMYwHcivjD_SKrzKHriW553w1Ovd1ge$C3xclldbf0gdFs"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qkL0gjd9QPUcxSbVyE6_z1A=="] = "#=qtcxKtN2CGWiRqBVWon7K9w==",
                    ["#=qxfiW1wiHjs2tG1ddxN6_Ag=="] = "#=qCPgAi2LtTnaYZBR2L6TwZw==",
                    ["#=q4jNqleUohYOS6cAKrOZDhg=="] = "#=qxgGv37d4vlpUKcZx_tBIsQ==",
                    ["#=q7UnyHNMcOTl6_SD0Hp0KIg=="] = "#=qe5HvWZ_M$cFHZ54W0izahw==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qhOvhnAv06GTt_DdEysPDXA=="] = "#=qHK7bZBoh5lZhgASLnn_jbA==",
                    ["#=qDFtmgRxdvTMwPPKIwNBi$Q=="] = "#=qxx1RXM_wy1qTVny92nbX_w==",
                    ["#=qVL8QROmvotwAf8m5BMt5qg=="] = "#=qfGlgMGEl1w1Q77kADK6Wew=="
                }
            },
            ["#=qktLUPOJ$6wDEPdkJ6jzERH9$M127vj0T6ZareaUb1F4="] = new TypeMapping()
            {
                typeName = "#=q5qi2ESBMUyhstmnfniXB9QvWKneMw$zX1rAdoi2k8yU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qMnmgZJMyUBiuXwXDUcmrKQ=="] = "#=qDx_tJGLF$RjpYSc0d8KdFA==",
                    ["#=qJtpPElcmys03in4mpBhlIg=="] = "#=qKLanZ_TNbHahiP12_KsHIA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6ILMBj_mlp31wZ4XY$GWPZlRTBZoWRgn_YuHJCqRrp0="] = "#=qXA7ucsT_UlYxlwSftKjamFRU7Uuy9AqnXmtiIejeIN0=",
                    ["#=qhG2kboi8Ip1vKd7UKOhfhg=="] = "#=qOQ95f$aD6OOXUDqL4bQUJA==",
                    ["#=qXzI1DGARWTgeV4lXv35wOA=="] = "#=q4nIm8Fm1$TB2fCoAfARfJQ=="
                }
            },
            ["#=qKtRqDhVOSm8NuTa$VIg5LnW0fJ$_fdXK$rlprt$yOBk="] = new TypeMapping()
            {
                typeName = "#=qNosK3lxjDhlOBdRJjCdQf3_9I7pjsLIw0mloyUi4dnI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qNwgqSUPRNeBaaGjxvQ7$Iw=="] = "#=qFuIIPhZXh7uQWEl0pENhLw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q7fgsuzfL_Kv5TaGp85$iIBR2ZeY_L48i$KXNEpxy$T4="] = "#=qxoIvfVdB_bnEdb2BZtuAiTmzwrVO5lZ89mZdMfMK_$8="
                }
            },
            ["#=ql84Udi9TI_YdYvLvk73vNDw0oi4FGS5A3GS4qsPUsNM="] = new TypeMapping()
            {
                typeName = "#=qIjbCgmBBpOrjdlDlnsYG34Suqlil9rer$INRLK9PkGA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3G574mj3oRQWHnbtHC3ikg=="] = "#=qAJBSd$jcaWfg16QiEUCjZA==",
                    ["#=qs1QK3RF8Bk3ejhYRbTDAUw=="] = "#=qSola_gooGHbpaqXAxXXOdQ==",
                    ["#=q642B8ITCyRhmEKOmCPw5vQ=="] = "#=q$uYqYwtN1DQXylLKzN$EBQ==",
                    ["#=qBebuXzr96iABdssDdVhPog=="] = "#=q__GmcVXuEwTtcbouGCM6uQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qL9hKRmVc7ahbjZGfrAdcpBv_GB6TwM8cXLEn7W_aHio="] = new TypeMapping()
            {
                typeName = "#=qSh_dYLWUjC2fmw5wZItF2R33UBPDRHywcvwXx5f0QlQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=ql0JO3nr4D__xdbqulu9BHQ=="] = "#=qE2qptQOtzsBAVCKhRIP7Qw==",
                    ["#=qR0StMLkhhBWZVnDqFjl8tw=="] = "#=qx0tSJ4fp4CLhV9_M9YZF0w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qVmBjwA_dpOvlyY4TLsCQ1w=="] = "#=q0xM9qHc5BQisQWFvxYJvHA==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qLcuJS7rkUZfVIfAH9ZEmPBTfLRR0kHtk1Aj00rWNNYk="] = new TypeMapping()
            {
                typeName = "#=q2lSPONn6GWQTCip8$GLj8Y93J2F0eLEKkJ8f7rbocxI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qwWLALEzLPhdt3THTdVWIHg=="] = "#=qhmEPY4QuN47760gWxMor6Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qxA0KizHtVF56Y$Zg_avrTg=="] = "#=qjyDRiWG2ZQJ1HXA_9MaLcg==",
                    ["#=qhmjf8W75KdmPyWFdzymsSQ=="] = "#=qIp9gOsmjyIkD3Vp_zsGZcg=="
                }
            },
            ["#=qleO_vCz_8sUOvM2tPbTjMXgzgIX_L6jU5w6Jeuq9lE3lIMQMmhnknBKMw9F$cP1C"] = new TypeMapping()
            {
                typeName = "#=q_l3R5srrpQOzQ$BHgldRs1wutOBtTgnyQmrl8dvsuP1OPfC3cwYvQRKtryRdvRWK",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qus7$WVeBMFbB3aLv0ibtVw=="] = "#=qsT9x2l$uQveGvWXBsAqnLw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ=="
                }
            },
            ["#=qlQgRjlwm39eeqdVezU9OG4v4xibd8rNCz5d2DNnECyw="] = new TypeMapping()
            {
                typeName = "#=qCoQCp9PEdt2ouTEETPknhGIVcidIi9a4XjHlL75ANRQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qd1vTOF76pDKkbnnrqqTRKod2Oj7fzkgxNJnqHBasGJE="] = "#=qk$9eN2Tg3AmY5T4hbz8eF4RNYY5vRnVB6rIMbac7Xyg=",
                    ["#=qCF4ta4umm2_Fm1cyDzDUWl9iAG4jCVg8PbCT0FolIRNb5IgKjBe96LE0WHd5Kj9c"] = "#=qWiPJQmTxVEl2zmnlhJ1vpgMUw$FMcj3Dz3M7yGzSOK34JfHXNC6ERRrRVAFcPmr4"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qVhVwSfDGNZzVDuRdccCMag=="] = "#=qEjf0t45FknZG76UjjHrBrw==",
                    ["#=q0QKowMaARqmdYnJAsE2ksw=="] = "#=qEtZf5TSZ4jxYI5KjM3yhcw==",
                    ["#=qHwrk$FcqWdRLrzh8qcIAhw=="] = "#=qspHouw7DcMLHBADGUDkeBg==",
                    ["#=quL1N8fSVe00BYpFOp6Nipg=="] = "#=qclU5R4_DGWNbFLz0BE2Hhg==",
                    ["#=qUGTk$enyAxMnkENaclS73253Lb1eTeoNPz5tB8t6ZEU="] = "#=qowXhRLDZdaOo_0HLJsrd8aQY_QYNWqSHPC1cHkFLxL0=",
                    ["#=qP4IqcA62oGVymPOqkE7pKg=="] = "#=q812fEvg8b3305eJNeomf5Q==",
                    ["#=qmjnKkNpk67z2LS8B2hbDTw=="] = "#=q$L2S59DgKWHxLeAP6M7LRw==",
                    ["#=qx$Xu_XK_O8ylide3kPOlSw=="] = "#=qVAEFJTloA3XcAGnzUtmaAg==",
                    ["#=q5uj_6pShf0gnYZKztvPJlA=="] = "#=qyRKL7gju4aVRaYFkTRXB9w==",
                    ["#=qrX82G7Ufi4T1AWFvy64yd$_lyWOXbXuUgWb5aSop_rM="] = "#=qVBisfS8IZYo4JVqLPAu6q4c3bvI85AuCH8SIRylYZic="
                }
            },
            ["#=qLqj_Zn$CEDeCS$aRnAn2ETaSpOAS9zb1vBiIP4xzWuc="] = new TypeMapping()
            {
                typeName = "#=qVK4rauzEcAXEYl3NF93Y99Yy7GuHmb21aTCkKjhaW2w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qLQZEUDeE5FZdYYw2s3brXxzEHotapuZgFuHM8KwskO7buk0B48NvUI6MXuiC_aKh"] = new TypeMapping()
            {
                typeName = "#=qD7ohNrBYbV03eTkUhHvnzhzBh6jMImM3skVGC2MkklA0gSaWfbYQkPmq4eE_KKpK",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qTosDgw8GQfC6eQ9U_pvhNRY1e0UiLSDv_Hgig9dKFcE="] = "#=qhY$65n2y7jE5RddyS9XHfbbrF_48H280q6ervbtvZto=",
                    ["#=q2KTlnqWJJNXLHxvubh2bPCNM3cn2UYObEwBaeTNPw2Q="] = "#=qMBiWRQ2bgafY5041TYc9y4kWZFdNVM1F9PaHN$E13bs=",
                    ["#=qVGsYwccnHwTBASLVuqFnvQ=="] = "#=qgV0ZtMIDjEEkJEj3Q1emLw==",
                    ["#=qQIk4PXos7eP5wo6uzjH5Pg=="] = "#=qG_HFpvApdU9prpBI9AdQow==",
                    ["#=qMffR9c7ebVyjJiaBK5alZQ=="] = "#=q886GmDaOObpHbT5nYxuBlg==",
                    ["#=qz2$Sl_5NA6iqQZ2sIUp0hQ=="] = "#=qOdFBypaOYEFMlYnrKAlXQg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qFRR_QCJAUCxejPwKF9Gjmw=="] = "#=qnGkmHS9$FvxNoyTqkRcDLA==",
                    ["#=qB9U7Fqh72DCIIXtZ7uQ8mg=="] = "#=qP6xLzrjPBhMrCqmI7y__iQ==",
                    ["#=qxxwOK8irTwm9cn6XuOoh9g=="] = "#=qbLR5$Nk3x2ClDW8vZg4IJg=="
                }
            },
            ["#=qLUCw_jVutxEe6WVEfr2S0KhxHamz4dTs_0IXdS8Ao5NgfUJDRzTwjXR$sxZF_Px1"] = new TypeMapping()
            {
                typeName = "#=qKt_8DydSUSUOmh3GExIXlgCEn9BQ1sc64_juudeyKcoEquAauGmlorsonhzU377w",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qrZSokokXFcbFQ6Stupvpsw=="] = "#=qkJbekjT041u$AgNc9OEbZg==",
                    ["#=q4b_6slrWArUsbmiaQQeEhQ=="] = "#=qjfxi7GwOPvFNTdDnwahpNw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=q26Fy5cesMryktuijVNM8og=="] = "#=qhtm9wlg6eoijZJmFmHonCQ==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY="
                }
            },
            ["#=qluNQDfRMFLyKqoHj6jNHoqAdw08AxwPQTM4Qz6TXybs="] = new TypeMapping()
            {
                typeName = "#=qFKLG02VI3t8M9woCmqhXX8XLqFqE_49Qv07ZRyDJyzk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q$Lcy676T1UHF7LOKmXONQA=="] = "#=qf0C9YCDzs97iQ1UcELUiZA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qmUuqHJV_Oy2ZQWG44yrh_A=="] = "#=q4UNnIe61Him4b1CTSfUI1w=="
                }
            },
            ["#=qLVRtTQfhdeOgm17LQj65jOMFOj0mdCzf9eZ8CHN$$ASnotTTWyz5V1JJFhmRvniC"] = new TypeMapping()
            {
                typeName = "#=qk4mt2s4sjvN0tIK7LqZs6pI34TkQxTKXV_gyIurCGFGTvkWbv1SF61U9xFw1cf8P",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpJHSINF23K0Z$pxLlj_i5Q=="] = "#=qY9QA3LGUf2w2KX$$iqZ2hg==",
                    ["#=qW$xii5kI4KWunSZ9wrR46g=="] = "#=qwVwvvAi3e8M4n2Qd0JeoGg==",
                    ["#=q1$7f6W4ySpMMQMkF087G1g=="] = "#=qYIibUCw9$GvKBsCV5sBNyQ==",
                    ["#=qKX4VQnoEZraK2t8jrk4ART4xouqrzJsuofhO3AAGjAk="] = "#=qZEvtOl56fI1Xb1nSz3fQFJJ9QnQH6$gDwT$kzvM_tkE=",
                    ["#=qflRxfDE6hvV$1WcvT55NeQ=="] = "#=q_8DVkYkH1dsfCKmVS9YR6g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg=="
                }
            },
            ["#=qm5woKRpdqnqnWeA94iso7yVJa1QBiqtQ2UIi1ve9RTEYX$1BS5oitTOZ4SFhMiB7"] = new TypeMapping()
            {
                typeName = "#=q9mEsr4XRT4b8am0sDc$1qvnQFHXAMpzq7uxtZi4onVlt7OvMyDPGomWVjNjO6XPo",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgadEQrzmWvkn7UXh24VuTg=="] = "#=q$0jP4vG0EM_2gJMMz9fsow==",
                    ["#=q5KqWskf8fABckklAinvwRg=="] = "#=qBSGx$wsRmDHFv5iJnC$dLA==",
                    ["#=qsvP7CudDCEbKoJ6fXtikGQ=="] = "#=qE1FIWl5Ryv96Tv$1i2cuiw==",
                    ["#=q8iVqLU2a8StfVTOUz7Gbmw=="] = "#=qfrLHH9ZaP8YT2SgloMMWZA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw="
                }
            },
            ["#=qm61udI5e9eXBbc6SfLdQV7yX5q1pHxeNW6GVBpIvu4WCXqjc7iv0xiYIIbSFEJec"] = new TypeMapping()
            {
                typeName = "#=qg3aY06GnoxoCnfwa4iCsKkVHNbg51pmLK1Wl9Pq2i7oZHpEpi4u8SQsMNw18tOMa",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q4ehf$6p2fVUu9Lomc2J5pQ=="] = "#=qFtUSDRIdsDUUdjISbgY9Ow==",
                    ["#=qg__hQw0EiTF1awOPa_w4Zw=="] = "#=qn5$dOy5_QrI2YwkQhlnh$g==",
                    ["#=qIV2M71QOG$Y0dvKzvZsJ6DQZ0PtG1MXcAWyQ8noZc42$aIqbDuC9N6uo7KL2f7DI"] = "#=qxlrUH$F2nxy$NdnTyPdpfW8WBs$aLdvJ_fGnjT1fFtvAeXp3hHHnF0Bm2MXcS1td",
                    ["#=q5f35OFP0SB29ZVRS1DWeWO0dFVeqJLZMn8aq8$7J7KYcbVHpmigzP9zSkoZ4xwqf"] = "#=qvOwOwTD_m2SGC2_yGlanTubfHPlsPw_btabnBNAKPOjgdtXws$FSOo4D4bghsQYo"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qPRrLoZV4RAjwmEZ7vd4nuw=="] = "#=qdjtunWgZNStOqsmapTOu8w==",
                    ["#=qIJ6OHOJHkV2QENHedUSEUg=="] = "#=qtgjrKIR5LCj_XIeRRPIYqg==",
                    ["#=qNhHGos3OsMZEDGetf50e2sWRgnJ65Qz12TbUVCoiKN8="] = "#=qGKmderUHDOcthwx5sesw4WKHR17ebk4NJBtj77shxiE=",
                    ["#=q0Wl2iouaeu_cIKWzKpS6iCCc4usq8OrtbkgK5aNDkfM="] = "#=qwZ$Mn5eD59gB48v0yX1e1D4xQ82DNhvamgFiaq$4awk=",
                    ["#=qAAzgivi$CUR7KbyHP4$0Tg=="] = "#=qVMyJ6KdPXBYxaREZGlAZ$Q==",
                    ["#=qKOOeuiJMr_XDuvgD4d4Kgw=="] = "#=q1L8SZS8XMDz7xhIQBTea9Q==",
                    ["#=qsGBphEMtjlzuVZ1l738vsg=="] = "#=qngbx_TG1u$JY2LGkeqfUaQ=="
                }
            },
            ["#=qm61udI5e9eXBbc6SfLdQV8XLfOnvNNF7wo86LmUnhyk="] = new TypeMapping()
            {
                typeName = "#=q7cQjbOm7s2QcFsbjaot46ySRS2NL$sprBcqs3ddf$TE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qe6mTAgH44mTukQWAdbjXcmj5JeO3xP6T0B5mkksl6fQ="] = "#=qKwMy829LR0dmuYNHJhJTb9ZqZe3Tc_8cOJkwmZeEEFA=",
                    ["#=q0HvMK82cqP4WeOzAmwICEmCNIx$kuxXDZKnPwLCJDl8="] = "#=qWXCsJAcw_XdaZ$v4oY7HoqnMYOh0LV8AEJB43tSzXvM=",
                    ["#=qpRHZUcyXRPCa3Ub8XABIkiUXMyx45TAcFBTDh5U6_8w="] = "#=q4L_jKN5zioHOzr1Yd2F1smOhxfxXwYim1imHsMZn7z0=",
                    ["#=qPbzxl$jM9tV_2PCFS5dthqgrFWy7sq1h_MFt_1Bkcd4="] = "#=qrH6HOBnNwLyDZWtoGY6AU$yGO$SdwwAA673vD3nPwXo=",
                    ["#=qUXs7OHU2QyeD1yQHPweJTndTs9QHbe9_RbH6dL6Q5jc="] = "#=qa9ld4HT$l2V0Top$J8tRIXEOLQlbdRnspqN7POJ2HkE=",
                    ["#=qynum9UPhY1u_qUiccok9Fg=="] = "#=qoEuNJ68GDljBDwJMMg9Vrw==",
                    ["#=qp$JDr2m23TEVTU9KVuur7w=="] = "#=qieiwrSchYBHabrSbJ7ZvHQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qIX0HrwfMGJM9q8zf9dh0nIOJXqrUwAYqTZnxe$S1Hl4="] = "#=qdWgkUljnZYJQruWjXxrqE11imjNLbOsoDrjj0IJtOQ0=",
                    ["#=qRzBNFsc9x3OKuCI0p8sV$A=="] = "#=qeaQ0HTz92VoaL6h$U_990A==",
                    ["#=qvtxEoyduAwbnVz6jm8HSxg=="] = "#=qTrtuXeA1Nav9llakpbHXCg=="
                }
            },
            ["#=qMDN06ehi4G6C_E_jZko9M1EnqE8ujVSTWZa8OFbOMtIR_nTtVduI4MjfrSCHuLqL"] = new TypeMapping()
            {
                typeName = "#=qAsjUPozP3DzN1zwVdM2F_In4_L8Pwu5EcmcFo$SKEGbDiy5vrsEKjofPDSFq5Qub",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qMEBPvuppX7fOnADUoRjrIBqbDsWX8jYGXUDghaZ9vHU="] = new TypeMapping()
            {
                typeName = "#=qckHHipxv8_uW0BE6IDT1rvr5vIo4UChrqs655g1tTz8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkoJAr3j_DVWdL$n_Y$btu9DfCzoEduQsI_Su17mvdzM="] = "#=qdBITO473VclUy6MMHz7a44Tv_l9MEmTqHG8zXC7nd1E=",
                    ["#=qXFuxCayZ7NwaxjrdLFiESA=="] = "#=qpXcbx1zUW8Th3X58nhXXAA=="
                }
            },
            ["#=qMg2YdLg6esxLjZpruwGGcbxB4VEDNBVPu$gTmGDCZIA="] = new TypeMapping()
            {
                typeName = "#=q9ajPRKzN2R_tduWqS3SKGGPut97Av7qN84YZFNLcPsk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0NqR0_h9shTD9BX8ilrcFA=="] = "#=ql4buwPebK1p0r6UHKvgkrA==",
                    ["#=qAqJn_pn7IOKAsrDjUhWAdw=="] = "#=qb4TPjbabt9w8zt3GAxqoew==",
                    ["#=qlYe3Qi84BeZhh9VRnxCXnw=="] = "#=qD3kZvImpunygIW$Re_vUGw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qOkn8cvDKNTl9XLIdsCp94qz_MOS40coMcAluaMd8Hu0="] = "#=q0BIovIcoaN0ywz07gHLvX8UohGDNFBRMjsxEfjirKDo=",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=qmiZSchbG65_vD_D7BQTcKXm6HClr97L9LYfTiMOeXq5s5LPtHVq0J8Wuq2i9QIJh"] = new TypeMapping()
            {
                typeName = "#=qN7eLW4_z$H06j75fsx1F2B3ze5TlA055jqVacB29hGVEfTrx8tvNbK1x2F2kL4aW",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qmjx00zzSUp0ar3TWZczE6zlkYCxYh5oRkV4hx8wOh2jOdvbo0eSeo5E5qkQxkq1z"] = new TypeMapping()
            {
                typeName = "#=q3drkDcLxMOqXT$3zl4mf0UEoIJNjysf_RH4i4rKQgxlos5uA1DZW5Nlp9fF3RU8N",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qu_5$DHVpCrCOHYyFIXShOQ=="] = "#=q1JDaVap6P3gDYZI0AxyK5A==",
                    ["#=qPkoa9v9L4HpYkMcH2wQsyyFoTaLMMSR1VnQpB9q73uU="] = "#=qO$HGfIAjbjJ1QSTT34j6YQaeKHCCRiOq0YtLOKPULSo=",
                    ["#=qzvMIiq1RvAXZ7w1duwna_w=="] = "#=qjOcDqWABJCTvr81cJjuC0w==",
                    ["#=qRrIxFWqybDjGan4ZW6jIPw=="] = "#=q_RKRbTm7aTtoOyir29XyWQ==",
                    ["#=qsYL6iUjxB8Y8aL7f5OEF1Q=="] = "#=qVF0KIG4P3oFSckP0xo1JGA==",
                    ["#=qiMmVVdhsmE679kggC8VOvRJ6by$dtRRTDrmeuW2KqCrmsEoHd3iXMe__Dr39W7uW"] = "#=qDTkvEDigSKdf_5dommaOPL62F5CV7TfEl3M8yKMoBeuRW$$KauQuIQjifGCBSKgw",
                    ["#=qLLjrrtUIvekoPSjYCuDwGPF4B1ob8cS5ovnC1Zs3WEIIYoeSSEp7K0kY_JCNTiwT"] = "#=qmFxyYvqDotjpqJEHWO19oLBhZp9KCtVGwEL$W_oA92cYZw$4b9EPQFicnUT_XnY_"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qhptpoMOa0vr89zjvK41P3g=="] = "#=qhBWpF98dFcLU18eTUnz8Bw==",
                    ["#=qZs6n_Vggmzer5D6f5gsuSg=="] = "#=qcQ$$eQl0gOASjRPf7ckYDQ==",
                    ["#=qmw$G5GIGEVqRcKGt5640ag=="] = "#=qqMwsnA6RQEYBdzQTSzpKWg==",
                    ["#=qrBmm0Cvxs81xol464leFgg=="] = "#=qjbVD1$2xgWAv5xgWs4dstA==",
                    ["#=q8_JhdYff33K_WzFSGNZXZhFmgmPy2y5QDZxjF2FZbeY="] = "#=qaJl98ODdCi$9t_EWws93JoNSPe9eelYbkJwUX1bwwRQ=",
                    ["#=qiOxgsKMOsYVwecwafCU5Aw=="] = "#=qNIHxGRO$3rgSjDvHSGYSfg==",
                    ["#=qHO0vfFnN5dubaCCBQpuoUg=="] = "#=qTiAzHXfvNTOTZKgygccyVw==",
                    ["#=q0YzVGtOFOmI$R2_zbUjDnw=="] = "#=qF6flrzBqUPSTtXsEbGGTDg==",
                    ["#=qk2TU$6MOsR2nMlUzQtovZQ=="] = "#=qTiiouE6mjBLcgJHdBhfOIg==",
                    ["#=q9C8LRkZEItMDN8wUHbSBZw=="] = "#=q8s0Whs80OU2clhe1_3Ip1A==",
                    ["#=qPnDCEjx5HwDzRCsJzUqcGw=="] = "#=qjT4_M4drtxYMZ$OUUTuqBg==",
                    ["#=qRG9XNZaaSgkC2qN$LuvN5JM8NFLw0qPi8eTOnFgBu90="] = "#=q_L6fxqsBDnRojTFuP$eniqnce2n4n_ua_snrjEBLT1c=",
                    ["#=qPON8ITQX$vyWesQQwxcR5g=="] = "#=qlh7VD5zRz42XRNs0TYkRWg==",
                    ["#=qWL9Wbn8SITZLgbt7jKN6fQ=="] = "#=q1DLF52mbjul7p5ZVYpGs6g==",
                    ["#=q_0SaeF2AP7uMW2PpGyJ8W87jNzMZN1i01N8CN_OII3Q="] = "#=qZHSqVa$Ae3RAchX4VE7U1fImOMsgmkiPHAH8PHuGZJI=",
                    ["#=qNuQB_r$VTASANnPK_2dksg=="] = "#=qGMrb5FwbrsGos8tldSx$FQ==",
                    ["#=qNUS4_aG1BtqTiFnKwmjhIA=="] = "#=qugSSTrPyc103YBBdhNPfRw==",
                    ["#=qHoMFtzS04tLmAqOhLDf6tQ=="] = "#=qdhlvd$uwuYGeF6N7KBWVMQ==",
                    ["#=qrwQFFScP4UBYj32Y9SddzMFKNQodriLKYM96EB4jnKs="] = "#=qS_qmdxnRnmRBUZ2oHwkAijcGoBOu3uaVtCg4VSDUZuU=",
                    ["#=q8oPQqjIoGnBzHBZ3Cxb8vQG3kPoN9EL3ZaS2JGNXOnc="] = "#=qRSI3OD1OOI1swD0lR1XcLnEtiNJofE6vJ7Q2VQlTV98=",
                    ["#=q5gSyqez8wWcyl8zLTfLZqRFlODT3B3NznigadbMrI$M="] = "#=qOx4QMII9DKi_dvZg5seCzPO0ETvQW6VIO4GaNcrgiIg="
                }
            },
            ["#=qml1pJoAiVhP0DrNfz58QwayWRFNmD1asJqQ$gRcjmdo="] = new TypeMapping()
            {
                typeName = "#=q0Al0KnkoeMtpAWuPhV8WlP4qqzwSE5FRQvYMsbRkC4c=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8yhdoKEzFjuNh8CuqwLYXQ=="] = "#=qWYFWI_bTT60Xs0BrHlTKIQ==",
                    ["#=qth3laSwm2oQ4EGUbwChXEw=="] = "#=q4IaadoKrJ0Y0uKyK1LApFw==",
                    ["#=qoIOK4J26Wzx1RJPkFXShAw=="] = "#=qaRTyurhBquthLUPPrVwvzg==",
                    ["#=qpH75bWiFGN2txQhUUyjtpA=="] = "#=qI5QcxLav$tN1XErDKzod2g==",
                    ["#=qk6UJY_dYG8qrv3JwSaJW9Q=="] = "#=qE4RHRLnxMFMdyXULzIXfeg==",
                    ["#=q_d4EolFP0OGEmRe1feaUiA=="] = "#=qs82dym46FrPnH0BDjkFeNQ==",
                    ["#=qZbP2CdS4$tl5gjaQGIiTACHXQYN1HJVuX_dr4VnvF72iMU8Vi5gw1HEDWUroH$50"] = "#=qYn7PpNkV_AuWxeydX3Bxz6rIJ_uBHVR1vPhtMd28DpHO6yAMe6nqj9ysxH2cgsXc",
                    ["#=qs$Dt47dK0jFjcHUU5DeI2f3iF45dLYKTC4bn_4vzTRVLL6h$8DLrSDWXr5dt77QH"] = "#=qxRUiIZwE5GYuCc6l6vC6iX6gPYCRJo2IVY8679D$PzWMAOdbYHOlDScUcTV4gHE0"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qI46CsnuLWP0YZLuDbu3IaZr8vtfYGZ0I_x7krqbKhM8="] = "#=q1_RHKRkxVY19532z0t8vYELgVyuCLtLdSLBqGBtaF08=",
                    ["#=qzN5S_p8yW_UL0Py8vIYQuQvgvj5Ar19diyjXFEbELWA="] = "#=qym$1sDrXyevaMWgd_uoAc_Yh8$KFwCR_Z$45VQklHlo=",
                    ["#=qTksvHjYX$oGp$FyZllQe3g=="] = "#=qRcMe0CmpNq0obOYdzXUqZg==",
                    ["#=ql0wFWexnG87I9b31YYNzMA=="] = "#=qWvaRPgrQ9xPsXcx$VaYrHg==",
                    ["#=qCWK4XM6awVdEv9OxfG2zJw=="] = "#=qNOzBGaXsKaHq57_Jm5sJKg==",
                    ["#=qRifZRsdJfaCAA5YhvKSeKQ=="] = "#=qLuPWUtqrNWsYAt$NYy8sxA==",
                    ["#=q8nFG3bb9erD8dTJ483hUVg=="] = "#=q9ZeCYUMGnL6DYGC8yDq3hw==",
                    ["#=qKpKRvCvCdWsE7RzVLWJ9pg=="] = "#=qBC$_0oKdF9OOuUu0YPoQmQ==",
                    ["#=q6GQjz0$ZIrUsoypma$Km0Z_exgFgNu13F3iy9NzbiAI="] = "#=qFgkNXKeajmNG5Ll3yDbuc_qLapbhDYox5j7HnwW2oLg=",
                    ["#=qjcnIGwXGyljwYjIOsN1JJ4VVW2ZAxuBGQHEVmoFam1g="] = "#=qjcnIGwXGyljwYjIOsN1JJ4VVW2ZAxuBGQHEVmoFam1g=",
                    ["#=qbNJsGtqj3AHpfH38UKLdPxz3xSOeQkNigUDMir8RhPI="] = "#=qYyt6HPxzVpFvBqt5Vl895qIMx9zIh1m_j5Zbt1kGwpg=",
                    ["#=qkAgzfJFsflyZkUT8pg_akjfyp7XoXt_cNYzwMIe12Dc="] = "#=qCMGE6ElIVhoJhxxb2qxWEPA$0uT7fEcppfXFFzgnN7A=",
                    ["#=qQRL3uBCBiFBIx6Uqrvq_NMuohuGguKRrQNIT$U63CPM="] = "#=q6wwhNw1iurq6IxxOkL2c_6Iq97YRCcixCw_CgOFUkXk="
                }
            },
            ["#=qMmXkqTv1izBg_QKs8cuUurHD3LB4ZAM2TOR84PtL2f0="] = new TypeMapping()
            {
                typeName = "#=qOpN1WfqM044htDhwU07PR$o0G_gTdGmLCy42jNvaMho=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZmHxJPMgQG9ptB8z$RM9DA=="] = "#=qVjeA4QH3fKc0Z86Txzxf1Q==",
                    ["#=qgBd2E1mOBWrCZrat8JQTkA=="] = "#=q2BXL8nfNZUQn1f_E6QMa4Q==",
                    ["#=qxbM5v6UQ4_BOqTb3ML6meQ=="] = "#=qWzWxzWMMKqiiQ3vWR70uqw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q3QfZ7gXT5sh33LlpQEfgo2JsiajzXYARZ6v68esowGw="] = "#=qrBOa89qELB4TVU0Vc46U$tiXZKpQ9_zDSb2lf3m6qVs=",
                    ["#=qUlRcP6f8V7wFjrjryxzs5A=="] = "#=qkpfkVnki_YTiMLM0KgoVgw==",
                    ["#=qSlhQ$wdEy$PmcvaOMn7QA$seXXSJPFMKtDYwpnsLLSM="] = "#=qTxF5bJxWE6JcFiTY9239J67MeKVwbprymEuwFSfJVF8=",
                    ["#=qKML29Z$$PwKl2koJsiMc$C7gwhjkNZrBKQIRh4o2uSs="] = "#=qZbbth_iD$Q$YpQrufy8kkFBJMYCTNYoWfAYaQP6tMVc="
                }
            },
            ["#=qmn0clb2Q$H7x9gDdzvrg69DvbFqsgbftsqWciesZ4pY="] = new TypeMapping()
            {
                typeName = "#=qScJAxpvOj3hc8swYDh8HSmTOR$P1t7qaqYDegmRDWNc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qQhhwHudm9UVq8DE$jpZkwbXn6kLjtZGuVJtgizh1R6Q="] = "#=q9tJam0N_5DdtkbGkPCGo0ek9vclV9qXW4zJYaCGuyKI=",
                    ["#=qTbaCI5$N5$u0O7vmqn2_wA=="] = "#=qpKZwlEsTey9CE8QElJxCKw==",
                    ["#=qPMsvtgOgkNy8Q5RtiaR9Yg=="] = "#=qbiOU6b21k64P5HgNHxqWmw==",
                    ["#=qn_EQ2kDGkRAUhTZlI8NEGg=="] = "#=qWbHSjexBtnlSUlvI$h8atQ==",
                    ["#=qykKjnw$NOXLM$a5YEIaUuQ=="] = "#=q$j$YIm3wwS4Q_yxVyOGuNw==",
                    ["#=qpywLkgHNMQECUn8YVwoAxA=="] = "#=qItsfKIuucP7sSzdLH4v_Bw==",
                    ["#=qLO2zaDrbS3raUmE3JnopYA=="] = "#=q4AIJEJhI44dTGLJ_ePAypA==",
                    ["#=qiETpxDGVhmX8dQ4s3J$f1g=="] = "#=qudZ_ZrJPxxehAWXISXZzvw==",
                    ["#=qogd1R5vflE2jifXi$7TCKg=="] = "#=qjK_eUKE7bmmZKLGR_97$hA==",
                    ["#=q$lOvrMbxSjjos9kfmYAu_g=="] = "#=q4LSuUHOHjVyEPopmxlAjrg==",
                    ["#=qWZjOS81BuOs2338OzSvCPA=="] = "#=qKTgNqNQEFTbb_Eh378FS5Q==",
                    ["#=qWPVB63hNwKy8AzGun9zhkw=="] = "#=qRkk_fxlUkpVBhiD1XB5sAw==",
                    ["#=qPWaAS1fvwyjBbm6rjXbgUA=="] = "#=qOfFp99MtYBRKZSgkDPP35g==",
                    ["#=qN4Vj5uvhtXHh1e6Amugp0YF25ErQCMrW7dssJpXVYsw="] = "#=qH5En0eAlVq2reIqQblts9m3ydI$YjpK1Kwe_LcXioeE=",
                    ["#=qpBOz7sUDYFWFl6uAwFsIrg=="] = "#=qgNmMXtaG2HxZbNEYjI1I$A==",
                    ["#=qpyxofguOh4gZIEkeF_NhmsXpvhu40qnSli6yiw$65Wc="] = "#=qt2j1HAUp1bQGYnXRajZRjVcbctBX9aAyYcHCmVqkesk=",
                    ["#=qHZcdvAFn_8tENB1rYFg0lQ=="] = "#=qZMp33YZYLqzE_DeWhqYYLw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q1uNERjWdjCXRKD29OtrCEQ=="] = "#=qzwMT6xWaV8Q8wo9nubTiIg==",
                    ["#=qlvexP3IDuD$GuJiLRGYKQw=="] = "#=q52CbgCInr6G$u2zIZft9gw==",
                    ["#=qJxfIMD0_IUsIlBlV31Q0ZByRhpe1EzPVY4BXN43o7xI="] = "#=qgIU6SU3qq6n5Juc8qPKnYq1NxJ2btgY09Nms2b8bt9c=",
                    ["#=qo$7TGLmprpdEyqIJD3Ad5orrEFszjqUOxzJpZVgfmMM="] = "#=q1y6xZqeTiTTwjfitI_1ZK0iFjZcEbiMo3LMLkh5u3yY=",
                    ["#=qmMwS3jW9X5XVwiTKRcud3Q=="] = "#=qJK1QOj0_mcKnLDkd40nJnw==",
                    ["#=q5cqJP6HnTIePBYlJNJvtcw=="] = "#=qat6_TCvm6AcZUvSkcJ5Leg==",
                    ["#=q7Ma9$y5pWH_jBGkgu4pCcWD0yIKrbk$J6zEUi6ZLRS4="] = "#=qz8OXe454GJ1f3fkmycR$ydypHVW8HptOkXJ2ZUJkJRU=",
                    ["#=qBMzTjkwaS2TKHoEvv05xbFPB30aY0QXEk8ufBcxKvNU="] = "#=qXC9EWxMZajCyNuTdVStXPU$21lLn5tPGE4nf0NWf004=",
                    ["#=qCoodQ6zeH8kYt9$OSwT51g=="] = "#=qPFC3WlIFEmdLgK6uIR1_Xw==",
                    ["#=qRe99k6TTmyyRhcweePE8Pg=="] = "#=q4tHjlOHs1yG2AJTDxyTy8A==",
                    ["#=q6Rt_BBreTivWqf7fr1bQPA=="] = "#=q5IpKuGlEbQWyUB2ZSzCBAQ==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qZRlm3BRILjvczh0cfk4Snw=="] = "#=q0_nWO3edU6_OlepYnqGiPQ==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qMp6I3VO3byRy4VKVHyKFjCc_N8xZDHhwW9jfTlGHjxboQMIbpkYyzk7o4Z7rfoaV"] = new TypeMapping()
            {
                typeName = "#=q9Iw59ZeGfUbv86UCY0780hdQOO9zV7vn3y1AqA5wqfF0fVnaTGTuhOzCL_V$Lg30",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qFIp9xGRUddYRmEfPKTEiag=="] = "#=q$uHLI2MW9Mwu7Pa5vIoNuA==",
                    ["#=qKibhv3bYc$nUBwNtlaUNcQ=="] = "#=qzc9UngliNjGRKe1temncOQ==",
                    ["#=qM1aMlg15irVX4YJLKmYawDHehXn3uSsA6Y0jFDYG7ug="] = "#=qeOqXkR8eB$AYdAFteY3yNKsGp20wyNR15tdD3_XGKeM=",
                    ["#=qIImB76rjB43Gu9z2Xfw6zA4FpvTsOvT2M3jpZP23qzM="] = "#=qHdZQVySOvo7G0WtrhP8pJipEOFzIP5cxTmqcsrfZ$Bg=",
                    ["#=qicyVVJpljYzy2xaXAHHnzhJr7Oa1p0BLMxlE6BwTcE4="] = "#=qJbiXd_DREl$AwjGKbebiTqVWd1FYL3mx$$fC29Wh8LI="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qBeo5jFOnY4uMnasU_WpsX76EUo5Kr$jNsm3fT9hzceA="] = "#=qgZKU7p1GVTM4HIAbtSOLVeQxJlWAE$xlixFVeCUOA_Y=",
                    ["#=q$4gYhg$Mf$PUUeL2sMyo5lU$eQOVdnR2q0oEWpH61jc="] = "#=q$4gYhg$Mf$PUUeL2sMyo5lU$eQOVdnR2q0oEWpH61jc=",
                    ["#=qe1Cyhijvwu9uuSBrpZbYUQ=="] = "#=qzE0gqy$8rYZTC5$LC4k$Rw==",
                    ["#=qrMJpz2p8ohW6fXWlTRkkhxtCvzCjc2VwG18QCYAwS$E="] = "#=qwpmbcz4FZoj5qVcfODTNayk7W1E9ffBt5FVs2tBKKJ8=",
                    ["#=q_kI06BiYRy$Jj29Nqq62uRKd7IJo5ii01OgnwWPA3uk="] = "#=qIsWtHa6z5vjnqtZm5tmpvik0vuEoghZgaoP18tzhZmg=",
                    ["#=qLNmQ4Sm6$qFXumtPEVF$JQ=="] = "#=qpWM_1tB6k$2KgeyYRVN_Eg==",
                    ["#=qtvKH9xXH6grylZotEmle4oSyKfDToN1GY4WmR0cSlIM="] = "#=qF35p0uzGxYdvlvaUV4rgd9R_8AkerD3kvsBHFYKm6Bs=",
                    ["#=qkKXc1_jqhEl5meKwKeaShN5KuruM8_YXNejcxjx2iCM="] = "#=qY9S7DqwjnznhudT4aNIMQnX3FSzIyeTi5RvRH5$Swrs=",
                    ["#=qb8QeP8I7mviv5aK1RaDTJojdujMN0cT1AnUxjlvFyRE="] = "#=q5njE$RmNyA8ZaIul84diiWxk7B7RBuGHfEe5Wjcld24=",
                    ["#=qYfxDBpXJZYE5d48VFVA7k_NZBsWJzBg5X51LiD$0Wc8="] = "#=qJIas5vn6xvkRbyHCL17i4JOg8vCWetlfkd2rmK_Iz5k=",
                    ["#=qvLvYPFICRn7BpfLT6r7W4TVB$pcX_6tcVr7RehyqrgU="] = "#=q56KJF7d2Iszmb_8O994iEX3wNcdYdRPnQeC99xg8d8Q=",
                    ["#=qs7KVuVn4eDGJuj$nLXUdvQ=="] = "#=qburdtPuT12O77OBfcw68qg==",
                    ["#=qWMKAgKEv41VdfJz4DW5scNkkrmdFSknhTyED599Q6kU="] = "#=qynk1Puo8RJUY6QwSDWU4G5SdINIibKbtmAGd_eaMCew=",
                    ["#=qDSCPMc7x2$$kY2foPb65J40pUC9J5a$$vx__E35k5rw="] = "#=q8AR7jxaN3HgfgxIexhhebkTo4a0OwXWFXyOaao12V0w=",
                    ["#=qOszZehGLXJcgAFp6ctJSHT4rxpx9G0MT0ItdPUM6UhQ="] = "#=q6Kl5hu89QycJFV6dqAlzxlL4xf4NMy8aoRZ2E_gQ7Rc=",
                    ["#=qZKGK_ZQ7OhZH1x4zwm3vHLMztE5eXM3ifUi$fKaS13Q="] = "#=qHrqE23m1aLrXd02$24buAQi3zYr47$7j5KJkScTY4nc=",
                    ["#=qqv3kuKGjUm1f2lvNsW1$SsZNXUiTdr5PaLrB3Br8DBE="] = "#=qNHOcAN5Km8YR2EaWyKcx4LhdP7q_U8oqYql6Qs4$9TE=",
                    ["#=qS3WgpslWkkV98cupI_oEvZH6voU_jST1t6wXRI1Iln8="] = "#=q8bV9q27vF9sOPDCgjPxS9YdAd4nTPxJuQDQSOw_zW0A=",
                    ["#=q38IPeGyFagYKwJ0GXO08nGZui2WCQ1QvJE_3Uz9enRI="] = "#=qsjEc261Z94_gmzNmlESBMnCKAYQCeV7SemmaxvLheZE=",
                    ["#=qHSQ9806xPyuh_SLBmYbBOQ6BCzdUwwvtZ$COOy3zOYk="] = "#=qqXGM4hw8vAXkYp$zEWGw8UsezCaepiUtnMGYSe6fnMk=",
                    ["#=qfq8pqUzFhAjwqgIpo9ExmKEdpHdEXiAsiQM$4lj5Qg8="] = "#=qKeCPDpd5T3uNcaEijPRLYWAHJ8GjlY3bIXhc4AAHRlA=",
                    ["#=q9tLdaOtIIdkuKrADhRQjL_X7DBambLNEa8x3XY2WPdI="] = "#=qHjP94cQrpkZ7EXuc53pWjfFpXy8VHA060KULQxoomWw=",
                    ["#=qNIMK6Vw7DtwPFHFNA2TTC_WOoGJv21mnwRTDPSZzTis="] = "#=qN330mdfcYoldyM8S$sNj6ZcJEiIXthhMGLPXrXGmIX0=",
                    ["#=qU0eB5impjvwt$9RVp5OKcxstAfBUt0VVnGg2Jhcbiso="] = "#=qmcLliGNaWaqhCdQq0iSCaBVHKPYnQK9t8bawGkXsok8=",
                    ["#=qWFAFeF3CkKOgn$ze7wF3mAXyimizQCpeKAKfVFhJ$oo="] = "#=qnTk1CjvMTW9wTZlNy1mbS0LW_VAdmRT2ET8ugmubuVc=",
                    ["#=qI1v2L$AucD5XvALeSpbF8eoXOKE$uOZEwb2kcZLdo8o="] = "#=qbeLea2eFE49n3NDB60QAAidLSHrimuDcnud1o_zz$Is=",
                    ["#=q2XVmlK8K0EM1Ow5gEYQ98l2tsEqD2s0GSfLUPZv42zU="] = "#=qfqCDJboCpwBrzUi4Bxw0JAleBJcW6PwSompajvyylgE=",
                    ["#=qf3hHlcah72qo$n0yRMkVrQ=="] = "#=qF5rh42xOCnPYi3OCYBtiyg==",
                    ["#=qw5Y3RtS2hNsdW6kLOK9nNoDmX$NvVX1t2yWgNcOEYh4="] = "#=quPNs5DsOA7crbmuLdG9a3d4jNsN3uC2_J_1OMKOJaP8=",
                    ["#=qXMLX3xg1TUm4PaxQpvTpuA=="] = "#=qTDsQraJhlRyFFvpdW85DCQ==",
                    ["#=qEjRQvvCFt83MNStnrURGDg=="] = "#=qvTqxlLGCM0qTzIT0riAotQ==",
                    ["#=qQfYl_o81aOU2tr1D_SvpbztpTNsvOWp5IUMvBBhFRJE="] = "#=q0wh41slHMVIYkx_x6l8MKq9F0hVTukCIXTB$wiOadCA=",
                    ["#=q2LCx52ZqdII2E09B6ht25gM$VQVRks95ZqmPnMwZ2Cs="] = "#=qEIlRA0wZ6ZOkDGUamNTcVcxaPgGP19du3Lazogl8XbA=",
                    ["#=qrY_dH$_v9QycAbRXguW88Eez0B1Jw91SSkdLViS5Qu4="] = "#=qm7SwxxltQCL5EDuH0xUb_EP5F4wGwlY3wO9l8al22tM=",
                    ["#=qZlrn_IKQVrf3wejHR61aSNhqog5kiOf_nPZW$H6x3IE="] = "#=qp2GSGDbr0LpkNKJ$IBhexIOamBDwTGKodDv0vXEwhcc=",
                    ["#=qqg8MjUTTDWY_z0gjqdlUDDvCfgQ_b6MBE66YvqVI1FU="] = "#=q8rQGW2WUiBydnm6TE5EWDhiGvEeM3vFkgqvKF1PvqbA=",
                    ["#=q27qWCGN6R6WiAG_76NvdyPPUOEMtOluDT2CzVoTKgKw="] = "#=qIfn1362OCUxFBeKl8shypjZraZIWNXkq_hncTNPaxec=",
                    ["#=qrJNgMqU_yLH5wtG$k2Sun7ZjmO7E7ly5KQWHok9IkVaIy3OpyHDUNUduZYn6lgOw"] = "#=qh4AwmJ$I_We1sqT4nafdXMBcoBWFIAR6GLwroq_OnoOARb5RoPLUKIOJSfeFPHAi",
                    ["#=qlK7jJ3MZxYTyboR0S2y5qVvrl1WUgfTp$pkP4WsJm1FCl0OLODePwblgVw$ciETn"] = "#=qtYnmRRdqNLHLlcdAvEAitOWWw5Lg_UiIXsjh_fMGvB06RuE1vgTNoNcxVPuYhQgJ",
                    ["#=q12KyJmvBMeF3Q1W6VQWdckbKqhx_OwxVylLW_zmeRnLzvqwaPj5WG5G3ukTDUyaV"] = "#=q9T2vo2KTZE3ylTzybcJh_RAPJ5ZoxixUN5dNUvDS_Iy1zTCrL1Higm$tIF5WRrgu",
                    ["#=qTvQQbVOJ5gg40PN7CWyGA$rLDvaaJfSXVdtpxgSJ1vPCjQfStDkQZx7sqDepzbpX"] = "#=q0gsaX1tGCG7iN13GWP8T6sYjDbsMFuJM4JDBBtiGLEYdnQT_ycJL6GawZ3ZdG6Ke",
                    ["#=qCGEmX3M$_ncrP$rk_UXDYMHmmUmZA_WtFYLea7tOgAX6Rqtcwfeo4n4SXAJmPzOt"] = "#=qjKZZKMk$p7ZMYSn0oohU8bWRS5HD_XlQJbWPKfzM6M_R6vfxsrGemCUD9yVDw7o7",
                    ["#=q3xSgJBbr4WEn7BmCHZuin$jMI2m1olJrmi5sHnDn$z0="] = "#=qu71HLwdxJilwnnCJ6m56cJ6Ewl2y3m9RVHrRL4t0WiY=",
                    ["#=qmEkLzI2hKoBGV3ORJTOPVcKeL0cvUmtomdO_KrT274I="] = "#=qbxAbIffyl4oJC7ue0HeqU8UFUDcBvujYijP_aaHWhiY="
                }
            },
            ["#=qMp6I3VO3byRy4VKVHyKFjMMYkpty0g5eke32AgvHxKcvkL_rsXVwGvLYJlqGcFYk"] = new TypeMapping()
            {
                typeName = "#=q7udX6SM_4u7Sl6hOHR2XfUlPzrGovjUUaZ_ichmHOqIjRBtFILaTVEdSgzXPJa8U",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qQlr_00bfZrtI$Zvxi2mZ7HwuPAlS0S9Ypz3VwaO8uHI="] = "#=qGfXyLHNJNPMUGfclbztMgt5xN176s3rQdyy_ZPHIrM8="
                }
            },
            ["#=qMqo7cnLNu8_aM4Ije$gk71jpBvWAxjVllHyxNWGUyjo="] = new TypeMapping()
            {
                typeName = "#=qiisc154Riwo69HcwLUlHYC4QZTNX_KYWp2AD1rlpj8w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qJjlGEuxhJuBihEPxSek5eQ=="] = "#=qlt$I7yO_tOfmJwcUJoyHOg==",
                    ["#=qX3uaSytm29iBG9Tdo5xJMg=="] = "#=qcsv_zMEqWP6MihRs51W8iw==",
                    ["#=qGU29UxLNJdOcfsQm39NIbA=="] = "#=qEMhH$1j8wYVxA2HKhTb$pA==",
                    ["#=qKK7UGwQvV82PZ1VXALRn$g=="] = "#=qH39zh52nb8sVTZFQJ4Jq3Q==",
                    ["#=qWbxIBB5Ba6Bv6CFM9UK5cEX8KMRt6rnfRFsqewFag9E="] = "#=qm_bRmbUscbys_1z2S2paNpr1olitjjvcSr9LZPPhRbk=",
                    ["#=qTGABSl9jvU2OVLqFSqEiJQ=="] = "#=qLp0vPxmnHCsUJIoTuQMgAQ==",
                    ["#=qSh8Ywp4qmlsSRHY6nsbQNw=="] = "#=qUtZ5Pgi92RopRT0$6ZMYEw==",
                    ["#=qYqE45_Yuox5TNxakMk_mHQ=="] = "#=qyUjakkjfrPpPuxgLRcr_qA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q8B6f_0e9JuTJ7fp2nAbwfg=="] = "#=qYGoYcJXZrJxJsmRY5b7BsA==",
                    ["#=qGt21o891ZpybmzlEjztGV7T106j5kghfBl0ywi5OWzw="] = "#=qsE5GF1gWohosVQ3gqhjyzY_C7BBdhGVp$MJ1EXfd4gM=",
                    ["#=qeMyOoHbm9vTI2w2iFM6$Aw=="] = "#=qyXHS2cbgPqiIMcCWitnkkA==",
                    ["#=qp3k0YIufQZLCZsreSgJwbQ=="] = "#=qEVVK1tQ$2i2lntx55Jra3w==",
                    ["#=qTnn0$yr0CCXWPlqMhMqhXw=="] = "#=q90ZLYubh79U3N$bR6470ug==",
                    ["#=qnTkhzeVF1xsvIqTuFuAkjg=="] = "#=qHbwFlCjSuyaki7WFzpwHPg==",
                    ["#=qNh9DNXIgo8jUG_hHN3Fcew=="] = "#=q7EbgsFshr6tTqwMUux2czg==",
                    ["#=qTyrO4S8tB4BGz02DU70O2Q=="] = "#=qyPr$UG3FadW1$Q3QAvsUNA==",
                    ["#=qt6b4wJcoiNJx0IYlnm9rSQ=="] = "#=qoX7nGWf8vBlmyJW0o7KfOA==",
                    ["#=qR8CxkbqlFQhk94c4xdgTMQ=="] = "#=qgAo7Q4vysjEfqD8wJLxhqA==",
                    ["#=q4NSojn_9bTMFy0zW_rbIYw=="] = "#=q6yoYkCGPO31NG1HKs$PWeQ==",
                    ["#=qftUKzbFeG6ofcSvu3P_oHQ=="] = "#=qsPjiKt9wlZDWFZp00$EyWg=="
                }
            },
            ["#=qmRKruzdPDMsXNhEp62qMReG6mf4FO6qI_QHkxfiyNk5F01P8jqqy6oBWleFKbp0z"] = new TypeMapping()
            {
                typeName = "#=q8nYsmjBm_ZpBKmtDs70PfaghhOoExYNMf_sgkthtcVHM2D8DPsgoa4V8T$3BUhJn",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmCqsaTv15JTKVZXB8G$xIA=="] = "#=qncdImNz5pzYMOfBfwkejFg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ=="
                }
            },
            ["#=qMSBwYGZ4oLA2aVGmeCL3ztm_tXRtuUplb1ZZ22DXAzk="] = new TypeMapping()
            {
                typeName = "#=qrhm9S7UIz930T19QqQVnSFYxWm5VHAteYdcLriOBwrI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkF01AA2ygIcyfIWNfH1WRg=="] = "#=qmuS3Aax$clYu5BlDPoefkg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qWQ9C0v0CMfaKLpfVOwAEcsGaSiQ732A3IT1eHEXrZS4="] = "#=q5QByaQ9eaDDFQESvs2qSqTTu4GHFpiRf9iQiK9wqGfM=",
                    ["#=q8kg$50nClUavq_$fKKmn$w=="] = "#=qry0wFggV$HskWRGeUg7cYg==",
                    ["#=qT8pit2Kr_rfHZfil8KHUZw=="] = "#=qn9f5WYgTHxu42cgXSi2J2g=="
                }
            },
            ["#=qmTQ5C7ED9qYXf50N6ZBWy4cQ0bi6Ozf1Q2fOa1Oh8MDL3LE9y1hvPlGm63CCXYM3"] = new TypeMapping()
            {
                typeName = "#=ql$ya8BKDrLv7ej7aZEstH1fSo2YKpUPTl7HBbojZGMyjoicVXqXPEwwjSm1OPuQa",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q1VY1MvERzgo$gO1azv1qvw=="] = "#=qNZGubILWliY3jCKKqv8PYg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qM0Cd_1Gw7LPFGFMid$_l5XICgPzA5qEoIkiCc7NsNCE="] = "#=qLK9ey$IWR9dYJ_uvm4H_DmpaLaMGZAsDwQvVF6Fc7Fo=",
                    ["#=q3862EKGWhMeY$qINMZYqNr$m1jeaNO2uNiMxCJbn_$c="] = "#=qN1CSJsRJ1pXxXGgrIz2vWUF9_kwKd3RQ6FOQnXZ_zUg=",
                    ["#=qaP2Jcqw4OKYLUxtpOpGtRw=="] = "#=q3lW_Hf8A_vKfurelKPRt3Q=="
                }
            },
            ["#=qMu2waAux6$KgQ6De2hxoTVj7p5ckd008TMvvCM$$Zgw="] = new TypeMapping()
            {
                typeName = "#=quRrJsFYKo9FuUzSWojFas6471oO5n731COtXy28Zpu8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q82Or7QbNgSMB0zB_AFEfiA=="] = "#=q14vKvOZXBh9M1g6Vj9FAcQ==",
                    ["#=q$5dhT0e4N0xfadwmxxNxag=="] = "#=qsULVQEkT3JDt03OqTYd2Kw==",
                    ["#=q4YFSZVb2sVMCqBrf8$aOrw=="] = "#=quOipHlNTFdoD_hpCH3ghhA==",
                    ["#=q1QqU2AlppB0zMv5hzhbmwg=="] = "#=qaE$GxmYft2fd$byv5Aqnog==",
                    ["#=qJObvso9g_b1R4xT3hq5Zyw=="] = "#=qNQbf4Sfwow48Iu7CgIWq1w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qMX6$iZBEiHwFQYvb_MY_iHn1Bq8Fd_wO8vCm_2VcKZNWBSf2cqQp5yay4vDkW4j7"] = new TypeMapping()
            {
                typeName = "#=qBPFbZnskOuozEH52Y552$xKZOmkmCdU_mQunmqtNf5CxheIzR2ZsmtxBPu75ssUQ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qMXVoNCZYbLkp1W7u5d4XKrK_uP2$QC2eABL6IjiXA4A="] = new TypeMapping()
            {
                typeName = "#=qcRVbmNHelUwuWvFxa7D7uwP1cM$5Sg3BOdV6Kon7AS0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qPyItGJeXEVasPUtH0hdfx1yMrhEqps79hEjcKzqZ2ac="] = "#=q$4nq$ecwTnisOatpjjFWS_rSZmMXV8$_nKpsrW45CgE=",
                    ["#=qJ7koZ9NzbBNrXMNX7mbxHg=="] = "#=qVL7hwsOGwuE6oErYtSBKvQ==",
                    ["#=qe1ilOX0gJ4gHDQ8IM1FwsA=="] = "#=q2pgYvUs5sIIThAmETtAUBQ==",
                    ["#=qefU3vLBtYYRI0Te6ty2arg99Z081SP$$B4G$x6M_6pU="] = "#=qHFTsejQO6gX_K$nXNDWyMsFLpbrXNYCHDybYUZ7WD$M="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qqudsU3fsoiOmFVJtl1_I5g=="] = "#=qgqHcjR8rivzIjvZaIO2$eQ==",
                    ["#=q4uXOLgOBW8G1Pc3iedWvnA=="] = "#=q1WFFCXN5qWVkJQesmMFUOw==",
                    ["#=qL_2oD4sol5KsB7jNGZhXkQ=="] = "#=qMKDIjtrzzRykwcF5e42Jcg==",
                    ["#=q1IR_ExRB6z2yGIUO17RmhQ=="] = "#=qCnXwscVyM6fecvohHT_8Ag==",
                    ["#=qpHN0cMVjDWCc9HojFwhLqwPXUSRijVei9Ji7KBQKHok="] = "#=qC_9dhQFXxMlpwJ_F1LGDOKYukthwQmxNsNYx8fohu1U="
                }
            },
            ["#=qmYbaTK$qDSiMDRUe5TH7t4n4sXnPoqcIBAtkOsSPhR8="] = new TypeMapping()
            {
                typeName = "#=qRP6D0MbT6M1jVQq17JJg$AWCBUdDF63IcrtttV6rQGA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSrCZE2fAlKqRl0p1MX6_Gg=="] = "#=q4AKPew1AT$ot3fFAGYSGrA==",
                    ["#=q6RGgLuUOFT6My8QzEUOc3w=="] = "#=q9MtPShNqtkXRuyhh5URWmw==",
                    ["#=qNlt3wxwmjko9S5CtwXWVNA=="] = "#=qNG6crvYSDqOHiT$1cXT_rA==",
                    ["#=qPUzS8YLi6waJ6agVebzwpenkwJWZJZtyLjxTs_DDzKc="] = "#=qQdt_KvScuWv67l0lbSBHIHNxN20AwUB82qYZHbOWzTA=",
                    ["#=qi4GVWyRA81_9rSbY3jCc5g=="] = "#=quWvywtdw1z0WOKpSkitc9Q==",
                    ["#=qHd9FRQkwGK9JG8rbRxNOf54clqHbpDHPzMGGBud6F5c="] = "#=qiXvFk8Nw$g3hdXC60_BvO9pAmZkxUXoBuTQG1dnLl3E="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=q2hfluxH_AsGFO4gTZw2tCA=="] = "#=qSwnaStY$suE3U_SujfHMiQ==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=q1rEi2dev9zLEYWBOG5SAq7P2_wbcPG2vuN8CLxbDoAU="] = "#=quuyJPrrUL3ZML8iXq7GR$xm8I_qJyGirLpqCj7WnJkE=",
                    ["#=qd3k$HWQ3NrX$5pEufjbAiUbhP83hPRpOGfs5Yr6l2Wr4fW4oAD4JhwmYCTacLWCa"] = "#=qcJUgv0iAKW9_6pH0lsbkhlqgp2Gps8XZHbXpLjCMwbL$F8IKYHz8Tz1Krs_Wdslw",
                    ["#=qj4QvilyKPDKh5rzkxc5cVR0CQHjvQdEBebUNswBYEONKCedCEdnwgZuwAB9sP71T"] = "#=qMn7aq4nGx4xIvmyVIhaDbU$SweZjbFbLlp95ArFsch2obkDVDrC57yCf9GqGxt3u",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qN_Tmpfdo8whEjD$2QsHuWg=="] = new TypeMapping()
            {
                typeName = "#=qXcvJm_XddnSyityoyBNbjw==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qY8bi8wRYAIYmurqmMGJw1w=="] = "#=qtPrbNyv_tiAIvauOjZoKLw==",
                    ["#=qIXhdxdRUu82j9vXtPFqD5A=="] = "#=qDnrDqBQuEpRG4tvbHw5a8A==",
                    ["#=qDTFbJbB$vvjcZ8Cq7gpX8VE4Y_p7xHtFfXzvGB9Wkl8="] = "#=qQsy11adM02i8uTpMZND9L74$0JGApOFx3AlkcuVZ8G4=",
                    ["#=q4eJoGl8SKUaZJkZFB1y4hPvhGQh4V6hLITbP_wMCPc8="] = "#=q34zFCVRGalmJDMrddTs_N_Efu8_722V60LqjvJYDgec=",
                    ["#=qG7kBMr8khBfONE$h483fuapMXukVBUK3f6rjgP4Rnu8="] = "#=qawuvLHC6uP$GjinerFBng6hyNMEpLJjeYqevbZU7cZg=",
                    ["#=qKGv1mRnUlXEZubgTOSQa$g=="] = "#=qHqxkwhAKGGdZnGB__ycXMA==",
                    ["#=qwv$9nJ_P9xA5AeCPe2NIOg=="] = "#=q7uf067olh5ZFH$O9tplQWw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qtMLwzqur6LmLTh$4x2XdLg=="] = "#=q7Ly6JQExax5THGa9JfJPGw==",
                    ["#=qNysDSsfLStwCBRxYlmqrC4FMzCn$pFZfrXUYflDjAnk="] = "#=qZuZSyR8L0NjijSg0UjjiZaaRxKAxqsXmQ$b9NdZlLyA=",
                    ["#=qo9dEACgV4WriZvjdlnr2vQ=="] = "#=qLc02TgcN9Ip7hyHVkv2_nw==",
                    ["#=qUG3v9plXcfPWaWxDH3vprA=="] = "#=qSWjwNv_SgUkGaaMEevIFsw==",
                    ["#=qGImDY22chqRe3adnC5p1dQ=="] = "#=qi8Hf7nuBnKyWzz7g4DseGw==",
                    ["Dispose"] = "Dispose",
                    ["#=qTzYXsEyNbd1zsiaYHsuwrw=="] = "#=q3UAWREaes5_ob8c_GAfU5w==",
                    ["#=qL0I5JEaSOCxbEMlqOogWKw=="] = "#=qSCjxknFuOtTzHLvzlOY5eg=="
                }
            },
            ["#=qN5Nb0u3xazqQvF9p59Nw_2zl5hcUw$4BDbYf0f6G5fw="] = new TypeMapping()
            {
                typeName = "#=qW_IvH8Z7nljWyEfxT17NKo8jfiqHursP0Wa26fsISUE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qn7NawKwBC_xLd4ZzKUr3cbXhy_kryCMlvS$YfQN9ehtoCe5cO4z5Y52nRsyMzGBa"] = new TypeMapping()
            {
                typeName = "#=qx90hSH4bmCy$8H6PoZVo$7y9Fai$aEZdWkYC3PLB3MwQUaHszEHEBDgLNs8xTIkG",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qk7iWSbt$Rl1vSTy$i8Ddjg=="] = "#=qHiWTScg1jq61Tyu5IgWV5w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=q$UUmwU4wJmgaAMzXUfyRTPE95kaW_PTEirYpGLQSX_w="] = "#=qv0boCqFlO67ECQcwNe4CsJ1CaHzRlds2T$jTl5lrTGI=",
                    ["#=qVKyhOEguKg9MEyLJMViSXl4ES7ZJ8gZrRwafDU$2TAE="] = "#=ql0Rw$JJqKPwdJaZQZkc80gbAGGUbwFkJ$N7YUJ7CUGg=",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qJXLgK3BxUM9QueB_Cy39pQ=="] = "#=qYsWUtsoq_zTI7cDbMSiJyw=="
                }
            },
            ["#=qn7NawKwBC_xLd4ZzKUr3cTq0MoOZPnofqSWjhj9KgAIDj2Zd96HqVaJCv8KwhTdq"] = new TypeMapping()
            {
                typeName = "#=q7SGKtt8hlQekf5qeuTNigbggCnZWNmuAPOE80lUlxGteYn8b6kp_mXgdJJ2d8H$B",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qN9bFA63uWC3Hvp2pp74o6A=="] = "#=q44hNuoKZHddVcP5zniq4ug=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig="
                }
            },
            ["#=qn7NawKwBC_xLd4ZzKUr3cTzweBT2GcT4two8JIj8CNY="] = new TypeMapping()
            {
                typeName = "#=qkG6uUlRv4NI_D6uj7xCq_I8PU1n74AT6ZGnRxcj8lRM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qs1Rn0ei7Tg1ZzoP8GwwTWQ=="] = "#=q9BCIxJLKoLrgIyNshsqX2Q==",
                    ["#=qfimoQkYz$IzAvdxLP5qgag=="] = "#=qdXQVPYZJzOEkcolYetf6Tw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qn9i58Ph8Ca6JR7Ga57JtL6MKZrSFUp3kp$YhvjhfxmQ="] = new TypeMapping()
            {
                typeName = "#=qrCe5qja_ldQpUtAdaaoDKU0RrHksSntazplvITpKgQA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpjaJAfKdTutx1hSW_AmW$g=="] = "#=qYEw4c422RFHfiWy69P8SAA==",
                    ["#=qeE1di2oLSCyvj$XKwqCW9g=="] = "#=qomVrszECDhmUWXwwjtuByQ==",
                    ["#=qGpKMCValPiGVdP_MfllQog=="] = "#=qs2hcznEfxvhK74kujxXyFA==",
                    ["#=qaskgny8sQWwgjOvSWzCvBA=="] = "#=qyVG91EM9Q6JqAwSL4bwGSA==",
                    ["#=qrswstRYKYagkTgoSH5$SnAYaRNhwSfAzxiJ0rDtPHRo="] = "#=qok8Di2UvT7yQmAxuLA__wZ1EQjeTD9ERrP5jYUFX5r4=",
                    ["#=qplV5DCgzMFbucTrSUuusWQ=="] = "#=qluJcffqf7hiQlGS6XRtAtA==",
                    ["#=qdGjI6g_gzqNHt978VQ7Dkw=="] = "#=qxejp5_B$K2GlLA26x1l$Vw==",
                    ["#=qY7LBE38YoJrKmvxUndgfQpBSKBZos37RRCX65EoB4FM="] = "#=qpFRo4wACDR18GhNCDqBqByKZg3hy$uSYInBZmd3siXA=",
                    ["#=qWJRw2$osGv8iT$ovarzhHw=="] = "#=qJwkwTTd6jh_Vq4NoA1Oiog==",
                    ["#=qdkR1lH0T4jp2eGmr3VlCuw=="] = "#=qWeh2OR5fCAw53lrEsAYB0w==",
                    ["#=qX34hcicDGsnc5TN9IW3JNw=="] = "#=qGiJJTDoj5fO_vquzk6jSsA==",
                    ["#=qsqIJb0MogbD0xb5vDimyjA=="] = "#=q6l9pZxZU$G$8B8c3F$8LyA==",
                    ["#=qVKZx0QP6pDjHTGTdKQD3Vg=="] = "#=qPZ1VUxnKBT0NV1DZyxRRNg==",
                    ["#=qaNJSbdFkOwVHc9YaFQBX2gHSQFVd1lqQNn$r84lzKOw="] = "#=qQ$Rt4Cn5s18KtmPovlyWkWSMj_MtSTBBPchzo$iNKHY=",
                    ["#=qYRqx1RAdCV2OoS5o2NJ6XzbzVgwomhCRqt47SLftC34="] = "#=qnQQUWTbE3RGizBxiRwrcdRYgUrVqlZxEuI36QW5A$fU=",
                    ["#=q_Eix2XvaJGaqRVrdk6zfwd45yPhOeDTiozPtBDlGtHTOzIdaLRq4UctR2fS_Vj3Y"] = "#=qiy50Ef5XVt31DOSLyjtSgnjXSdM6Py5f0713tIilzgrRf5DC$6eLm8luHCzC9vmD"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qMHsXBKS100lNDQhHApJ7I60HGGNP3ZQhEX4MhnifKdw="] = "#=qxqy_5YNEbGNdElFYvz3qAzkhfzyJwsFbe33kIvWdHDI=",
                    ["#=q4RsKU6KlEnUg1FUT3QO_z4bGu7JLAJkGHtBsWPsY$e4="] = "#=q1lYVCmhJg9e6agDD2mhtAykMvpuSEhguyN$QtCssQkA=",
                    ["#=q8FJ9kKOYQrM$eJRzxSTrD6hLGNoGdLaYz38h3Jk3Ozw="] = "#=q3$KjJoGMcdnAg_qrabbN4JpsJBSn7sY51EUVR4RinSg=",
                    ["#=q103w7PGlKVWlE3Br4VM2mIgZl2wzBkMhVOy2fxNyeJ0="] = "#=qRlpS_JHLxHm9G2oasXhKY5J6qJYnxVzbvUGCZLlRHaM=",
                    ["#=q8b$HVTPql9LdQs_yYjt3$V3b4rnnbpGIAh7gL7QC9Eo="] = "#=qJ00q$7lulUGJVmKjadpz80wLN4dJys66SKcF$XApKDU=",
                    ["#=qLWonsSDXjmq50BuFIQR9WVZjbJr3GxgJ$NFvypFcxgk="] = "#=q8oOH9tbLBKE5glNhj1oY$NHRNRn$2WGKHiKjopD6aVw=",
                    ["#=qEbONLj1WiBLO0fQgUZXVIw=="] = "#=qdH$HDFBXghFev$mWj7epVA==",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=q8UpZ2OUCP6NkVPtDk39CtWCusD7Rk0R1JwS4w5Wiw4s="] = "#=qilF0zl3wK2EYaFU9Fewkbx1U5t2x$aaEdb3cbZ$Mp$w=",
                    ["#=qUyf0dS_sy9ahHpDQIPw0$A=="] = "#=qxxy4eVyodLcDtdOgB8xpyw==",
                    ["#=q9N7aqSfUdG3A9nvFXwOI1A=="] = "#=q8NmbbiAd7WJ9lQe$Mhbv$w==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=qIyHuGzbWIzJ2Rb$H61OMwg=="] = "#=qnMOaM9qlH96hZxd9sQb5zA==",
                    ["#=qHqSl8jLPzLjf_$rRhxfNmHL6VS6ogbqrrymneE8PiAE="] = "#=q_WEOtLjVBGbk2Nq7RFog2v1FFLEwY3MbGGOj3VzmpPo="
                }
            },
            ["#=qnawFw3A2XmwyefntKVsusVIvSKxQ47apE$QBIYEbZfFBWSZGYDdkebhGchC2Sc8O"] = new TypeMapping()
            {
                typeName = "#=q4T$tnVlZA9GOX5u6g_MK_NWAgMh8bf73JuwzlriRVz9bRu4iyM4q_3JqMCPhJGsy",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qNi9kaZpFXNoER$yBlyaYPA=="] = "#=q2OrPJZ1TWgG20KMiTuEu4A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg=="
                }
            },
            ["#=qNBLhZFelnnEPOZwFnrVBdSEfwfKWRQGL9hq8XK2wQYlK7hkTUu4iAho6EpVD3XpJ"] = new TypeMapping()
            {
                typeName = "#=q$yeRSLoADBnb5TrW9HpuJVpQKzq6VCXt1cvh95DTodes30YOhBSwoxkdlnVAel4G",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsDTupKgENzJ$5NrQSPOwPA=="] = "#=qyGWBaopqLal8LyD_x6Yszg==",
                    ["#=qsTZ6AOh4aeQlT0dbsW69Ag=="] = "#=qTf9cPrRXzhmxynhTZ2UQkg==",
                    ["#=qC3IBoGFpawMEMdG3LHbKZTEge1Q207a9NMSyCbXi$FE="] = "#=qYtZWmzRhr$aKQOd395yFsOUTC8QXuVGiUbddiibQaDg=",
                    ["#=qHZG_uC89$OTjdqNPFRvkNQ=="] = "#=q_2te7aR5P6ldbWygQuKFYw==",
                    ["#=qYt_5pe$vVoGJzFZYRCfPng=="] = "#=qP2gJgNpawfvNn8q1b3Zkpw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qZYpZEVBovj9m8UEzCydXbds9d_GznU_K$IodeYLCbyg="] = "#=q_tSTbbDe7V__Et1c04ADU8rOo5M25AaTVR4VCvNxVOw=",
                    ["#=q_dN1RZkKgoa67lzcXM_EaORzv7UxxZV_wo638T8NHaU="] = "#=qD5cyNc3qWCX7xWEi15lA0JWJ$v$8Wr19nr9_GFirXvs=",
                    ["#=qKnLj7D7xTk8BPbn16I47qw=="] = "#=qELYPz8nmyAsJ390xVVmxig=="
                }
            },
            ["#=qnDUrkRtnp5LJ66Ox9C$vGF0yjw1M$9CDjSwj_5f8S3Y8vOItd9xR5XUwMePzUj_v"] = new TypeMapping()
            {
                typeName = "#=q5qZ3hMgYMXSHEEOkEEprWTJhhdoU00ALcS8w$aQXeGU5Sm4T6Q7uGnpawFZ9QY2k",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qx5qniTx3WdsAOMOLE2mBZg=="] = "#=qOngPCp9TGawbr1Q0YvdwWA==",
                    ["#=qatVLUP31LehIN2DsgSJ1ABVrc3Qt2PYngIxfK0oz22U="] = "#=q4Jcx9plkR8zjD$i_Iql5DZuDV3V6YDHot6$6zgXvwJQ="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qt0$tSRmkwV6yefhSQcYYag=="] = "#=qlI9vg8PrFtyC0Npgg9lGuw==",
                    ["#=qcMnfSvSXxhW7_a5_PH0Aowho2T92bRVPfFLadk45pqM="] = "#=q4aVndYj82z8t2r0lXXE2wDxwM1eMkETT$wcFl05HeJc=",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=q94PeHam9imUQjNoI1aM9jQ=="] = "#=qHvR5OcNk0V5VhO42AkWG_A==",
                    ["#=qlC6rGPj$8hjqmHUsKmHGMQ=="] = "#=qMfvdB5J_JF$OKSXAgXeOaQ=="
                }
            },
            ["#=qNEPnt7Fm0ssiAZKEH00HH98inldorfJg4AoHAUqWHZo="] = new TypeMapping()
            {
                typeName = "#=qXxAme$IeD2vtHMpzCBGq6L8GHrF5J1BJOFJF4V0AtH4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qG8nBUEYyGir$SynT6f2R9A=="] = "#=qGn8HlV3vOfz5dW$lj7EDjQ==",
                    ["#=qjkU830SLw7jsPYROMoy6hA=="] = "#=qDzHVYo9W1aktezsSwq1asg==",
                    ["#=qkltQuMQKL6Hhe_UbzIUpvA=="] = "#=qYSo0oPg09xsUJLFAjXEEGg==",
                    ["#=qdRQP4wmErGErZaZnew0RWQ=="] = "#=qUTXkWXDlqOCtEpxwBZWL4A=="
                }
            },
            ["#=qnFMGpkArdB9jalotUoz$cS9Gc24K1gZi7A10tYafGS3gLFRZiH3iZ7cy6TOXXHVk"] = new TypeMapping()
            {
                typeName = "#=qeTGRa9sPzGd1vu_F8thohdhy7WizexUh6xtSl7L12NM2VzN5hvCr$69Ca2m2wXzG",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qyIN0E3_Cy7hJYuYpTZuFM2RWvr7DCZBT3GbiUpADtkc="] = "#=qnC_2XYaojuB8g$_kcy29an_r7ySvMuloOFt60uHDDS8=",
                    ["#=qBSCh4$DCQ948IaTBL1oTL1EX$kIe0m1uZdgVkTpPXtU="] = "#=qoYnBX6yjHpf$7nI8uYgGwYq0qm97KiGbEL0UnWoqyCw=",
                    ["#=qOzmHhP3MGBubBd68QqoXEtJNBMkWfeL_a7ADSUFWNjA="] = "#=qNF9Mc9NO5fiDf0zK8tUyvNbDy7inxlYJ0YitR6_G$Yw=",
                    ["#=qLlOvvMgDKVgi9X3ZJkCjaQ=="] = "#=quH3rWzbKAzLJspMkfRFa4w==",
                    ["#=qPGYrrdArOsOUAdCPtC$kpg=="] = "#=qrc8UR9dHimTL0B5$XPztlw==",
                    ["#=qY_78KGgCQHlQ$Emp13M_Zw=="] = "#=qhUSbGCY2_3tR58HazoMb1g==",
                    ["#=qKO6aKZLTI9DzANggiY213A=="] = "#=q7B1B3fah7lFMaxjkKcfRiw==",
                    ["#=qJY67TAg2XmI8PdCK_VY9uCkKrapyjscEbEp3f4tChRJwCbF5wmhJV1ia9ONygmtJ"] = "#=qsrgaFLuO1LZvnkQzW1vxIVpTWc_VVhh5TAxvnrmepg5HMIgMjowRSzYmn_BzwUNr",
                    ["#=qaNnK66AGcDyEINxX6C_wTAqSnC_drL$0AHmXZsyh3defmp8wLLWNllqSi3PGZFfh"] = "#=qy5mCFWNZ8pLFdm$7ynB$pCl0BaCNuF3mbVwscxFrIs_bCbbEeJWZEKG6w_3_O8y0",
                    ["#=q8zkUl2UzXML8fqMClsNNZ8LFivCmoUm$WoJTZeIL6Cjm8f2G5$7ueJ$h5m9YEGJl"] = "#=qDTkvEDigSKdf_5dommaOPL62F5CV7TfEl3M8yKMoBev$zIWOwVRjIKeSdSAtGuLA",
                    ["#=qHw_2LO_Nz$Y0vq1cf8uMw_1ypz8qO7kfpX8$nfYpuzUndYYhe7iQmdXy$W7NcN8Y"] = "#=qDAfC1CbRhns1DIagzC_vLyzD16e7IrIUIwSfpymYVZSWDCfUHPaHztnMh4WwzNxx",
                    ["#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieUm1$T_OcHFkKrLEkPoZsEB"] = "#=qRYtoSXeYjAZOD$yQoESy6lvAV7xsyRaU31sv1uh42V7iow9JV8LQHquzap$ts9SM"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qOpZQc2V0Rw7qjRdVHvNiDg=="] = "#=q13rL0kVttdrV$ZJg8hS1$g==",
                    ["#=qBxgPiuKAFXyV6h4zwsgk3w=="] = "#=qaZY4Ho_vCf71vyUhUGh53g==",
                    ["#=qpeeGOY51SsIGIsS8Btc7rQ=="] = "#=qylEu78GJMtkvYYp8G1sqAQ==",
                    ["#=qbY4UBP8cC2EWYkftXWIQXg=="] = "#=qrx$5ex7nJr2xUHL995qc8g==",
                    ["#=qf_YWCuVC07ao9aWLGT3pU9Q8Oe46JtMBMtCQXDxSIAmTwoM7RUb3TqFH9oZFYwvR"] = "#=qGbSbbo4n8EyCFUINdjbvQ29kVcjVDzsIpx00jQ6dlMeL0TtinxGpkX3VH_M_tN0x",
                    ["#=qx0JqMxgIgx3xrDNOqZqWbbRjq22JOjBNtP0HT6a4tlY="] = "#=qbO4Z8fAfe6NsWFlOj7f374kINvNNUOBPah5Ga5WS7kU=",
                    ["#=q92SZxr42T4vtWmTnw$PGH4ZM9UyKneOWos2p2WVA$2w="] = "#=q2u2UC3eVai8tc9EvcaxLUtyU5AuJqDK1opUfwk8cFGk=",
                    ["#=qVoT3l3yUZQK_Y5lzRIwJf9XbhONll5FnOVZhkIvK0yA="] = "#=quDpR1I__smXGBzajAEWYSrskTrLdV4S9jF5hnmD1ky4=",
                    ["#=qveq6zLvLfmFqpmUNbDvD_Q=="] = "#=q2gT6iqPgBZZRYWJp64zzyw==",
                    ["#=qksC46436PisFulkysbD1sWRuZrw5zaI4EX4vuxsIZMo="] = "#=qDLAboYxSZixbVfDN$cHSyuMvyqcNM9VSXSDqWyxucKk=",
                    ["#=qoYmkx8VLfrhCPOC7W2DWpKdrJwJwqgDjHA_jWQ0P2qY="] = "#=qOldJm_DVRtSVSwD3eUiiKN6DZEBcs6KNYVkTNkJjIpw=",
                    ["#=qoxWo4EXXbPRCqzjJWm8ng7ae2kTzQK9ZuOXjRa5KFDQ="] = "#=qQ1akJtIhEIgQbqxZ99yTPfsofU4EOlFv7yZJDPxfmI8=",
                    ["#=qRezYBw2EGPMkq_vaoT6y$2VUmzZSz4p8taoL1FsC7T8="] = "#=qUpaogfgoMEPMiGEstUFwAmadGMFSe3VdN7bFWdw$_Ww=",
                    ["#=qDt8OqFFyB_1yz8AxSxAmgzhAtWVmjiP882eSjMx3h6o="] = "#=q7JlceV$2Ea5K0SPJvcoq9O1$S18CnjzsMkrSMcXNUgQ=",
                    ["#=qM7OrX__O3awjEy4hxoumvT1vwej3y$vKKrR6RKtnonw="] = "#=qop8I9KaFnoar0noIDFp00vEdk$XTQRUnteRwNZyRoG8=",
                    ["#=qKBTIxLo3osDA1iA9XlEi5WPkSNIH31Y1hjk6XZVEkGw="] = "#=qS4bbMK9mciM5vx71Uk2SnErOaXBJm1jl1J4NxwznOKw="
                }
            },
            ["#=qngQSM4vCoA40KmgUbcWCT_jexisgs81XKzWBF92MEGkhWgRsHUJ$WKEpLZXk1$wE"] = new TypeMapping()
            {
                typeName = "#=qovnI8KVvci1XQrHdbqLYFTCLc7srEfnnjsGljZpXg$dgDOHXnRa1mTw8XO5vf$kg",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qH_H$c3PpVi_g7aXwcNtvDQ=="] = "#=qL7kO7pzXhh63HEXiPooW5A==",
                    ["#=qheBVF8brkGh$tleiodMwG5eRX3OZeZWdUzJWGqwM5wD3zxnRpqkarzE_pdAxvS$7"] = "#=qH5dwz_iUIF2lUDbzQBRMYwHcivjD_SKrzKHriW553w1RRAYQRslD0cLnCElxNlDn",
                    ["#=qsXERQp$vSNMNEDBiO82QF$zBZPt_wAiiRZhNRcKB$0H7_3dgwYf$hNvmg_hIu8Pb"] = "#=q$YJrKuz247yAm0YSfxwMDQ0hMwvmNFSw3Ybgx0OgvSWJ6SYgMj5Ga3y_rCz$$8$A"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q7_M2WWKrlwT6mwK4_1x1Rg=="] = "#=qxsclmnhGwUhu$utgOD0$zg==",
                    ["#=qRpsyzieAC6mrhv5LZ6s1MA=="] = "#=q5X4NweLWJKN44WiVkenPSQ=="
                }
            },
            ["#=qNhyBJ9yGtQC$1t$b6U1RqXetStKU_JQfXa$JMPV5C$056td9qX3J2Dd6c7VKelbV"] = new TypeMapping()
            {
                typeName = "#=qLqZw1zpNwV8sGJpJxwOhcAGnjiwhBOaxZMQdKlfBRYdqiTsGHXWadb5r8RzdqMtO",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qnMqa9oW8shSOYlHAc1yc0H1NMlFPVRVyLQTtTlC8J7Y="] = new TypeMapping()
            {
                typeName = "#=qHlBLNRLHNgB01bBgWbHAve$MT5Roqj9NdPAn8iupZnw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qPYSV8a4AgshGKYYj8S5_oQ=="] = "#=qrYDBzf_v86lCLX_cGBhf7g==",
                    ["#=q9xuDm7MJrzJFRGhXliGGuw=="] = "#=qvCXHxQdfeG1KZbckynLc2g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qNMyErThTTQWLkR97uABDTk0EnfEiMZIDpSIEKPxFWWh4pO1UUNrJhi6jPySS1Fwn"] = new TypeMapping()
            {
                typeName = "#=qWJoSDA_Jtx$UQTytwlVsLaj$2UP4MYXzSeZHyW7kqCF4flfGkQUKFtnDBWHVncbS",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsOSmLOUQmbpIOpnOi8Wejw=="] = "#=q4RG4vN3RzqlMfk9OnpYfeA==",
                    ["#=q9OQp0XCMkz4bCjRlEfLWfg=="] = "#=qPXTUcNlCEaY2PgN9HdnN7g==",
                    ["#=qSAvuNvjQtOfb4TxUuwAA4g=="] = "#=qlLJJDU_f_Aq4aIsEToILTw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qObqIbLF9WbGsxOZdCHCtEg=="] = "#=qNOuqy1bYH0LGqTjvkrklLQ==",
                    ["#=qrnudXnnvBCLvolY0pipit1vnpyieO7aa10dxC7vr45o="] = "#=qD3kYGnvCQXXWTA_Wu$OZrGFff4jJUUJuZr5KABxfTRc=",
                    ["#=qQxlevcduc2PAvMx_vDOPkGT23LX7HUmoEjstM$T_J$8="] = "#=qsTfgP5dZHSHjvbjDVIE20uGSbbgn1KX2$40$p3deNhU=",
                    ["#=qPR6keQb428aZVkRUlUGVXr_P5Hc2hafQWmOyssPGuyk="] = "#=qcnnX9Zdqu9EZaNQuDnRXILJBckEOn4puKz8pKIlCxr8="
                }
            },
            ["#=qNNueVW4OnLl21hN82W7uo9JPMAzcJu$gSKXGmW64HthRDQQW7HghdWohfl7xMkyf"] = new TypeMapping()
            {
                typeName = "#=qkbdjJat3ynOQl$lD2gn6pfdEG9Qtqqf9yVZU9VKcBEif6QqJphvFFo1LPlaZjozk",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qw_PnS0UckLwuMIoj19$TTCiMrfJNDRil$BmsyUo_1GA="] = "#=qNssqgS0ib9EYxKd7Y4C4PqanGnMKRFBBRPfOpJH5ExI=",
                    ["#=qwjFpcCCFHQ1f567mI77mGn4EoSvjgYPPSpASIRyBPN4="] = "#=qp3Qs1YHViiUptrft3UNWGizXdIkqH8Rgm0Y7e0uSxW8=",
                    ["#=q98jJGs84syuoep5MCwR5Sw=="] = "#=qIBX0IDhiEPwD5mN0$n1vgw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qd_VQzTwSrKRfFU8Q0ED8e5lsBPDroM_OM6F0ELv5Yd0="] = "#=qPfPEp3nQ2w68c_OQYTy5jsW721lkZ$0J9DXyCe0p5HM="
                }
            },
            ["#=qnQ9DzO7rLkHdiFlWK8nVs8D8Meu1ep7DPjXXkdzMDkj_J0qeP8$fuuld3bWTtaYt"] = new TypeMapping()
            {
                typeName = "#=qCFBqWussazWJJFsCmn8M8$RkvZl87f2CVa5Dy4VKiHAHDLvYlA9uLiDA0NXT5lo5",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qNrFkie8CTHjmKDcRNuKwhKTiMeJ4C45qTEzBrELLp8cs336qms7yCnndRgd29_XN"] = new TypeMapping()
            {
                typeName = "#=qelo5ZwYvQMxH0m06U3A6xUglSEQe$_W3Ub0pVPL4oNfQzQ1FyRWcigra3JxPuPIm",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q7Dcg6DJemxUOENjdrUQP5LtfgYofyR6sfBL3cbg6RHA="] = "#=q4KVRpCfR9wka9lcwq1VuCtNmzTG3uZurihgR69HLyrQ=",
                    ["#=qsGTcLbEMCuMTGbC345xS_g=="] = "#=qkXSFzqrLLkte$7FCbVzi_A==",
                    ["#=qJkQStjf5rVr20$7Se0dl5w=="] = "#=qeqtR3c9k0YcsslRP4N7Iow==",
                    ["#=qkslBZ5esbtr2TRnmKTC7FIvqF4KStpArmGKOvCf7Hlo="] = "#=qsyXrC6JOfXOfsrLMtXHix1DO36Gw0iC1I6$zvd2dhB4=",
                    ["#=qhJ0BxJ_yQdup7pUssjEO6Q=="] = "#=qp9c9_RWh3hIkrHDl_1bcoQ==",
                    ["#=qUVnFVyIDkTodwVMpFn1YlQ=="] = "#=q$$U5XaUSJqsac2k7$PTutg==",
                    ["#=qc6yBpezIcSbu_UnngRRTeg=="] = "#=qfhnVkrBL3cr$_b7vQjcHWg==",
                    ["#=q6VP8qR93vf1z2k9xc5hrIQ=="] = "#=q0L5zspQz2BsCGYf4un4_fg==",
                    ["#=qXfBKcFbRnME_Rs4XsOk8ew=="] = "#=qqTFq6o3z0JPwsTig5s0N9g==",
                    ["#=qEfJUQTrb5BIPMcfeiEMtfw=="] = "#=qLC$WKCt9vH_U9DDAi5ajgA==",
                    ["#=qH71NcED8z$kY0CXuc6xEh3kPtOfYXIki_PCMtJvxEqg="] = "#=qYiBKnseRBAs$0GbZjUFLgI3jRK62MLsCRSs2QIwuVOw=",
                    ["#=qx0_l8pnI2JruIsOcenadpyL70K6t1xDvi08bU9Vr9EvHxSaWGJiuBW5zLjhFMRbM"] = "#=qARX7N7tvRJoVy$hETbVXSC9ua6UmglaJyHSsMEC7p$06ohqm6fnig6W6kC0aCKCw",
                    ["#=qxlrUH$F2nxy$NdnTyPdpfW8WBs$aLdvJ_fGnjT1fFtv53ZrPT4Ynt0wMJPUB0hj1"] = "#=qA2A3qSe96kGFldKZipHhgSAbn2KX9W5HEV3dGS10wf7p8uA2M_TUtnxuge0J11mA"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qd_m2eLXFt22bDr9XvlfmLA=="] = "#=qUUgscj6Otn7vF1$8aNy_4w==",
                    ["#=qXXHpk3RCOXVwPtuZX3TJMg=="] = "#=qf4cojVEyOs9SUGdX8ihCnQ==",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=q0QcRSV9MzF6$tVO9VxlHvDbHXvfN3PtD7BXtBb6q$7o="] = "#=qUaYYQBDnAry4oryP8ACVG05cVjE12Q6$BvsCgWa$hkk=",
                    ["#=q5C$LTZnQdZQ_rbW09uZpdscJRuU$bDlsI39ULhC1HdY="] = "#=qLj0MnoGuIThCISu7RV6D0PClmxvPhx2e51$ycQudW_M=",
                    ["#=qNnk5AQJH5gT4Gnoc2PTez3eYmZUfCHyiLKLz7bVWj6Q="] = "#=qUxxfLaX9SDdCIKic8CsdLJsYULQx0jUtdusUewWA3Is=",
                    ["#=qvhZOByvV4VvHIiVrhdmRa3cVr2LjPAGCoIMAFZxqmjg="] = "#=q0Vw6Sucnd$9jbnCFZirvGj7wsoeMfrktESB6UNtjm5Q=",
                    ["#=q15fVWz0b9iMLl_Js0CpUF5wMEWetJ_mmwSK1FiT1sx6BnkmJvviRJVskfA3R345A"] = "#=qOUUoHzsoXxgkaDSyNbeMo$TMDqtLoekgUhuGwby4fQujNBF9AOJIcxBBQXGp7EIQ",
                    ["#=qWvS9016Rnrd_qRrZ28SxlmrjNIqNwgoIeADNlHYjkek="] = "#=qS05GBCFCYqKnVN45e6i6gn0tTkyKLDQhzZ7N39FYgFg=",
                    ["#=qn12HvrTfaMtF6WhkpqYAx9CcKoibjhSH5x7wltM9Iv0="] = "#=qu5QEjzl0E8wNfMPN3J5cHF$OQn94h3yvwAewrzs1QDs=",
                    ["#=qdPW6bYzgIqD_LbTp5VtMAFCJijbnrtMeyvMUfJceEic="] = "#=qnuoYrEkeLRVaH_o9QHmskW8EjYEZaxcO7vDrwEErQzI=",
                    ["#=qGdaz_pqbgL7gskVDp4rnfYbZmaxNPDFmHGCkeG$anpE="] = "#=qVWgDHtLX8ebWi3S0Z1Y0gPXMk1R3vhgcxTcwyHyQpes=",
                    ["#=qiPrAkLM210AoPzdGszdWvYKhnhyraFIGegL_Xcexh4U="] = "#=qYsIQxYgdqQwlMGEimMGx$KkDZbLXlUWAOT8cDtvjQZw=",
                    ["#=qYKmtgQY9btqdzyRvZrxWKhiOWyPgdbHx80QXPv6W50g="] = "#=q7HpPbMHDm0F$hQtm_Su7356$w6IvHqYg_taoMKMbXD4=",
                    ["#=qt2vthzejETl1WtG6_RpCgF4J3EGzpXionCvDy90kC4E="] = "#=qBJd4svfP5iwhXdlLp4AaaFqqoi0d4lnWsIiBf6kJDKs=",
                    ["#=qNZo7jen4UijbqgjyiZdyeJ1R3V_By8PCa7vabJu9W7c="] = "#=qZ0VgZ40gVyhP2qgDZS8gA8hdrftUCxqAAeDEUc6ERrc=",
                    ["#=qp7bNkxI5icJ7eoYrPdnkzC50oVt$MQcZJJ5_QSlVY0o="] = "#=qeyU5wA8iFZmKkmXS9iHvKkw2BVxEV$VDZ6SWWjSXZwQ=",
                    ["#=q$mU9X3jZl4p2IbdjK$4gUXagsfJbjHD9OcaaKtd_DI1zHQz5Gz8yxp19juvP4Vse"] = "#=q4FjjH718AKGAnluTNZjhH7vnIKFztoqqD8SfR2Z6EqSANcncJMWvXmQ_UfFiDxUi",
                    ["#=q0gFw3gNh7z8JeMTKsn4jW$DATIK5Z5G5KDCHfn4aeN98i4cLrbfXuVoKWDnSDslg"] = "#=qM14sz683ib0EqZCxjy2PUfOfK_roqoTKOsL23NrRUv8Dcf2GRDl6MaNY_iZNDcrB",
                    ["#=qf1T4CtMXKeEgrFVLRck4by9tXRoVvzbtdU8MlgvAarK4EBxUmGU7LaplXwENXMEl"] = "#=qjqcbz8USNM1twMDf2k9Ztd7RprL6rHC7I6q_aPZTUCirErmY323qP50Fi8gJmgD9",
                    ["#=qcGnoqBcegikyQ1DA65t5$_sTw_KyudlA9itv$d88fTY="] = "#=q6LIaT_45bEEsGJ8VnBh1_vKK06hWe7jga38ik47ZOFA=",
                    ["#=qLnX7nX3uWNJ6VsrMxf0SnoCA19vM$ecoiJdFzei3YKM="] = "#=qbEC76D1kqU98aLIYId6WaEwFyvo9yNl0JD5Is7tO8Og=",
                    ["#=qkcFB$SYMkbK_RNy3AuXQdE8ZkCYH1WJbitkvLY_lb$4="] = "#=q6wr8OaaL3V0veOB8R1zCjWMQr2tCgXDJlCPwhEUl2Xk="
                }
            },
            ["#=qNtQ6M$n5GEyPT_eGy9tmGcKb1_bGpAp9vbBykXUJPzAet7HHK1Nm57igQr8Ldv6G"] = new TypeMapping()
            {
                typeName = "#=qJ9iAnVErHtYNmofbeI5HHNQ$gyfklVw1SQqPcLv4p2C5rfKiQkZ6TkZTsdpsp9PH",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qP1rZaBMhLgcZRsNxPG5KYQ=="] = "#=qrlG3nKGTIXeDevDlFZ0tAA==",
                    ["#=qfAtAQSKG30HVyrwGtFokIg=="] = "#=qYVgagxdcpg2$P8OLd4pwtA==",
                    ["#=qPRtjshyAGg65zmuG_PZxVA=="] = "#=q5ivyBu59IpGBWzEtWi8wMQ==",
                    ["#=qFbQzNQKmPddyPnrJwGluGQ=="] = "#=quefIWqldTkrU1asQ44xgOw==",
                    ["#=qVPGzuHiRXo3MLY8Awyxi$Q=="] = "#=qRtWvWplx0fKo9P5Vspl7JA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qWIb_6LqgQ_ZSQzDr0diaKA=="] = "#=qHIAxAAUh$ixC2oqAvP0uuQ==",
                    ["#=q8jfwaeTEqy1lGZ9DhxD4wQ=="] = "#=qlsbLgrIKXX8TGsKi0gRJEw==",
                    ["#=qahcLE9pp7OJeaVa864_k8A=="] = "#=qH2tHN49ukmBPPD3_ijZJug==",
                    ["#=qx2WAyvdF0tkH8ghwWIJMXQ=="] = "#=qzbBC3rySs8mp584s3He0sQ==",
                    ["#=qAAzgivi$CUR7KbyHP4$0Tg=="] = "#=qVMyJ6KdPXBYxaREZGlAZ$Q==",
                    ["#=q0kRoAYZWnqMp5DOr5Etj5g=="] = "#=qyVtM7i1FbgZCMb9VSEf0Ww==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qeGBBKeb2NzBiJBDq11RQKg=="] = "#=qYcmdN$ur7xRF8cFHVbycnw==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qDxkbHT0ktdvjMBxB7DvlzEYNj7XjCgqn18jQfKC3kHXT6f8Q0ptGfnNu2OcrX3QP"] = "#=q04QUT6plrH8Qz7iLcrHtSmb8I8WpjYFkpkVHwekRuaMGBUHh0_DGJ_dKi9sbLKAP"
                }
            },
            ["#=qnXizoHa4dN33EsdBlCLIeK0SZalNiwRqmxF1iN6o1FQ="] = new TypeMapping()
            {
                typeName = "#=ql6PLr6IGKKfqv8qV0O24p$4$WW52zvhgysAxkpSc9Zk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q$1DamooDZz2o87pGKltODw=="] = "#=qWsFmWJCS33bGkVp652elpg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q5r0l$pwE4R73pQhTlRF6XgNRqTd13SI6tDqHNWVdiIw="] = "#=qg$cn2C8DxMwnPW1WPrMccUYyYGKvEVi3I32j3ZY7LrA=",
                    ["#=q920C_6wSslXFyGPLV4V7OQ=="] = "#=qZ6oWZYzth2ncWZsrvipK$A==",
                    ["#=qbzDzWZ4jwBRoHHLfn0FB_A=="] = "#=qGaKRpl7BW1_4g0EgvzWdYA==",
                    ["#=q3fNp4UpIVchWVbe0TywjQg=="] = "#=qWOc8ADpgmZAsBnf6f6oBhw==",
                    ["#=q7tM_baLFQ_wG3eBwNTdQNA=="] = "#=qUt$sYMt7b9qdqm8keJOP9g==",
                    ["#=qybKgxlkirl3XnHnGBSGE1w=="] = "#=qRhhdAJ0Q9SV2yC8BHDrUoA=="
                }
            },
            ["#=qo_TpIMKcO2tzqPOlXKVz$I$DQDQzPrqnvkaUtfIi8A4="] = new TypeMapping()
            {
                typeName = "#=qo5URSkiu_5fUQv9IfWwke2QTpp22rPNnqdMdaAp6E7Y=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q_p2lyl7r0p1FIEitWfI4xg=="] = "#=qrXnUmSca5l3sVZatjUkgPg==",
                    ["#=qO2BTkJqz0$$XyIKbnIeefA=="] = "#=qYDoagVbKMT6JV_iRjMs9nA==",
                    ["#=q9mcgYlm8MKm70VB1bjpTEA=="] = "#=q6gwobqPRaH9WM4dqsrRQKg==",
                    ["#=qRLyIiDoVXxl4oyxUIKUdSg=="] = "#=qOatAc$EmKBL49hwdkzXO1g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkCINkmnuRKp$CCuwCFEWnw=="] = "#=qG435dX29HT2v2D1bngs4fg==",
                    ["#=qlAX$rVdoInHD6Xck992QzA=="] = "#=qa8jr$9zfCIyN0cslJCs33g==",
                    ["#=q_uSIDq$CqCb4mu1UPyhivw=="] = "#=qEZyHp7FwtQ7$5HHhcU3Peg==",
                    ["#=qs9lJfG4dpJ2i6dOujaDYKg=="] = "#=q47CVJtCoOWgF3bjPnyYlYw=="
                }
            },
            ["#=qO6NZO_hc3o9ZMH2kdPmloKaCxLJsyrukBwJxpYikFOK3ZsEpKOboJByd$GFs3Lcy"] = new TypeMapping()
            {
                typeName = "#=qE5pNdbqa11khFk95AhwK2Zxp7FhRg5Z9vurFUSocXJVDhPkALUdfHs1wSKa5rI0f",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qO6NZO_hc3o9ZMH2kdPmloP17dzrF0c0xUDjJ3PcxVkCdMa$NMgkKtzAgcNpQiNTC"] = new TypeMapping()
            {
                typeName = "#=q3ooxeKiVnyB5Z_owGRwWQSzZwZhxVYqwrB8iCm9tf6DN8kU01XPHWxydM1nhw9Pk",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qaVKEl0BhUd$RYzqe4UgsAiEJDd3q$ZcXwTHym00fyOY="] = "#=qWLdAXV$aOmmfHcjhGYsAckR8TSysY3mwCEj7UXw0v2Q=",
                    ["#=qDCcOnFaZuXwdCKP65ncAyw=="] = "#=q0j5rQLMn1JcDXQT0nulrvw==",
                    ["#=qRf7zErKfogw_RZbhsLQ4Zp9W1vEtsQxgookVBMXxRjY="] = "#=qw9WcbhNM1q_N6tFRc1wSERwL_ogZ3DwlUSA4t$AP_Vo=",
                    ["#=qzXFL2iHgREAOAT160vEZdA=="] = "#=qjHRAY2MG7XLohG5gNPfLig==",
                    ["#=qC9mke6iNUxIxx0C075VZ3A=="] = "#=qFScfbZoK219dfZuThH59Rw==",
                    ["#=qhdMuoc8EOrPMqg7ZsmftvQ=="] = "#=qx1tJnZ6o4wUS60E4KNNTbQ==",
                    ["#=qLRGKRVG3zUuNiM2a4hUimw=="] = "#=q7cGBtHIQ5cyyrZfmvg3d4g==",
                    ["#=qTDKTNhqcyG_AOU4ODx1Fgw=="] = "#=qlMrZSaHnhANgb12LWq2O8g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=qO8NYVVhhdx0dagnPcNZySHg70HX5ks_hK6GPyBHuB9mnkY_FgjJpgJ6pzHg3Zg75"] = new TypeMapping()
            {
                typeName = "#=qoQD78rkpHOvEoYDnOEhKzHkdVaOJ7Dw6Y0A58ulxOBAu9e8loG8pFlGfrOgNwWRZ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qqUmNo$37urnEQFFO1UPAjAabOZRq052vPBxTU_7zdkQ="] = "#=qAPzPkU5wrr5Kef9_pFAJ3ANzr2gZdaTXZF_R2fAsk3k="
                }
            },
            ["#=qOB2pAmDJeoMinzSHeI0QygYlHHd$9v8Ellqg5Q2WSHgqk6xgzc$3NDvNoFBqminR"] = new TypeMapping()
            {
                typeName = "#=qO$JbpoiZ$QeoCcWW7PahHirEuMLQRot$Dio1s2xakPdxMX7z98c86790PMtraZAt",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qoBzQr2jFiLAEWDKXW_W$BlElDO4fjXgI6WaU8MNhLBc="] = new TypeMapping()
            {
                typeName = "#=q8rb91JxW4xkfNdLlLZEyUThPzDOtShWl4Lyvca52b3U=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0FHmmsxVPjN6KKkeO2q2uA=="] = "#=q0FHmmsxVPjN6KKkeO2q2uA==",
                    ["#=qNQ37yPdF$FmZH8wFHjdsAA=="] = "#=qghaHIaJA1X593vHaIxwxTw==",
                    ["#=q1ibFSqxWmEpRM1dZuCQot0yuBpPUiiUsIMQY3X3NcSU="] = "#=qM3ZlhomrO0FyvHh5IxJykty5fDvL7Eor9AzEQ3v6h1I="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qNjiY17ZJcU57$PTKv8nDsQ=="] = "#=q11lD1xOZQRvzYC2o5HsBhA==",
                    ["#=qhdTO7ZCngRpwzJr3t7R$mw=="] = "#=qeqnrAUQf57c5SWxErBvCiw==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qOCff0FMp6HLIJiin8tAPOs8YzSkhvTUQ2CQafDRjcHs="] = new TypeMapping()
            {
                typeName = "#=q$qn5wlUg$WMnx9x25aJaUCwagQ4V$M_nnGbQck447pA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qQ1DRF04QJ1LZTJb$X6Na8A=="] = "#=qBYipO$iAr079w_nAsOGcmw==",
                    ["#=qMAv_dOoKDzLYtqXkEO2ApQ=="] = "#=qyiLs_v5dwHiMa9F9nZ$$SA==",
                    ["#=qSlE3HFPpn2uNRwW4YBT_EQ=="] = "#=qms59tb2yEBa4VgxwEdXkGQ==",
                    ["#=qzvGiH$51kfqN$NQYl6m6lA=="] = "#=qk1Pjup7B6LdeJarvnTbDmA==",
                    ["#=qFr22Sq0zQ4Xgn8Y3wyuKaQ=="] = "#=qi1XWCqKOEde5IN8zlG1XEA==",
                    ["#=qpUQbl1ioamSHx7Rejjq26Q=="] = "#=q2nWzYIITfhKFrYfloyDlXA==",
                    ["#=qmRayv1j6IoDx0pzo1XWr9w=="] = "#=qJbGq233J2oXMtMiOXbjpRQ==",
                    ["#=qvRqI0DoF1YEi5duvHlTw4A=="] = "#=qcR8E9p5beLcQuXsfcxni4w==",
                    ["#=quSoo5PVw$ioRPgDBzsatCw=="] = "#=qrN2HP4tM86kFmZp9_WMJZQ==",
                    ["#=qpluX59wl1P_pur9u7agyJg=="] = "#=qruIBzIOYzZb$GSedtk82vw==",
                    ["#=q1u6CVZl8QTQXkI4JpIZitg=="] = "#=qsfs2u9vYSRTZza98ybL1ZQ==",
                    ["#=qFzPSI5QNeRtrmV6pcTMk1w=="] = "#=qeuB2GdCDOw3Hy6rFInAqSA==",
                    ["#=qmNstQaRgjs2eGx4RkzTiXw=="] = "#=qpGDjSkC4PtllrAZUoREjXw==",
                    ["#=qiJEVeNpgE3SzfB6flblo$Q=="] = "#=qYkBpDZFFh1rFhumqF9bU1w==",
                    ["#=qkuhFp3uIcO3priVGdXF2vQ=="] = "#=qsLZ4FK3_KdTXJvzIpQMoCw==",
                    ["#=q2CgWavstOrE3Ufx_c8$0OQ=="] = "#=qSak90OOWduoSTQJY4kxgSQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q3k$h7vybmJvD_CMEKb9lAua8H2rXNcoKUD0YlAd6YRA="] = "#=qU7wR94qv6ELkBvhx2oqdEKppzmJEhXX2wNo7wuGJZPs=",
                    ["#=qBvKdASPnG0_mx4JVeirJr60sXLQ2mkTX76_Kh1CFrJU="] = "#=qQjR5YcqM2y$n5vTh4ml4SFFvJ3FAhpuEzp4epMuuxK0=",
                    ["#=q8WwBzP6RYCnwZwSh4BhIeeY4iVzjpBKd9aSqlyIYpFI="] = "#=qDbC_bkoQHQUMytajyvk1sIrbTWkQiRzVG7y9LnddZL0=",
                    ["#=qfCw9i6snkzpdx__hnpP68V8NiKlzKOTl$2DwZKpBmY0="] = "#=qcrkt$Tlx1ZGK9NgPet8AKIrO1wIQnNytJACk97vxvJA=",
                    ["#=qgtppIKPjpHQD7fAq0HR$cg=="] = "#=qT4aMayxs21_w7c1uIlNBgQ==",
                    ["#=qpaynUmyKqrGOev8acVt3HA=="] = "#=qFBVmJbw2vf1tD3lebLOQ9A==",
                    ["#=qqeK6rjv59jtxhwbcdOPu4A=="] = "#=qr6bXY31IdvTet3inZOM15g==",
                    ["#=qDlEnzzRR3ado9dikEqNnig=="] = "#=qPulelSHCM0NBou9g2ElHRA==",
                    ["#=qrAa1ffypBDzdWzs3j_V9BQ=="] = "#=q1k97aWxJvRF7vddy8FEveA==",
                    ["#=qBHJ1pfaRCB7bGzpFsPExhA=="] = "#=qx2cnUxgNuhmVlvzyP3opAA==",
                    ["#=q$CnnddswsPnooaQTxzmabKroBVjqkkQvUHXu91Fnlxs="] = "#=qmXXycvS7V1RepGYaX74QveqGSpUkO43N1FWev3JrhcI=",
                    ["#=qjHMf7PZrV6uriToAY3A6pmuTsEZQhZPEEBvSoPcnrLI="] = "#=qLWLCmASzA1rizCuHy7wEmzDeetqs5kAOBvNX5PERRKw=",
                    ["#=qAvGPPnnkKF2SEtQjejhXQPiH9Lcio3MXR18IFpG3F$M="] = "#=qTpr7JE2zR2tewoGbMd595SX$JHAYHa9sstbKeSGqZ0E=",
                    ["#=q7lzZKvdtz4EdZze_7IQdrrOR5hv2BqRSUH3yx3Qyq7k="] = "#=qZy5cR$lPJ7Bs1kc$lp4arWOKMqRHkAf7mE8ozymnKGQ=",
                    ["#=qMfXUNe3tgiAL53akYOddUA=="] = "#=qN7iC_FlBQlIzykjbOP$p3g==",
                    ["#=qlrlsVc2m2To5$LC_pd0kjQ=="] = "#=qTCGedGjFRpFt22ykQ6Hf8Q==",
                    ["#=q$Ny1aQDzjuVBPAZI$vtgEw=="] = "#=qsOo_WjA3zwYUzVLL5o6KYw==",
                    ["#=qQ3mOqdihhsB6qb23lBtIbw=="] = "#=qFRzptnitOQIHL$EQt60FHQ==",
                    ["#=q$CMteVO9lX4suKo1Cajm6iTI2WNS12av2ul62Q0b894="] = "#=qqSY3Hi5K6E_sWQJnDpjkmuuwfJHC5hub7_apvM3yrUE=",
                    ["#=qoGKrtyCVer_CAU4wGu7cXg=="] = "#=q5u3Xm5evy9o5rzqCEDsA8w==",
                    ["#=qNXcT_g0YOgqevt6d31KSD_tlrMkdY4U8JEg1d6Rtd3I="] = "#=qh$maCq$zLnjavXTq7IIggaJ_2RLOoSByxcJrIA8tYjg=",
                    ["#=qB$8uz51pT_6ypS7G0DKdCPRrrO8PJ_MTz96I0Yg7Ipc="] = "#=qpdyGrlsilH6Qc4jy2L3woAc3mdUJKlfHHaKBoiXQyyQ=",
                    ["#=qpDidmaOXfLWHJf76h4NXqg=="] = "#=q6j5eHKx6X4XcmAR631kyEw=="
                }
            },
            ["#=qOEpxIT50u1dCOT_wOsxF_V8hwULypImW0R_Br0rUiWcnRyOPln618DWiOHw0IDw6"] = new TypeMapping()
            {
                typeName = "#=qwoKXfkhXXbIKewIvsqXDCvPq7wwCaHKnZEIXwM6kILCOxYZVaKForYN33I8Sii6v",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qwEqpyQgkzIqDZxAeyeh1Hw=="] = "#=qvxrw$26rlzkQa8IvFknCQw==",
                    ["#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaR53fcLjC3$deAKb13P$jCU"] = "#=qsqRhztglKqoDHg$6hXmmnlxTfBSkDjNgu$Ew8v3ax1$ygVOexJPcm1KLC0p8IsSu"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qqUmNo$37urnEQFFO1UPAjAabOZRq052vPBxTU_7zdkQ="] = "#=qAPzPkU5wrr5Kef9_pFAJ3ANzr2gZdaTXZF_R2fAsk3k=",
                    ["#=qWRvmqzHWBlNHnxA$aqlXZvefpd4GxOeBnMMGioDHh4Y="] = "#=qsUC63t3PG7fwbnF7xZdU2tKqe1XsmIpdZolRfJyfxCg=",
                    ["#=q2gQOz_f3JyvUlmDvR3biaw=="] = "#=qvvu1UNfDitJlTF_JEMNlVQ==",
                    ["#=q$h1hffTN3HW0NRzJz9f9NQ=="] = "#=qjqu2ROkXNGgHxHwkPJbKSw==",
                    ["#=qTH9Fhq0LOvhlgryFBSeiQxngktkvLq51LEsIzZkhC5M="] = "#=qyOMrGdhaognPSQ5R8hQ_BvyTls0mxbRzdSTqeiJKkhI=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ==",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=q2eT$mOthG2MN89mR6b0knqmiIz50_KdJLOOchZwxy8E="] = "#=qUurn_jFUahv0_Eej0rzBcINEVWf4dcFzfUaVtn6jpds="
                }
            },
            ["#=qohmHDQa$qCNQhyIh$bGaX6ryqX3$ZJOOchr58MljAI8="] = new TypeMapping()
            {
                typeName = "#=qbeVJh2MnSypEjYI2pYJng8DDojZmUzNn4t_96f03_N8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qOIDSnFuyIAPArXepJV4AQ4t00f2Il4kdHEByH5jJlxs="] = new TypeMapping()
            {
                typeName = "#=qPmLLblMDInGkMefA0xVd_MAGU4czaCZv_1tM6s18Teo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsSH0YS7wzM5RFCXKzYu7wQ=="] = "#=q67X19r6W7$_1BeDAe$K_eA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qJcZ3OAAbESzjUlXOA6F2Cg=="] = "#=qg$KJxr3a8qJM7TVAHqmxUg==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qoinRHCGTiQixtVtIh0H07yWk_nNdyBrOGhz8ILY2PSRS5jaTYN1Cehgw_BItc122"] = new TypeMapping()
            {
                typeName = "#=qZl4bhconeMsyKSEVSoFqkpBTHdH5Q3pwiWn9XdxSDJKZPVsBz4zR1$1AW_AuASh$",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpwsKEg4ShGauIRC237Mgtg=="] = "#=qc6u_txjcs_qkqmUxb5jJfg==",
                    ["#=qECJRYhQ7KiWgAX9i5dR1OIWLr_FLKMccH5o6eSL8oaQAAi85cwz6g5fJYFeX0O5$"] = "#=q5zlIeZ4m2xCCCSC5jRhr_B9$XeedT9TxjjaAjG_2cn0xC9zcChn0xxl9zLjWEF1I",
                    ["#=q6WdoHtzpQeJ1P5TTWWn0T6vDRkiSnGaLElfNVGSiMIJgLA4aHay4kEm$UZKwkF1m"] = "#=qRePwNS9YYGqHL76akuXi4tQVPyj_VMpiQUO0DOjz6vD3tqz135Bwh3MyfzBvL6Q0"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=q6fM8ype9Z4pFc2Nq1q7xBg=="] = "#=qkhI2d_hZILkocxC0ySmYSA==",
                    ["#=qHmDDphkwQpy4HBUgncRJQA=="] = "#=qHAPvAMc1Q$KHLG6vzzga2g=="
                }
            },
            ["#=qoSI_9BF762PciSMb3t5BzwcXqi3tg3uCy6x1_TMwg7E="] = new TypeMapping()
            {
                typeName = "#=qAnP8Y9juZvX32h9k3eV5TL2pn2rz5EmHFmGelDRrRt4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qKvNugKtNPPCjow23IHOM65wpbegUdoaGmr34XM8uKCw="] = "#=qibMKbqUYbIc9W1mBvMUk9DUN6lH6m8ee5QVlB5lbpCQ=",
                    ["#=qgiYEnWWZSWvi5IpmT5PQpQ=="] = "#=q2pchNM7ckeE4S3x3FkCh1Q==",
                    ["#=qrqdOts_uLN1jF0T7Eilvuw=="] = "#=q9HChy3WW1P7wjValJfbM2w==",
                    ["#=qz74HJ7i_6kPRIVNLCG5kRg=="] = "#=qyRA0P2qWiYQHbOEIlgS7xQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qmlsjmaIW4C4KYsstuk4J7j$lo$t4$AitU1$RQwVAVLw="] = "#=qUAapi14sYrrCA0Sj0YAMLW2$ZwGBfrmwj$cl6bFVf4w=",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qnBXUDRWInpfQ6jzHUaGsgmVHhfYrhTKsUyLHglP1UOk="] = "#=qCOqPDZxW0EQ_cXMx2VWLYUcrhrglqXcijFV2H44M4YE=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qJsmfByNRi48tSY2nht1wXQ=="] = "#=qEDRmme5sjddEQ7qORLMJxg==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qOSvD1Oe_hY2fCsg$YD6mU5sGamD2q_e02yeilzkIRJI="] = new TypeMapping()
            {
                typeName = "#=qgKc39LoNt1ipU3CKKOL$8wexFAAlrdoXOWklVUpIBus=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qv0E4GJd5gl$tPuUF7fMUtw=="] = "#=qZWgm2AJN9vTQWwybMWYtdA==",
                    ["#=q20pJ5lmKOK1DGuZ4jP0d7Q=="] = "#=qb5K5DK8Wr7nmyVQFb9$omQ==",
                    ["#=qyillBO8St4O5pOLj7pVXZg=="] = "#=qOlR_Tdd79mYXUKBEGd7bZg==",
                    ["#=qxscTPjAPNr_r7q4aGGrAWw=="] = "#=qrqW$rGAVKjAaAU53VujRhQ==",
                    ["#=qvRUyrOdK_u$cCw1LfOw0pw=="] = "#=qcqYSKgD6NRDMVe_NfYdeRw==",
                    ["#=q1S7attLraJvXv$uXY54KuQ=="] = "#=q_IuCUplH5mTnT95Ow0UzjA==",
                    ["#=q89m1zPO$OZ1pmB_5NtJs_g=="] = "#=qxPQtu8aNGxGZdn996xmjDw==",
                    ["#=qqAjxvZ8JYT37N_GhfYJoVA=="] = "#=qtUt7h$CQz1Kn71pdSQpsEg==",
                    ["#=qAzrQqIqLUV9C54LzAztywg=="] = "#=qx222_yYPR0XuK9qxuhBU$Q==",
                    ["#=qzxGc90XEoOyiLOxRKXCMug=="] = "#=qb7w3Sf$KbRSARAXJKnfFtw==",
                    ["#=qeevZ0Ofc5u5s5Fe8fxvy0w=="] = "#=qkkToeed7v1w_Ruuxz9yVnQ=="
                }
            },
            ["#=qOuq7A6QRJjFEBWjUWiZyaGCdY$W3xa5FFHIYCo9Yo1A="] = new TypeMapping()
            {
                typeName = "#=qHG1A6wKHegdQp1srD$7Lnz4WSdWHwy0_Q3l8FlUrAbk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qOvF6TNJBnhU8mKXGrtzkk1Nzd3kf18F$m81xKakJDxj4B8B7Tf5H0hIgBBK6kDhv"] = new TypeMapping()
            {
                typeName = "#=qh_a85TaQHlP_H1drqPlsibMCh72iTWXECxp64AL2HkWLn3IWmJyLRwmSxv2Q4aFR",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDzqQDhl$6r727c2aFWnJKLUxUl2D_05fg9PX$u8lRZg="] = "#=qwf2iaAdEgEri1ntiASuxopvkyaVojKHImHiDONklJC8=",
                    ["#=q_YP5Tk24yqwCYxCNSAnGmOsxBFevl3u0adCWXHvAVlY="] = "#=qo6q$1I155xcE2BGYPhJhjFuNPrxJZQ68uO_UvWkuX2E="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qlQVM9qyHmwEHo_SGG9S9E05fypkV7D22l$KzzbyAbno="] = "#=qaTRI$ix9Xzg8D1E$jLZiMHqIlr53j59vgc$GDZP6qVk=",
                    ["#=qhKqf$Vg2cOs6ZHk1oL0UeB08Rp6LqxGWSdnSfJy292Q="] = "#=q6SvgR_GH$vDRWricX46eQP1p$L5iT7CFDJi7I8ZDYcY="
                }
            },
            ["#=qovPHRaoOAhEwdMkj7TqYuU0$LqJcHwNXIzdJ7kUUZkk="] = new TypeMapping()
            {
                typeName = "#=qijkP6f4RGEi6aS4qnTaPGI94MHAHkOsnqc0SMvCXJQA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qzpYGM7HFeZ3HlUvG5zhlbQ=="] = "#=qTq22Hn6kuiuFPeVA_Q8ECA==",
                    ["#=qTKkVZ9HQCGRvX5Ysh_79aA=="] = "#=qqhYwp3Dycchi3N9FxibXlw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qb_g_sXJ8EqfHx4v9LzkO0Q=="] = "#=qut$0c8OR1tXvbn4tM9hhcg==",
                    ["#=qNe1UZLyiWg9YTb3dOiDNCA=="] = "#=qIHXxPDU$3p$kjNlZTNExuw==",
                    ["#=qTiPDO7Dy6MIhPS2JbGz_cA=="] = "#=q$zbojT$EH1wUjx$$yi3j4A=="
                }
            },
            ["#=qow$cPA3EVFPHz_F2Kg0P$okppdt3fVr8Yitx$HLvwyC85Sm9k0VzZnEz_EIgfvg8"] = new TypeMapping()
            {
                typeName = "#=qO$JbpoiZ$QeoCcWW7PahHurAL2QritzC4l5osHT8JyNGqXHxlxZS3jSj3Wk1jYod",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qoYsQu_lm7ItlPnBtut6N6DDVmbcclKuRy2Jhma8UUGOl7OQxQI$DsyO$DtyjAfH6"] = new TypeMapping()
            {
                typeName = "#=qUigskHClvB2cO$wzL30Zx9Z3AnUhfDjsI5XM4B3nCEmBgivG0lFaLreTtvcvwIHJ",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qp_g_XtU9IJhX9gIvkYd53wj3xxbc1EV6uuAPmacLv1Z6233uXd0b9476sjanRJCD"] = new TypeMapping()
            {
                typeName = "#=qwndZyjs91o1BaZDNSxGqv191NPjkLE_eJ9xovhFZEovzdp9ouh_tHtyJDfOH4nog",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qbKSMBzDaepg1FIIRTBbmniT3riQW6SfLezeS2x91V5E="] = "#=q6Lvgum5VpCEi5Y5BrTSwHITEDNNldiBBLcb28w_goMM=",
                    ["#=q4TCP9VVxWi1Ubo2EWeJPe0kwz4XV$umur0Jz2$jkY90FRovi0l14Fy3iIqa0yiia"] = "#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$AMNgf4BDfqGpNV4off24blS",
                    ["#=qxlrUH$F2nxy$NdnTyPdpfW8WBs$aLdvJ_fGnjT1fFtsTQevA1l6Ri2LzcJzZKquz"] = "#=qMKdbmdaXg9cnA9a_bXRc$DoPaCD7z9siJSsp6CLTVxp04ve7ShCFy5zC$7Z9vm_m"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qk6VVbTZxO8i7pgQnd6Ka8CtZOoP9bFv5qGyn$jg6c2g="] = "#=qTJPhfEv4c6KJolfEncmCnaLwZeR6KD5GIWiyrLC43Tc=",
                    ["#=qR2WL7fAAlCq8SBM9dN98FEOT_3mSTw79qFXrj0xK5Qk="] = "#=qHMuDp7BKM2eBx$xHv25n4vkeqiT$wFOPPfCHwdW7gA0=",
                    ["#=q_$2v3GlBpvfCD0ZZPiJqCadfsiQP6uGWU8xQcg1PhRo="] = "#=qme2OIf4RdVvvwEoBZWcezWOYUvpsU$Ds_jorBG7QHjg=",
                    ["#=qopBKSbNRiGBY_nGfaksYCM4GIOz2mwFxCo7sO4$bsOA="] = "#=q3oaC2_hb_CtwqbuSkPgiEXsCcpOPJ0cHmcbi3ddpJHc=",
                    ["#=qtW6X$eDo5zkYgrRwZH5C9tfZmOitjLgo4$3XUJ6WQ3o="] = "#=qddrat9HozprwXWM5tlit3EHXU1m9kaPEz8OzSeYQFqQ=",
                    ["#=qdONHnZmHPLi_05bf2imxLckFDgrnf$5cSpCazg3ZRKA="] = "#=qNC8dD2i$jcyYob1SJnzA48j4I9nUeMkgYsSG_cYXilM="
                }
            },
            ["#=qp2u$S2Qsixj21L9SDxnBEdXIaD458RFCjdwhH472jLo="] = new TypeMapping()
            {
                typeName = "#=qrcN$p7UuJOB$DFdesruYFfSrbOcmjMnuvzPx2qqFmps=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgXVSazRulCN_pranZ5RiKg=="] = "#=q5cNuL_aPuKCNAQKeKatrFA==",
                    ["#=qX5X6ULmCEm7pw0xOs0fj5Q=="] = "#=qt8Yktt2QKhvZZWvIkvkeag==",
                    ["#=qZlbruOj1rAhDpbTFzJFmDw=="] = "#=qbcUCb2e12O8zv6PC9JdjJg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qq9LEjS61K8CiewaCoYC5tQbXcXWTbGFL5EM754mJkF8="] = "#=q4FrEQ5SIrE$LlvWC4a6rKIfut4vMvvfAiH3JEA_bNPs=",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ=="
                }
            },
            ["#=qP4bmhP4MC7AxZEtXX17Fvg=="] = new TypeMapping()
            {
                typeName = "#=q0W9ICkYUOFDYY8YM_KaxCA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAOwv0_4CVEzMZaISjOGv5g=="] = "#=qVGb6df_nYMIzvtZROSq02g==",
                    ["#=qJVYQzrEuzeieBsF0AaGt7g=="] = "#=qEbzFdXzJ8Myk10T9vg90HQ==",
                    ["#=qSrqVkgWqKqt53xxrvz4hYQ=="] = "#=qLuqfXUC$hn4uZZodKhDCSw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q5ZXaojGoU9tfbcC4zAQpWA=="] = "#=qu5qxsls7GmfoF0Ebl1QC3g=="
                }
            },
            ["#=qP660_FdmceFxmF7K_m10AVtPQ5mD6t$UHSlvTqTJDNw="] = new TypeMapping()
            {
                typeName = "#=qZ3$3$Jf$6riSLcbw_LjN4$uA_gRSSN73vq3f8bUQna4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qbZHEuohytmsZe3u_QwOdhg=="] = "#=qIBHqU9YwphzJQItgAvTTdw==",
                    ["#=q8ARY6RRtgL_Zpxktc02Q3Q=="] = "#=qLIqqmznjbDEu3LYuhc4PdQ==",
                    ["#=q70Ep$YP4B72Bot3CA7hmDw=="] = "#=qeKjRdxbD7rabcFWTk0y7Mg==",
                    ["#=q_5ryq0w3$M67vHlbHC7Cig=="] = "#=qVyn4nm3Scll9tLldPqE56A==",
                    ["#=qHStTTe7nw5AdUx$RVzVzNA=="] = "#=qvd5bAg4C3tyN0ykpPk_Fww==",
                    ["#=qrVWBlY69RkpSAmZ6Eo7WMA=="] = "#=qck9YjyMsn_i8bDrejYGOtg==",
                    ["#=q45Cusri2aePzqHqbVMmm9g=="] = "#=qri54J3DhKPmOMNQsMNIyqg==",
                    ["#=q1yLx5WiJRutCro6kQlDSQQ=="] = "#=qGGXzTadqOJ6vgFhIwwLirQ==",
                    ["#=qxwtPMLM4fAdaoj9q5efFEw=="] = "#=q6Zp4Ce9m4NMehED1dIj6qA==",
                    ["#=qt13zYf2aGzKi8LfNmStMDQ=="] = "#=qrNL2S_Vr73z8wAiJmtcyfQ==",
                    ["#=qYOE1tQH51m_a8YWjr$oQthNNF5$vY3hW$Fl$aIHjlBM="] = "#=qkUKQEIqENRbX4bpWJe02gWAWq6ESfpcJ0aeWk5q$ggQ=",
                    ["#=qaubRARrrxfu2uphLEGBNJbjRcy5D7YztpCEW8bRpGss="] = "#=qLhzSeP$dS1htGcJI_xrIgnsEpXjHF$LFOt8zD6gPLuU=",
                    ["#=qiGj_zQNNlIL2KU26fWEHgw=="] = "#=qYcNOpG9f0tw7Y_h5OSt6Hw==",
                    ["#=qhcE5ARgpA1pNOddtKS9kdQ=="] = "#=q611DHGLcvSWccT9BVCX9zw==",
                    ["#=qKdwfK3$FR_dDEMIln3zjXA=="] = "#=qU6tWtopssgHm1dQGbek4xg==",
                    ["#=qHqSShYCDUhZsDCWe2IoFEA=="] = "#=qbAqx$3kfB_4HloaVLvfn_Q==",
                    ["#=q2uPHyZU45LcRwD28lmfhWA=="] = "#=qdJJTD6NGJlwLzmcMgMnJ4w==",
                    ["#=qL8weINGHT83ITJG2Y2rMXQ=="] = "#=qaOrqVbw1IcFm2x8$Qkrm5g==",
                    ["#=qlPq6qDGPy38CT778ADjjRw=="] = "#=qg5HZFqgPzutIA7vHMeWSiA==",
                    ["#=q_pdMba60Rnfs43n_Ukg$FA=="] = "#=qKxJWdmS5F1vV_xiQg9925Q==",
                    ["#=q4_0_YXJBuMLBu9abvbaB7A=="] = "#=qMGo4WZ2F2gLied1poEvDvA==",
                    ["#=qPnUWd7DOaNNzPl4lCoIcVbUHSPJ6835VVRTB5SCkFB8="] = "#=qQ80DuJc8pZn34TkdtUrnsegcj4p_n41kHK6Pv3MtIuQ=",
                    ["#=q8OweCgI2h3Vv1NXsalgaAriEcC7UdAGnII9qsY_xv4U="] = "#=qJH_rURbco35q7056MoV_BK9jUZbr_39bmzll_XbVZYw=",
                    ["#=qvOZbMFBcDJpEuirqndbydRK6n97Ox8p8rYPnl69Meqg="] = "#=qjpGZnwSUE8EOx$YU6HPo6dQ5ffbT53qZlGfm5gmiIHQ=",
                    ["#=qJPkU13x8pRVvScBWbdqclmby3y0$$l7Ui3P4C40oNi4="] = "#=qErDeGtXm0OydlQsui8ZxYpJccIYKiJEaDwC3QMl2Dwk=",
                    ["#=qhIJgnaFMkrG5a27CKbqIKg=="] = "#=qezOoNRO6xg_q76WMuAVomQ==",
                    ["#=q2LYrNbC7h505w7GO1pwAnQ=="] = "#=qZQRAzlHd1oHH1YU30jyiYA==",
                    ["#=qHeDLKHIlwqIc8Dt8a1LCvw=="] = "#=qihNwVcWLpcX_3Oo8aHGL_Q==",
                    ["#=qAN1zs3jJ6j4LhDeM3tO0sjdwHK_FkGcnuL2Hf1uSBKQ="] = "#=qCJ6lVw_tETD$Cok8gne64wpWEItkwf4Ddx$mMAfmSdg=",
                    ["#=qUubqfGEbvIeiFS4RTDH0kH4IoaO1mxDVe1wza4EdlVQ="] = "#=qq$Qr5WbHTt8D7knewjIsnAzZIvBRBTaUj8tJgxOm0jU=",
                    ["#=qJiywcdSfyZ_90Fz4snstimeRlCOQdf5lf07lZJKQzGc="] = "#=qMFItDS920F8Sz$ptoVJub$0j3n5OwpqC1ZN4zdEhzeM=",
                    ["#=qFzy_wHtem7E93$HRN4f_7nS3TLjzZpyW6AMtsuc8e08="] = "#=qKfpjGHkI8GTFrZuw6LPWPnETeVf84Qz1PExk1sd3G4E=",
                    ["#=q0vR64I5XtO$2x4F8mS$CsTiew7HxlWQn_EPEk4Oq66g="] = "#=qOdGcHc27ALLAiFx08b1QuEL2UqNOyhyHwvdKRY3pkzk=",
                    ["#=qmkEYBbdsaWudtzXkcE3VZObNJ_SMjS0CcPoPcuS3Oag="] = "#=q5gi62k1BnRO2wG6JdBqW6mRpJpfKiMwXxe2Y2m6ay8o=",
                    ["#=qIqVv42jnzWojm9k7x$mKprrS6ppHkrE4AE8RJpLbLBM="] = "#=qLyMx7uT2f55FDp_pEyq3MY9xBvxSpaxaM0QeXrqlbG8=",
                    ["#=qyVjk68VZ9X93x9rG$nHepLB2Yl_QAtKfuSadidpKgj4="] = "#=qvk3G_S3ChDvJS8EFYnwavYcsWFCHiaZ_Iz_8eIle6yU=",
                    ["#=q0ldSkFoWmcNCM5zqDsgfrQ=="] = "#=qFnoMjnf4$eC3nTEX7dBABQ==",
                    ["#=qy3vWXHkCQWESVR90iSbp$g=="] = "#=qnP75rSD$0ESPXgScew7dvg==",
                    ["#=q0MIgN1FmktkqBHhqezEEnA=="] = "#=qVpADIrXlmGbK7XaMXrGBwQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor"
                }
            },
            ["#=qPbQtczTimNo6MJeXYU0s19k9E9TfGWM_0AnWAiGoeEQ="] = new TypeMapping()
            {
                typeName = "#=qfIH6M$BA7aO59WnCAyJc1VXl79HNxkii1YEg0OPyFXM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9o$_CNX8dIvQB2TPHh3uqg=="] = "#=quBzpcqz7r9mduMC848yCiw==",
                    ["#=qj5473o78Y74MNwHh3Jwi8g=="] = "#=qEEl5eCo4WhqHFCATBAoXSw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qCoodQ6zeH8kYt9$OSwT51g=="] = "#=qPFC3WlIFEmdLgK6uIR1_Xw==",
                    ["#=q6Rt_BBreTivWqf7fr1bQPA=="] = "#=q5IpKuGlEbQWyUB2ZSzCBAQ==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw=="
                }
            },
            ["#=qpcCrOZGpXpYeIIpADrbK7JYxmT1q0bbMNat1o9JXytE="] = new TypeMapping()
            {
                typeName = "#=q0fsd8fjrSdqb$Lx79jvI7Zjpt7i0fB3HjZwLEZiEjX0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qCLxmUOPEOsPus3PCrsGo8A=="] = "#=qt4cV2gg9g6qGvD_9JJtjtg==",
                    ["#=qb3Six_dFO9hfGGjJEDfElQ=="] = "#=qmmFz6T03jiVeJiTOuNe8zw==",
                    ["#=qI3tQpM5wHy0zC3tWdWZipg=="] = "#=qzEKaw_bEdfqa8xLKzZwPbA==",
                    ["#=qpllAav1noJ4_NVbPeqcryQ=="] = "#=qrSdtLBR5$tflhMhY4EINNA==",
                    ["#=qVTXjzgl7guCMhaCsNnhV9g=="] = "#=qAuAFDJPfp6edgv50Und5cg==",
                    ["#=qJ2F6zvDMeF5IGvyDe1AJnQ=="] = "#=qTobqFdH2lbun3lrMlR8MWQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qTSNsYeIHIvPUeK7GKeeZGQ=="] = "#=qgvyr1076ezNOwfdiQxMOCA==",
                    ["#=qq2ZBhyvtaEHsU$c4c9CJmA=="] = "#=qw9iyGHUYMOwAfVNMoXTPNQ=="
                }
            },
            ["#=qPCXLUVYrGhfB_HTV3hXIwDfeltuy0a8X3B8WgZD7uW1RYaQYETNDG8GLWGHN6YGF"] = new TypeMapping()
            {
                typeName = "#=qH0PkJzyeQiRC2VA2M4tG1x0IZvPHcjT2U3vpTbNfuDDtqjt4g$1LcpR0Jyg2Y6l6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3EXJfn4Gje9n$ZUs4dSkrA=="] = "#=qe$mKimPFZuvgxuaGbgZ0hw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w=="
                }
            },
            ["#=qPDgUsd2wibdM5MQifm787cHHkOF2WrWU0gOE6I1Sg90uqyw_Eeg8FVDXj4cK$v0f"] = new TypeMapping()
            {
                typeName = "#=q5qZ3hMgYMXSHEEOkEEprWeCqfZSvLgAYrsHlPDzzTPtwW8$iFS5sdHV$4y0wQp84",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA=="
                }
            },
            ["#=qPDxYg9Al0UJowcs5h$DPCAt1ZDpZLqxYnGriTtpRPOQ="] = new TypeMapping()
            {
                typeName = "#=qG_DPWDxQ1Ats2oRCzI62JVF35zvfPnzQCXdhEbQudkU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qmljqo$zpVAw7gIukc$iD_A=="] = "#=qXskK1YQv3h5G7f8tE0cZ5g==",
                    ["#=qEs$jw$Ht202JKThbaLcxnrOd$CugRTUIw65Cp2ZiigY="] = "#=qwgGn48GBiVRjLApOfkNpVxTCK3pBxOIAi634pFYR0Ms=",
                    ["#=q5$hP9mGXrFV4SpWROHPJug=="] = "#=qAUaBAYAiLCBxGJnTQpUAMA==",
                    ["#=qM3KSkuau5p$X6FdfAY4hfQ=="] = "#=qtvk99kE1yoA4lBV6KA3bxg==",
                    ["#=qzysrcD_rYjJEt0Te1mz4Yg=="] = "#=qFuinJoFnaP9qA$qaAQd$KQ==",
                    ["#=q_kXzeLdfQms5WXYgLTYj3g=="] = "#=qVh0QKvEKaaoVdXfc_B1Mgw==",
                    ["#=qM9Vgeuq5EGTvb_agi0$q2Q=="] = "#=qQT4X1E_K2l3_btnr4XXN$A==",
                    ["#=q7dhxAMykqge2D6OdB7ey_g=="] = "#=q_qhCvwFZrgNMrpqrWlBhgg==",
                    ["#=qeD2QOfd9G5utMGPuMFoZqw=="] = "#=qFn05S6PD7DI7lVQWa69Fgw==",
                    ["#=qFpvFPm$5gypDjeSOc1QQDQ=="] = "#=qe0_Hei21Yd3O8Cut2G718w==",
                    ["#=q91x_AFxbx4IJQ7Y__ecCCw=="] = "#=qeJfjdX2y1AU1bXwnSgs5Cg==",
                    ["#=qd47iyU63tx4UgfFKI5o9QKyPtdlUdYO5xjBleFejemo="] = "#=q0tMkwZzDQlku4lpcqi_k9k0SzYZ6o9N4Hw$NgCAhM2A="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Xqbmjpf2yrvPTug2hxppQ=="] = "#=qi9gTLwglUvkWFZ2M640_uQ==",
                    ["#=qv2ZolCwbg3j9ejDXsiJByg=="] = "#=qGGBe1rwushg6jVD9yeGJnQ==",
                    ["#=qxBEcP4lqpk9mch2FN0XaQA=="] = "#=qbe0k1$rrRJH6p9zOplWphA==",
                    ["#=qEDsFPvYHPdpzOTRKf1lrxg=="] = "#=q2AKE$ESFLpudzcnMlsjtag==",
                    ["#=qg3h0PHHoJzBwHt4UpNp9nkdADRKXvKahqm5dpGJmbFA="] = "#=qQ5J2101JzbFs$PW85WeaS5DQKxUFZRWBToainK2HtCk=",
                    ["#=qay_S5RPvtpM9xAa_IiU4FQ=="] = "#=qeYcGEyJwiMis0nECJfftdg==",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qI94hrrdIJOD_pOvtJZEQC2XFDtvilJ52Kf46vJKaUlk="] = "#=q$omJJUk7jGeTjxqKbtBD0YbPD91GH93gJaSG0oDdh_Y=",
                    ["#=qZZp4sBTbQBRyBo04INLdixxpLQJfOnVWEHAE2Rx3V2A="] = "#=qEMML28Gg4kd67JUJQC77XRx3eOR$lusP2zLYyzkDS$Q=",
                    ["#=qzZhabB$V21bzVfZvfinQW13Ay9i_8WN2g0f9ei1UArY="] = "#=qVVx9peT4$cbUM5sSVGbHfitMMyORYa6CXHIPCa7Sxxo=",
                    ["#=qDaMvtdaMNaKqdlcuX_Z1GawG0McOr5xjQT0IEsAoFR0="] = "#=qMfu1lC84ZdYlBAk1ndJqWtji_WeXFwsq68bKFJxuHHs="
                }
            },
            ["#=qpGFoOJh3uG5yoLVYViQtMvvH97qZmdAld32WupOcW_CRvqeh3uZvEcMAfq8gTrz6"] = new TypeMapping()
            {
                typeName = "#=qpT1t96dZbxlUHJdoPnLZZeve0cE6Rjh11LwpUfBjKU6phSBbpfXK9fCYRQsYr9dr",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPtgg$rpAVVBrHqDN0f0XEg=="] = "#=q7NZrXVMB$ywUktx0XCK$Wg=="
                }
            },
            ["#=qPkaLGQ2RKS1x5uVvvCYU3SDosbh$zIOBFzCXfZ3HpKc="] = new TypeMapping()
            {
                typeName = "#=qo2PWZWz74sDARYUr721rB8OVQD_9cVGksEW7ZW0rcNc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qV2GyQCAn8tU3vXcmswTWVw=="] = "#=qPatGZpKFA3_9yldkp46tVw==",
                    ["#=q7_fE_33PD6kv1EmgKUSLcg=="] = "#=qmIEjbUjEtrkfhTqjegGy6g==",
                    ["#=qrOqKHDnk4omSCpdT_YtJaQ=="] = "#=qol1re95s5FVwVg_DsH8uDw==",
                    ["#=qRmo9Rymz47Jh8YGUGYGUKg=="] = "#=qZ6AE_JFg1GFzbqP1_nsmvw==",
                    ["#=qc9XG_KeY52WobMqRmKc5vg=="] = "#=q_59iBotnT6cLL1OLueFdng==",
                    ["#=qrF$DhpPwM$rHVAHqQ1q5hg=="] = "#=qra235lkQPlwOMH7DMqkYXg==",
                    ["#=q8ZmiadkH6HvCzrhoxt6yWg=="] = "#=qHR3OCzF0Lpy_d2caxjcLNA==",
                    ["#=qCaaCEYehG5RrZaC$f7$U3g=="] = "#=qsPqA7R3AFnpsN43wxTvUog==",
                    ["#=qVO45gy5DnJ70ZZsUDDu9xw=="] = "#=qpxK8nIoeHqRMh3XBE0RDtA==",
                    ["#=q0BWHK0TJUFC0bFkW$Zt1pQ=="] = "#=qg1gbjeB5s5k9tfvHkIty_w==",
                    ["#=qc0BiEh2EnK2XL_mfURESxg=="] = "#=qCaMQQaaPPimEEEHxk7xdWg==",
                    ["#=qioHY8Nq6MF1Qjm5uZ0Rhcg=="] = "#=qqDJSI0DBMErvS6sVfucjvA==",
                    ["#=qgZ3WnCWMlfTdE82qhrj4Xg=="] = "#=qYOrKv0IKeFH3AUjsaE9ErA==",
                    ["#=q0pEk7ahiak1CSHNZXdnZIA=="] = "#=qBWCHttW9cKid5$uJr34elg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=qpoo9B8HJ1jfTSlmA$jY_f$B8kCgrbb033C6bfA352$Ttko8vqcnml6AiS9bKcL3$"] = new TypeMapping()
            {
                typeName = "#=q0N6djdGm8OLB3O_aqTcL1v65I0uKOpB6dONJQPYgmajanTtpeRMp4rrqkqP1POwc",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhsFSNRLW56TzxU5bgykrSQ=="] = "#=qudAsfDYacVu6Bhlg0Rufpw==",
                    ["#=qLVZaaJIPh9SPlgnknAlASg=="] = "#=q7tHlgkor3v87MICR9a4JUA==",
                    ["#=qZ1jUGdHkRoDbakG8NvUpwK7DfGdKbRuYcWCc4kQcp8g="] = "#=qHOd4WlbIfVZJBihss7h13FZEiUPlhQTm6ZFHLvrpqu4=",
                    ["#=qN7aUmGbF49l7XmVp8f6W5y3z_kn6HdDoDsDgmQsE0iA="] = "#=qbv77Dw7sRy0h3$i7lFixIS0c_z$r5GXyw5eqZYuPwfQ=",
                    ["#=qdzLL2xCMAnOU5akEOqYoUeYygrambWIUpZ1EPCJ_y90="] = "#=qV3xxlVPhhqY1DZ97$somtZC9YwmbKUNxVmEsoVhzSTg=",
                    ["#=qyZMnisn6lc4X6_GQwmkQ8Q=="] = "#=qGp6BAA6mkLtxxZp77iJTOw==",
                    ["#=qdbx433vmFov91EOdSWd4b2PVypKSU$DsCElUcEBPx5U="] = "#=qPtNx5yz37f8LWAIWkZfbbKlnAmTnRKwnIuTYO4hAlBg=",
                    ["#=qwHTzixMftV_TMpNla3S7wQ=="] = "#=q9HbAFrQf66H6ImMSmyPMVQ==",
                    ["#=qoHWosUA1cnUeTocYFYMmiA=="] = "#=q70Rza5N_vjT5bWEJbNEjLg==",
                    ["#=qA_ouasSSu6KFqPtdbs4bCg=="] = "#=qCf81jpoz2jTSKGUWzZ1YMg==",
                    ["#=qdyI2zmH20kmzlJN8Oz89ZxFuZnZN21jv_u_qKNpBdqA="] = "#=qooMNBJNJb89xGDAnnIVnjsVKkBSGHHXj$EIDXQZVBaM=",
                    ["#=qnzbvaoP2amItxeWk8EaaKg=="] = "#=qoTkQ80LZyaNqGDsZs$1qFA==",
                    ["#=qCCEo0Wz$VOddL9gcYcES$g=="] = "#=qmYlbTYQndtlHnnuF8GJiUg==",
                    ["#=qgwxnQxSVPHlWH4pH9wfRzw=="] = "#=q54wUrBCGc5c76_jujZXk_A==",
                    ["#=q4XAKZUWNEjG_CJtjtwyMmw=="] = "#=qobnvkQq2o1VxbLvvxJ1scA==",
                    ["#=q$Wc1XjIN3NUsXXfcDmlA7KDxu9u1yPYWirPk1x17ccg="] = "#=q7GhJlaPFe5Qlbo7vU$XMLy2Yb9mVZDkoxsWE_oVRN1o=",
                    ["#=qasDKSVNaoU24xJ2$ozbL4XHSfTN0uV11M6LFWhyebvI="] = "#=quIQtI51Bq7NLGSz8pK$BLyqfpWNOFeSDUxxQW62exrg=",
                    ["#=qMXF$2m$Uyh7muNihyH5RrA=="] = "#=qA0yGizIk_S8m7cYFw4qHKQ==",
                    ["#=qd7tZj3ftZO1umMFx8EG38g=="] = "#=qyQoItk5TtEl6rVrmoCY$sA==",
                    ["#=qapV1bj8l7lpgeRSj08PsHw=="] = "#=qHu2VIED_OAobvA01IxTcyg==",
                    ["#=qNpKbReL4H7rtnwdw5c8_pA=="] = "#=qj618hrWkFYl4I1QNVoTZVA==",
                    ["#=qxLVew6xr_Cmb82ldBrgWow=="] = "#=qM2wlOVLwNrGFrUwzSeX_GQ==",
                    ["#=qhz9YpNPxWh9t8FgzJrocXbpvmIyBWZjIWQiPaFW6bhc="] = "#=qQ_JtJO1S_Ja5EhiKCDXpJmhrzsRhNproq2JyXNZJxuA=",
                    ["#=qfHPxi42nLxwzlt3yYl96$A=="] = "#=q4n9Ilkwgx8p9l9iKR59vXg==",
                    ["#=qIdEXAB3j_MxqprV8j04xXWgMkr6bcHKoKezqalw5RM0yGE3kdei6iWQYk2soOSjH"] = "#=qeVe2A62DSzpHy2UGqcdGNNESTgkZZam$LNHK7Z3$KQvVhGVA31FrbnJZTRtnc_Np",
                    ["#=qiIgBLxbUnVNACfr8AcklsBYNxE_85TMXgzmr7UDquY7uIGTSerBCN_7lGc3Fec8E"] = "#=qg7HLJZAjxQ9KE4qhs6vqFOEfiKUDazhIJC08cJbcQgdtVwAGJ1f0txwreS7z$TVz",
                    ["#=qYalx4WUHeIEPMQfWjLNbvuP7P5UsMrXTREwf95p140qx7EfahMQ2ODGqn9PQivw6"] = "#=q5f35OFP0SB29ZVRS1DWeWO0dFVeqJLZMn8aq8$7J7KYEuGeRd3xZMHm8Ojwya94P",
                    ["#=qE8uF$vYQPLbr6cQlHFILJ7R6$1yM2udPd0Dar0cBy2gHSWWDhrpZnaPYOgW0oO23"] = "#=qg5ZBYP4n7ngVCo80KgVknZDDRIyVsDiWcSMtWInJbVSeM$1TPAY8ESEC_wODfMRE",
                    ["#=q5TMIokeivS_tFzY3nEFeHsBJs$MKImDRrb9em105O5AGCU2BkFCG8tUFmds6DWlv"] = "#=qQjCmZBHYUeEPAATn9EsRwHxjfyR5R6PQNDqWp0zozEHKFZrnzPkCFqlyphxQLFUZ",
                    ["#=qnMAxlTWoK74lSxWnh9f1unMwvSfiNR9VPi7HX_m6TncFkKEu5SnPhz1lqqsT73QB"] = "#=qJY67TAg2XmI8PdCK_VY9uCkKrapyjscEbEp3f4tChRJ4S9sBTfWDoHMiLENepHih",
                    ["#=qm1fTiztmRDWIFReCKkF1_a2Q_EhnErtFzqeE3ZKHRYvNLKkb_wRpHvbyMhWjlgF$"] = "#=qbcsHo8ZXkEnL$1TzyYbMbWVaPth9cWV94NgtN$W98mxsKokmBcFohYiMcFyjDVAZ",
                    ["#=qfLD7j7ju6ogoElPkK_pwrJaRlvwSx3kx1tNhjzl8yhyr_xCdY8DhUsr3tuV5$j_V"] = "#=q$KSp$23WiyM$l2dhcJ$OESum5K7xcHAGMz9PETkaSHjAiOOyVxEVapcaY463ZuZ6",
                    ["#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$AOtPokUbs$UFZOS7yO1VVcm"] = "#=qbyeXK4GyCkr3C7lbVwdVkLfhXqHQG$xWik7pSU1ZroF5vbksu3igPmtM4Ni3fAOf",
                    ["#=qIIPTH4n2clqCoOvhJGchb5frupeB3ZaHHBD3yZTh8_LHxFhc7WS3ojQd_X0S$PMo"] = "#=qMs$MQ5zt6clvN258MuIM5fu91oOKTN8rpFyuWWlRulTjxp9QkFFezon_wY2kpgcq",
                    ["#=qU1ssvtk$leEsQwmy8XTvZJtViCYsMaBEnn0eSIYi$baqYcJQahI0JN0rooEE2AbK"] = "#=qAzTkgudx7JhUWqNHzQjQ8x_WXqe_ZACxJZGaYUbHk0bnvWSA8KXQZClB75Imczi0",
                    ["#=q8c3bExyAMSh7ZuL30rWmzCNjwLRSCnA4dQr0$wctEGTwYdxOcrsjqfK8DEcfuzzT"] = "#=qk4Ev2HPNBpuW1EEDKdjlFzFP9VIU7G$QH5na_afbYu4WSxqKz6z4FZWlXaKQhQGN"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qzr3LSEc6JZRt1y5e80Ebw5zS0BCJeAly7lioAJKiUa4="] = "#=q2tXxfr7WH$MHh6VuVzGaK_P$RhCREj_9cVBXZRvNoCA=",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qnIk6vC4Ehi0DZjlvbqQaIAqV4zC305X4xVqfrsORNC8="] = "#=qhEHZD22sSmEvZ8482OFbQ5f2r_L488KC6HApCbf98wA=",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qGtXYesk0LCqzhl4_He7FdA=="] = "#=qVQrjFWW5GALSwa$ew82CVA==",
                    ["#=qZe55oqAzwPQt72oRQWgeVEALacqFijFWj65X25tiGFU="] = "#=qmSCs2FbViyz3jI7JoNlHXg9cZ3zd4ZBs_v912dEwQDw=",
                    ["#=qkRH9ybgjj_$hQm5JmmMYyo6xUj4tDU34TYjtWUZo1kQ="] = "#=qvMKah06KIvjFP9BfjtY0ezNVVao3XeLo3aDytP_DiKY=",
                    ["#=qIHft7FcH67tGrv3WupGmng=="] = "#=qUmPqKjIC6FtpaXsHOXe3ag==",
                    ["#=qwnOPT03KNoXwmP8bgzjOwpqW6gU1UNt2cWxE01qP7_A="] = "#=qAha0G0Po1LjqOLCg2sXt$bH99ZvhU4KH$_PDWWjf9bg=",
                    ["#=q_UQq7A1NBRQUj2BbedX9E1RLsMcDJ7t35NCTEOinpuXXaitg3xSJ_rmB16FMsPS5"] = "#=qmCizzkQ3IHz6F4NcoqOAMQgLlySbVQRGGmyGMhkEM_B6_svoWQ6Zu$_oCeKbhMVI",
                    ["#=qmx70s4BrbqjB6xcYmPWNw8MdiZrY5cVjCLTqyDDrq3o="] = "#=q7B1nCXlN4OQBg8rdoK44hb8o29UNy3hOtke6V3IpCmo=",
                    ["#=qZxXMw2yYjdIY3lckgUUf$Q=="] = "#=qAHMIpbZ0ZhFBRhC7wfjaqA==",
                    ["#=q2ouZnQnO7a9yX8Q0IcyaJpwangfrDm8ZregkuksVJNk="] = "#=q6BnPhe3x5pX7Akvmz8ZJPhEdX2wvlnbk8Z7g9OLKW4s=",
                    ["#=qGIs1DbwX$lv5bLgmlBtApA=="] = "#=qDKHfKkgzPZRTDDlAqr5NxQ==",
                    ["#=qo2GrFemBul1wgilIBVWsOb126uSD6cW6fwfXt8ce01Q="] = "#=qNWCNhkWVCmo6rHjdjwXz97vB50pNXbSrB7VfOX7rGLY=",
                    ["#=qVmQ3uxZdFdkIzFQJQMIN7Q=="] = "#=qpi_b__p0jbW98o6qWO5H0Q==",
                    ["#=qadKuZSga31tM51qtPA9oDg=="] = "#=qDZmc6ggNW7VTmvpdN5pB0w==",
                    ["#=q2t8moBMVJ$MPzI95yx$SLtjgrjKxatfvh0KjOYSXI84="] = "#=q2y2KmES2dgj3eblNJ$Lksa4ivhF2qwwDWPmJiyrvrac=",
                    ["#=q1JfeTQwvUMpDNC8RSBD0te0bkeY_7nGF0vANnt0FsyI="] = "#=qhYD_eKuCXcDCuLWUtqHdjaTAvhb1oOt5Uq6LTCY8dMI=",
                    ["#=q6HVl4ixKoZpQYuscYlSQmqj3w3nsMu2mBHmrWrYZ3Xo="] = "#=qB9OpCsY7VzcW_pV2YbxgZqdsrUoFyxdy4yjlmOvx0UU=",
                    ["#=qZzmDP8oATshZyZb3DrirCn3cMHTRv4Tu$A2ZKdWF4D8="] = "#=qYK8ICnzzk_y7oSNXa4jjfrjrF5TyKq5N5Bn0BLy$ts8=",
                    ["#=qL$JLM$CG9minHbEaKkXnlEo9uavK_d_jy73Ga0sNk7w="] = "#=qg5QWcv4P$R7_j3zhLua0KLZQZa8v4GhqADWx$XKY2es=",
                    ["#=qeE5Amimt6E0f6x1YITAXiU2BG868HonWSBRHG1pyj9Y="] = "#=qZ$z6DrmBrlY6VZQ02bBhfc4rpuDegS3VyK4eGxKbZCA=",
                    ["#=qbsePcorPDVBncrBUvtTGH9RbBoTEAOkFPexwA1lM$1Y="] = "#=qVLqYxs6b9rNhcEMORgkXp47v9JftIFcqf3_VConTzH8=",
                    ["#=quQX2iECV$i2pr_PNxHYsVQopeBYMPvzXrt52J6ihi_U="] = "#=qYFyqx5o2BhgcH6YTEBOQ_J7UERPkAG$WUu2ns2EidZI=",
                    ["#=qRLfgvgtI263PmD2uHzSPpD3KM0NsKwWhHKMIkP_w44Q="] = "#=qcVw7S$Ua$d4Qi5jJ7FybijSCNwVkHauuyaQEwjTbrmw=",
                    ["#=qDJvs8vHvN5iW9jryut0WbvrMP$86S1NaFXYvnwPqg0I="] = "#=qVpiRQqossa1sOz4qz6SzNemLxn2tU$WHCG5fhnpGi8s=",
                    ["#=qDwUobjq2tMYmt2J5GZ4MI4IhWSpTcTJXIeRfTZlfiIw="] = "#=qKdUPwwbtNTJ9hRfIseNMoT6y7I3JBRKQFxp7BXna7UM=",
                    ["#=qDvZ$avHHwBqksP6D1o863PkKAWFmly3VECyPZDlofAw="] = "#=qEl7cp$ib6DTm6xSsdKe8zCdUTZHvwySbXkkypjAIUlE=",
                    ["#=qSHcQzWzgc8pXNZeV$xq_MvxZ4Ymcm1QygvoU_GrlJiI="] = "#=qcrzAJ6k1W1vmDfi8to4xwHAW5zyGL1W3pKL6KyXVzTw=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=qk4jLI3V2NtjYriX2vZk4xxVD8TRH5z17WkFOipbKY5I="] = "#=q6EPD_llspYQSn6SPuOJD9mQ0MzIS54c8jN1iejDInlo=",
                    ["#=qsgG9j$vRt5dCRlI9LjwiEli_laBZpGUsSCkfq06A0Jg="] = "#=qUoMY5L8GmCr4eh1qcRxLiuFLV6zfGEoPJglNG$JYzvs=",
                    ["#=qikoldAO1u2tBqigRjftL60vrF7WRwYAcSFV4NyshDKQ="] = "#=q3$0iO7yP_zeB6bzl3DphoCvhD6eWLfzRHox_SXib7pA=",
                    ["#=q55e5KZfg4edKGR8q_jR3eVZZGjTxgNqmUfeeJCQWM10="] = "#=qiU3Q$udgt46$uPxfdIkJCAsSUFwGSkb4fsxrStjqhLM=",
                    ["#=qzLpZC4dJInmPKfd6cdJHPAvyqmfXwwN1R$0tXh0uY04="] = "#=qdPbLG$WbGxLkmqY9WJU21TeC$rfiUNk7ALzp1KeoR1E=",
                    ["#=qvCA0IE79IPiA3pByL1CB7Glc$lwnwhrF8R9hdievPcE="] = "#=qqTQQc5Xv7RBqKzbJSBDkcD0RnpJq88MMuQTMtj9IX2w=",
                    ["#=qy6uFemV76PB$rzBVMAslxMl9x5ey1KBt_pW_OU45yG8="] = "#=qvCA0IE79IPiA3pByL1CB7NBYk8a2DQWlpyBeHZvbO1E=",
                    ["#=qyYbIb7olrcZEtsCfS5Nwddoiqu39WBiZPVCsSSvG_MY="] = "#=qHr5hiJwiXM4Ad6WvO$wWyTKTZ2swv5jGjDd3uBejuY0=",
                    ["#=q69SiMrPFS2bqyyb27_7IFeVulNle5DQ93u3mROAPCxU="] = "#=qkUiecqmIY8XNNy9TKWGjTuhv2Uzw8WD1kclgH2dem4A=",
                    ["#=qMCNnCoQflGKRiSFafNv4Dn$$XrVdVZ9aozkrwXgz$ds="] = "#=qQD$_WGHtr3zdQvEyPq$klfz_B4ZYpQi59OaccUZx4jo=",
                    ["#=qMWnORaGH9zn3xXVl2YKo1yW1D7_A27ouDkwksMNbo88="] = "#=q2wro1GG_jtOJOLjpZrOUO7la$6cU5IQUK3Aljz6Zy4c=",
                    ["#=qMz$znbncOrjiXiP7wFXg5jgEAFb69_YFHQBk2aNC96s="] = "#=qfKtp1pw2rmOdweLFYcLatDPcNJv36QbQIVswFp83XUg="
                }
            },
            ["#=qpqvJBjVdfxpD6FlLOOcHmPBqZFc7V$izBaQkqv5lFXE="] = new TypeMapping()
            {
                typeName = "#=qRf5exDu091sJhDDvLHzK3whXnL98J$4nxzF$fOWcXJM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhL40pGKZPJeDwtJO7Yzfuy8C5NUR_w5RZc2K7i9LB8c="] = "#=qTuSUN$fKSQS2g1RPi$dTOAvKLnYAS1G8ibW6NAwrYJo=",
                    ["#=qHfsgDTZX9dCM0EbJG$5lwjm9hQQSpIZ9uTlRlE6lv_8="] = "#=qdOFsFH3eoSSrHOmBkTzg8G1phuSxfcy5FZprjeCbE1I=",
                    ["#=qpYxHsA4oJ$6MSJiAV4QCwLPv$ql$joVgQThgxrafeSA="] = "#=q0_w4zc1Lw2c32Ks0d3WGrDdigGZOVMvKOLzOiAV60JI=",
                    ["#=qIeeTDwzt$3JbHX6JqRk3k00hUOuQ5m3LgU0X$n1hJLs="] = "#=q06yb4sR698dYYbvWF3Gnybb1OhnmRSkznpfJ0c8dsAE=",
                    ["#=q3u0A1qks4xG39KG4OLjlEzfu0yOPzig4ypxA8yw6OWI="] = "#=q50rSdJ8hVGf17DaG4MkEu3r2Ir72LI$kChWhSP7wwx4=",
                    ["#=qMpzMZQn1A2o3sIHv$zwmoTZTAGq20oMH2EDBHhNxBp0="] = "#=qqePuYYlNVVmhDT5wx8ZgkcvJ1HP5zXy$WXxRCihggQU=",
                    ["#=q8V4_P2NqGmfz5tiooN5H5F1U2p6UCnXSIC32e5ljI4c="] = "#=qrOEstq6ZNrL5K$m5OGM0vFBZYjxoCQvYA3R615CGC2I="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qJWaziriVS4BGGrXcWqy8AQ=="] = "#=qPAvsl6c7lREyF1Ki8PRUGQ==",
                    ["#=qVQ5EeR$gFol9Vc7Nllx7Lrj1tZNoOI2eOjW5ViBVz4E="] = "#=qTlsUvLRJsOS7hI8qKgjlJIq8tzGXsjUTg6j9Hf6nWdo="
                }
            },
            ["#=qPrGMQeCUVkOV57HGGY8mtXxy5$sZp5JDzu4nf4QhL9g="] = new TypeMapping()
            {
                typeName = "#=qpytI3GmkJEtkou1tYk_NmHmDRpvJlWcXtF3pJfBVOnA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q$zIicWF6N8KzvqqGxW6KFA=="] = "#=qoCKR0MuqmTLNgiQ0LHbTYA==",
                    ["#=qK8gJnFV6f0nCF0DI3InSYA=="] = "#=qigwBiOHEJ4Gdcb21ACv5SQ==",
                    ["#=qXzAfG1gHLG3dd1SUxWKNLA=="] = "#=qUR77h34VYKR2fKfej0YlEQ==",
                    ["#=q0fTS6sMNPNj1m7k61aVpKQ=="] = "#=qGotfv34RFzt7EkYYCH1lCw==",
                    ["#=qM2$oneanoj_CzpgPCpcjjw=="] = "#=qeH4Ggd_$L7V5nJEZ3i5kpQ==",
                    ["#=qTA8RnxsQ8PN1Q1iPf37SVw=="] = "#=qde4KgLctuGjsVtfJibBIPQ==",
                    ["#=qsHRYoS$s8l7U$swPuD07_Q=="] = "#=q7qJmS1QTvbqzpKiRlSzf3Q==",
                    ["#=qKnOnBx4HwuOZY3pzPKxHqg=="] = "#=qDt2oywvzvZOAKDDMxpQHSQ==",
                    ["#=qAxUs9WgH6D1$X3qndyVRgg=="] = "#=q0er62tY2tOzAlXvpXIyMLA==",
                    ["#=q_uGrckevbveTMPukQMV0mQ=="] = "#=qhHuMi7_DAyktnn06n5O0bw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qQSofNlsISYNOGcB8o9vnbw=="] = "#=qMAnDRNvNf0a0VqXCDHkn_g==",
                    ["#=qEer7Eb5tzjyFrUvkCtPhAw=="] = "#=qi_QXwfCe$b7YcKwOwPncRw==",
                    ["#=qh$VXnbAnCL8AVxYdOfjxvA=="] = "#=q8_amtOzji8xc23teryO$nw==",
                    ["#=qROfTtSy5$KskBJOwaGXlkA=="] = "#=qkEWjFdm$7S3gibE3FM4P0A==",
                    ["#=qCcYmHAxQVrzONX9UAXnK9w=="] = "#=q3FTes6cDJHZWvmVG4$j0Bw==",
                    ["#=qX4oe$5Eqj5LHMQ7MbebeqQ=="] = "#=qCcYmHAxQVrzONX9UAXnK9w==",
                    ["#=q1nDBSr2tkVLaqm4DDJu3SA=="] = "#=qnx6Eocv26Qc95BQxL5Sqww==",
                    ["#=ql66VLWpwX$vOkoBPXIfT8Q=="] = "#=qYtdIT7X7AiNuil8wqTm0Ng==",
                    ["#=qcLlXwqfeimluq3jESy1nnA=="] = "#=q_YXSas$LJR3JQjwC16sF1A==",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["#=qYFot26QejtsxfKSSaf4JZg=="] = "#=q2zXMscfF9WotQqY6SQBxeA==",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode"
                }
            },
            ["#=qpTVksg9ERP1UfXIXSN_NQOc0cktreCHN_pIYrD5qv1w="] = new TypeMapping()
            {
                typeName = "#=qPO1$p1yW59Yh62aCZYFO$f3dm4CuDSojOPClcSs1zXo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qpuWOjdQ$fekgI88FYtdWH6muMdAlF8N4sjPvivWF9ew="] = new TypeMapping()
            {
                typeName = "#=q08w92_42jyUIQsfhUpaYx6jmF3jHdwUhZwPKDtchkaw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q5NFT_M_MSuF9$QyEctE9gw=="] = "#=qxCq1WjuxtN5BIYySTE7RwA==",
                    ["#=qJuuFPzyPDkU79PeYPIqNig=="] = "#=qOUxQBGpM7fQhw7UOge$28g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qpZ0Ref7ydVrWhLU0QDDXYu$FX8zKc8sc2UEzktJgjIk="] = new TypeMapping()
            {
                typeName = "#=qEuuxPm16QnohmyMTWwpKxS1rT7r$L8zN32Wak2m1zyA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8awjsYQMi4OTgst4kEvCdurSnFlTUSDchsY6yWzrdj8="] = "#=qnvnEVeSSTjWYjMRCBhVzFmzKxcW8RnUVlLgYaTif9Xg=",
                    ["#=qwL0deiYh1vEBx5er0mSzuQ=="] = "#=q5q6tZw$e364veQFqO7lOnA==",
                    ["#=qn9Is742XnFpcqee8eHtQvQ=="] = "#=qWxumCT169AVeoplQjDQSYg==",
                    ["#=q216$$rhSM9Vy6_sn0U$AvQ=="] = "#=qupZJdk4lR6JsViMYgh9vQA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qLdEDwycpd8h2F0loD$xdPg=="] = "#=qAD8xd885m4Ar55yuIvb2Jg==",
                    ["#=qwpQOtrmHYcTKd9vDlMRZiQ=="] = "#=qbaL9alVOi1K9aCuBwCU11w==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=qq$1R1EhMsgCoAjghd2qMrJI$KJiX21HyHPJRx1JuekA="] = new TypeMapping()
            {
                typeName = "#=q0Ab7KNsYp8QJ5ZmJfGl3xaeBiTIM4ERsvpD1qLpHj8w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qNoP0llmt7LJmS3H_DEeG3Q=="] = "#=qg9VFxMRg61rwO4nMLsHXYg==",
                    ["#=qtN$i8Ttce9n0x5MctiS7GA=="] = "#=q9Igb4R9fo6UvZdGxqGh8xw==",
                    ["#=qrHssyHJZ2lV163McreHRNA=="] = "#=qfq$I2hDLE2umUmJB0uak7Q==",
                    ["#=qRjCj0NDURatob8$8EAa6LA=="] = "#=qH7Ojg4Buw7f9sXFOwFge9w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qKVnXEnAcN1z7s0TshbC8Pg=="] = "#=q2m158v8Nj94sXvGBuhjyWQ==",
                    ["#=qihYk6wfsp8nCgpB$p_Qc8g=="] = "#=q9oPRTWGWVuot9XoomQpdFw==",
                    ["#=qOQ$kikdZD7GkviVblI37_A=="] = "#=qG$FKaRUh_QBzNxbYAVhi$A==",
                    ["#=qHjeJ7qjX_koyzO9dLcNhlw=="] = "#=qVekiTAFAOdIS0R22evhzMQ==",
                    ["#=qCcC2k$o6Cd4UYNo8p5Sw7w=="] = "#=qyTVC$R$CybDTkwt99s$BDw==",
                    ["#=qCoHMu1Jr087R3LAlUT5XiA=="] = "#=qpHiFn9kJVSk_7heypdHcmA=="
                }
            },
            ["#=qq0A48JbOKylPWpk6lNUr2mk6N9UZk6C_NxsF3j9RRVDQ2URCLPcMdyIIoQ3ngTZ0"] = new TypeMapping()
            {
                typeName = "#=q7NBIkmAJIFcOU9c4dL4xJKxco5WNzaNBOCOYvb2uvNnmim59FdoIvanuu5KEoJ4o",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3KgjXbwfVkwKlXPVbK0neg=="] = "#=qNrYVHIMU1k6nHRABFKCEWQ==",
                    ["#=q_Eix2XvaJGaqRVrdk6zfwd45yPhOeDTiozPtBDlGtHS4wdCVUTVNYlnO4pW1pYw2"] = "#=qoWiBZ2CMMPv9yVn5auZOKaHgsG4PAjzvYPJjBhIyF01uKGJvQ2i3QnHHjY78xIMR",
                    ["#=qOUdR$hxbFkBzVKsOXCMT1zf94z7cvKI9EuCq8SrW7_k3ykdYpm00_3rZnKv5OpGA"] = "#=qRo2RSCVTwC8kVm3KRjt1lrqEBVa$HrQcWKtyQ6cakyavCviMDAr_Lke3AN56_a3o"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ==",
                    ["#=q_1zhPaPpmQTexs1cwcfT7A=="] = "#=qfsB5qJAsSPOQVGYKceTzRw==",
                    ["#=qEE0yiiOcBe7LuAnPAGyidQ=="] = "#=qhvJfglOoJa03MUpmij017A=="
                }
            },
            ["#=qq1fcNEgymUJcDzYM79baOFeZgNvaeGil2Ir89RcdATI="] = new TypeMapping()
            {
                typeName = "#=qcvadXvfhISW2SdvBl5xfFGMWBcm6Tr$URwXtSB_Df_Q=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qThimVdOfxUYvPsr5k80B4A=="] = "#=qHaA28LY$D00fiy5O1hY9RQ==",
                    ["#=qNsBGAgcTICXu9TfQizlEeg=="] = "#=qCZ63klAKo1JyO8XL9Bj10Q==",
                    ["#=qMRx331efyI7GUblJRkbZBA=="] = "#=qDlnSte14APHPgDAT7MJQNw==",
                    ["#=qryQFXhas0Vuadx9RejGjSA=="] = "#=q1Lh3DtncO6ddoC2Z6X695g=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qq2ZBhyvtaEHsU$c4c9CJmA=="] = "#=qZ5WKiOygvvo8GRJNxN5x3g=="
                }
            },
            ["#=qq7uJMGpGDxLVIjKUihO_0g=="] = new TypeMapping()
            {
                typeName = "#=qNJMvtvrCZg4Su_7is$xTdw==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qv5aZQmG3tnGlpvuvhX1URw=="] = "#=qDYnlh91cYF_Rs88rSQdSYA==",
                    ["#=qgs_3K5G5cNJUXiY6HDpTzQ=="] = "#=qyDeZ2jrsN5M53Hu8GO672A==",
                    ["#=qu0Am5HB3m1H6HXaSs38ojQ=="] = "#=qkTVA_QrsLxDzmvO_GXQPNg==",
                    ["#=qEqnqolcjk1vnBQQK2SqAzg=="] = "#=q8ztMFZX1Q$W0mWdqHiB$oQ==",
                    ["#=qvbj$tSGXkxEmmYQVEQ0koA=="] = "#=qbviMjYKqT5tnntzSnAx$aw==",
                    ["#=q5bVjOPDeBFHg_3J9Rrk9AQ=="] = "#=qcnbCPt7sYc9hJLNJgyXr1g==",
                    ["#=qSePjFXr8I5ipEoEHutGY8w=="] = "#=qZg7qbZRMrA_M5Hi$3IaJxw==",
                    ["#=q5zTsQGOCcfy0XZcB5g4AoA=="] = "#=qUQrQgmFUt3E48Vp9pngW2A==",
                    ["#=qLAjoy$56lktuahpUzJa3Fw=="] = "#=qmZfdhsyf$GM$9Y9El1LQKA==",
                    ["#=qcjZQs9E74aH$nTFiNlFK5A=="] = "#=q75pN_WkPM2wsN4eE$hD7TQ==",
                    ["#=qtbwsI1pjUX7YpEtWGzTs6w=="] = "#=qwAIeMjrqWLsy$dzPjqTugw==",
                    ["#=qGp5NfdYS3dNA$46GB4Ba8w=="] = "#=q9NA6$BCa2R_g0vyh4LqLVg==",
                    ["#=q0xHFbKRajwHTPt_qsLV7jw=="] = "#=qtD3rdvTrim9HP_kJn9Ia9w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qGxBECihPkehRK4nrAaAEPA=="] = "#=qtLWGt26YzmQzsT4F15JkKQ==",
                    ["#=q1pOZPJlIS9690LiVU$ETwQ=="] = "#=qEO945LqFyucihAA_ZTbeMw==",
                    ["#=qOfv1VSBe4OKxp$HlgG2cHg=="] = "#=qoG9ehEWWSck2KTgFhAv1RA==",
                    ["#=qWs7wf2ABTUTmSHKsPcr85Q=="] = "#=qyDoK1OwkcJLpdR0EAB9hjw==",
                    ["#=qZ0yW5tOIb0w9yuJ4xhzY9Q=="] = "#=qA4Qg$$brWxRaA7OjEjx$Aw==",
                    ["#=qNBewQs9dwZX_y1D_wQxmDsuGqxwv$XeDawCM7Gfz7ok="] = "#=qAUgcTKILjLdnB9xMrTYJc47JX8wEX2LoaE15YvnhZXY="
                }
            },
            ["#=qQdKRcUfE46$efAqMsrzhkw=="] = new TypeMapping()
            {
                typeName = "#=q2pCdcXWAtZM7_QiVX6zMPQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qetmtzlK4IUWrerD0WQ3CmQ=="] = "#=qy7uuyDWiNxgGa_LLZhhGWg==",
                    ["#=qhTMtTPZpq4xGnPEJdY5cO8roOjfY$bdzrNc_XWbU8yQ="] = "#=qrt0av9PyQOeKVZgTQhPYbaacAFV8LXloNe0IdUEYTdk=",
                    ["#=qZnVhuCMJtXnIcK5cfpXRLg=="] = "#=qfYkmcoOIrkZMkCCtO0zZ1w==",
                    ["#=qXXak5QPMiCVmIf12APvztQ=="] = "#=qYYlZN9dSkH1cw088lu6_pQ==",
                    ["#=qVraeO8U4kHSsnXx0Ayb02$muXXwqzTDKW$OEsswT6zs="] = "#=qRvUQPwwIfIhzahkTuZ45kD6HvszpLPpo4OFya0sA66g=",
                    ["#=qFYCWhO79FFj4u_RFllYVXBpcptzeyfFXHHv8GHIW3rQ="] = "#=qu3il_ZyYpFYpWF1bxASAiCfZLsnL08_00NlQ4pblXOA=",
                    ["#=qedlwS3AdKOGHD1xvpcA52YcRN7jZRN0L6zkK$9Advi0="] = "#=qA5lOadWCl47iTDEH4THv9x_HZweVFTCkBygAW_obrls=",
                    ["#=qmTQ4bWtgKn3M$g6JxP8JcHiK2yO1EqgFy7Ecz0qWf3c="] = "#=qLLTI5hpHxliOeTfHR32j43cpgidk8d3tWrWrcXhUU40=",
                    ["#=qptSeZnmIcuLyAM5xaLC$Ww=="] = "#=qDeqb4SbKNwzc6qgGWd1_DA==",
                    ["#=qCvUwBUtarE_9S3QKbtXR9A=="] = "#=qmNpwiX5L5PzhF2Ty2vRKrA==",
                    ["#=qYfsQ5QAcCQmoLtfxYobf4Q=="] = "#=qRrgMNGbfdV$YTvWnS4pPOA==",
                    ["#=qojh$MdoQlJSa8cCESvcNzA=="] = "#=qK0$rPwgJbXWBAylDN3QBGQ==",
                    ["#=qx8YYvRWHBDF3ZVlH8DvElw=="] = "#=qjtTTUDtEh5RHbXtUPOBLXg==",
                    ["#=qxEHvvyaCYMsVabJLmaNU2w=="] = "#=qFhQQdk_VRLNfWFbwC6gMzw==",
                    ["#=quNHyenZrxuLQ$FJRxfP$Dw=="] = "#=qCngB7Tp2aSsUlwNbLKc4gQ==",
                    ["#=qxIu2HnTiJ6UMOlwldtJ6Yg=="] = "#=qInCUWXFSa_JHCBIw2JjCWA==",
                    ["#=qNtar$P22ROCmW4rx45oGSIjZI8fqToqp$4$Mjsies$g="] = "#=qNraXg$8Ixsidyw93je09heZWvQAqFEMXOBsv2NPeGp4=",
                    ["#=qPpvLwDqFKMxsnwIktxjV4A=="] = "#=qr2BPv$ica8qMXdik6ijbpg==",
                    ["#=qg8kz94IIwK_YfUaekAN3gw=="] = "#=qHP4Fn5vUJnXRG9w2vKDaQQ==",
                    ["#=qN99HDaeZa253DAz5bUqQWg=="] = "#=qWnmUto6hbekrGcBoucsIkQ==",
                    ["#=qhtsRVeukbzCdO7rSDnWqHQ=="] = "#=qh6BmFAsvZvy2HGfBksAcEA==",
                    ["#=quO_kY98LwzPqFBu7yToX9Q=="] = "#=qamCMhfElzBiYimlkDe_q5g==",
                    ["#=qwwKMpscg4vAD_0RNzYlQeA=="] = "#=qe9UUlSz38HSMzGpiF$wP8g==",
                    ["#=qGLelxLK_7JWc5g7JtZFnzQ=="] = "#=qOeITB0UUOgB8SLGyW5g6mw==",
                    ["#=qm_o1GddsvE$2BweL0jRFtg=="] = "#=qpZzYQ6_mNwgnZHf4U77pRw==",
                    ["#=qYHtY3bferLfElSfukdPcEw=="] = "#=q7_hFAgbnSvwur1eVRRD6Lw==",
                    ["#=qtsTzAmufJhwp5Nyc_h3ntA=="] = "#=qp0PGxWOrIjWCCflRJ3K4Bg==",
                    ["#=qbGqJ88Zcd7epY5ONF8L12w=="] = "#=qfIxpKgdIVFCkWDaTPF4qyg==",
                    ["#=qAUm8rPjoRED7BuLb_y5pYyOZeTFvuFUC6NE$M8oZdRY="] = "#=q05GN4SjXT0bk1Kwl4jLDXfXB_j1yPaBJKj$z8Ut57Z8=",
                    ["#=qCEuAWROpkyjgAY5_fQizyA=="] = "#=qAUhb0V2eC$MVuKMDaCEzBg==",
                    ["#=qoF1jObfQh6WBnXAlywFX_Q=="] = "#=qH6uByGPUF8NzcW74YCwgPg==",
                    ["#=qaHZ_GZWUdBUttbgtlK8Z3Qa2X9gslf5VWGvh1aBi2kU9QViZoBclDHpFu5P1C2Ox"] = "#=qL13v0O$BlzNNgcrolnXewYlwk4VkbdMDSVI4PNIuhLFOlwedNlPn1Y14edn$DM3l",
                    ["#=qHzx_jm1rPB6jKM2K2dGxG7kUMdp5hJyt53xPRE5FI5g="] = "#=qPdfC0k8w_Xw6locYeuVve4W4_IuADdSm58LP36tYmuw="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qa3xtTs2VqLsvb0d9muuX3EgEKZZ4mr09$f71njLGHNE="] = "#=qcE_V95EkRH_xqF2l4IC2bmxt3B9CKzaMkjZyNgw5EvE=",
                    ["#=q$r4fn5O0YsEDzVDSUke1iWPQBkYwM$ExTePB3NrRYLI="] = "#=qmk1Jz63Vm$TSvYwjqoJpvizuL8Y3xJG$6IcPyOlq2EM=",
                    ["#=qGUma_DtC6XDk134stzLzbaK7vqI3SViY8IkTDeDTd1I="] = "#=qqkwAdFumcui8oBogaOyfAwCaucH6y1Nm26EIUlm7lsM=",
                    ["#=qJnnFs817YGN0cuwUCjaeeGoNdZwVIDCtu0D8FyyRyKk="] = "#=qrgDvCpufsVNhu9LQPPPQs6YzXu71rn03p4nIhf4Oa_U=",
                    ["#=q$xtiCt4$Kv1$pHGMS7nKcA=="] = "#=qYBW_UNbvC$cDL0DjJEPn7g==",
                    ["#=q5VKv_voWyIjysrkl3skR0Q=="] = "#=q5inpwKKFW$5GuiluJWQPyA==",
                    ["#=qIIRTW0KinnT0wX4ub7J9Uw=="] = "#=qrNlLh$E3CNrHQTpbPXjtmA==",
                    ["#=qF8vP$bMXfAB52shssqdK0g=="] = "#=qtOBzVzV5yogqwthDlzqnEw==",
                    ["#=qgTo06CFBoYPs9ZtQHTsohA=="] = "#=qh5YAgP0B_o$ZhQIv55NfaA==",
                    ["#=qGLqVL$SM55CY2v7Mt0CHmpO$p6xQ74l$SDtNp2D0YRc="] = "#=qlQ28FEsgC_bcPG0jcXc99BDTemo8fofwk1l$aMzkwEs=",
                    ["#=q9qnDGlejYGdomiWt$SRkmw=="] = "#=qzEH4EC01lSEK1i6x60H6jA==",
                    ["#=qtAieMJa3O4$ICce59T5vcg=="] = "#=q9xX4NTvD5X7xqniSnY62Fw==",
                    ["#=qfLmyN83GIO8Swe_rBpJs5dJXoxkseWjtzN6tON7wAtk="] = "#=qDsne2yk_4cZB6I9w0ANOzJPM3jU9xKNHmqMjk2Hp5xU=",
                    ["#=qPq6L5_Etvd9kGPPkpGnjgA=="] = "#=qj6tNNtZ39uvfFeOdPonK4Q==",
                    ["#=q_O5c39kyLRWxj8UH8Mw87wE59g5h5HFljtF6SteOoTM="] = "#=qDppYnj1ImYLA9HK_IH80s4c8kRCO0HlxA_LOkdJ4FrY=",
                    ["#=qBDcPJr96mzuFUkRow8_IjML5uw8TcRqYmW0l18lmM4c="] = "#=q2GullQKoiYtZ6EoI2HXd5GVpyeXRqF9ArvsaB$KlvcA=",
                    ["#=qmkUYMjejC43opDFpr_zJWStLZ22VYbTvoI_H0lcXJm8="] = "#=qX58pCHKWtSTgDc2R5S2yenkxjIaoDXvXV6VhvW6929k=",
                    ["#=qzuKcPW8F_GsofjfkpFkkAg=="] = "#=qwTGJC5X089RXmCKCuj6CjQ==",
                    ["#=ql7I1Gbr9BCeKY_JIIwgC8g=="] = "#=qqkBCib3eg68sl6jQGNlb4Q==",
                    ["#=qEzzZxNI0DrswuZnf3BBXTQ=="] = "#=qvNWT0qiT0meR7_InSaFowA==",
                    ["#=q86Rk6lRHR_C9PTUkQPfC9Ruvm5D3y$N8lnLWm6coGRE="] = "#=qQw_ZWdJaAWx$tKVSVoUlIGh1csPVtFQYseaqo1IEYZU=",
                    ["#=qgLEANBhVfIuIevx4ZYI9dQ=="] = "#=qtsn6aZToXiQBLq$ztaiswQ==",
                    ["Dispose"] = "Dispose",
                    ["#=qRFN0FnV2blHEDK$U2DYCcMN5Bnx0Ep19oRmCIHKbWGg="] = "#=qCYIF$kpyu2lMg0CvEnbXMR3sCKfTLFg_CH1vcAMGFFM=",
                    ["#=qRWVrsXIEO4GXBNdMkxGCWQ=="] = "#=qxSJ$r1_UrIgYLyHi63Tneg==",
                    ["#=qpbiKAlcoi8xVL999AKgtyxyeqFDS2FyGwioHUWHS6kk="] = "#=qTwAkWjQFxsj6mQvVu3HlLFWvUO6G$diomyKtW09lwNI=",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qA9e_m1gxLrLHNKGXRuzArQ==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qddfn8Y2liaZZX43O$JYvyA==",
                    ["#=qVW1Y4JJu$lSCYbh3jtOlIQ=="] = "#=qVk79$LktRyr1pBoSsUXyMQ==",
                    ["#=qrXUYDij3kpneut6CIO2oDjHdTCBi4TJR1dvX3k3TluQ="] = "#=q4ZC5v_VN9C61R3Ga7Dgt0BfLkEPzeIUJ73yilKtUMww=",
                    ["#=qR8NmYFJFPAg_vJXUNcEtLlKGIVJ$z36gA_LBFasfXaY="] = "#=qOYh$2MFbxz5qyIh2GGulR1BBPRKltBiBGTphMjQ3I4Q=",
                    ["#=q5WOuKwfupuNkUG_wFFLT3w=="] = "#=qQhVVkIceTYrTg2ZmsOCCVw==",
                    ["#=qXna9aKUAsDxahInFoR1K7w=="] = "#=qd6wnQybTZ685LYkBLHgQYQ==",
                    ["#=qy6fziF8lQimzneutpxGlPQ=="] = "#=qBXQrufaliRY3Jg3GoYV9lg==",
                    ["#=qk$WidYSLJLTgYW5Zosl0DQ=="] = "#=q0w8yJWCbhyNDMkMSKGXiBA==",
                    ["#=qO8aCQ9av7H3jc5Xv3uvCyBaY6dh3$8Ml$cPUhF_j$hI="] = "#=q989bh4LmOd2E_B70k8XYG5zvkSx4pZNX_ni7ICfgUSw=",
                    ["#=qP2seSJQq_dwN3XEw8p$jmzfV3j0xTaZvIoYwHUfBC3o="] = "#=qQDFpaCuls3xpG2mDT6JZu8BTwU9xafYO$75f$y9ob58=",
                    ["#=qPLkZJy0i2XyF97eAgZfcM7C1Tz5MKaeKW2dUPI9boyY="] = "#=qunZCLJKY20Jm47w7OToltkEqxxcPCIU6Ce6Go0c4UVE=",
                    ["#=qhNmOz2Lve0hG$zRzglsV6Fhowfnqcdw7AwjAL$kKVvI="] = "#=qJkThH7ry0HQqDdo8iNjTABFEcfNakmGJPaM2qUmcdI4=",
                    ["#=qRlIHp5V38RlqfWrmNEV08A=="] = "#=qv8vAsq10ShbNsGBbPZkIGQ==",
                    ["#=qqtfXBpSFSnIye8GbeeGNbWnZ$tW8p6g2Y663IoU5alA="] = "#=qYNqoSz7fOOhJhvwyQB16fOrFiQEXzMPyEQWsAMqcPso="
                }
            },
            ["#=qQI4mmiRg8uHO$ev2ClwhkV7MRzjp5JMnwZIZahsyuM0="] = new TypeMapping()
            {
                typeName = "#=qvk8_P0N32k9h3hbiNz6FIuCQjY4GUCtSrftws1owkio=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qL81iTLu3EfA0KAfx_gyrJA=="] = "#=qgBUI95RLf2vzEZh8LNxBtg==",
                    ["#=qMwQWNqiphUEVzfjBCFNpTg=="] = "#=qUE9t56rOc0F6YyVyPLTLqg==",
                    ["#=qUyTaTmBMMHScF6IVyE5U_SIizF5dp2PxubYXDfLIe5I="] = "#=q68yASWMPVUquGjFgJ4kP2sSzuau2FfZJKF15gKj3D$o="
                }
            },
            ["#=qqoGZYRxPqC5tv9E51lUW0KCP3zR9Mc8pL6gxjQWKrkqKKAah7LcYCkIUcV9LPL2npbzghCrP87kgbeRHAjQsnA=="] = new TypeMapping()
            {
                typeName = "#=qlDyA8RZND3Df0voMv8w7Kn7SRK72BnXcV4gJULGPLEf0YdKgJtUCAnZmfsOI1bHKth0uAmkr41Gug_Vfkr0Imw==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qnh5wn4nUyA5PX1SqaUTOyg=="] = "#=q75NZ$oDY1Eb9EuW734sHmQ==",
                    ["#=qejhgWN2GB5GaaWl3C_SlgA=="] = "#=qh_HIVov1hS5dBnyGJBN6xw==",
                    ["#=qJLj_GPwyEERQ32$WMqOVmg=="] = "#=qgnUeAxonfUmmkrYFuFoTYQ==",
                    ["#=q8C7A$mDCpEuteyZfwVX5HQ=="] = "#=qZcO64OVODYvS2mbhRJUiLA==",
                    ["#=q2ZKJklNkdfSPuIY1vZMCDg=="] = "#=q$Odyu_Wa20ORa3Mp6uTSVA==",
                    ["#=qXj7RNwNuAbDozI2LXDDMfQ=="] = "#=qh5TuglCLs7l0UsdLewTG9g==",
                    ["#=qWZT_poIO4yS6b3F7gILl_bYpEBo$ZO8uSxubpqOINQwaXntMtXE8fS1s0MGJ9JDp"] = "#=qQBc$lxQV40hgUjM_QdanrLDhBtsod0wLwtcixkEm3v4mTdHQa3EjCO6UzsOkg$rs"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU=",
                    ["#=qhVJa35EdA6LZfZrC0CiU2hbuSD$jOGW0PGdvQEgmsUY="] = "#=qCIHiOe8n6iXvpzl2rXVgq1ulL_4RhQJe1xRHtHI$Gmw="
                }
            },
            ["#=qqoh76rg6pHBZuwfmairpHau1KC0TaOg4IRrC_4Qpn3Y="] = new TypeMapping()
            {
                typeName = "#=qqd9nwOAVC5m9hgnlqvy2_VgboDTUeYXiQkAZDidwvlE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q6VdjqBBSpSsXEMiH4D2jjT06tzFdizmOUYOd9BwKYOs="] = "#=qgyFuplkCl3x9SMw4K$Eboxavn6JoLmdzupHRvtpOBbQ=",
                    ["#=qU5vcUL_Ubg2yk1WtU8nF0w=="] = "#=qLHOo25zRRqHJED2ZT4RQ1A==",
                    ["#=qNIN0vKnD34Cvsr2ongzadw=="] = "#=qaTMQdRapfub0VlaToCoAMg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q98xCv55BEa8pd9iAJiwG9w=="] = "#=qPSKLg6UmL2OvVYKyq$p$Qg==",
                    ["#=q$3VAawzCIiImVX$vRToKDg=="] = "#=qzoo9nZbSb5ejh_T0$Wg21Q==",
                    ["#=qAWag$EJgEqvOfe7prfSubA=="] = "#=q9$kd7bcTAeeUs9tS8BsHYg=="
                }
            },
            ["#=qqup4QHtvpbzevHC9UIEzorx_0vYkJS5rFrNi8o$0rkk="] = new TypeMapping()
            {
                typeName = "#=qJPt0$xnz_GmpucsXp9N6uuHBQB$09eBti4_i2ZMZ_ig=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qwasKRecW0PK17NIGKUD82w=="] = "#=qxyPePrcMB67mC8vXFXlk2A==",
                    ["#=qhR9VLRoCSYwlRzs1aF9lww=="] = "#=qUiBH1Qv1MgvYfBJ$KE28yQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qwq7J2SGXwkqEiUGVyWHvew=="] = "#=qaP2Jcqw4OKYLUxtpOpGtRw==",
                    ["#=qmbtsjxMbfBzDXLOZYJ33$dnzmvZyHQBfutogILH7TuU="] = "#=qtp8V8rUwEerI23ArTaOzBxzPR1bWeYdm8mHsYDmd29o=",
                    ["#=qipwPOw5nGPALFjW3CUH8TcNmAjlyAxJSYQuOWXUIZwc="] = "#=q6yk8kaEUgRGGR3ptmnPxaeecx0Ha4dDMGvSeMnoGi$c=",
                    ["#=qUWDITpnAx8IS$wwScHR0IDD0WyV9MGqQ_KtbGuBf2L4="] = "#=q3c1xvVaMrwo$6uy4W2QJ6EIVnwe9pTuGPgNLgX_xCxA="
                }
            },
            ["#=qQxaGOIX_q7xKpPYBNResmgJ3fcK11nZBJFZbzog3Lro="] = new TypeMapping()
            {
                typeName = "#=qhnrnSz7uuCJyKaYrs_FC0JJiRd4DnM0nsDRRyVCttZ8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q7elwebe_n2deUzQqLtSs$g=="] = "#=qcdt57YCdqYbVcUVBullCRQ==",
                    ["#=qTCq8C0AuZMwbFcDfCa3W0w=="] = "#=qsNSNI5XJ6U3uX2RnHo4_yg==",
                    ["#=qSaM5DAFufvFgTY_PraqsGQ=="] = "#=q_ACS0LkpuxDxyWNgqNOZRg==",
                    ["#=qlfxfkkMqFqc8KhvvDKfqRg=="] = "#=qVeJF3eKYxdl3DDENj5MeAA==",
                    ["#=qzf3TVwYYUFwmSWKivk4I$g=="] = "#=qiKWfmA6WdcNzoWL9m1xbBA==",
                    ["#=qpPWUIJSia3lfJ0Nko616fA=="] = "#=qpiqpoYmrInqmtW8c872Vdw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qnHdSPhDK2m036C21sDDDgw=="] = "#=q3WrEO1naR8e39hocE6ZzAg==",
                    ["#=qQfs8APS3bjCxYZfa9P2kEQ=="] = "#=qZ754rRPSEXK5sqCcs1qVrg==",
                    ["#=qBtu0ulZ2ijsDbc0DQFvWSQ=="] = "#=qlXk_0ih3FVcrz5VrKIY6dg==",
                    ["#=q9hkrXPdwGmWNgfGUtN2oJ$GjSXS6eXGNJS8CshbJRLw="] = "#=qQnjfBOVvDemYbt6o8QbF1fOsTDzKvh0R0loYpEHsfRg="
                }
            },
            ["#=qqXKuKU1RxgYLDGnDY7JaVtE8$mCKPJL3uXpxqiYT8BdUqBUFzROSsHOnYMQVFgxm"] = new TypeMapping()
            {
                typeName = "#=qqoGZYRxPqC5tv9E51lUW0Ip7QKTxotdc2FHsCj9jjYgMDU19mQfgbThyT62qvY7P",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qqXKuKU1RxgYLDGnDY7JaVulu0V9H2cGFUuXw3VPcp4g="] = new TypeMapping()
            {
                typeName = "#=qbVYiuFUiFv8DeuzGAXnnR826H1nJxiyI34WE9xhzPyQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgbai7_$QffhhgcJILNAzGg=="] = "#=qQ2FMBq8LFKuG5bK_UcvMRA==",
                    ["#=q5AkKgVvRgHfR0IQkxutLEA=="] = "#=qprQkqbdDAmjfagMc8p7SIw==",
                    ["#=qlmnDNPDOJLzFQ_DMXD$94Q=="] = "#=q_ib8aovDqMgs_LLxC5SLhg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qjzUbHfoqDySyLv5NnOv6oA=="] = "#=qtvGC7fS4CxyfGtFEoickVA==",
                    ["#=q7z8EEwaILieBXBlinVP2cQ=="] = "#=qOygtobpD_mf5aQGW3yKtog==",
                    ["#=qsqvw5r8ZWlC2S4$9kZ1Isw=="] = "#=q_ZGWsPiAYfaXmjh0MKZb$g==",
                    ["#=qbOkHnkKV9aKwxaP4P59bDg=="] = "#=q7lHeBwX0TiCWS$DbaslANA==",
                    ["#=qZuUKpnnvGUWzBt5hSSXloQ=="] = "#=q1pJzvnVkEdO5wu4EofrAqA=="
                }
            },
            ["#=qqxvPGot3E9HqmCd4Uan6$DVzmAUyWTpfM_9FlWyheL79vK1gsVefyWl3qW5GCZ4R"] = new TypeMapping()
            {
                typeName = "#=q1WFHJ62Zf7dvUUiXxLfRYCnYdoFvAAZGVN$mqn3PWY7Wohm9$chyaAnQeNVc6kPj",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qaIi3ymXxDHHpG0ORlTy6Eg=="] = "#=qMoEqew2wWOxPdEXyFpZkXQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qQyJrhW763sCYXMrcDhdKS4exD9sLnt1CTdToI3FRTnc="] = new TypeMapping()
            {
                typeName = "#=qIaBH2zfegFvVKz3j5wjHRg$7ComAHSlDliLe2uBY6yM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q_OLF$mxigw08lCAs67Ls6Q=="] = "#=qpKR76EZlsRUJAYoJPQw3_Q==",
                    ["#=qLyTpPl02b9hoExDskPqSmA=="] = "#=qEYuxjzVlHJv6rMzaYgCW9w==",
                    ["#=qJYbBkvOrxSlGTgemiypgnw=="] = "#=qXpMCSoQKG5xFVkBtMswpbQ==",
                    ["#=qW5tj0SJ_iBMyJO6_HLpvvw=="] = "#=qvh2OcUOMerBJ$BYH2jdgyQ==",
                    ["#=qE0wYjRcMHUxUrk5$hB4C8_h97ecdVR7iZaOAC9NWNqA="] = "#=qBnq15hiuZizWijevXjrziUzPPYHR2cgG2HiyF2TS17s=",
                    ["#=q414Z2hRUlTPGEyepzyReRyxvXBtfHZ$_XBDDlnaQF5s="] = "#=qU61epD_b3pSQYXSU65ki$Y_cf$YsEMJmZbRvmlq$HQI=",
                    ["#=qIQ6QjCXV86UMG1QQT13lD2mPHBS5GesBKMIVnlF6Bdk="] = "#=qJIlKAhWuNHYE1$jVBLDzNTFVeUiRQ1oSccGOo8j_bUU=",
                    ["#=qvTRyoj1WFRyNKB9EGXWC42ja0FNT7_IHBuWG7TG6GiU="] = "#=qQTFKsJ7c08vfurtH6cXYAWXe$04MIYWNWWulhRonn9s=",
                    ["#=qrB6pzNTGgxquWjRJcx42vA=="] = "#=qHTViJi5IEZcvL1TqWDB5hA==",
                    ["#=qnH6pQLbt3MyO4Sm1XFVvRg=="] = "#=qLWC76JL4Dtf8ZgrfGC$68A==",
                    ["#=qODVbX1uzmncWcz$Savmx$g=="] = "#=qc4h5AwzkmeNtd2r471135g==",
                    ["#=qIMdqFv$mjyu6REozR2uM2NsWLjNDeqqi$WNCoYbzo9s="] = "#=qduld8bv2xKrIJfu2b9WY4D3sU59qfT4wxVjth9l6Fzc=",
                    ["#=qaoLCVktmO0rktrPFOTTElw=="] = "#=qo4_YoR0h3WowzRT5JCqJBQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qb8Y7Z_9f2$yEGCUE63JB_g=="] = "#=qLGxzNeqWvNgETkdF8RYBdw==",
                    ["#=qPUzI9xtPgESGewOdfRpQ4g=="] = "#=qjqeALP00BsWgQivG3ol$Hw==",
                    ["#=qgOvW1Fve$3rHsv2ETYlEKxh16cKE_IZPCpu88Wmyjuw="] = "#=qyNvft53HIvo6nE8r7dW3IS6Tq92n_mmvM872Vzgn2aE=",
                    ["#=qR3WuvRHzZw1vww9iqq$mQw=="] = "#=qZUOk8Uk_ObZ6cI29FmXjOA==",
                    ["#=q35OEq$9JiJQMPCr8Fpt0uQ=="] = "#=qTDXtSPMM2k1KX1Ogxzq3nw==",
                    ["#=qbemUuowXRX4n$Cei8yRR9Q=="] = "#=qpHAxmFm2_bOTC_EgrPf0ag==",
                    ["#=q1x5ypa5VqehxKfpI27sCEg=="] = "#=quoKZBuPXsivAvFY5LpOeIA==",
                    ["#=qhMDQtuHpzLS62SLHdUBF3w=="] = "#=qEVI4fFNZfbQZ_kvYKkD5Hw==",
                    ["#=qUdvZTN40ugU4trowTONjfQ=="] = "#=qk6m1epDK6cZvd5bgHB2_0g==",
                    ["#=qcHLfycvtg7srNjRKONzmgg=="] = "#=qCV$nqHJqP$$Qd__EZfN_GQ==",
                    ["#=qS$JQRRtB96Qbtp4v0Xl$HA=="] = "#=qsAuzt9zba75xU$NAvqrkMw==",
                    ["#=qAR03CJuu6fKFB$B$1HOGX0KgopcJffSFck8sml5yn9c="] = "#=qPOgJ6r6LVQ1B4tj590c9HVNP$locN7fG1XFpJrxeX$k=",
                    ["#=qTWTAYRuOqUif930dKWKa4A=="] = "#=qmaV$Kz$1ZuazF7pAvLkbcA==",
                    ["#=qB9U7Fqh72DCIIXtZ7uQ8mg=="] = "#=qkc2kLDC_MFSR6EUi6Aa7hA=="
                }
            },
            ["#=qQZNBhnuwPQNS7T2cPvaRQ0AL7X1xkRD$tLhiG4t4h7c="] = new TypeMapping()
            {
                typeName = "#=q7gANQ67F9MiLrnSjk1orVkFUaBChLKQSw2AxNbiVB3E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qVmBjwA_dpOvlyY4TLsCQ1w=="] = "#=q0xM9qHc5BQisQWFvxYJvHA==",
                    ["#=qJcZ3OAAbESzjUlXOA6F2Cg=="] = "#=qg$KJxr3a8qJM7TVAHqmxUg==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qR8Jg1QRHWrvhIatnsWYcUX_aW9ckO8o5wFWvxXyvkQE="] = new TypeMapping()
            {
                typeName = "#=qUxv2$45_5kJgmpFTLTIJ9saLxBHku8kouzCmVOWo$AQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qrAToZ8hK1kCr5BrRzsdA7AgmEV2T_0SppJXLKpB_mHko$XJtEWuDc_NMvOuNTNQu"] = new TypeMapping()
            {
                typeName = "#=q4ZOzIaGtm97CBHr1VEekeA_l5tw$B10O4ns1mSyPaL00P_r4vR_g0hsATSuvZ9Jk",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9NsLIkoEuHEOEKCu3mCUtQ=="] = "#=q8HXy6Hl$FYxRv7U7J9nSDw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qYXYsC2NH_yqfkjObGrwHqA=="] = "#=qiLzh45PSyebcBiBVXS2Lqg==",
                    ["#=qEmE78s89HPwF0gtlmxFZyFBJAdsKKQAGFYNe7KF8hI0="] = "#=ql0tV1mMK33LrHyprtN1lfjsV95hutn87KvXft_UwRkg=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY="
                }
            },
            ["#=qRBdw085jF4c5V3uyKl5XSg=="] = new TypeMapping()
            {
                typeName = "#=qvI_5b4NP9HkdDxWgMVeVzw==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qL_8gReIEpT7YJjfia6DjTA=="] = "#=qFAnbhfCH2YxAwC37pSwYnA==",
                    ["#=q_Sl03R0Lza439t5m0v9OFQ=="] = "#=qwIkGZttXj3iF06NW7pLHJA==",
                    ["#=qKTb1BmeemSWsYZzfhKrUhg=="] = "#=qYs9EQCCteHV6Lll_5Me4sw==",
                    ["#=qm4i4qdVtezhpr_z0KX7ctQ=="] = "#=qZsjPt10yyW3r_9xhQ4I0Og==",
                    ["#=qSYr6LkmvkaEvXXC1H5w11A=="] = "#=q9Cdo3bO2StIaZwrQ$jWlgw==",
                    ["#=qzhiYY9vKT$Bdv1HyoRvdkw=="] = "#=q1VSvNZjjU2RWgAeY2SYSBA==",
                    ["#=qbqJIrwE_CEvl9SGXx_QJVg=="] = "#=q8vUKN0gAhCKGTpw2XWmFQQ==",
                    ["#=qgySHKk9dN7kipTwgP16a3A=="] = "#=qlgNtXoK5SzGp3RDGSdpVdg==",
                    ["#=qQ2AiNNALfQl3cUP$65Zs3A=="] = "#=qk3yRTAjmDG60Xs2R_uBjeA==",
                    ["#=qax$5siWsCzcDslekmBtfDQ=="] = "#=qQwy2X_z5elHZNLXELa6Zkw==",
                    ["#=qfdWNjuPFl48VLoi87mV04g=="] = "#=qs4UM$zt_HmVsPWykJamgSA==",
                    ["#=qAloYg0djnZPv7RORhof40Q=="] = "#=qZQp_uglcvXNGXTKGKzdZwg==",
                    ["#=qoQV1HYh2TT4IFT41m33S7w=="] = "#=q25sP_7v_SHzJ15DAs5GPnw==",
                    ["#=q4TBN4$nywBi6QjzzyjDOfw=="] = "#=q1f9_mYCmcRm1TRyrVgr4vg==",
                    ["#=qQEBYArZxs7qjMJO68bPUVA=="] = "#=qPwm3ckRSOanW0N0kWeyong==",
                    ["#=qtpwkiAxO19k9MXzndMzBbQ=="] = "#=qXsDxQfiu5WZR_Rci$KAE3A==",
                    ["#=qoM6_b9p7SYqfL1z4KOh8oQ=="] = "#=qebYLwbEyDFCJkesnaSHnRg==",
                    ["#=qTUC9p6vmAp15Fv1LDDx2uQ=="] = "#=qDh8ISPGSr1uXn1ELiJ5S_g==",
                    ["#=qqudkZGmhUCaH6_Ho0xhwKQ=="] = "#=qAx$VFcLa2nqU$0YvhB9EFQ==",
                    ["#=qCzi1c2IBXgt7iVjWyPfFOw=="] = "#=qgIX8ABknr$69WMQaCgQIAQ==",
                    ["#=qN959l6BSLA_aToqWnXWxeQ=="] = "#=qIuT24DEmZBakU1ci$f8Tkw==",
                    ["#=qjPv86JgRS7BC17NxgoNiUg=="] = "#=qkfxOGo8RUCna$NG3E6nfDw==",
                    ["#=qn7qkLIgor1tzsZ_PPe3Zag=="] = "#=qY9ym9lEeZoFLRyP9JZtTVQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qHWW_ltSD2QmIx_NY9o7e6eaxzYztgXvJq1TyCPQP7xQ="] = "#=q0pV2NIl6XqkqA8MnKv3J03$EIF6oQj$kzODlsvERqaQ=",
                    ["#=qd$HetzOCrk6$UcWMckuyjw=="] = "#=qnU0_D8aFgvLD$7$0joCjlw==",
                    ["#=qxLeJF9Gg2hpOhafqYJeIkA=="] = "#=qY20RxuyPpCa5Ophg9RGRvA==",
                    ["op_Multiply"] = "op_Multiply",
                    ["#=q1Jt75J1GYLBXZjOsnU48kpFfGXtKn4zaHBxjS2BeWu4="] = "#=qK$sCLnF9yVje345dhd7sfuW4ckobsNJajQXUEfFKqtQ=",
                    ["#=q$me_4yw8CBY2WjRe0If9yw=="] = "#=qZvvnv79iogHfpRk0Y7NsPQ==",
                    ["#=q$aJXndOM32D9fUNVw7p3Zg=="] = "#=q1W1EFK7yggT1XrTfTRI$cg==",
                    ["#=q3AMGGQ8MSX4FTAC9Iagjjg=="] = "#=qL1H3aD874ngKEglBoTOsvQ==",
                    ["#=qGxeAC5yjWe0Fo556pvb$WQ=="] = "#=qN_2m75qvUoJwbBNX5i0nFw==",
                    ["#=qDFhgaErmYUfYRX9D4yHyug=="] = "#=qEkxCA9aSW7XAvYeUkJESRQ==",
                    ["#=qv_6_LT6KYHx6mbZXAcxbQw=="] = "#=qcIgzAjg9L18LLF5IyMcLSw=="
                }
            },
            ["#=qRBTFm46L1IOA1rI6BoRj$ogs_2QiDnG4GmwdQfg23rE="] = new TypeMapping()
            {
                typeName = "#=qGhPOG3sW1lHBzy4KhUQ4rHwbrGPJ4bmepSoNPcO1W2E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvpLcQ6HHnMfNeunL6CZGsg=="] = "#=qChlSl18txFx2$c61xUb5TQ==",
                    ["#=qDtoroAsF8Ykg5UJKAFPgOzv_5$eZFECjSV4qEFbSbCA="] = "#=qi08SptShFsBq7SVsmyX3W2t61dYTx$RurjuRgqFJOto=",
                    ["#=q1VUaidSZU5bc5r0iFnno9MFSRqu2buSISSLpRquqdoY="] = "#=qe05EInXk$NdJwwchvmzj1Ftb0hNCcys8gDVIdxiFOGE=",
                    ["#=qU14x6XeQUhFa1FK0LbmMwA=="] = "#=qsfmDUJmJbFIqt2l8d4w94Q==",
                    ["#=qu6NbSgLwbSqMIrhdICStnhIu93foML9I0Qu1Ax7LOXs="] = "#=q8i9qE1Ce$wxJxuJNx4dLitQNaYsjaM4JXG1gHT9ruCU=",
                    ["#=qCJQ0qklKvTpDYE70qmf1zA=="] = "#=qTb4CATxZ0KSP2F1giyZs$Q==",
                    ["#=qSpUOyxsMTo$hVum6EezR0kfhx6lzTojFvGPF$CMaQ7Q="] = "#=q1BAzQfO1cQZqgAIxlH2a3O12ypI8Wh5hdTtosQDQ42E=",
                    ["#=q2gB7acJYhgjR5YFLXj9EsGURqh5vhcnnFn3GdY02OdU="] = "#=qgwlITYgKcMtO_nElvOcO0kr0Rnwb$8GZzBQejafEJeo=",
                    ["#=qbpiH1I0_pdYCJ3bj5AaVAcI65H8aATPD74NluIc8tWk="] = "#=q2ZsysXtBLI745$8NytPQbY$oenlW5xv7HYlOtxdtXOg=",
                    ["#=q1FunOknxb5bddbrzylLH0A=="] = "#=qnLoyO_F47pIGzjRSUEO1MA==",
                    ["#=qMq_s_oVscTw39Hz5Yo1DKQ=="] = "#=qNlPfhqQ9oLa5fH6h0ImQgw==",
                    ["#=q8Rawd1O5kOA0w9FdAV2PAw=="] = "#=qCZMPFCAl_6XqEbDTW$xcOA==",
                    ["#=q3qoAxjHtpa4PDkwmUpxTxA=="] = "#=q14_3XzggD9vjleQEPRn8yw==",
                    ["#=qNOjmlDwz6e2VWF3D_TT5JrUAVwT4RHDUSF7GWhdSVIM="] = "#=qtydffbteb9BoYMQWRsP__ELeiY3Ds7GnB5lPXwE_CkM="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qbipsgIr1pfpMNh_vrC2KvaSKwZl7W4ad87MDbVxSg_I="] = "#=qAj7nzjXS9lQpOK3H$PoJXRIYCgnQP$TsjIZTk20O$HU=",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qTu$ErwIwQzMyBrEJDbpUX5qdd7TS6lpPMkXXsPXOsnQ="] = "#=qS81_L_SmrZ$jRTxmlHPK1zkBcFDZdof5YN8OyiLMGao=",
                    ["#=qKGDV5$k2AMqi6Tr9wduG0w=="] = "#=qRTbizs2aUjbqvW3Ue1bkxQ==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=qpmPmm6jTybXqKL$L73dpc_u12pbib1QlEmAuA_XY2lA="] = "#=qrf5I76TnYZZa89OfUGuaiNz4OdM$QBZU$sOdv_ojm74=",
                    ["#=q3qnB4xkGBGxspkXUPYPZ6w=="] = "#=q97dHY3Tdz7uTAh96PDGpGw==",
                    ["#=qhrEse$jYREd$JDpPuEekNQ=="] = "#=qkqW7i3CZV2uQxeh64eB11A==",
                    ["#=qlMLCh99HVy7V7SufWcH_4A=="] = "#=qQI76aMmOwIdLLZpU1TLLng==",
                    ["#=qulaulPAm_46FV$e8E5piOw=="] = "#=quxinymU6hqe_DwNaYXigQA==",
                    ["#=qsZtnCMhNqwIZLQtp1c_jqA=="] = "#=q$4j0YEJIYcwxwOatePB7lw=="
                }
            },
            ["#=qRBTFm46L1IOA1rI6BoRj$qKd6DuxaSv34K8dQZ3OmnI="] = new TypeMapping()
            {
                typeName = "#=qnQ9DzO7rLkHdiFlWK8nVs5fglDUcuYfelH$XZwcUirg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8kO9l6WZAdc_iOrKi2iSpw=="] = "#=qKlxdKgmNwlEoeH4f8VQm0w==",
                    ["#=qk5u8Bvkx1hi8zH5lOMGLRA=="] = "#=q0N7mgMrJ1Xv$GjVkJMSRRg==",
                    ["#=qAvErGpK9N5hYjqM6cQBPZA=="] = "#=qooozDo1_9dkSmee9jDpE9w==",
                    ["#=qrw9J5rHwkGUw$mnOxLJNWA=="] = "#=qQgxdIdev72qD1_c0viq4eg==",
                    ["#=qstCyMk1Adi754BB1TNjKWQ=="] = "#=q5jS2_EIR2PRD5k9AnRXDaw==",
                    ["#=qWfG$YkEO3mPzrQhTAcSiJQ=="] = "#=qRpv7FFmYtHVj5duvXGMb0w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qvMKiLTeeI854erpe6A$ZeQ=="] = "#=q8cRDoymOPbbsoVxH4mmBzQ==",
                    ["#=qBrqSOUMTPM2G8lwK9AtSYqW1uzf3KXMX7AIu5gHBSPI="] = "#=q7p3yOi61GHoeUNKTG8tpPDGMbaPFLjLeq88odEEVLMg=",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ==",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE="
                }
            },
            ["#=qrCe5qja_ldQpUtAdaaoDKW7ahk$gwARlqa4boL9pWaV4SpJXqQefDJqVmRQSERYt"] = new TypeMapping()
            {
                typeName = "#=qO9DNxqmpHWcHhhTwtqduzrPNYmxZ5VVEWqBhzPxtzeN_JTzwpa_cuykZ$upzbyvU",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qrCJREAf$Hf9aGa3TuUSykqD5r_3Ab8bBF_TygfhUUAQ="] = new TypeMapping()
            {
                typeName = "#=qcfYdOY3RHpXhp9ORbawk3lRMcr9aqIsmwPYd1guQqDU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0LeBhv6yRga9X2of4g76oQ=="] = "#=qAOZmKzS1kEwPNWCkHys9yA==",
                    ["#=qlq3yRIWqxmc2VnI5NrZ0hw7J2LansVk1aJhLct3cJCo="] = "#=q2zN9Yyw0XkYq3Zjsw$R5kUWm6Z1Z2uUkjNJBggwsV48=",
                    ["#=quKKU3J59NFQ8KU8SQ8hzWw=="] = "#=qXVQE$tSUtNc2s2yLjm8EnA==",
                    ["#=qFFQ_0cmdCGg$KIuVqMD9KQ=="] = "#=q4_4rMPzIOs0DyVIL54hfeQ==",
                    ["#=qFFrbcTbz9t0MqAJ_5xEPqg=="] = "#=qbkD9pNf8qjSfjHnMBXCOwA==",
                    ["#=qNTJajZ72moOfB9kf7QCqXQ=="] = "#=ql4Y0AW8Rt1BNYWkdQeXmvQ==",
                    ["#=qcQ2kpsjO8rtIitsO5k3ltU6n$8PSkgDZUK3qQS$FD$w="] = "#=qdGRN6b11KnC9RpqOoTwPFuowRnhxwlh6ldOig8MPfi0=",
                    ["#=qCr9nBKeJoE$6hGixxu8V3g=="] = "#=qU1IV4ef5NoAkkVNrKyTkOg==",
                    ["#=qlFDh3Aw25lFZTtfu8qoojw=="] = "#=qatKPKrlHMA_8El5RlsDKhQ==",
                    ["#=qbvQt7XvIKHsFi8qqc4AdCw=="] = "#=qWGelDpsRRQPCQYV4KBNJ_w==",
                    ["#=qG99IHSfzQlWliD88y$g7jQ=="] = "#=q8mT7lLmzBuV7uSB8Q263yQ==",
                    ["#=q4G4k9dZqU_PA8BFauo7uKg=="] = "#=q9DxfiMOwODOOYUeW$AGYMQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=q$6CvEnKZs2f9uNZucAs9WgN3_e8w9QZokdBuKBduLUc="] = "#=qH2UtEHGw7VBKQihjXzzWi5JTXcJ$hMvpPmvv_6kGq$w=",
                    ["#=qdA77mGcWacpGLhe3_7IAkZd2Fwtpw_GP8PuqtqzbpVA="] = "#=qEDIktYaP1bMfs27msUxNHcZbHhUEAMioe9Rv5j$nWtI=",
                    ["#=qhR5OvDsLwl9z6_zLoumkHnhnORq56zPNbXSSm6TnS2U="] = "#=qY3QPGCBhAJtX44IH932cuQlICubQH$Lg4c6i5UsSUpM=",
                    ["#=qf$I1QGSk5kMLRW9jxmYNSoKSG$BazRzHNPCuOYzzWEs="] = "#=qlZ87_IKk2npRX$jcx1efec7dCKVAYE3uIjOlrou1OgA=",
                    ["#=qobW5AlMlQYEdHedZIopZ_Q=="] = "#=quzuSJ1iLjbqbniDoYkUAFA==",
                    ["#=qAgwLmvCteZBjvtnHkOEEwgYmcgQ8QGBZzG19bo74mlw="] = "#=qgodTeFKTJNq4Crn9o9xmFFUwP3jEJIxIGpPry$iBrnE=",
                    ["#=q7z3NGS6oMdyGn6275xFicA=="] = "#=qX42E3yjhgONQqltBD52Htg==",
                    ["#=qNr68SDwJuwX2KBtmnunwfA=="] = "#=q$ASCrY_pmRULnLMNNnx2Fg==",
                    ["#=q9LPAhOau04lmJm1ceDqa5w=="] = "#=q9dPZnwxgv9$Dwi7TJ9OL0w==",
                    ["#=qm$Cf81pDaaU964bJ51LXvQ=="] = "#=qCSrAIIkBIccAxZV046w5xQ==",
                    ["#=qB2$khk_YfjRXZI0gJ67_X4C7Yjan4$YjMNRG_jJWycA="] = "#=qDtPfz4LNVfW1HX_7b42qBuq8JRs073Lwk_z_4My5w7Q=",
                    ["#=qWqwwUR72z5y6GHhQML6oag=="] = "#=q91JqckcptYDULqXO73bpYw==",
                    ["#=qGaPe5nkVI0$zqbI4$5MSCw=="] = "#=qraOrh6ZEgwWklGDERiviiA==",
                    ["#=qwU2gXPcB345VrTj6Ffudrw=="] = "#=qpa9u3SXEmJDTFF7ItFzEOg==",
                    ["#=qsorPhEgoPHtzXPXzHz7YTQ=="] = "#=queIEp57YN7l1z8d2nGjGAw==",
                    ["#=qsDVF4QavCI67pPxURWZm1A=="] = "#=q9h2A9irsslyYKW7bF24I9g==",
                    ["#=qJ5k_w6sTadmYz9i_SNscUgVwMiFFoAsXgcuNW_klHak1taIeyFtYb$JkcpRFlRzk"] = "#=q1GKdFN4qSFW0LiwB8nfxqNt3m90D41I1OTe0wu45fLpuAuUs_B8R7YXWzjoSFRvg"
                }
            },
            ["#=qrd7YSsxHDEtXAI0dc4IeGThu4P_DiU$HzUxrKbSR_R4="] = new TypeMapping()
            {
                typeName = "#=qApIoNjI9$ddDvl2rQOUrSDDMKs2sqEjPe3TjL1EVU5I=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q$bt3nCFdRMdWR_S7KVL9fg=="] = "#=q5dS7O8VdKRklLP2fXbZ6uw==",
                    ["#=q4kbXDev3saF9iSUe7PVqXg=="] = "#=q9N79a$3yuJYlJOGJGVi11Q==",
                    ["#=qG4ekI$GJGve3AprBLoNgBQ=="] = "#=q5VJk8w0MdOZ1quIosnG$zA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qM4wrUSpakJptcnPKbgk9dw=="] = "#=qf5gvDCQxfyMMUFhpXlNgmQ==",
                    ["#=qp2TgPr1vsvKeY$woByyzug=="] = "#=qHBhlEedzMIT_K2mgwcQHBw==",
                    ["#=qPqQujEdigVlh0li83RDyDw=="] = "#=qGi1DO7qYQ4CCQ6Nlafcz6A==",
                    ["#=qX1zr8vs$MH7fD_QWa6DPuj_8uDf32V4ziVpfbhkJyMI="] = "#=qee3Kyi8XNY2hSCpvzjLQDi$Zg6xnaIIhKb0Amz1D_vw=",
                    ["#=qrxsythggDbMW1HYtGoP2Ag=="] = "#=qGbXutLYZRJ1KoK_rzKSczw==",
                    ["#=qA_oB7ZPo8qaVIs77Dfsn6g=="] = "#=qgB$Al8Qyrcxs4BG$GM_IVQ==",
                    ["#=qXeRzCTyx6H6_zYyS9k4EjA=="] = "#=qyWugBwsfKoh12_MwjaxAIg==",
                    ["#=qVma0ZInj7_fAFYoh5JGeGg=="] = "#=quelG18y3MTkzi6tXMU6g8g==",
                    ["#=qQkmR9FzUyDO3cXMOcaO_yQ=="] = "#=qDIZcjikJ7RW0u1MbhI6AcQ==",
                    ["#=qlyvNcOjxirH6LnXyoW4Ayg=="] = "#=qtkpWIwLrPddBKWFvKGE7uA=="
                }
            },
            ["#=qrF5exugOgeEYag$KdYYJW73EbkwJw2g3uDmnC0zo7eMBvydNWkp4mHV1W62m1j7G"] = new TypeMapping()
            {
                typeName = "#=q3Ha0LGtMW1j5TP6iNYy_2mYrIT0oHl95ToHpDErlF0$uRwK30yYUSelTR4NeKI1s",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qVZ9NWXXEhcGM79C5$fkraQ=="] = "#=qsf7IGCMjFzKI7rWhxq26KA==",
                    ["#=qjniV9SgGuzUkFZVzeH7KqjGrYzZRNUKVG3F3XYpNLw0="] = "#=qOU6rs7XJ7ahDThLwKRc_Um5gRMHWh8tZ2r$plv48pUA=",
                    ["#=qBRWEtKCoYXXR$Pq8HktvAw=="] = "#=q04eaRV3vP$62v17dBu2eRA==",
                    ["#=qz295htNldYO3uNHSmFTy_Q=="] = "#=qBjnJCCgTKkAChCJhP9anEg==",
                    ["#=q4sZ68sFfldRdNinOEwG5nQ=="] = "#=qG8yWVc_JZ3IkJG96cdxMIQ==",
                    ["#=q_pH$XVa2075ofL_XA2sUEjrfdOFsxIT9Ga9jD48OtrA="] = "#=qUpnR7NuxcRXykcDe6ILigAcc6DQnP7FwH60cvd11zSA=",
                    ["#=qoGAHPRu2LfTqiClHRwKhq4X_ls9LMUOBJRgVNrgY814="] = "#=qDgfC0svs3ZO0QyCCelgOCy03Zsl9FM1YhixucQ$XkF8=",
                    ["#=q$OG4cS5E4Q$Y1tjh7RVTj2TvTmKrhnjgziIIeGqoTa4="] = "#=qSIGd6Czk0VaC5FzuLErXIyWVViCUAYV_5iWyr76oVME=",
                    ["#=qPBl3pKGTXYNm5Da22y0aqO8erYVSW1BN$w7$7Gq_Xrw="] = "#=qxZCNRIUi06c4YDYCQwNq4hwE5uRHeMJR2PjopY_79Lg=",
                    ["#=qL4EoUMZrRVcnyKkzr2srgg=="] = "#=q7XfTE2uWKwTB3umO6Yjvlw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qShyPMiJTuBChAq5NY7nhDw=="] = "#=qF8Gd8VKz291GyZ0X7scjaQ==",
                    ["#=qWxzKb0uMYVP93AhzHEA6NZE6r10Lq0sDtZn2w4JlTxE="] = "#=qdv_APncPMpglJFKjajOsejH61qIGfF3K3_2P_usXmdU=",
                    ["#=qDejEHkZ$NhFR2p5Sd3Wj0w=="] = "#=qs9SojT5CMvSjiruxPRnXPQ==",
                    ["#=qUnDTDwmtW09WzRIP2hnQPPMQRYOToqGoEm8A7OHX$_Q="] = "#=qx5M302r00au2krqfjaPutr0lSWxC71jYHRPo_8l1zSI=",
                    ["#=qlP7OQnUlBH$Rn1CFi5u73WutMfmaomtHMGJYgfJhoOg="] = "#=qFkQ$Dib8qJ$yrXjpLqgbYs7ap$OZCNtBHkr9XrgRe2Q=",
                    ["#=qSXfh1Td4ffWsfh1OoDZBw2UPWwuVxk5r887aybP0a70="] = "#=qLW1nIg_ivXi5zsjwIt9m6tqsoKJ$ugG09kwxv_D4W4c=",
                    ["#=q43Vhimhnudn2$PMyHc2Ecn3vAQNQ9dTc7K0X4IvN2AY="] = "#=qW7YV05Nz_ylp2BXnvhirJiGa$z17u2yWx6LHgDu7_GY=",
                    ["#=qqJHQWMcM0hytGx7fBOvu0phv01GQcFE$zhWVms1WGfI="] = "#=qAZ$eOpFbjwvwLGpyrzql3rBdqDTETc08jhZTv6Thr_w=",
                    ["#=qP3AU061gpN4ynofXDNIr65x_PkY_9tK_19vTvQDV3Zk="] = "#=qRtplPpL4H0VgrfFnEsq3dj8QP1LOL9iAkGa7wXWvoeI=",
                    ["#=qPafmmgX5FOS3VvXxoFTXJo$4Tve$Uodqu2nRQhp0BWM="] = "#=qZY7UKmCr0qWRKI9ArJ7h_XT9WyiU5KsTwopNyJP5CfM=",
                    ["#=qp$omMYHBvqam2XnmmBVqktCUxQ9YyvGO6mH1E2U1WL4="] = "#=qXi5IAT$nd_VGa8dFsifsRNEYlrYQoUYOMIv_OBv7eDE=",
                    ["#=qft7KWJxWY_TdZNvVXavuNvVtYqsJ5MDrdzhz0dt7EAA="] = "#=qge8$vvzwhH96wW8Hvnjh_MnKo5qyUt5m3WbBrg6xTf8=",
                    ["#=qFBPXzpAsXXrH1NlS4CKOualPLpAjv6wHmsCpNT6v2I0="] = "#=qtdxRi3htmnVQPT3W6V0nsfXaPDAjelKoM$qgp$TqVKY=",
                    ["#=qOR1rbJ1v_H1c9scJ0MdXlArg710TUtU5PExmR0FccWk="] = "#=qzLKYkxDyp4QPihBei95XyZsA6N3iGc4imDrec5CkNII=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qrFxIQVHB6zckGS$2S2QkW$XrHB4sWmt5Z39oMPWYOPOWH45jpaEPAUIXTav3HKvF"] = new TypeMapping()
            {
                typeName = "#=qW_IvH8Z7nljWyEfxT17NKi8xhfCCDX2XazOg8Ptwm6FqQ0R23Ezo2m$$bGDNRdq0",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qh$gSG0skC0n22GbhCCP$T1NoiZ2BLcnfqVxuKK8lAfA="] = "#=qg5Xm505DEWBd3EPwVvXfxNvULAOyB1HmR8Pi1f6ykLI=",
                    ["#=qIMKqU0mKNHlkQkNhnJXQGQzi21XtBki6Op4LWN9LNsk="] = "#=qC7dyWMY0yuA_beATM$bx4pWYgNPxoq1udu_fw1CaUv0=",
                    ["#=qQytY0rHbnzvFReKL$IkrVXtHzwqln$nGwMG5ligon$c="] = "#=q9ifzz74WmBjNvStyceEg0ywDMkTAVHVEES7jpBb_EAo=",
                    ["#=qOlYWLGLExMx5Au_yam78JDGrTSEifTvQj11ZVoNYbI0="] = "#=qSQRf2oEKp4XDrEAHrN6ScyNiGxHXvfU3KzL4HGO9FZI=",
                    ["#=qKxtfjWaLgCUmpSatEMLeSg=="] = "#=quxo6LWOyknwJElJ0iBmRnQ==",
                    ["#=qSpeFRCAWjwWwa56Zbe$YAQ=="] = "#=qGGbe4E8qO772eF7VPz0ENQ==",
                    ["#=qTrJ04XtsM1KRXHIWppHH8QVX9RUFaCZkPArGk50Ecik="] = "#=qRL62DdkceWFdR3KSUMPerTDi7tNyWJLizff1V2ra_28=",
                    ["#=qaDrT8BpwvqJLC3i_bg$NVA=="] = "#=qYm3U8HmBvzWB0Ww6zYOwlw==",
                    ["#=qha_RbmJrNkvJduhDWQ1FGQ=="] = "#=qDJX2RSbUgeoTByqtJwh0ZQ==",
                    ["#=qvU4YPotWW$3aAM4J97oJ$A=="] = "#=qksNHq1pJPtpR5MKURYTB6Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qOBn2_szgloPdGXWy0JfMYQ=="] = "#=qrqV4MAomh5DNLtaC9NjG_A==",
                    ["#=qyhnapt5_H2TYIwmPaO4e$SlnqiB_cL$UQhwi5PVVJtnoN_SYvAis0e44GxrPSNsR"] = "#=qtOJH_NhBtzPEclMOSdIciUbQEEZnsVUMCh0IEZNncbmX5kXp6aBY297AXJrc4Lg5",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg=",
                    ["#=quiaRDl_HiRlLNrWxz1xmxA=="] = "#=qxTsG$i3RFAblVZisfoDQ6A==",
                    ["#=qOGFbG5dtn6DBHULogPwizA=="] = "#=qNRFZClVBMJAvyWBmslA0Kw==",
                    ["#=qeX_OzvYXZSxsceyJf3KVU9dQvtWmJTIraRFQ6OKn7kM="] = "#=qsB4Cyer6OaD34qVplx6XOOEZOfBMPJLac3bMHclpzSI=",
                    ["#=qvMoqOIfb72uECi2h0zLMd7QZt4eGmJDt6deAuKw8yRQ="] = "#=q_j97oHz1CjjgzhFswWDy2WhreGApUSWIOkvY4OoOK3Q=",
                    ["#=q6DS_KBksWzNdRTOjx7oa_g=="] = "#=qqkBkzA6$Bi_8APYSEtnkNg==",
                    ["#=qHts8q5QFZPnzq_Sws6z5rA=="] = "#=qb07$s63rdhVeckhER9zn0Q==",
                    ["#=qygIi8DqITmBKoWKRRghoQA=="] = "#=qtBQZwKW_u295xuRO9SezJQ==",
                    ["#=qcO3yHHAOvd8JCiaxImk78w=="] = "#=qpSFKp14lhsbObDyqCgYvEw==",
                    ["#=qfy313zIRRGAoFnQj25X3MJlAqeLAMYtgq2k9jrERjis="] = "#=q4MZnX_uGHLkLMMQG86RFytjdKnlJ2iQ2tfaQLb9d9ZE="
                }
            },
            ["#=qrFxIQVHB6zckGS$2S2QkW_s5ENqpbdjRMeEO8Pw2kcg="] = new TypeMapping()
            {
                typeName = "#=qVYef0114$JdsptnqVavlvOCiy_g1Tmytt6OLxUfwssk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qm5InPSp8HvgUNf81JP92T5kdDf6EC7N_5DKkWXjpT_E="] = "#=q_rl5tMIQIUzCtBvRpnbpg0WsExPLj1OfE23J65Qb2TE="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qRgRNfFXMMLRN6CFWx2Ho6O0t7k1I6h6IcMgpGyWR3CU="] = new TypeMapping()
            {
                typeName = "#=q1Ba7K_7AT4wET09jx0CUrB2VBxolOyXnXxLLsi4fBRM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q4nOtQApF14hLqimx4dW6mQ=="] = "#=qhVVDBYJGmAkfHgKul7UyGA==",
                    ["#=qmChGKpPmy$XLhZCZMJZyZg=="] = "#=qfe39amSsVESKofrfRK9fCA==",
                    ["#=qTUqu2$o1qMeXeY1v7AeAag=="] = "#=quzS6IelvMzTslqPM7bX0ew=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor"
                }
            },
            ["#=qrMdopXlwTJgAcCtyESMefqMBheiqDh24yTr8HcMhfgVKmdSOPT4emz0Tbgo8JSpR"] = new TypeMapping()
            {
                typeName = "#=qNenjPAIeqFgcDMPZdfsMrPtVMfBPetZFZpe0_aIhcN$MsKtZpZjI38GJJJDYT4qY",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRG1zCc9W01yvOuG6BTdhGQ=="] = "#=qeAaCva6jsm3ihhHUOjoiBw==",
                    ["#=qGGRiWK6Hr2OsfuWrtmrCnQ=="] = "#=qrnr0chleSTDj1J1Mc6c5Uw==",
                    ["#=qseR6IFShBDB6Judf3mRuJA=="] = "#=qi5beTCR_eiieTN4ddBtMbA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q3QfZ7gXT5sh33LlpQEfgo2JsiajzXYARZ6v68esowGw="] = "#=qrBOa89qELB4TVU0Vc46U$tiXZKpQ9_zDSb2lf3m6qVs=",
                    ["#=qT9CIMnvDuJpH89uXs2pgFg=="] = "#=q86ryNYpi1oYiBjWx4K9J1Q==",
                    ["#=qUlRcP6f8V7wFjrjryxzs5A=="] = "#=qkpfkVnki_YTiMLM0KgoVgw==",
                    ["#=qSlhQ$wdEy$PmcvaOMn7QA$seXXSJPFMKtDYwpnsLLSM="] = "#=qTxF5bJxWE6JcFiTY9239J67MeKVwbprymEuwFSfJVF8="
                }
            },
            ["#=qrN8FTf4zsIFKC$3MYN22ulhh7h5FMxHtWoEjCmflAOwtvwdROa03a60hXP$4ijf2"] = new TypeMapping()
            {
                typeName = "#=qoKSkCrqyAvwoJod3m2C0RUDe8jafGa7M6ll2RQ0m$umA0gIre61Bv0pSBlt3o7C3",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qg2FiHWPCw7sIcfnyh4Kjqw=="] = "#=q45Y0fjuIiszoLBH$8JVYwg==",
                    ["#=qI$X4TFwRScBv7LqB9gx0OA=="] = "#=qjAjQh0TJQ0BA5CRN$wS8wg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qRnUjCB0anMXtXWn_ZwRApFYQK30tMWdM6vl0nexs26w="] = new TypeMapping()
            {
                typeName = "#=qNvCE9iIfMcvG4bTBjrkNgcTA7UuS6DBm7aN00UPMWtI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qRnUjCB0anMXtXWn_ZwRApO3IFZ1qIUaUXZ5zKSXIMWc="] = new TypeMapping()
            {
                typeName = "#=qJdMAV6K2HnqOha$FBjfagOIeS$mo8kLOxQuwnANpGnw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qROrqHW3ccrCaVdGljx7f2g=="] = new TypeMapping()
            {
                typeName = "#=qw7a9PkfLP0uGbM7FoErH4w==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qKBQh7$GRLPvtc$5gKdRZEQ=="] = "#=qibNkn8gbG9$PUc$gpXn3IA==",
                    ["#=qH49x$X1LMFG4rVgl1pjKQg=="] = "#=qu7rsdXVc7k8yZkK3wg$9nw==",
                    ["#=qL5iMuDUj5JMLrLssFElm0y882KnFcaBPx2SIsc1e7ME="] = "#=qXpYWR2V0_PatzzvxCYcd1yy$tNYg46yNjiOxjM_jiqQ=",
                    ["#=qOqt2fLafUlAQHlNFYYVmlQ=="] = "#=qwv$9nJ_P9xA5AeCPe2NIOg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6xUaUuArBOiDYKTBe1x3Cg=="] = "#=qi7XtY0DE8bGZpT3XXavrTA==",
                    ["#=q3YmbWVJeX$tGVW0iepTusw=="] = "#=qddwKBWc1n_1OefxB5ZHNwA==",
                    ["#=qYlKLnX$qTR8qWaFt1zcbkA=="] = "#=q2UuPRljLesT78qcKLLJpHg==",
                    ["Dispose"] = "Dispose",
                    ["#=qYBvgqyJuwkFL0vnTEGmwDw=="] = "#=qDRVdZk7w5o2wjXt7RSI64A==",
                    ["#=qlftRM4s0zyLkCgIM6fPvkw=="] = "#=qemzQcxgXE17Q3X38t61DQA==",
                    ["#=qdCaNCURnuQJd3u3MK6CzoQ=="] = "#=qFZkidbjCoxrLdBclZeoTJg==",
                    ["#=qo6isOrxl_5oyCBco$$iXsj4nSzs2GO80IA5eDAzFlTc="] = "#=q6OXe$mINB6Nokegd1m236iim5D2XN4I4LSgpE1myyZM=",
                    ["#=q24H4eHTAtpCg$wE0EMS4MQ=="] = "#=qLknY43OwgK05RXWmV9E4Lg=="
                }
            },
            ["#=qrpRzL0i4CVHSZuwqrZRl$R_OzvJOqFQUDOqrHMCNsdXGhJaKPIgjrKMnuK6E6sNc"] = new TypeMapping()
            {
                typeName = "#=qEh8VOMYLCNQYd8HeCpcL4fciWF8RftKmLMdTyYASwvnbM6XyH3zLD7WZ3iNfMcfH",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qvqMMLut7v9E_umRsq8yhAQ=="] = "#=qKC5dyKqbnlbAJBOak8Guwg==",
                    ["#=qe44rqWGqPKmKj1tpW9WMUA=="] = "#=qBofSx4jlmE9PGDohZD8pAg==",
                    ["#=q09DW0qd$GZIgtG$gpSKh$xj53AgtCx6dwFhzY9EvBx0="] = "#=q4e64sWkX$tYXVdzhFveWYNyZBNUlby3S2erCNL1NJIU=",
                    ["#=qYUGyWK1kvDk54xBCVrSlhg=="] = "#=qZy3kAhJcWche6rP$oEFR7Q==",
                    ["#=qqDl8KLW8dhkhw$B_RboVpQ=="] = "#=qn1r74foH290wcfNlgdYylQ==",
                    ["#=qQkIjRPtjGrSVsOkMjMESM5kdVBpdbuCWKQtCDP0oKOQ="] = "#=qGAcGO3fV_ZjK$2Be0quXdQ9l40BrReVuMvwAchV0hAY=",
                    ["#=qWTByR4wlBwmN$EGoWRk1FQ=="] = "#=q3Oxj_xtLPsN7Ti7ZR2tjTA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2AZAknRqH9mCBg4Zv1xClw=="] = "#=q08NsHXGHP1bjWBJ7cxqt_A==",
                    ["#=qyDqfPPndQQn6VnG7IJBL4A=="] = "#=qJBblaS_IFzLy2bWIOna0Zg=="
                }
            },
            ["#=qRqUwhWFHixPvT0KV7h$SNtGqcj$0b8M2a3zKyfvxpvc="] = new TypeMapping()
            {
                typeName = "#=qmSSpmS0D7v6T4$0tNRJsADNM5XXXLxkWZf75Xwlkces=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZ$nUUlPgue7AqGl6lV9t0Q=="] = "#=qqNJu2928fXb2vrm9nJHAQA==",
                    ["#=qzhQ6bF6zN_Qv7UDqLfiYqFR5WqpHaaW2D0h0RpmgvBU="] = "#=qjJRF8Amikfd7QH7D4R4DnpDFI9c6hzbCogqmBjMeB_s=",
                    ["#=qCiPSQy5AgBqSDaqpRmUuWeechpzxgUR0ttwIbLo_UCI="] = "#=qnxqFWLCXafXBNb44uir0TOXBmaFCZdntJB5_KkDE9lM=",
                    ["#=qVTUsV1iBR9v0K8nGmBgyFQ=="] = "#=qfgj4U$XMcTwR$z7T9TGBzw==",
                    ["#=qA9RnbkoLIyZ2j6TeHUwfbg=="] = "#=qgwRG_FPjHsNVbsWwuLsYTw==",
                    ["#=qrPIBR0I0hcwuUeam0kwoKw=="] = "#=qHkXmv$CdEM2xhzvGzAKImw==",
                    ["#=q_DI96y4vjebp5BX1Bugxdg=="] = "#=qX63ZB9F08BfsgwFwt2unXA==",
                    ["#=q_ScuXvKOhQmzlaJucu2O1IzOua_9zWwtBuUu9JWvIBQ="] = "#=qiqtFhJSk2bDWsF_PxudXMsRDbHlscLR_bLN5GQpnaTw=",
                    ["#=q_vC2o0A9n0Tfiri8pMx1OMAwl9t_qEmENjIdL1q9uiM="] = "#=qA11B54kxpYnhI5qSbWnJWf05VnYdEgjj1FaE$GKn38I=",
                    ["#=qiS90KYuGUeP$_VBkWwQdJg=="] = "#=q6jMpSesAOknCCh$48oVd8Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qKlmPj72IKkeC1hb3kZitolfMEDChQevorZREWMq144o="] = "#=qShnK9yuwGJ0oqLUnsy7ngupecFgnmCLhbA_Wl3QfWsw=",
                    ["#=qy6FIEnr1NuDQjcNhQsaJtg=="] = "#=qCDs05t5KIumFzIjXPNpWuw==",
                    ["#=qwtnTU9p2pjP167UAcal4Og=="] = "#=q5gGZBa1sZ8pJa2qyPZA5ig==",
                    ["#=qCY4CcPz1j5WJLpaiAjT3wiNKyyo8s3EDQKlQ_O_Jb90="] = "#=qiJv9FRP_EAmbtgjrblK3Mhh25pS9eRyL9ghp9X6BuMg=",
                    ["#=qg58KHao0kHehyn1S4EeZZiuYpKqLrokq8Kh2dcEMieY="] = "#=qFz1_tKshR2et4XJtVX0RgPQIkMgIcKgPQSDydU8LEoA=",
                    ["#=qvNQj6u0WBa_GRa7yYYVAC$tuPxpH4weABZgF0yUE6Xs="] = "#=qS175BomR63oEzzfRme9itsBC1zmw585jnDfeHJTifoc=",
                    ["#=qTSMdtjEAVErS3KDdoOcGczvc8E23oTVmMQSygDwthRk="] = "#=qxdvHHajElNt1OAHw9ZhzhYAx6S2l5N4uDVHOnphu6fE=",
                    ["#=qbSC9OQuqZ8zBZuGZXk69PWtrJbddSWy3KcOds4UU4ck="] = "#=qch_akHuhyjKp$lzlqR9v_dfI9oZrOUWhwWSPYOd1gbk=",
                    ["#=qxTnIc$N_n74kt_lzV8moHA=="] = "#=qe8jjqhskN9pR5D4K346hKA==",
                    ["#=qy3FYbiJPcx0rEIo0Wq_TOw=="] = "#=q3YC$YimcxU5qTmHHZuBNfA=="
                }
            },
            ["#=qrS2lIidkLtcgeTZrbLG2tn$2eYmVqlTj6u5EbLLVnh_9$AwKn7cINctzN1IzEMdk"] = new TypeMapping()
            {
                typeName = "#=qkVDC7Zo2W8PnoCjMgXtJapbhBsvIrNtNXLuYZACwTn9XcEMuidCxyXIC8Uq0EGy6",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qRSL0ypWJ$OvyWUC683qgovSlbsqr_DnXU06SzktbcAo="] = new TypeMapping()
            {
                typeName = "#=qwQQWuZze7NsovogeZuV1j$Yt0sPrE4NkvF8lokD3irg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDRKKlegMQFYfttsk8tS0_w=="] = "#=qNpF4nHdOktFKbCOgDuRk7A==",
                    ["#=q_qpqLsbb$YGXVNdN_98evA=="] = "#=q7M57H0XCn6n0j8WpjwbZ0w==",
                    ["#=q5BSjjj$$pKOdTHVMi0cSIA=="] = "#=q7vj$oIwWrLk741IRvK1c7g==",
                    ["#=qpYaObpn$7H3526RNaqJFZA=="] = "#=quXTeejvN9eMg3Noa3YA$mQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qrTX_UNp$bteDAnEj5q0F1vzjqEfOwojnZRWNS8D2kB_VncPX0pGXLaQQDUX$9Aeg"] = new TypeMapping()
            {
                typeName = "#=qXOeohT7obbNXufoe79t_5jnONh5NqksWiqkviRPMHW7NdkUjeuWvc$KXUprxRt3$",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qrUM8eENC7dHe6$KfcsPuAH2pBk6uq2Tk6NOoe4K2NaXSGJllDR47ssqky74TwE16XDLsb88BB0eQm1uCBAJhIw=="] = new TypeMapping()
            {
                typeName = "#=qf4a1rC7b_pteq82uSrkhyuy$DgOawENCNUndGF8AdPDnfixNen_oSsqI9dp7GXC2v2gl8bAZ6dr7i_zrRUARQQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qRWPlOFnPvg_vYy4xPtKMXEdfk9968xs6IPEbsTY_2mQ="] = new TypeMapping()
            {
                typeName = "#=qtLqCcWuXt7wGsX3OIiziax7_Kz3m2sG7gBcMe7EApiY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q8whFxllIiVZTliGNaUoVqR_55yz4KGIZq8SisNlmPA0="] = "#=qg0tSQQr2lwOZjV9eLHThVvALVwGa8GIGMv6KOwIemt0=",
                    ["#=qRQHY79Pbddlo85xEoskkZA=="] = "#=qNy3GcXw9EVQ15RelyhFf0g==",
                    ["#=qHPp5yvhJTnwnYrvqDjBDAA=="] = "#=qghHSUExqGzeMbsHT_HtGBg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qlpgceyBI_dJ3b09xO50Hkg=="] = "#=qsHx2rb8mub38ZKefy$sniw=="
                }
            },
            ["#=qRx7ZfPnU_oTBF0cGYkaGvuWAPvS478krajKgfxLowe72jz3UhMX6QvkfGxi6IxYe"] = new TypeMapping()
            {
                typeName = "#=qdQb0ne7Q4MYBUoXm8PCCFDrVnhRUCRYTFW2TDGymAeDM6SfXWqitjK98PJllCIgx",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qs$FGSWwyrDExva9oJphcbsrtSXvurPiAi906j$pmUFKmPU8igDl3HL4vIbxD_FOb"] = new TypeMapping()
            {
                typeName = "#=qfA2eGpf39d5P6kZNrVqAEgg4liunpR3PQih$GjnDHM$o0yxkaM12OyFGcJRyU2$M",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qS$ORv1zF2BM2naiQPh6Hv9kZgZV1tw0kGIBqL2ZLWPV6Bwbg4Y6w5VHGmoiqjEJL"] = new TypeMapping()
            {
                typeName = "#=qFk$oETyXmLl0_UGbcIgdaxgT3g2DCXLACNau2YW3PhGzIVdwBewn$3kiUpObMtcw",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qg6dk6p7d5ptFLSHtDP1nOA=="] = "#=q1KumePUBIXTLvhgfoRmavw==",
                    ["#=qjGqkEWVPbDJ2cvCAM$K3MA=="] = "#=q4aNMRxeoD$WlCd46GnDlOA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qpVQ7I8kA5J6RCDwbNHFKxg=="] = "#=qEemMcSf1XGurtqFcS6x3MA==",
                    ["#=q$2QQ0c$uwsVTQyE4yCY65A=="] = "#=qmuMwYP7E4jkbDSJhAj5aUw=="
                }
            },
            ["#=qS9IEnocXBs_6TpFbgWBEpPkLZkmiNOQz2WY86q3rDXQ="] = new TypeMapping()
            {
                typeName = "#=q_i1ULUjvyyp_zhQUWlrRXG5cb5YFb_ox0FG4yzbI8YE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qPQeBFXVC68vflveK02nxOw=="] = "#=qjGJJGa1xfpqS6Hzxp5ISZQ==",
                    ["#=qAZBk4Q_EDKa5YclDJN3ofw=="] = "#=qQejch$8w7xaYimr2dF7e6A==",
                    ["#=qsklKpBNCMT_Yidln4S6DbA=="] = "#=qHU_VDRtppKCdpTbYlwjecA==",
                    ["#=qxgAFbOAKtu0qHJNMQAjGWzYcfmYcsx6s3FIVrc$dY9g="] = "#=q2QmdLsCqWU7c6asFy3zN3bvshhVdMdeHKIzpNim1dUA=",
                    ["#=q8iZCS_1VapFtRBChmyRCfg=="] = "#=qG_Tl$71dEdRtXGbtIKDi8A==",
                    ["#=qegilLINem2QYNmgBsDWqxw=="] = "#=qpmPVlrpSIIkBD2EEiJAPpg==",
                    ["#=qqYY0QaBC6bWtcH3zbK9nyw=="] = "#=q$x8PGFrXRsbx3ytf$CFnkA==",
                    ["#=qTwGMMeyaLaOKwnjyORDhKrbzA6RkDnupIRlLhKEf_Bg="] = "#=qKJPQutRqJ1om$n49Y1siR8u0fDKOXfbYnSGFrotUygY=",
                    ["#=qNkcjv2X$wwQyiC1i7Iphy$hxbGftF$1254$zjHmtbDs="] = "#=qscjb7Ix7QxmJhYkS_8OdjcyfEewVyXlkEXi8Q7vXQNM=",
                    ["#=q5W4XlNPxEq8VXMULLb4Cww=="] = "#=qK07cUUzuFB7ewei5JEUTGQ==",
                    ["#=q9Qnjod9IhiQ2XCwkVLOAzg=="] = "#=qiS2jxW2pO355DcTHl1tUNQ==",
                    ["#=qg1SpeSLDFlfys$AaO5oWVJs2CJUCh4NVEKxFrBOr$lSUDw5zS4RnrdDV0I$ob62o"] = "#=qRsH5tpi4ysrdqxuOvKDCKHd9kWThiJJfMWJ9fs0vng8euPyTg5XfODY$2FqEoeWL",
                    ["#=q7jUkHwnblqgzzJaD4oKK7e0glgwQcbdfBrOEbzWRsVfG2WBI1g7Wrt41xBZ9RDUF"] = "#=qg7HLJZAjxQ9KE4qhs6vqFOEfiKUDazhIJC08cJbcQgfUvNDYR5xrq_BrpXlI40p0"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qcqj9Fyv_0ujIpb0RTyN3p4itDUAVfkq5aK64p3rUVek="] = "#=q$ZuZjR0aWsCB3jkHu0h8jIACfaG4UA$L0xf9MVGQUHU=",
                    ["#=qcNDxN8UDHOzeK5IjIk3fJx4GghmzVBUKVUruqXbbKew="] = "#=qnuEpeWqMZsEhUdxQYcV_N9lsuNhgPrFbcYhFTGfQpMw=",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qKaBNPpXAZ9lZj1dPH4xG4g=="] = "#=qFHZd7Pg_5uhQfNJJn8BYnA==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qldLoAjwo9_IqHhBLtQEJzmFpkw_5U9QfPTG3tbCOv4M="] = "#=qiaegkeaGqSAGK5vY$5ce26$DxFCMWVI6hLSaaZOoQzs=",
                    ["#=q_$2CRNnRaR8k9W0p91XW4_JakO9XeAVZXp1ddhXuaPU="] = "#=qQMtBFIQ5hpwyuoos5yf1NYKpR2HafXoIkYL2SMLou2o="
                }
            },
            ["#=qsCjZn62mmoZCDDN6N$_bS5V1rB31qYW0FwRxwHqqHaA="] = new TypeMapping()
            {
                typeName = "#=qEQALQ1_LnJhxNojF_3oafoTOFpWZMWF_8_E2qBVBpDE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qF5xcQKzvUEtHVoxVTzjVDw=="] = "#=qeJXNB0ffiiRwJpLZLFPbng==",
                    ["#=qFe4L6mRny1I_YHBvmXyoBQ=="] = "#=qL_tswO0$5PcWznNntXxESg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qie9ChTmkRx85jJG28AZGvA=="] = "#=qKyuywIZN1liB8Bn1CZ32Lg==",
                    ["#=qgBwByNjqHCpBp_ls4O0AQQ=="] = "#=qK5Vj1FL33b7fh9qiO3jF8A==",
                    ["#=quR45sPz0e2Lxhclfgb3x5Q=="] = "#=qTjGFHjexTOFsrO3fjCPWXw==",
                    ["#=qyR6I0eTnpXho9fpe0ViuEg=="] = "#=qmCbixwQ55KWa0Dnck8Jy$A=="
                }
            },
            ["#=qSIcTYKpy_Gzd4V$hIVlNySpW$TEsXk1wOzQb5S6z9Xg8YTXmpRVTjrtyy$XpVPpz"] = new TypeMapping()
            {
                typeName = "#=qyLJuo9$y6LJePhsz8xIcjzmk5u9mtG$7KgqSa_7o6gBN08LGlKe4r3TNPhDuVgCH",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qSIcTYKpy_Gzd4V$hIVlNyYRWofTw0DKmFlGsTHhHA4LVpQDcNpup3pwUSTSpU8a3"] = new TypeMapping()
            {
                typeName = "#=qOEpxIT50u1dCOT_wOsxF_ZgSrCr1UZlUNlcj1X0qDYZwPaaeZvQAbSpablzfyTFT",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qsL87EJ4VhPil5p_uK142cAHahOHtoLQ2U3f9yPXIibo="] = new TypeMapping()
            {
                typeName = "#=qFGYK03tisX4sZ6CsiLKvmqf6iR5KIyqaH7wjFdN4DZA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEXb67CRBfduqSEN5k4Jovg=="] = "#=q5SJ2qOw_38VB6JLAn90Eog==",
                    ["#=qCZMziYoXAOtpxtE1XOnHqw=="] = "#=q_6CzLKMbUCzxjx8gGVMmww=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qLItyWHg9I1DRIAjQguhK6g=="] = "#=qyfRDOH8K18kSgme7gR8ngw==",
                    ["#=q29h633bNjzr1qrcxMG_t0g=="] = "#=qi9$xwk3MWOG6V0u8xuJJ5Q=="
                }
            },
            ["#=qSlusDAc3BLHoObNQc2yvkUMA4WBNUJLmb$y2usJO8k0="] = new TypeMapping()
            {
                typeName = "#=qO637k335Jt2nYY1OiSVg16PI1A$nINBBgv_EV2twldc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qbRKTXKQoJEzKc64Ey2CnIg=="] = "#=qRhVOiGE_HdKURLncWRimTw==",
                    ["#=qnGCr6P$cXH83z1T$3v2uTw=="] = "#=qohDN1SCTWTc4N6LY2YKI2g==",
                    ["#=qoSrwKdtA8LkXO4Db8iP6og=="] = "#=qdRs2h2f9YXgAByFQWVwkEA==",
                    ["#=qJ81NnyKIpi9Ulxf1bY4MYYr3e00XtZMhb_pMN6ptjAk="] = "#=qm45DVB7WVCnWX8vIMqMOYN5kcOL2LoqoDm1VFUzzjMs=",
                    ["#=qOUz6u3WbDlljhiPZixM9vw=="] = "#=qI3a7rzX7qXwZMwXNcEWBaw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qf_No_j1cqK1SzoSJi6CBRw=="] = "#=qoACHivR5CXjSuYiz0DXDPA==",
                    ["#=qKuuSsoGd5A9kZpwDFOgAxcVW2gYGr3pzFcumoGhPpbE="] = "#=qKuuSsoGd5A9kZpwDFOgAxcVW2gYGr3pzFcumoGhPpbE=",
                    ["#=q7VWQhup$_XKp971_n7V4nA=="] = "#=qx$X$Wvn7EwzqvWWJ_vPHzQ==",
                    ["#=qVdOwgy9sXcCzFNjQu8w9uQ=="] = "#=qyGoob2OR_Z3u6E96ISSrAQ==",
                    ["#=qTHe$9q9MkwwivAA3KsZvRQ=="] = "#=q3CU$_cpMLmVmetrkkgjITA==",
                    ["Dispose"] = "Dispose",
                    ["#=qH2kn5dEgBQdYEh5EUk7G7g=="] = "#=qKunnMRZHRHijD4dXDRbB0w==",
                    ["#=q3Bqd2l_dP6O97mEAz6V_Ig=="] = "#=qd6bBviW51MBr1Wcys5D4Uw==",
                    ["#=q3F17h_YBF9qlPVgoI_ABSw=="] = "#=qKC6X3EBuYZpiYY1HyiXTRw==",
                    ["#=qytspx_Dv_PaUy95RA$NQOA=="] = "#=qTDcvaBxCsU959SsjmSzl0w=="
                }
            },
            ["#=qSSQy_1bzVElX5T59rD4xMRuCKOesrPrehxKI5H0yneD7txG6U$AkDxNBN5hRoEkg"] = new TypeMapping()
            {
                typeName = "#=qVgiPeCSxqfDTQUYKHpB_rSYqYFDQQABZ6HTxFdBlDbOQckl94UU4NP0WuJX7w1TP",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qSUtGfaESiDXPc2$wB9klQvCOKqemPR7$iOkEy8x0BqE="] = new TypeMapping()
            {
                typeName = "#=qnQ9DzO7rLkHdiFlWK8nVs0$3NX4tck4BRc4ygKiiF2o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qsvvaHAEKco$Kv8oTqiI5obg83fNAhrmQ1uuANspcsPs="] = new TypeMapping()
            {
                typeName = "#=qmd5gEo14mVkbOhHSuPO25i5no_5PT9yBtonyCi2a2yA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAg1A9TajYPs5dEeGnVVEgQ=="] = "#=qqYrqmiFcEjRgYIp5o3ud0Q==",
                    ["#=qz5bp5v1HGjrBNfymYi9WKw=="] = "#=qP20LfPeEm3CXmIZGX53CWw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qi0t$5xcw$wWVeu3lMsA$VnJ_xjfcenjaW8aouLeC08A="] = "#=qQvEjYc1wr37QMvqSm7Nwcc_oS5288t9HDJJ$5sHvKpk=",
                    ["#=qSeY6yXR4KOKx5XWDrcyUig=="] = "#=qlVjhUitQOcXwOLZtCVB5OA=="
                }
            },
            ["#=qsvYvVZGDHCLWjmv_feQ0eYMlu3_K84wbBnaTXRe0TZS1mAhh4_O5JVaJrBrE_bvu"] = new TypeMapping()
            {
                typeName = "#=qNNR8d0CCCYIp_eyDjD4jOoPujaYtlB9Ku7oMP3l7XWbU$ZnKrb5kFBFMZKmD6r_$",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qt27zcAwMUplz1W00sSQpVL6AfV_128m4ANUoVBjaLNmDM3WxJpBSUvQD6JcVLph$"] = new TypeMapping()
            {
                typeName = "#=q_fYcRjsh4JZ_zCITZ3Y$dXgATWkZBqngMOwmaPW9u5LiTRGZt525PHMLknTrTkri",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qf6D6GNocrSa80AXUlDWVvA=="] = "#=qdkgYBMguHZoRY1E$doLVng==",
                    ["#=qPvWOhR1N89BnEnt6LJSM1Q=="] = "#=qzzy0JgHfi1o3FqRGrlzdHQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction"
                }
            },
            ["#=qT3YrgP_Yn$n5Sk2YSQQEwlE4XEdCvgNNvYUCmr78JN9pVI4CwJ8_l8yj88Yul9Vh"] = new TypeMapping()
            {
                typeName = "#=qWSBabxvwDoHfRsi7bHmr1i_GLa2hHYif8SbR$0FA7hq1VoAf8PEcNPp3ygRy_vFv",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qRK3xXnorb7BmnRZDIs5Wfg=="] = "#=q_XubG92yaVDAzikbI2Otcg==",
                    ["#=qmYOW2mtpePcMt0px_G_bwg=="] = "#=qhUNRNtdz94Q3P2$imzn09A==",
                    ["#=qVDSjuGDfY$eSarmk4FChoA=="] = "#=qqhkgtjzzirl9PUmiR1LGcA==",
                    ["#=qyljhLjoiwjJqzuhkAw32rEm7aVcyoFYpFl6Smkke7ZA="] = "#=qubgzSlJl3i4Uiqr9DhTf09S1dQqkh88VNJstSbYs08c=",
                    ["#=qY7EvXiT7fyTtj8ZmILee4WHPgo8CVG$tS2W1RDIqmOY="] = "#=q1fK8YXlAse9iV6DZQ3pSK0cueDVG5GiL50s7dn757ck=",
                    ["#=qFu1pFrikM2WMRodyWWm7EaDB$sFf2Uwxz3L20C$tWOw="] = "#=qeXS8CaDgtkj5hJqxlVxEMLJVVedqTL1zwv9zB5hrXfo=",
                    ["#=qCsTgqZoP0U6FR6OcTUn4ZA=="] = "#=qVQlbMiytbB_IPS7yywPA5w==",
                    ["#=q$YJrKuz247yAm0YSfxwMDQ0hMwvmNFSw3Ybgx0OgvSW26qth6p0gqpMl4wa60_dW"] = "#=qBvLIR7UZatWMlooGu9lRa6BPS6hwoAnML8U2ASYA9ejAHSLrGhVDdQkUBqzRGccl"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qaP5qnYqZs$TM5FsLUDA59Pw3UwrrhL1q9X41SMYWVqM="] = "#=q0Y4qwsA3a3DqNzJCtoNgu8jMeY6Qrjf8G0eGMM5ggc4=",
                    ["#=q6M2BwYjAx_jkKV$2r6U5LQ=="] = "#=qR0rKz7uPpkCTU2mGFQEstw==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qowWpOI8s9UM96$$G$1yrBg=="] = "#=q64oNhaKK01KWI5aaSIsrjg=="
                }
            },
            ["#=qt5hhxoJisGeH9Jtd2MsnX7S6K1pZ9iBlmOgx$tf66Io="] = new TypeMapping()
            {
                typeName = "#=qMnLL6LI8MCqv_tkc52Po4ITR9O94uvPe4fWSUc8oTmM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpBW0nIJ6ojPSJlxk0irONg=="] = "#=q$Qkb$U3Y8wsXenI9LNKRVA==",
                    ["#=qjiJfO5DDgXyaRwabSb1nMw=="] = "#=qzHX4bdAu0pmCAm8J5ZHEpQ==",
                    ["#=qcu_2u0yTZ0VHE4TPfB64GA=="] = "#=q2KWQ213w9Wf9H6gx9KabAQ==",
                    ["#=qvsKNNAfzY0LZXVxCglIlwg=="] = "#=qZbKKnjlUeE9vy2O3OovPpg==",
                    ["#=qnqyK_pMLaVjddKFNqx9a5w=="] = "#=ql36BBfV5ymc4874pRe_AVQ==",
                    ["#=q9HHyZ$wDtq791qHoO$fbuQ=="] = "#=qTzYIvApO7raOjnuPqPY1rw==",
                    ["#=qJSRvgFtO4kyQRVD8598SWg=="] = "#=qCGo6RpW259jAV_TJVvL6yQ==",
                    ["#=qzK_3myo5$NnEWv_9E_xlLA=="] = "#=q4Nr07HEeiPbAa_Cg007TYg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6Hn13ATM28ePmgh8mPFaoA=="] = "#=qT5kWGjarcqAQ9ncDNKrOOQ==",
                    ["#=qZ1ktu6flOOveXxeGhR5IEw=="] = "#=qEti6k$v$5pD64KDjDPctRA==",
                    ["#=qCc882nxlt$kZM3Of4r8FktZJdNBc$CiQzPm_$EY9dxc="] = "#=q4gO0F5vlysJYD0yHThUo7ghdAToFIjGHJxlj0cGdIC0=",
                    ["#=qca65znzoBFQiXeR3Svn9ww=="] = "#=qa7g1iTUF6ZVR1Etrl0Utag==",
                    ["#=quCT9rHTpfaTdFTlAoNu8$g=="] = "#=qJpIFYOukmGLg_PE5ZovDsA=="
                }
            },
            ["#=qT5m9zMMOGgeXuvB5RBp1CjKxG2TMp9VAFSsa0vglCLY="] = new TypeMapping()
            {
                typeName = "#=qHjOhq6fK1vUc7nKTphvjbSFcwJlU7gup9NlrFmi6$Yc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qpk666II0NKb_5LMzxFlyVw=="] = "#=qpMiKRPxPVkIbWneWxuv2pQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qPIRAUrqKXKil8PC4ddVqUg=="] = "#=qKiXPEqUOeJIubf7aONgggQ==",
                    ["#=qXYEX0UCMEzgZT5Za8zdXCw=="] = "#=qM4c7RZEgNmhuM8uqIpKXuA=="
                }
            },
            ["#=qt7TNkcPqTCabAuPrtAYGG7sbVMKPgxJO0_zCHfXEkMs="] = new TypeMapping()
            {
                typeName = "#=q5H3I0V$FgUJ71tkDCx$bQHAV7faJ7srDiK9SKkF4QeU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qt7TNkcPqTCabAuPrtAYGGzaOhHlswtxlWoj5JmxvN4M="] = new TypeMapping()
            {
                typeName = "#=q5T7X$VWyN5cPALVAz6lnITEncKOIdIEqJb0p1KS1ZqM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qWyTgLYOwXV21oyC$GlcIKQ=="] = "#=qr7ydb1CwBETuTN91gfbhkg==",
                    ["#=qFvoK34cjUJB9jYFwrueWFIZXFsIxtsVJF$oBUBBq6M0="] = "#=qYxDsSec9JpetolNU1aU2ic3r8hJVCj88qsBMZcGzs0I=",
                    ["#=qugpI5sHFHiL12Uk9yH9x4rw8Ytx$ZAYwwWIGW_KLjEs="] = "#=qoHx7jotpM04BPhZlZmu6qjnPeRnOeZCDLcLAVKZCzDQ=",
                    ["#=qhjQ_Lk$XJKXojWZq5DwE7oxqoP4tsraVzUonYjtpc40="] = "#=qdbeWrTUTP4UDMI8UstFVi9XRxrtI6GiLnqlzAj3Kofo=",
                    ["#=qq6Jj6S8JVD5G_CZv4_oh2g=="] = "#=qod6qoxvNwYW5LTT1yWB1vg==",
                    ["#=qd37Uw3z1yhjGEp9mGsrz1g=="] = "#=q1yooKEH7rkAH7s6hj65_GA==",
                    ["#=qEEnqylC8laA4nixMaAGlgA=="] = "#=q99TcGINKnln4pxKTgJgsDA==",
                    ["#=qt7Xdt5p2ssJjzft96J_6gJ0hCB63b18Ilhd0j7zhA9o="] = "#=qgO9iutsKQuEPjI1_jLBEUMi93JKgGGS_KB2MJZEMIUc=",
                    ["#=qYdvgErzTSyid2HOF4N_$ew=="] = "#=qViQmlAqIsEuGFtBIYYHM6w==",
                    ["#=q5ndWyMhxCnT0mAMmD8x1aesDHMInIUhUg7iro$T$O20="] = "#=qy5XsZcAVjatru$B_dWEYJctTNeAyVb1p6aGA6FYUZYA=",
                    ["#=qk$y9Iuarnh1PAAZwC89iFQ=="] = "#=qbyVmbq_utwIERG$FjQc0wQ==",
                    ["#=q8ZeEaz8mUy8GBDcHZUdTIQ=="] = "#=qUbJDAHp7gNR8snAydVIrEg==",
                    ["#=qLXwC_6k$auQp7EMC$D5aIg=="] = "#=qk_KvPj6fj3aqW1Xio$eMgA==",
                    ["#=q7zpW5Oqq4fKRtAg0I1dFn1ZmIhHj4xkM410oN$COcFM="] = "#=qwA1yi1zUgAUntG_ZzB75NxXhQ4LH8pAPI8$XisXTYi8=",
                    ["#=qOcc5Cv9iP6LByxtR5T_BgYHbRRkaxmJszAl7yEMn30g="] = "#=q_p3M_JUIlP7iHzufuZspFPnYFGWnuk6hnI1kzRHlrX0=",
                    ["#=qmBSHlyoQznNJ1Q1rTXPQuscgcCoCdwYTIo5IrGSCjnM="] = "#=qTy35KLMYgiexZlZrYV4sc$sUj_Lo77aPOU0o3OGqFxg=",
                    ["#=qXyQauRWep$1dWbATfafxqdMYMgKf8cVPcbG1sHTa35I="] = "#=qgHcd84rSuM9kFefrwzfeWULFOObEEJTAlWmeTfUOfAE=",
                    ["#=qzWY3xCTC5le_rXpq_z12Vg=="] = "#=qYKfp1Rm_XVczAGMbKkNUdA==",
                    ["#=qhc6Cf4r596jYPZmONkNAHtEnquZkYEfAWwNB06wCoDE="] = "#=qkHBWCjcf9QP4SiiOo$VF$q1PoQZm_AJYyx$GyiwvoiI=",
                    ["#=q7HOuQSfpbiMGt77dG_Un7A=="] = "#=q2HSy8tdPtvCXeTME5uU$lQ==",
                    ["#=qnsD0qY5i1OpIcBihCdHZmw=="] = "#=qNSolYPlk0IU$g2_rnz3baw==",
                    ["#=q1qEYajcwHq$6l4Cqwu7R1Q=="] = "#=qWpPUpdJ59Z$y1XFdqsvZoA==",
                    ["#=q0zs_goJjyMCWBGkqp1Ib__WgRPM4xeeSjwtNKapXy$6ihDs$5Az8_xxQ4P3opUL5"] = "#=qOEuVdEGoLCltgj4OeiwqPL6aEBWl4yd6dUwVNj1CKY7s7Gk5xZRQ37MzXdiYwxaq"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q57CQFfhku6ySwOp3Rn3icg=="] = "#=qQPo31YIVKKxGBOMz_ZrKgg==",
                    ["#=qXnVi35rhrh3vOQ$1A8ehyBhoaglityuB6XII7$D6LHA="] = "#=qUaxFR50zM9bqj_IRiXKU7kueGMxx7br10PtxMqb117k=",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=q$LddAlkMTGv3TVy40hHeDg=="] = "#=qMTq9Uw5wqEmNDvBIxBiAuA==",
                    ["#=qU8107PHVKV4cFcsoGQbpswLVh6AeyOcKMxpnarky9qM="] = "#=q5bvBQH$giDla9yb62RC7YCsAZ4mNU8r0sDHeZTgx7FY=",
                    ["#=qvsK4WpPeNzs5McXtk2eU1fHUnQUI67A7arwH6S3JwoU="] = "#=q_f$Z1iDAjBm3sVDBu8VWrY9_442O_asvDeZ0XoEItmw=",
                    ["#=qahxv4aaw2080dHfWLgbqPQ=="] = "#=qb8xkmoIf0m1ddc9xRVOEHQ==",
                    ["#=qtVQ222iow92XPiEMDKVvkA=="] = "#=qwV12pcqLwOl8dRzkY3ZF2g==",
                    ["#=qnwPNg1cqS48sBKZbKmCnxA=="] = "#=qRw5wWoqk6wlqmsKTHs3Yng==",
                    ["#=qB5XJkPxmv9s$mOSlA_YtKQ=="] = "#=qh6aiESyWe9Gi1vlc23Lcmg==",
                    ["#=qDgPEXVPBM0DhP6W3uViJgQ=="] = "#=qSRRJPME$OM4Iowffo4e3FA==",
                    ["#=q1TefYjJ4yAdZBAE5Btp81Q=="] = "#=qNziIN5nBzuB1ZQiZo_GBKQ==",
                    ["#=qXZlU4ae9JdZRqI6QyDmQ$g=="] = "#=qgwsvRLTD0gzsHbQ_HBrEBg==",
                    ["#=qXbY4aZ9q0GkeTcmVzwZABg=="] = "#=qrSci$yH$sEDvKgi1BhJt$g==",
                    ["#=q8q3PspjsMme7AgJj3q1AYQ=="] = "#=qrK7$12vnS1jz1EggG0zT3w==",
                    ["#=qWiklVAbXV8bqjkhaSFRiZw=="] = "#=qhoW4sL5LLdddpOlNbHEtDQ==",
                    ["#=qSBk7S$hjpkHc9DRF54saRg=="] = "#=qi_ezxkQKKQZJYPGaK5_g0w=="
                }
            },
            ["#=qTA0Bh1xkj5vInK8W1furYiWC5x0HPXFvZ0$$PpqWtx8="] = new TypeMapping()
            {
                typeName = "#=qLVq0DUlKw7w4sqoWaS28zSPL$yLlrZp5Wli4YV4d8ZY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qerrhPcjkR25yD9R5HG6FYw=="] = "#=q8JLieR_pdsLPvhDuC$bNlg==",
                    ["#=qoWX1XwF7Inqe3qgD7$vK7A=="] = "#=q1M4dvd0ad_kTPY4fjZ7_ng==",
                    ["#=qGQzOkjrmCzCIC$AfeLTUkw=="] = "#=qJDO0hTngh$T9VJrHnusehw==",
                    ["#=qskXg_j8Cia63_MJ81C9zSQ=="] = "#=qxLb1KGSvPk9t9dbmsa12wg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qJWVdb6QTDQZ8up6C3CBT6A=="] = "#=qjQ1$zKhuTdg5hmTuXBBYDw==",
                    ["#=qEpHgljys$11L4UF1IwpnXg=="] = "#=qe5D5tNykVbjIohnajoeYiA=="
                }
            },
            ["#=qTa17_Gnfffk6ThimKoJDW$_1437cQdHkI4hXwVJZN7U="] = new TypeMapping()
            {
                typeName = "#=qsiaU89pdYCZGD4QBQr0B9ohnjgCGpWhFGXQ2FeRn0U8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qtcelC8vNjEDO1z4sMaJFjWJCCOwLlWazAX$27OodERc="] = new TypeMapping()
            {
                typeName = "#=qKVvMSoi7cV_GaB45uaLB9LUTDgX5bHWQ4AjScaLtlL4=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q9rrTuZ3JgTX$UaqhLHk3Bw=="] = "#=qN6zTA_iqrN3UIZA8VVOSIQ==",
                    ["#=q$omW87vH6oYDregfnWt$0w=="] = "#=qSECGCXtVMnSbK1JiproB_g==",
                    ["#=q7_NthPgm0GhxvUYQg3yF0A=="] = "#=quyi9cbob7RciTWBOeEAk3Q==",
                    ["#=qu4Uj037fwNZEkdhC9Zn0zQ=="] = "#=q5Gq1w7zt0DXpot7PJLSIFg==",
                    ["#=qwisZ3UYhvOqUr6rd_Jj5oA=="] = "#=qCV97cqkTTM9nA46dBn4bPw==",
                    ["#=qmuGZCCgUivjqe25PaT4sWg=="] = "#=qLU2umrLMh0ses5YCKKfwdA==",
                    ["#=qETbTfQZ75qwWYLPqVb5nVw=="] = "#=qvkjh$AA_WZDUnqzLCClE$w==",
                    ["#=qj1WCSSgSOwBXTm01sPv4aw=="] = "#=qJ1E99WYQErj7ra3UtG2Slg==",
                    ["#=qPpKWpwvYG0d6XbGSSMyWLw=="] = "#=qjHKdH_FERfLl1TjS901GgQ==",
                    ["#=q1ncrq95wGx02GbkzGLQnDw=="] = "#=qD89PTYxlnen_PUka1OlwtQ==",
                    ["#=q6iSrRUQjEOLnK5qNpi4aDU5touJvtBTnpndYVSu_EGM="] = "#=qBFG4od4HS87Sr5Bufpd4o6WdgLYu3vPk2GYDsLMOsF0=",
                    ["#=qCe9NIZ3NrmiHacXcJGKGS$Xo8kI2l2VhiMAdwMZEU2Y="] = "#=qhXxX0gK7IxKCC1lHGTi168YsDR5r47qk8NSLud29GGY=",
                    ["#=q40kLUy$lo0IyYZeh8kw2sKaHK8TL_ZB_whWBeNb5LGM="] = "#=qEzJBfRE78_KLc_okiZbabZN396DxgRGmSgPccFICWhI=",
                    ["#=qFZwewkB32asdxeGOz4euag=="] = "#=qbBTXbqWBsdx7YTw56U3LfA==",
                    ["#=qtNTUHuLiIw0TVqWiwD3MOA=="] = "#=qepUVFGJY9EbUqoYO$FjFqg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qn5Pptcrx2r_FroL7rgXvxzmc358_hp48cuxHKapF8Bc="] = "#=q1TuHXRYRtv7fCC1DRZVjB7$CHbjeaGVf6BN1ky7vUmU=",
                    ["#=qpbiKAlcoi8xVL999AKgtyxyeqFDS2FyGwioHUWHS6kk="] = "#=qTwAkWjQFxsj6mQvVu3HlLFWvUO6G$diomyKtW09lwNI=",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qA9e_m1gxLrLHNKGXRuzArQ==",
                    ["#=qxRXb2jFMRa7wHHLGnN6suw=="] = "#=q$$StBOReNGLOT83SPG9U3A==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qddfn8Y2liaZZX43O$JYvyA==",
                    ["#=qVW1Y4JJu$lSCYbh3jtOlIQ=="] = "#=qVk79$LktRyr1pBoSsUXyMQ==",
                    ["#=qrXUYDij3kpneut6CIO2oDjHdTCBi4TJR1dvX3k3TluQ="] = "#=q4ZC5v_VN9C61R3Ga7Dgt0BfLkEPzeIUJ73yilKtUMww=",
                    ["#=qR8NmYFJFPAg_vJXUNcEtLlKGIVJ$z36gA_LBFasfXaY="] = "#=qOYh$2MFbxz5qyIh2GGulR1BBPRKltBiBGTphMjQ3I4Q=",
                    ["#=qXna9aKUAsDxahInFoR1K7w=="] = "#=qd6wnQybTZ685LYkBLHgQYQ==",
                    ["#=qy6fziF8lQimzneutpxGlPQ=="] = "#=qBXQrufaliRY3Jg3GoYV9lg==",
                    ["#=qHuWpBhkIl80JbCSp2TlS8qAriqdn1fN_3IyhQAvbBYE="] = "#=qm_Jjmz_HkQYa_kHBrqveZwJHMI4dzKUaU_xLA0rLiSA=",
                    ["#=qBJOvI$6ajEQ8pOQa8R_jMRsdie_8nOY0YOo8yaIdGKY="] = "#=qvOVRP9nn7vanZkLWg4Tsz3dy9Y2rdeKTa8TjqbOI1kc=",
                    ["#=qk$WidYSLJLTgYW5Zosl0DQ=="] = "#=q0w8yJWCbhyNDMkMSKGXiBA==",
                    ["#=qzuKcPW8F_GsofjfkpFkkAg=="] = "#=qwTGJC5X089RXmCKCuj6CjQ==",
                    ["#=qO8aCQ9av7H3jc5Xv3uvCyBaY6dh3$8Ml$cPUhF_j$hI="] = "#=q989bh4LmOd2E_B70k8XYG5zvkSx4pZNX_ni7ICfgUSw=",
                    ["#=qc3BsRtEj5D0hH8_ldmq$Iw=="] = "#=qVqqektmKskl$UIku5bLvmQ==",
                    ["#=qjMUHUc4FpjOYrA2YKVtAXw=="] = "#=qal7tdAge54ZvIrsCWTzvAw==",
                    ["#=qz8EjxaclmBa6Rt7lKsiUVg=="] = "#=qLEjxfAomCiypG6cdZ$zoFQ==",
                    ["#=qge2mLRMYAtjAOWhOOvaaTw=="] = "#=quuaHmug7d0tbc7MBniwkLg==",
                    ["#=qP2seSJQq_dwN3XEw8p$jmzfV3j0xTaZvIoYwHUfBC3o="] = "#=qQDFpaCuls3xpG2mDT6JZu8BTwU9xafYO$75f$y9ob58=",
                    ["#=qPLkZJy0i2XyF97eAgZfcM7C1Tz5MKaeKW2dUPI9boyY="] = "#=qunZCLJKY20Jm47w7OToltkEqxxcPCIU6Ce6Go0c4UVE=",
                    ["#=qhNmOz2Lve0hG$zRzglsV6Fhowfnqcdw7AwjAL$kKVvI="] = "#=qJkThH7ry0HQqDdo8iNjTABFEcfNakmGJPaM2qUmcdI4=",
                    ["#=qJK5avxM9Q5_iUesDo3hlodge1qLDiCB_P8XBkZci7LY="] = "#=qkq9umBC9TlKOYHxsrfKsvGBXjwjDoBFVNXI0tUQq_ko="
                }
            },
            ["#=qthsrGoaAh1A6Td_A5amBZhRkWiVKcrplO6noscqam8MVgVgcogZU$R1AC2IaVPeb"] = new TypeMapping()
            {
                typeName = "#=qHfLyKpmpzQuL5H1SaAXf1UNdT_AvqGpH5CeF8kEfSuSMYq755$gInzqLD1ATXBfm",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxJyFqI_gZliH7zzTog74iw=="] = "#=qubRoexMbWiJCgpbH9GHRng==",
                    ["#=qyCleRjZpjLtQX7iBLKW$OA=="] = "#=q0RCGPKtwSGGkPKnXdCKVyA==",
                    ["#=qgxsdBn1fkQ3u7UKyFg9CzQ=="] = "#=q3rlKNwZvkh53P5W9qTM4OA==",
                    ["#=qinmQb4Rxe1G7KynSM9zh6LlHEHtKFPL$VT1mHmtgiNs="] = "#=qqzdXugtGT4xjbunmG9881ntbBVXWJ8m$0ZKL0lwlm3E=",
                    ["#=qPCIcCqoV2w6ex6WB5x0aPiWYYMGNwrEnjNVAAQVQr3djl4wD9yPw7$SdnHmuUWpl"] = "#=q5zlIeZ4m2xCCCSC5jRhr_B9$XeedT9TxjjaAjG_2cn3oHloDw_ispEYPBcFq$fTH"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q1Q$PMmGDBdPbpsNnLnA2WA=="] = "#=qtsIn3ax5xC2g11$tQRhNeA==",
                    ["#=qDWJU3pjwHUEwYbaqIevFcA=="] = "#=qrN7NuaydpF_t9UQUNLJloQ==",
                    ["#=qHnhsrDHgDXd267sPS4xCZQ=="] = "#=qoItMWte0P0JWZj$bRACi$g==",
                    ["#=qiCHDJ7CU90p97rjK64g48w=="] = "#=q0WbcnMuTfDAZAbqemhZXGQ==",
                    ["#=qj46Igb$ASjVWuK$u28phtA=="] = "#=q0ChsOZJr1Ds$H7jdl1KK0w=="
                }
            },
            ["#=qthsrGoaAh1A6Td_A5amBZpHM$qdyze0MpJpo1QnPV91unqsyYe19w0rrZEbfjZgM"] = new TypeMapping()
            {
                typeName = "#=qu1jVDQ7CzB$Hsor2mIzlb9PWgIlexU25aDW5J_2XBxhxmrBAAx17712PjxQOg1VI",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgadEQrzmWvkn7UXh24VuTg=="] = "#=qA8xtyH3aUnTq1IM97GpNxg==",
                    ["#=qPtDI$Z2Rc5wstli0AYqtyw=="] = "#=qM9wjRXH4Hudn2doNGuNzSw==",
                    ["#=q1nllAZS1fvwY6bPZ$mtLjw=="] = "#=qauy08AuQFYr5n2qQ23db0Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw=",
                    ["#=qPW4$66OqFv8v35okypbz1A=="] = "#=qkXb7uUc4QpFulWNJgzRQmA=="
                }
            },
            ["#=qTiWF3GxPEJRSe2LtZrec029e28iYXlPu6aZoUbNzcDI="] = new TypeMapping()
            {
                typeName = "#=qdytDDtIGtG7j9fHyk_qusXfXpI8dod_i4kAJuDgYUrE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q3_kUop5vG_Ics6RC_Xep3w=="] = "#=qEeyxpBPapxf922k3At6vkA==",
                    ["#=q$VHedLruZpWIHrGPlOdFjQ=="] = "#=qPNQ1USmaCS6$Yso5F8$fMg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qpivpJGKfPgiZjYaIIKchdg=="] = "#=qczVmreU1OkMjhC8z_Squdw==",
                    ["#=q7p5Jccopv42PlDwSOUGbvw=="] = "#=qjStJRBcmNmXX_teeXTPVfg=="
                }
            },
            ["#=qtl2wJnXgM0Mq3un0pcVWel4o1GcuH8cP$M_0vYWJiS0="] = new TypeMapping()
            {
                typeName = "#=qlmr17hLaE41GmqeCuJ$xQpkG$gVFasPo0n6ASNkhnxo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qLALLsTz7HntMWV2sbpajDg=="] = "#=qXq5vzXZnmw89H_XwrCbIHA==",
                    ["#=q1g5kv9lnDQOfnwyXTRjvjATTDcyuuftaFYMq6Et_x9k="] = "#=q$3oL942aFIDxosx3V6zesmaa$$Lw3cSfXTEgyv2FCVI=",
                    ["#=qnUsd7I0fJ9I6joMsXHuJXFw0tkJHDnAQ_FYwxN6RkJA="] = "#=qX2F_a4UxxT8bCyiN5ZMzceELZq7FlNeutEYqpdGqxt0=",
                    ["#=q83bJMTZQ5C4IgjMhYIWmQ8KSd0Q_Z9KU2uhJwxradgA="] = "#=qDY_qsYj5_XnDy78tCoP8T5OAW4aBHOJ2D0vr8GURglk=",
                    ["#=qWtJAD3CqtYMguIiwaZlCAdSsv8j4hTviN8q4RD9Hi8g="] = "#=qcq4yIzvSR5G7STHAc9WRftFDhPqqxiumlNQrwAgRlGo=",
                    ["#=qNvwrRFV31itTztQ57sOqtg=="] = "#=qF2qCqZdlE1m00S3o5C7GpQ==",
                    ["#=qB0FboOj9NBP7fQq4Bf4R7A=="] = "#=qlR9JQg$hPDM5B8H8Z8ktjw==",
                    ["#=q5i0ubxX6tdCFKnH30Zloh7s1tWjGlscDb61VHTsVVFw="] = "#=qoivimksYc4cMTmfC2aertlrClAoxOYOyc8ro1KV2aeA=",
                    ["#=q9jpD6KA9Jz2vQ6PWazoFrQ=="] = "#=qbaxuW3h4O_AAQoK_ULFecA==",
                    ["#=q54iYuOMj2gSOW8CanVCpiw=="] = "#=qVpdviKE_qPvvN1AawBb5hQ==",
                    ["#=qsFQKDr1yvxU1UfOF7xC3rA=="] = "#=qv0QYiQzIAjSEoH_waza2ZQ==",
                    ["#=qz31XC_2RfC_09pYkoaMIeg=="] = "#=qxvwpxKmUJZxdaPPkywpuQg==",
                    ["#=quLeC9_25sweUZsQdopuMcg=="] = "#=qvRIm153EFfGpPLaAH3i6wg==",
                    ["#=qYWK7cgYQnkJjluJUUopaEA=="] = "#=q0BxzXo$Z_Tr_awW1q4vMqw==",
                    ["#=qgz0Vgq$N5F4$yXyWqAXT5Q=="] = "#=qyfOVmBXs5kmXWdw7iPNhFw==",
                    ["#=qBywFyUjOcZ8taMbaj5_1aw=="] = "#=q9cneqqZJYI1E_gz82V91aQ==",
                    ["#=qASOEIupa0lMCzmopEEjH7w=="] = "#=qaOk4DNNUDan2Luwbw9H7fw==",
                    ["#=qbgRk6sxrULMxfkqOldrArw=="] = "#=qQIbBM48olNhYOjHjqlfPig==",
                    ["#=q66e9al9V1NeCBJp$UPsl6w=="] = "#=q0xjyxBjGiGDjBaV9tn65uA==",
                    ["#=qTgDVQsmiJh4nuWGEPnlq9A=="] = "#=qI$r7IY1dOVQuzMVV8gFMPw==",
                    ["#=q_giFrqOhYnJK9iZEONrTnw=="] = "#=qLvOmfQT1aCsFS1EDtQR5tg==",
                    ["#=qvkVGzmUdb36IkspzEmHtbQ=="] = "#=q7G2aAczNp0VlASXZvaswpw==",
                    ["#=quKOf4M5LMedp7EckR5fqMw=="] = "#=qybiNgsoJAZ85UfZ4_qbAvA==",
                    ["#=qh3XgfGHlRPf7$f$mMuy6AA=="] = "#=q69n3O7o6zeV_T868hOVXhA==",
                    ["#=q8Vp8_hblNEtwqP5z3VeKHw=="] = "#=qVU4d_hw1TR1M4YFgNrNgoA==",
                    ["#=qf2Hn3iGeoQ4837_8o$nyo9PopQ0yfxp6knGMt5fFa_w="] = "#=qwOg8FpQ1HuyZaS1Vyj9ho4UCyj15r$Ffs2WhEG_yYbA=",
                    ["#=qoVLl5OKb6Rgka7_UzyEcJUjsps6NPP1aWPwBj3grPa0="] = "#=qwk$hMFW_zRaE2d40NnIyy5ZwiGqJXHrhSVwpx7btbxw=",
                    ["#=qNMFyzHD_Zt$XQnSfukppSw=="] = "#=qsR7PC9F45ikVqKiSdQUmvg==",
                    ["#=qvEPz8V8192jpt6i1mv6XwA=="] = "#=qBq3yRmhiPcykv2LA4mfdQw==",
                    ["#=qjZGo5HiBc13vCdmS9hBmng=="] = "#=qojklFz3mRynI1j0ktY060g==",
                    ["#=qeQiaj69on1a2hGBG6dqB6A=="] = "#=qts8ES6MOrt5g4JESu9NSDw==",
                    ["#=qEdktVghwZf0q596mRqIMUA=="] = "#=qN36mJscIdYhjIt2Bq9tR9Q==",
                    ["#=q6E8TAV6OIowYQONY_8tDHQ=="] = "#=qFeGpivp$AYqeBN$39zKgmw==",
                    ["#=qC21dqjQRIBKGh0GkO$zkrA=="] = "#=qHcksi1fbkW1xmC_tkH6ViQ==",
                    ["#=qjqdTBBOsK8yQQYiBv2v06w=="] = "#=qwOL1nMOrtdOF05UOEm8JpQ==",
                    ["#=q_cjSQr0uHdhzyn80jHIUgl3b0lulOabisZtH_2MiyTo="] = "#=qd0k0DZGmE1ZnVdKu3fcgMjl0zbz8MTWhdxYKtTIyVSs=",
                    ["#=qLYJPe3deAxWUl0DUAH$I$8cOQA7Eph4yC7ZH7YMGid4="] = "#=qyjETK3RnpNeCy1AR1xVed11JydL4_4$Gmwwtszs9_Rs=",
                    ["#=qrfh7BzTT5uyiM31I1dJj18ughYZC6yMIH9xCiYyX3qE="] = "#=q96G7GRUFdI0ly0X2jwRSOssyozOrHUjNAchGMuk2qoI=",
                    ["#=qGGoGnOcYGldhDSICqCPHbCptbm2GRlZjAMqGx4RYSps="] = "#=qcUOJ7YaFHo4M6kEoqkuvS_vXgGqeqaI$EyG_6vJ_0PI=",
                    ["#=q8e3JSxjtRDs3jqT19171YQ=="] = "#=q0NGEb5qy7NJ1Ad6nLhNpqg==",
                    ["#=qT34bIgVWzoEvjadOKPJwTg=="] = "#=q6apqaaXEmv6koMqM5KOz1Q==",
                    ["#=q2FfnKT8lIfdsZ0a1A5ehcg=="] = "#=qNod9gXqKJRbUYDoHIVzE$Q==",
                    ["#=qLVwOz0eaD0goqvBUhRoFqA=="] = "#=q1H1p76MAF9Te8iWxOo3eIQ==",
                    ["#=qz8meAf3GVdQRzTimQuLEz9diJhpQzgZZ1l2ubNmJbJ9yJxL0YK5UcguqQF0OZ2JI"] = "#=qq8Xe6NXzjijXX8S4G8GQaTcYuuQidFGb6fm0gEBy6LaIh81lIIpV9Jl2d9s94QcH",
                    ["#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$AOKAQmvIVObNmq2I1pK5T1s"] = "#=qJiKPc16F3395dI4Mf5vmA_fxiKQ7zgPiu7GM2Ymup3bcMyaKW2SwI4gairMS20Aa",
                    ["#=q5f35OFP0SB29ZVRS1DWeWO0dFVeqJLZMn8aq8$7J7KbYxTpIdJvg_DeUhzNqjDQn"] = "#=quH8Gu6v53G7Gsl9Zgvhy6PkVY7AkmWCg_LmI6jeFrBvHtQk$hVIwiaOV3c6P7ReJ",
                    ["#=qoWiBZ2CMMPv9yVn5auZOKaHgsG4PAjzvYPJjBhIyF01Ihr18xSfeoKx67P$R87AD"] = "#=q9euTVRrjoX_EM1HLkNK_OJvwBYNrJWHBpBlA$NlhNnftxMps63uugAcL8w5Zcv2o",
                    ["#=q2VBTJc3zwiHNEJTW5vOf334VHLdRKh9r$1CH9G1gFa68gCCyocv0lObYYobf5w8n"] = "#=qiJ$rkXBDI_j3pWGGB8gajItF29$Mf9LHPp0guUXSpDR$ILYCYTzw4Oj6Ri73MQJm",
                    ["#=q6K$AENmZmO5tVkvkx0jRqfUPtjejrt2xCzktowuV6iM8h1rKGYlq9Xc8c1JAPi6J"] = "#=qMs$MQ5zt6clvN258MuIM5fu91oOKTN8rpFyuWWlRulS1dw3PmMldx9T9BTF1ZHXi",
                    ["#=qdCyKCK6eeX4zhkM_EWJti1kyvMmM7_S41noax$varJqntwXtC62XLgkZ5T7vYilo"] = "#=q8mgDNnGIkUScdfRLl0fUu0KSqI2QT1FfKgkDANRubTYhhmMusyTWOya80$nC_ckE",
                    ["#=qvoq9q_IyRQ3l09XUh5sQB89KR23DjyU2OdLea9wgEMuOUt746Bg3Jqp6DRq1LUQl"] = "#=qsXERQp$vSNMNEDBiO82QF$zBZPt_wAiiRZhNRcKB$0E5Ii8UVwbVn$NOsW937hDN",
                    ["#=qqETA7cxTl_J1Kyp2MAXblhpwMzruDfw0gSm$bbz3Yq104Kg174Ij6RxFi$uDeEnJ"] = "#=qk4Ev2HPNBpuW1EEDKdjlFzFP9VIU7G$QH5na_afbYu5ryoyXrdFBbAnpo6frO0GY"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qZ3mqnGc9DDHuYhhM_UXxgQ=="] = "#=qxlhZnYNXLniBhGJRdBhlLg==",
                    ["#=qiOSMFYq00NTRXgFFeQXpxRcdsSdMX60AmiBCGSOrP$8="] = "#=qrAGXdbWAXuilwwEkrbkTSYgCl4bBfBq5qwseyIarFGo=",
                    ["#=qxLONZrP23VG5IXJISoyTuA=="] = "#=q4bpcTPLfyUgAgCuMli$DfQ==",
                    ["#=qViI1LeJiAPdbAlbT0PxELRTo4f03om4v3FkqXek4i34="] = "#=qUTl_UoALIFFu8R$jycfKY8NMlczUWaDcTdQHoyxeG1k=",
                    ["#=q6t5ho_ByaejxIr7Mfhow2vZ0i1IG9S0wXpeMpdDB4wY="] = "#=qNeRg6HQ2MYhVEdEh2WFCcwyrkXqiqbZRs$z3wNIStPA=",
                    ["#=qMOh9Rsb3F$VzGuIMrBtxFOjG2aMt4QqOuJCvTuz5QfU="] = "#=qk_BklGaRVNOmaI$I4gFNgZgOZLMNO01eQTSK3sx_g5Y=",
                    ["#=qWVkqcH5WJh6y5XDeb9tbnQTf9mA_a6VF59CY9RROo_o="] = "#=qaThSNxt8MRB_kwtQn7sW$YoSZZxUG7shCJYl_2lhK1M=",
                    ["#=qQq$WSQs7H_53fpjW70HTv9tmJnENPGv$2IbROoUrBkc="] = "#=qRkQVd1C1M79OKGjj707mkRSRBY1MpQnZiqkf_XFs_Nk=",
                    ["#=qITzsgr2He52Y3TMQJkzn6C6ZYEcROTo1RCfSEiSviMQ="] = "#=qCFqtvUL0_M4taSqMvc5N0To6ePkEMmSh_ZtL7_ec$3c=",
                    ["#=qSzQ5Je$83mXx0XTo1SMy32nNOorqeCHeKToQ6wqytSE="] = "#=qLeBoPItMnYYM7dXUMawtVxY5iGaJ0PFadrjzed3F2qA=",
                    ["#=qNnTzyhRRqZ2yStSRlFdyqA=="] = "#=qYYcADlShTlJTWAnpVaWlBA==",
                    ["#=qdyFzHrqApgyl85HYJVgxJQ=="] = "#=qgHReQPknCc3SWWBbnKfqag==",
                    ["#=qRyG4BXfDH0QmGOWhDa_msOM4jhInqtfXq6jxda5_ZIc="] = "#=qu7NvUAZDuku57wvP0MbLMJSSySVGJObJzcaLV_33HVU=",
                    ["#=qjteoRu3IBTntoL71iPSz8g=="] = "#=qtRuePRlpjFVh35oLQKwmlA==",
                    ["#=qxU2FtX7PCPSqVgohhP$fIA=="] = "#=q2e4zURWVEAtUj0QazurwiA==",
                    ["#=qWWErjdq7sVnCoAVGRLYsFA=="] = "#=q0EkJt$YcLmxvmIP9nVhNWg==",
                    ["#=qDCuxPHi9Xpw__B$HdzwKXg=="] = "#=qztYntDo5Yivv$3AG0U6ntg==",
                    ["#=qdGknNhsVKU36v57KpaHHLw=="] = "#=qeKcTAbhoJMzvU0Qj5lzeRw==",
                    ["#=quir8t2RfdqEn26RH$fM_qw=="] = "#=q03Ir2x6HmfKqiBee7CTkzQ==",
                    ["#=q5yAS5XL2HpfAZ$o5TqA0iEdBgbLeEFgtDwc6g2bqQlU="] = "#=qsKn8AggYtKxM9wDkwzcOE$x8kwdLekQIBCauldwZfQE=",
                    ["#=q7bJqDBoIRR$i0Dtk9kehNBkXQVuwq8fKEeRQrz7K5iE="] = "#=qGE4oQZDq2cKD_TCPxXbXukhWz820iFFZXK8xzwx0gbI=",
                    ["#=qEyhnbqFM$C7qpg7F9BQFzQ=="] = "#=qP2Gaf5u91mY9GduCM_CYcA==",
                    ["#=qQZ0Pcnyxysc_AAEdtlPiCg=="] = "#=qIAxqcgjoHabz_aQo2$Mvcw==",
                    ["#=qDt5LLvjaFKdqYv8ZafQaGnfbGB_O9ipDUTvdPEe3A20="] = "#=qMyUogJ1xYxZjxfBs5e4sQ7qRdUjg1yeG9p9VnHcxccE=",
                    ["#=qW2JVpIZ0ZblqxDTKfEgpJ1QtdNYVaTqoiY5jmJalQcQ="] = "#=qBuxGPirX9$gH3_ckTpXar7CgUXAmVWfiVD0IMDeKH_0=",
                    ["#=q7QajdphH1Cbun02ThpfzlQ=="] = "#=q8Ui0N1_82uWfI4bZ867fiA==",
                    ["#=qUEIWWWh0geMrgwMbjDnFBg=="] = "#=qPgmNSqlSwaNpyHf3$qZJpA==",
                    ["#=qO1SFMpWugQJRD6MmilbD_w=="] = "#=q4_78P6P7CLcgElbmf9Os0A==",
                    ["#=qH05Wzv9YSKMKlEvu0y8FAA=="] = "#=qQGhF$ucB$Z6BpS6gw0An3w==",
                    ["#=qkKRJ9osY8OWwS_$RJUlApw=="] = "#=qUE_D04wzYHfZcVatR$__sg==",
                    ["#=qp1doa2eTIkZGzTrE$RVSSA=="] = "#=q2G9i_l8O8_N_5zgaKnd8wQ==",
                    ["#=q2Ciql3p_GuLAH8mcEigA3A=="] = "#=qM50pWz6q5n9DDFCcLmXm1A==",
                    ["#=q1CbESTmtHOC3qeXysXDqIA=="] = "#=qU$_abTM0iocluhX1PV7$$g==",
                    ["#=qWRMFkk4TfVLPMRWPoTWvsA=="] = "#=q8JVGBsa5frHg9ZUT5Y6jow==",
                    ["#=qA4KAgoJJYB$Zdq8ANXsIeJZijqyY7uh_yvags6eVbt4="] = "#=qI$HXuAw2QCZPU5OAc79$kzUfLxKdD78xkgob9gjTR0w=",
                    ["#=qGk17dLSoLRUSGrATObB473LLQR3gbpvEY6XWm8GMICM="] = "#=qyIO3imCiSXQaF$76MrhjAJNVp7ZsQkielOcoGuaQaBs=",
                    ["#=qd_LsC6$dLwknoxAWB2Y2lg=="] = "#=qieo$$iarByY3pvGkrAC6uQ==",
                    ["#=qlt0AQKm3Bmivo01SycWGfw=="] = "#=qmQqej2aHW5kLsb5nFS9WWQ==",
                    ["#=qHfGpWDg52XCeMIMOdiBKAMFXDL67m0oXWMSKfQzzASs="] = "#=qYKAbgf_lTnHSbXD5CpF_4qVOcJt1USaX2e2JgXeAsLA=",
                    ["#=qrM3$maCEOjsH7aOaS25ZpQ=="] = "#=qoJN96vNvXzzAlep8OPW_Tg==",
                    ["#=qSUJ$EnnDJ8Vy3vdc6m5h4Q=="] = "#=qOpG9JzCsrJpjolhezycSYg==",
                    ["#=q9BrHYwynOxcWFKV2$_DUZfMH_mFqXKWJiyMOMvZToIM="] = "#=qUmFGr1gcdkcP6ULRbexoqPT1P8_osDjwbA0HxB1OL0I=",
                    ["#=q0gngGjC1A5OW9QtREZehcslWzMtvXjL8vf0g4X39m5g="] = "#=qHpDfH9AMG_pxCKa4WBtTIyp7Md0k6oPgA5CIusxJBbA=",
                    ["#=qOG06yurWe5si5XxwBsjrdy9OVUTMXBxj1kLm3kh8wV4="] = "#=qlXIAU_5JNNCrhZSmnm$Q2CHq7QmqVCr7yErAythuXGY=",
                    ["#=qnOloeGvK6nwRLuHFyReKUDQmynOeOpBplG2eH_Np49E="] = "#=q_r7iwdDDcW75gfi7N2adZNQnmSqwLXK1J6n0tQgdSF0=",
                    ["#=qNz$j9Mf41VpOgicy3DYiqdrMMg8RwZcheyH7jxQQMqk="] = "#=qHQgiOtZg2EfdhquqkE6Xlfm3jkopXQmvUte3PeXQmVQ=",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qjE5R97Or9SqzZ3Kd37fWsgfP9Pk0ZgyH4OKHwJbKGs24CbsQX3CvvhNEb6j$FDRT"] = "#=q$XFwtnxEmFakJG$oc$x7lk_Xj8c$qyAm79AEbWqY9kGUbAI$vyZrZGAulP1hlOno",
                    ["#=qd4qFMLHVKgQSUIdsWNQUTA=="] = "#=qKWOMgm41ExpcAM$F3y1aZw==",
                    ["#=qj9VGfAuMrKVejpTnyopwbw=="] = "#=qUyAbsttoojkl8Wf7ANrrKw==",
                    ["#=qqVZO6F4PX_x$uyUs3apR4g=="] = "#=qfkLYzqPEu6Bfl6KlMrGU6g==",
                    ["#=qY0AZifLpBIp33iXPVfhpatMWjpZzfHFqDlWnRY_CIRs="] = "#=qgarFTQfPJBBPVz83pmPx1V_EG1BsifMRl4NnnvU3E6M=",
                    ["#=qnPdXth$B_mP7ciZhlXXLVw=="] = "#=qUTzIstCYdFNcrqXXJXoADg==",
                    ["#=qYtlKKtoJUWQiVCEtq4HOxw=="] = "#=qIHsbbeZui$gkzPbjuJjIAw==",
                    ["#=qnxwVaWqKM0013dK7FxEeVw=="] = "#=qCCvR4oR8$mV15tTaruxgOQ==",
                    ["#=qKXeKKzC0YPvdtVQwllK4gw=="] = "#=qpuM0U2Qs58PrrhoYetC3ew==",
                    ["#=qHcz91I51b9lB7CbsDCUEXw=="] = "#=qJW3FUXuNyvKW4NMn7u6AcA==",
                    ["#=qsHg6e0orD6LUwRpSNvzl5Q=="] = "#=qdk1NdPWaYX3$huO7XVBg8g==",
                    ["#=qje0XTXTcsTTBoEwkQPituA=="] = "#=qfUHTMUtXL6TQy7sg_WuYqw==",
                    ["#=qVyWOdstJ9ujfmJkWdt5Q9A=="] = "#=qL_5FL1$dTsT9MQblMWyOOg=="
                }
            },
            ["#=qtMD59Y1tl1_MUnX42ZCH9A=="] = new TypeMapping()
            {
                typeName = "#=qwPTEczcyhBHC6I2$sDKYGQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0d5TeJFJFyUhzEKf69lixg=="] = "#=quJLisWfaesFaGoE7IXDwXw==",
                    ["#=qt$o_00ON0Nk9uHWQ$BU$_g=="] = "#=qycOa41en5drXSOHAIedsAA==",
                    ["#=qp7wSUDUkAhAxg$yxJcbW_A=="] = "#=qy671Z0SOwAyrMAgsiUoMxw==",
                    ["#=q6NZk60WtlgSrZN5a5PS2lA=="] = "#=qPwpLGebfiGsmxialmUTt6A==",
                    ["#=qn3QdhIF3Bw6AdMlxPQ3yjw=="] = "#=qPV0Q0t4QZxbXdiXxlpIiDQ==",
                    ["#=q0pV$qiWshg9YC86JGGsHXA=="] = "#=qqIhWkBXuW5uXSjRv9ayOEg==",
                    ["#=qAZwqztK2TcdUi80p7DHwzg=="] = "#=q8_r6F9NX6$PM1iAhfDI3zQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qOudp5caJ1CSCVfWlDMnrpA=="] = "#=qjDxaDUA9k91WqmCLEJ3ZbA==",
                    ["#=q8zRF4kNjRHjwW4Ky5N$bcg=="] = "#=qyvOQb05r0dcXWFr2AKqRIQ==",
                    ["#=q2hSUGXBJBE55G6cLV_ndag=="] = "#=qg9vPehkxg9uI2fuKNksSeg==",
                    ["#=qRakwBZyq7K$l7HWmeXGfOA=="] = "#=qPrUpEkriRk6ddMgzO2rHcQ==",
                    ["#=qABT0oOb1rtlXUU0Sgd2Eyw=="] = "#=qB0fEzxFYC$kWzv772P9p1w==",
                    ["#=qAbFWViFfc2MhPHLKVaNFbQ=="] = "#=qRj6V_9vV2XYyWls$efGxJQ==",
                    ["#=qJxihXq931RBXOYkomYLEpw=="] = "#=qm22sZ8JOHtvOAGXSbN$TXw==",
                    ["#=qoXf4$IvoX6a6geujOalkTA=="] = "#=qCNRDJxTs3ufUFyyJzAYLYw==",
                    ["#=q6lvumJar4R9vYFkxQM0mcw=="] = "#=qyxSeAsPrFMu3k8VRs$dW1w==",
                    ["#=q4iaRZtucEVUJwSndAMMzeA=="] = "#=qwIEiYun25x_TGeD2gRVClw==",
                    ["#=qCbMXvWOhVLN2VzZzJ14lzw=="] = "#=qQ9Rxnj6DllWuSFS5CscoZg==",
                    ["#=qOwJadkYj9dcRUBvlxQPGiA=="] = "#=q0xEf8dx0migT6qn8KkQ88A==",
                    ["#=qTl_WHWzym89yc7wGY_W4_Q=="] = "#=qJPCev5Zns03WRgAosUbaYQ==",
                    ["GetHashCode"] = "GetHashCode",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["#=qI2G49t5UG1sbUvk6MOErxQ=="] = "#=qHGkwTPfRPftUaNaedGWE3Q==",
                    ["#=qR0IOp_k9WLmhW087wz1LOLJS7GTWpZJaNom3gcfCGXM="] = "#=qtH1qQe2vYHC7ITfA8ISmwV1UsGcY1xODepxvgNmFcTo="
                }
            },
            ["#=qtNAJ8WIXDc9WosynrVOS_3m7Sf79oi2sQvJAnmCs5kc="] = new TypeMapping()
            {
                typeName = "#=q4yMKkIXA_R0OPmw9MloApV6Pd68dgZWsjJLqBh9HIG0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qhdvu1P6mnWdugRBt6dgctA=="] = "#=qglaYWnQpaoMAb$S7x6PEyA==",
                    ["#=qaJGEaL6WEfPUFRjQPXVpgQ=="] = "#=qIwl97r$1sKI1763gduBUUQ==",
                    ["#=q8XWvhWCibmT9AmLnKVo41A=="] = "#=qLUc0cmdkLyzY0BzDc5C0zQ==",
                    ["#=q1NVSTcmH3q1qj7n$RwoCVw=="] = "#=qpj2DGqdtxiRySg4gob3Ieg==",
                    ["#=qA$cliqON2b1KkA76wLapxg=="] = "#=qQEw_J0kRtJKN8y3nt9OtWQ==",
                    ["#=qxRUiIZwE5GYuCc6l6vC6iX6gPYCRJo2IVY8679D$PzVciFa1i1SQrRcnkulUFuwb"] = "#=qFVNkLDs$CmHIQfr1iSYl49H0WLZWhXWwDhAKhCGuOXwgLSMpt9X4kHPLI0USCQoB"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qyDzDv6crstD_2Z9FdUanZg=="] = "#=qyluhkZ$WGdVeVfxmKHlliA==",
                    ["#=qfvzhl0x3_BNpLD3pWhlpkg=="] = "#=q2jvYYVaOGXU2pkBSNcpcpw==",
                    ["#=q_u9hBIyXJbA3bcp7apNNNA=="] = "#=qds9yh5JciVKqp8Y48niGug==",
                    ["#=ql_0z34pAS30tik6ErE0gow=="] = "#=qfvIfxfyCCp_G_Wenrxx$oA==",
                    ["#=qd8ZJnt8FEX6lI$1Td88vhw=="] = "#=qwHe_kf2T8KRjWSeYWyzGUA==",
                    ["#=qwj$eZtRW5rvH4bZY5hPKOw=="] = "#=q6u4d3RC8g5zzj0r$gr0syQ==",
                    ["#=q_X$Z6SDBy5asVsUzE$4GMQ=="] = "#=q_X$Z6SDBy5asVsUzE$4GMQ==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qoCeQXLeI5rzVEdME5qk9dcuL7TPXDRpJT0KjASQN92UtNb_CwexsA8kv3vEUlDU4"] = "#=qH49DlRoYPhom45S2NcLwYsLRWUdvac7ftvIom8GtsU7mUo4MWMib8Tbo5_392w6v",
                    ["#=q8R50rSzZx2s7ML4M1q6kwg=="] = "#=qEsTH3$a1EDd5h42w0Pr$eg=="
                }
            },
            ["#=qtof8a3RC8Q7zDPANiyJeJxWDfGvlZVh22V7iM7k6Wts="] = new TypeMapping()
            {
                typeName = "#=qyQxvwvIAXEfdCON7BoTPPyix6eukJYcpOmv9WGj9aPg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qi32BOElqKZkMdqyhWwGi2g=="] = "#=qqUawVNZ65nSALPAtbmKK1Q==",
                    ["#=quWFedk8Yqug28my40fA17g=="] = "#=q5nBvS6$3LwaDPn$YZS84zg==",
                    ["#=qr$wA7P6YKF_2iWqmWrbjiyV94MnGDcMt0Mi$dzLiW4OP9P_yESMN6gKgkgrwRAVR"] = "#=q$YJrKuz247yAm0YSfxwMDQ0hMwvmNFSw3Ybgx0OgvSW26qth6p0gqpMl4wa60_dW"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=q4gsHEEEo4987bMWMLlnWCJ$06ELNai30zwo5ij6w3R8="] = "#=qz67bjo0tuQsEuA_RVhou04GPO42vNxIzq36IbuDoFJQ=",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qCoodQ6zeH8kYt9$OSwT51g=="] = "#=qPFC3WlIFEmdLgK6uIR1_Xw==",
                    ["#=q6Rt_BBreTivWqf7fr1bQPA=="] = "#=q5IpKuGlEbQWyUB2ZSzCBAQ==",
                    ["#=qTA6irUchupEkULBIEv6UQw=="] = "#=qtA4BuNUxBEXKO$qUgbdxUQ=="
                }
            },
            ["#=qTpg5YdyDN8SMjaPKOz_TDKQOiqt0UcogIzsosPhEPejdrcAgcp7f0HMttqDH1w5k"] = new TypeMapping()
            {
                typeName = "#=q2NRLPZgfZey0JQjkfO$$FpdWtjCcWJfKVLd2BibzNHp7rUf8itRVuOHdQNljcqo8",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgQ_msh89jU_i8t2nyw0KmQ=="] = "#=qQMaxzOv8DA8OcmY99Ag54w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qIURk5R1i5M$y_uNmDTNhPQ=="] = "#=qy1Gc3FZ3JiTammhpCn9HhQ=="
                }
            },
            ["#=qTQUuj6Mtz26vwCVn2K6SNTscgAZmMl56ZBgVP$pjAUg="] = new TypeMapping()
            {
                typeName = "#=qIBh1LH9gsw0W7uM6c5fnL_cmPI7Eh7UAMzs7UlSTDW0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qybJYNxZMA8yKFwNxRMxkyKNLP1Atq_F9F15iVQHfudE="] = "#=qJg489qV7aBbHBm5tD1Vy0Ys65pSANMezUxsNuyG0l1A=",
                    ["#=qIYXTxggIsfW6$CPx_Jqr8MMBfD7N0XyNm80Jb$EaKLk="] = "#=q0GVEz0l5DPsQ3ANCzdBe$xuDu2n04YmbE5_SPgNobM4=",
                    ["#=qdwhWxK0qE3lZNXUbxsrfcyZBBsPoBOvVcFYKOPvTZ5tuTkwSuBva7WmRH7N8JjG5"] = "#=qJCzdNjCaSP4D8A8evNKCOM3LAgHmehMgNU1wiaxwdS762N1XFJmgrJpsgByb6W8y"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qw2f31zjZV1EaqTV3Qb$Bpgfg6wqzV81ryk6ccpVH_gI="] = "#=qYuhb2a5MuHFO64O3$YLv4bccyyuE8VO4EiGpZR6eOvs=",
                    ["#=qrJd3uj$vunA_UUMESv0a05Kgba_QLREmMGgbDIylZKU="] = "#=qJoLJn2z9JkPXlo8_o8$msQnWCLRHLjeNvMLJSucDH_U=",
                    ["#=qUKRduqIE7vK1ua4jpaIctbMftu76A_GUEVzZmURZH_I="] = "#=qyQfJyPU45ojHcNN8LAzBLO5Y_z_wnFWNmjJ27vSWbYU=",
                    ["#=q2lPFj7uYahO2xUK$XBqzyA=="] = "#=qPyv44lnwai06veE8CpDDKw==",
                    ["#=qAc8tSZ4sl5NTg811nyj1Vw=="] = "#=qfDuIQUCSFXmm6sR3KlhAog==",
                    ["#=qiWBB0OFoBRUsPlyMSBNcbg=="] = "#=qcc43JGr$g$NAa7R$IZ0iVg=="
                }
            },
            ["#=qtSpCom9E35SQoydGqwYjO3auRgaSWeD3eBYTlbGbDKk="] = new TypeMapping()
            {
                typeName = "#=qhTf_5mBSxx58Y5TEoHFRFJBRjaIoaFuRl$SXkebF86w=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZOCXIIVn3wg0syGghc996g=="] = "#=q9Zf39kEqNwXaSAp4pLEF4Q==",
                    ["#=qsNtvxSGukxITBgc4f2Ay5Q=="] = "#=qSeVjcg1weXH_K7H$$VPjkw==",
                    ["#=qgwM$sqbqlIVq1gZpDhmW4A=="] = "#=qTJXKQ$FzKE_Cs58KCe5VhQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qArg6DIxTS1aX6fGoxvcK1U2Ox8RQfpGR_afQ$xybWGM="] = "#=qj9iASsjiseMGEjUIwV5TL8hEcT9yea4sDjYMg29P1Ak=",
                    ["#=qavif4ZWPr9Z6vhWoPnexMg=="] = "#=q$Ozk0gRBTpcvUPnrpPtHhQ==",
                    ["#=q214HJ3TwQ0_L4PXN3u7R9g=="] = "#=qTCVG5pD0S9R5fOYya8IUTg==",
                    ["#=qGH_u3G4VyCitX5xi$dw_fLMf46VQhD1FFGWOAz$ijaU="] = "#=qtis4DSobV4M9KlTaqzFXYX57allNs0MKFuzs0HzIQAA=",
                    ["#=qDU86AtLIDElWxkN2d9F9BA=="] = "#=qi8w5_2Q0CNqZ9QJSUTS5$A=="
                }
            },
            ["#=qu2x14Z_VOIllD2S1eD2KghxeyvDQHYMLrpN3UZuV2Gs="] = new TypeMapping()
            {
                typeName = "#=q0iwSX7tIItsHVCTQR_AYQMNvN9QU55K7Uaxlq_mlXJY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qf19EETzlK$_nM$79Hm1kVw=="] = "#=qsquhOW7KnASOxlmuAQ2vkw==",
                    ["#=qr24FdIUgNslfyLnGH0nkAQ=="] = "#=qZebANEtPguhjOtTBdeHY_A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qU4BZ8qjVcUVazVe32McrfiDVh5irDS4bobu6Q6dhAX8="] = new TypeMapping()
            {
                typeName = "#=qvQ9z355BgzTk0Vo_gZYy3OpkMyde1JnvddW6yrJMcTY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qD_NevDtlsZTCnMDI9_jIAA=="] = "#=qj8_APe$brpwFGPOo2Tkv0A==",
                    ["#=qnYArk_oPC2O613NgvD4Jqw=="] = "#=qKCMxnvH6Vg2abVmvovdH1Q==",
                    ["#=q4XIGzRjtxmKVJ2RAE$0u2w=="] = "#=q9H6eElWKkZ64Vz4_iqntDA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qfKPBvWuTDZGkaoJp6SEU5A=="] = "#=q9FIuuDldz844y2sOsYMrWw==",
                    ["#=q_LkfVx11TTqx5sCKpFSkEQ=="] = "#=qzhKopixlqBFd4qqckz26Jw=="
                }
            },
            ["#=qu9LE5un2q5YhO_EqC8bTphvCbQBF7HpyzpeG5TLvj11J068PinB9ZKNVlLjNjTNg"] = new TypeMapping()
            {
                typeName = "#=qRCB$yOEAYKnOX$FkACpQQCX0mHg4sjz6LAXvSVskpSM3dw1GO2rMnxJ$aUsIJd6z",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qJzhS9uFkS4imdIVc5fXewA=="] = "#=qw9YkrI$0$RB2xuXu1qDu9w==",
                    ["#=qcKkgvuQKpK2QuD6gJ1tbfg=="] = "#=qzmVOtVX4V2jXUtjjBXBmng==",
                    ["#=qe6jcte2eGnn3L$PJGI0teA=="] = "#=q5ZXAlI0rHEUpWaMT5_hZDw==",
                    ["#=qxn92etQ4tdIzbIHKTld8lA=="] = "#=qTXEHPzboiu3PRa58d_KWOg==",
                    ["#=qRRkpnxxemW1E9YYezbzXbR7Joa_XeswfL4oFn9V6c6M="] = "#=qN$UR55BwMN21LcpJwr9uAjvCTs2w9vQfCsL1t3kZ9n0=",
                    ["#=q5WYZTHL3fipK5k0S3B9mRQ=="] = "#=q115DeBBI6D0_g2G2iM6uAg==",
                    ["#=q4K9sEsloerND91YGriB_VA=="] = "#=qAPC6Qn18j3nkCBf358lJOw==",
                    ["#=qDb54ryg_Ejqb1vlEP4LHWw=="] = "#=qoVIkT8q$OG1dv1yUjxLRjg==",
                    ["#=qsK8ZsCjP9$iBu1yY0vWK_g=="] = "#=qSlcoRz9eCNmK4hG0Y51XMA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qU9GqnohyqkgSk8ll1mkAzkZsVsO87Zz4poxbELgjPCQ="] = "#=qO4xnmbkSzX_QTGOJaBCdBx2Em5KbNykLgti_d4PQbUg="
                }
            },
            ["#=qudaXMRoPFohPZ5gabmBLIR1qxnv0pSKEDdEsHEfvI6w="] = new TypeMapping()
            {
                typeName = "#=qn0n6jqQWN5fEC8XH05Yq3x_7KgMVrmQfvEd3Dw_OyWs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qnX5_9QrEnvlqg9MGS4DUow=="] = "#=q_dFZQgXQM6hlWkcuyTxvYQ==",
                    ["#=q9xuDm7MJrzJFRGhXliGGuw=="] = "#=qJdX7ztPTFWGfuEgvtlsRuA==",
                    ["#=q40OTYlppbaayDhscFzXwOpsgSx9iPESuNUrXZiLbA5I="] = "#=qh7NH3Zn2D1VvMhE1Y8lOm3DXoc97dXEN15bu1eV_imQ="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qUK$LQIc0oiii$4lJuRJl6csxuOMaIZ70zPTUvD38SV0mPqiHuwdvTogBMeJub5JY"] = new TypeMapping()
            {
                typeName = "#=qUK$LQIc0oiii$4lJuRJl6csxuOMaIZ70zPTUvD38SV0mPqiHuwdvTogBMeJub5JY",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=quP_mMR_eMtfWYhUPsH3O22IgKwkjwlcofkqI6GUyh_k="] = new TypeMapping()
            {
                typeName = "#=q2Gm5aZJXEgb35tc2QLMgJmdte3F1xvGkBzo1JbGxZfU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qE97pPqBPT4EGjc9XNkTffA=="] = "#=q1Pc2fB6bBieLD8tql7_gnw==",
                    ["#=qznIvcQ3RlBEt24sreoOPhQ=="] = "#=qxD_zxt8dymw57HE9fLHn5Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qDCFEst6Mdpje0WqgFzoNUw=="] = "#=qvaBmlgKIncOwT6AbTvY4qg==",
                    ["#=qgr2$wmqwQBsIzUKU1sF4pg=="] = "#=qK1ego36p5NZy6mZA_vjhZQ=="
                }
            },
            ["#=quRHatq3_Zmo_FSVxgpFbw1TYIu411yGJw$qycRxfS2R4hFAkRzipbKteJly$JuXh"] = new TypeMapping()
            {
                typeName = "#=q500ySlJ8EdEWtzrlFkgdSkXOWV1GTtsLtDSvCLSnpW8ZexsxYQRUvlk9x66BHlEI",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q777pB0$w3tkPWFMXJ$twxg=="] = "#=qQUU$8DwbZpMX8Vz5DKWGkQ==",
                    ["#=qpkEnvJHVoJNSp4WE6e5yKQ=="] = "#=q6JPSa0eX1$DtZ4B4I8vaog=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qFupDmmwLZdPfQivlBsGbHA=="] = "#=qAB_q7f7S7St8TAoBRVsg6A==",
                    ["#=qPwEsHaDxZ_c3x1ENUpa806WTXbvEVtc8GtDfEIJ_t50="] = "#=qy6G8cOVQQ_4SnY_HBXt4EITE4upv64tGhXN9Fnhk5DU=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY="
                }
            },
            ["#=quSFTo52LRTMTvIu4wt9k14Lcmpt1H_50cQwCjAYveYk="] = new TypeMapping()
            {
                typeName = "#=qOEpxIT50u1dCOT_wOsxF_UvBrc_L19mC6z6Xt_Gzh84=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=quSFTo52LRTMTvIu4wt9k19PW4MpJP3cNDSvPNHBwH$o="] = new TypeMapping()
            {
                typeName = "#=qIDBpAPCIVzMn6fy_WLfItmNQVG7yWCWtpMNaco6DEhA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=quvk5IYYhTSeq0O1WJSq2fKM$zXaD4CRKCLK2zdLfZM3WP_XkckcP1QZ3mk_1rxRa"] = new TypeMapping()
            {
                typeName = "#=qVBiby0LwG5DFoSrU26S81_dO_08ZEZor2mI3yzkCuSCIht_gmKdXYvU_v3snVi$X",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDaulSclSIxh7noPtO5DzUA=="] = "#=qmTWB3tL0uCj8X4nmnlCGQA==",
                    ["#=qHK0Y0l3FjQxerZkcVt4bPg=="] = "#=q8xBRmXIgXQVX8e5rLYAPRw==",
                    ["#=qMAtoEVuYc5CcjSS59Opyjg=="] = "#=qGyXPCrLfe5r$d0PCDAUWBg==",
                    ["#=qGlhwj_CHRjAAAW9Q44sIcjj9nUhO1ZsOn1WsXUbXTOE="] = "#=qRf5eYQEmNaLwFqkSpbzL6Tka_w0JE5bpwv$W$1dQ$GY="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q4yzeOSynIuV0hpCT6r0_7jQ8H8mxQ_mnEBW5YzfIS5A="] = "#=qc5bKLi6Wb7EUAIE5JEK6_xCoOGu09EEq2qn1QVt2LxE=",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg=="
                }
            },
            ["#=qv_kAIXce_SutLwViNGcwhuIcCTiw$3uypyxv_A8Da9DjCjzUYrjPoFhRG3Isj2Hy"] = new TypeMapping()
            {
                typeName = "#=q2$k2ZS5xhVUWueYFsCkbc_2iNaLIpSoEXjX$cYieQoIRSQcWe7OyLfPIWKfu2wL9",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlbRQWqwuvfZvzB9JaDr6FQ=="] = "#=qryQY_aSaDbyt1W2HxMUoqA=="
                }
            },
            ["#=qv4R2502ez372tBwEC5x$ODW_AmE$K774n9A_A9cISEzJHPzyjhnfUDfL2Q0ADW07"] = new TypeMapping()
            {
                typeName = "#=qU6XjcWeaXbZjiMHz5QE2Z_CDHutjrQ_Q6obBYlelPyx9cgRrEEu71Q4qFaAjp9UA",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgYjJ3g9N684BotJwDLh6BA=="] = "#=q50wJxtqh83$2ACijIkYkxw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qv9bJswOPDvNzQMuQU7YIszsXyYWS_iDA2FCPUSpsVkg1YrvXkc1n5y6UcC8LUVWhbszKYRMCjVgidpMTlHFGKg=="] = new TypeMapping()
            {
                typeName = "#=qOmpuxSlHGJuSA7Aa1tHw3VRnTtbnnA2MxA4JZ1i$I0RLQSF_wVMG$8lX0l8tLa4n68zbEFWDyIVCC3oUxXlaEA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q95WKRpyT$uHlRgFyeoVGlw=="] = "#=qZWDZ_ijnIeypQDoQTc2qpw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor"
                }
            },
            ["#=qVD$7Gu8kf_jnTRbU2nYuyTP4fgymx6aAiakVnMAtij$h5WwrOkSmMotBSOsDHUVq"] = new TypeMapping()
            {
                typeName = "#=qrrI7XFij_OXwVKEZeZ_dl1URMPnmFC_NcoACbAeszhmw3CgU_8XJLD$Sx5Ly$OYl",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qArC2ovxYdK_UDiZoUBgUNA=="] = "#=qfeKjFYedte8Mi_QasH5USg==",
                    ["#=qqvkoHMZU7Kx8PwYUzKPpSw=="] = "#=qfFuM71_AYImzTMZ1eWtnsQ==",
                    ["#=qAX2IJZGuy2ul_f5yN5JUwg=="] = "#=qFKMvbDjXttdfwiZwTLx89A==",
                    ["#=q9Pg8XcoRzzJ3hP2C3RBJ6CIArXsidogQdeTSjWNGqhWxNihzV$K5HZO32BMNFg9c"] = "#=qMn9LZTaSSyEucTOTgm7$x5hg89H9BaXJu$OnIsK1RgBABKmhTkAxE1TJSJrVpxjR",
                    ["#=qOUdR$hxbFkBzVKsOXCMT1zf94z7cvKI9EuCq8SrW7_mggd3UEVb7TNO28ROo274s"] = "#=qfg7EKLxtp4MSQlJ6w62XAhEcPocSzj42jpAFljYpsEKso8X_EOywbhxfVVxtk3Gh"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg==",
                    ["#=qE$uvWclupp6NTrHPSXdulg=="] = "#=qUJvQW24ASkOcKQ2UDawVcg==",
                    ["#=qqYgIsQcrhz9cg5ygUBN31w=="] = "#=qCDzArzDdDg$WdoIdohdhSQ==",
                    ["#=qSzQbmsyZ0bn0PS2IVqYMXR2UHaFekX6FGBnnykiDwZc="] = "#=qg5ImTor5vCayCXaW986IxFQxXjh_xsm$3QkELnQGsS8=",
                    ["#=qqB9cI92PVuKgvNOtlFz7pA=="] = "#=qHqXwgNDxBEYhSO08_8cjzg==",
                    ["#=qu3s$Ty5SHSoA3hY83qyFIA=="] = "#=qKKvjkVr9nd3IiLvVtxdhnw==",
                    ["#=qXecYFXP9nnIT0_YNdavHWg=="] = "#=qS_MC7BzBBmOKct5aLFF3wQ=="
                }
            },
            ["#=qVgcb9bqOG2LIq3$MX6VkYU4czSi3JdKalgwUK1b1DOY="] = new TypeMapping()
            {
                typeName = "#=qyBder1WNO1U89ouX_XCoTpUPCg_y1_kX5K6m2aDUPf8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q5fOoOGiwgCM9pLSgPwQduA=="] = "#=qIUV9nwSdY4xI5BgIH$40ow=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9aH0OZDTSDTZuGjB_IUWEw=="] = "#=qmHofWUhRc$iBtbYgEb7$bg=="
                }
            },
            ["#=qviKeLKiONmznQRMq602nbFdmyT8Q07$td_dC55Hutfw="] = new TypeMapping()
            {
                typeName = "#=q6Jk1SyRdfcPY9Hou1VJcI6xxowE8C2lSR0tmiUfH69E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q4QbuK$OURwI57IPMLRBwx989r7huqS4S26Q5zAkP4CE="] = "#=qPdzCBWZCUDTMySLSlLxbY_RWKwUah$0gsjqHUvrGXI8=",
                    ["#=q$ZHHLQLLza4tYxA6mYqi8w=="] = "#=qZj0QDr$FmoEEFSy5u0e4Gw==",
                    ["#=qZSSmzstc8EdetV19RekhYz1sdhIlhSW7cGsKoVsuSqY="] = "#=q7XtQ15R0Ktxm5jmYwVnPeMne4KLjg9BmlbdXzpN$I3A=",
                    ["#=q3fDDlqKYxfzqDASUkOC8xQ=="] = "#=qzbGgh9JHTGbVnurK28r2hQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qBgl4gMkao5UZiz7k64q9DQ=="] = "#=q2QGP88q2XPEgeTJpp0Y81A==",
                    ["#=q3eknMHS8cOuhugLHE5Quyg=="] = "#=qny8WipZyrvNGFWmFySpr$g==",
                    ["#=qIX0HrwfMGJM9q8zf9dh0nIOJXqrUwAYqTZnxe$S1Hl4="] = "#=qdWgkUljnZYJQruWjXxrqE11imjNLbOsoDrjj0IJtOQ0=",
                    ["#=qRzBNFsc9x3OKuCI0p8sV$A=="] = "#=qeaQ0HTz92VoaL6h$U_990A==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw=="
                }
            },
            ["#=qvJpLFNTehTZALLUM4jUcCrY7ig8LQYn8da9q7rAn9KKNxphP6KhB_gKKjHKG$2cb"] = new TypeMapping()
            {
                typeName = "#=qFk$oETyXmLl0_UGbcIgda$A$KlCKs1HYhNpuG5q$ziuA33AyPuzq7j5jBI0V2$uL",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAKFEB5uI5tCssWOX0D7fvg=="] = "#=q2ziGN2YgSYCOsdIZSTj2BQ==",
                    ["#=qE9LHHZ$EDGgjAWdrBKjrVg=="] = "#=q$2TRxVg3CvBVppP6n_l6pA==",
                    ["#=q7krL4rLHJRiOKdZ4nQS8bg=="] = "#=qQpp4Qr0tZUKcWGyHk2rUGw==",
                    ["#=qBeQGwiU6x5hErVRta9b$3g=="] = "#=qP4NjzsjDpS9plZtwzFnYMw==",
                    ["#=qAK5RDfx4M$UpYVlA5EdsTw=="] = "#=qap3tKkl1RkBL4AmohZ$xVQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qs_afYTvOTshVQ2Chp4HK2Q=="] = "#=q8ekv6C1PVZ4ReMo90Btv0A==",
                    ["#=qxtRkpT5EsbRvIg12$X8t9g=="] = "#=qyRBbLeICdJvz$1k_oYOsog==",
                    ["#=qC9st_zX$QiuQWtPI9Qcs8g=="] = "#=q3TrnfDqS4dOnPftLwtSRtw=="
                }
            },
            ["#=qvOaQZAcAKvqagjv3wWEqRroemyvkQq88ZI5waXac_tZ8C5_q_9rh7KhUvVpVUXjX"] = new TypeMapping()
            {
                typeName = "#=q0pk1$X66W$8AWW9GG$AiFDgOv_fbi2UX5m3r80j3xkSLWxbaCzJlMs5Hu6p8JOrA",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["CanConvert"] = "CanConvert",
                    ["ReadJson"] = "ReadJson",
                    ["WriteJson"] = "WriteJson"
                }
            },
            ["#=qvTHbHarplMe8BALjWEV4kxZF_t4MTlPZc13NlseUZ4I="] = new TypeMapping()
            {
                typeName = "#=qmzk$RQI1oI2tAfDYJVYemvV6KLFFwE_DOBAdHTQoppA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDocRupyKhXpyj9t8D5weGA=="] = "#=qp$ne9jQAQ1MetbjRRija$w==",
                    ["#=qDCG13j9UZeTloDup03MmVQ=="] = "#=qOCkGUOFutw7HbCFNIYVM9w==",
                    ["#=qX0$9bdU_12_pCq9Fk0A5Ig=="] = "#=qRRDJuVPWsOq9UZPo$N3Fyg==",
                    ["#=quTZBfM$hGtBg34LuoDU_julc5$XqFOD9tpelTQi6Smo="] = "#=qrnGy54JalNEeKZUyXp_vtXFY0XtaUirguezLUoo0j94=",
                    ["#=qCsCMl7TKHBgy7EcsEcr78inJE$U_F1kGHA1V8F3AD4w="] = "#=qZ02W8dfZqriCWMEXcMgI339tohsdTVRcHIva9Yyca1U=",
                    ["#=qhbvz8W7VXWcPxKI6ZYXoDA=="] = "#=qqi7MQVUt5I2KT285r8f1Ug==",
                    ["#=qT8fKB4I14a_CB2ADIf9sH4FQslOGPhpVbhTCHHRhu4o="] = "#=qXyx_RCEzOxv_kQV8Hi1eACbUlS4dbyvK$grquRlChxA=",
                    ["#=qUPzKa9qYIq9PwSyPm0MUIQ=="] = "#=qGwC5mvar4Du7EjNc4K8jvg==",
                    ["#=qAEPsVqiAFcWiH4XMY2QHGA=="] = "#=q9BmlGe5L0v6oKMyLDiEelA==",
                    ["#=qpnkkuQHddXzDWiaWzQS2Yg=="] = "#=qjzdugvr4XWi$eDiqqWeMgQ==",
                    ["#=qNAc_Q90uaPEdg7F8ygNzvw=="] = "#=qa5yBuIGs1L4KHby4E1NaYg==",
                    ["#=qo4yqu_90T055H6p$z9iR_A=="] = "#=qzn7K3g_QSOe6aV40UOScdA==",
                    ["#=q5oCshLvx7aTngFc9phi9Vf80Wj61beCjZv2ya$rc0io="] = "#=qs3Raox7KUUiDnUmxFovTkJ9XXFmqZ_G7QQ9z7ghkcGE=",
                    ["#=qolT8_dbItwVsAWfZdgy3Vw=="] = "#=q0HF3848E_uvsaCpC9xmOvQ==",
                    ["#=qae$mEU4PM660RunZ$dP_Bg=="] = "#=qbXVHzn_HF$SGLOIShU2nRw==",
                    ["#=q4bphlLNYYITsgVj$81zRMw=="] = "#=qjZ0b9gtbyhRwcl8mIwgf3g==",
                    ["#=qf58Z7UmFmbiksIICY6QUFg=="] = "#=qU1itfbh58McEaM0x0IThUQ==",
                    ["#=qhVX5IfeDEeW1R2pFjSkzTw=="] = "#=qsNI$O7zGDg4rUrrrMAA9yQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qHCTkbGibCf_AdEWYk$4NIvM6VwdllDn0aMm6bsW5nsU="] = "#=qsMa2b7X9BvIQiGbbQGOttYgeBdsyrWHmsG1jHayQCJE=",
                    ["#=q3Cl6z04sjWGeDAthvwos5g=="] = "#=qALD3Mct_PEGd8MA9Fdw5Nw==",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w==",
                    ["#=qL8ViT5pgO8NmCEXd$b5gaNWK_kBk$2Rr6NyokB4UMfU="] = "#=q9lgJOAmLR1k9aU6z0zfToUGlZA8fNFSjS3fyzpgy7Eg=",
                    ["#=qqXaNnBDzkcDC$adMbDYmo3sVhW2sFindXf3aKcmK8fI="] = "#=q_f$Z1iDAjBm3sVDBu8VWrY9_442O_asvDeZ0XoEItmw=",
                    ["#=qhT0TeAMpVNeIduVaNk_bmw=="] = "#=qRPFV53TqGQiJEPTjrTR7Kg==",
                    ["#=qWw78aKoynMlZndvS8iTaog=="] = "#=qE9b97Vkh_7PWm1xWypL3bQ==",
                    ["#=qflIb_RLHI97PM9wJJbIxjg=="] = "#=qj0NfaG7LSztqPMedJoIvTg==",
                    ["#=qSksQtgJjt_6aaj7l9FqyNw=="] = "#=qF$argRLz5G750e2S0iS63w==",
                    ["#=qQnMgpil3uTo4Sdp5bSqOpg=="] = "#=qxp5mBruyrLFEjWn7X3G1_A==",
                    ["#=qK4izRPf5_80ct0JEOUHNHA=="] = "#=q9mfxp22clIbWYBDZta81rA==",
                    ["#=q_xZBUJNH88kE4RfYtwUoLw=="] = "#=qamL3roWINVepmv8FgY5lCg=="
                }
            },
            ["#=qvwBRxKbjL71dVaamoNk8lUHkJysDNVEGjg5IgAn6clg="] = new TypeMapping()
            {
                typeName = "#=qBhJt4dza9HfMn4Ek4dcQH$F2LcVajUaucPLKeJ2Vyq0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDlpxPxNBiC3V8swwofNXEQ=="] = "#=q0HvtdHrtilBEvaxwvoMb3Q==",
                    ["#=qi66uR0k_$hrm69cGIHPByw=="] = "#=qZqw6Rslro1Jb0YOiMzpHKA==",
                    ["#=qIddnWGemCKyJmVDTNrzLCw=="] = "#=q1QFVCPhkchAZsWqJqaI_wQ==",
                    ["#=qns6TArwDs0xBQlUlzRRzaQ=="] = "#=qBt_UAOYbunXfwAvuQSZVBQ==",
                    ["#=q83Wvbqj$_Kw5zJbKLVJtLA=="] = "#=q9_P15maHFCp2MV$riRsdHQ==",
                    ["#=qV9KAlN3B$$jtdYaIlLDH3A=="] = "#=qrpPz7Gxh9g85Nk19Ay6lbw==",
                    ["#=qcNgJo2h2n7zOj177bytZtw=="] = "#=qhG0X01r0qeFGOqqOZTuYZQ==",
                    ["#=qc6MWTDQU6_x9WI753ZPdRQ=="] = "#=q_1OO6BRFSPcmLYdC0j1cgw==",
                    ["#=qac0m7zom83XiUQVVLIWiGg=="] = "#=qA5nhMUeWbElsP38l2aliZA==",
                    ["#=qtzr6xoFUBh$CEUgXr1hgLQ=="] = "#=qgSQPEe2MoYZmChzMbKJ74A==",
                    ["#=qCoT_TnshU12Vtf6sFxjVuA=="] = "#=q3ZkMRTZzY58BjJFoqvG6Bw==",
                    ["#=ql_cbuWhOtSfkl2TZ7vzXdw=="] = "#=qXpYLBKZzN_4ynGIcx6DrWw==",
                    ["#=qRPC2$$INytxbIhO$LotStywd3wygIHGmWZDoaDU9AmA="] = "#=qVavHajKK3v0R0So29s5y65Jt6zwWp_G2zYAmsYNqQpk="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qKEXL6jjDZ3gsMzp6a4tHBA=="] = "#=qxDsP4_XlaDX$etAKBIlqHQ==",
                    ["#=qopIXGBdciCmDZlkrnjysjw=="] = "#=qpvWoTm6zo5vSeEiUGfjTXA==",
                    ["#=q4FsgFHELI0JiyrxBAPdIiw=="] = "#=q2KcGgbNvMYSrrtbgc9tqTA==",
                    ["#=qVQCoIRBjumDJVIeG$6pvBg=="] = "#=qNq3wkV0xnGSTfdEP6ykzrA=="
                }
            },
            ["#=qvWkw_yfabtEZtyzamBBBvUk8Udll9pCcz$4UiKOkNz3GpODQcDp9IdyHJxz3yKfG"] = new TypeMapping()
            {
                typeName = "#=qqO6nzyDmlH4ilJZM3atq0DQIY_CUCqw91AaQ6Mf2hhU7CdO5OiagM4TCNoYe4G4q",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qpCRb4anQPm6V7O3YSBWP8Q=="] = "#=qIBTIr2GytDIwT4mzVA$wqQ==",
                    ["#=qsc9doBZlF8WkgZV7iVu8NA=="] = "#=q$vMkSaL8VlkrSUwnajacCg=="
                }
            },
            ["#=qVwqrDsB8rUL2BXNd5kodI0V5A3AG97HWiBrloz3O6uf1alw2gMBC2_4QEWjVE8LkmbCkUkFelD2vH5VnFtnUtNLzhGpmyfsdosw4WD2glgc="] = new TypeMapping()
            {
                typeName = "#=qYfqFfe8Zpo35cCUZ64WGMWG3i86yLV50_42hjjzl8GnE0bTnVd9xiuMYV2sOcA7kfC9_r83YLHFJMpq6FAL9YGKWHNPhO3REQ1MquIKpm$8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qSDzhK6iIXvBuGl$C60UbXuHaM6fY6CMm4Ak4J68D1Is="] = "#=qFDLp0IZ1Ni9FxnaMdCDFzfjOesvK6kJs1D3Nr06CKkU="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=qVYk8q8_7$KwJvxa5g7nHPpnNgJwiA5pK7fUNzuUn4i4="] = new TypeMapping()
            {
                typeName = "#=qNFwUwKdPpaEn5n8tyPbXLS6OQhT8uIHWFw27f0GFQ$Q=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qCmBZkbmjzgOWZsAobVbfYAKiCY6CQjw6Pqxw3vsVcj0="] = "#=qKWup9ggKFF9cCaTURuJbta4PDn9nEjsULVmbxHdhqB8=",
                    ["#=qv0HR1G8emo7co1PsR29h3Lm8Z2vjiWu7C8B7gAaALPE="] = "#=qBKEe7_Z3M$qV2PE_tlwm9nQHwXUJ03dWYPrR9F$Zvfc=",
                    ["#=qDX2VL8xhnTnMcymOKggpMw=="] = "#=qFVVl_VrX66MVYjio5YlM3Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qck7pqnoKtXebJDkLKZJ1kw=="] = "#=qz0WZP8AkCiFanfQMHmlm2Q==",
                    ["#=qBJeVSJbmqDsAe4lA1HbQqBxRC$F5eutGH4tszQuyUds="] = "#=qRE$UTK6rdKFJxooEdqkzUquCUFiLActi32IVu0GjFLk=",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ==",
                    ["#=qf2mWxduIA319HWcsuNr3nQ=="] = "#=qTAbkzZ7xO8kTmxXJYMIFCw==",
                    ["#=q5AAr9XMdgkjPkID2fcamFp_SJSd3y5zE4pFz32PgX2s="] = "#=qOklpD_JBD3M$qSIbkOPi13gzyI546YGc6maQHuyGJ5A=",
                    ["#=qtJmjlv4F9m77mvB921qTeDlAnvdjUkpD3YdcaF3ziKY="] = "#=qhPbnKqCGJlUWVEq9r5roYFmM09UGNglr8m_aUJYnskc=",
                    ["#=quOGhYqrtvDF0Ji_1kx4abw=="] = "#=q3HCI5bg_fYC6WAZNmRNWXA==",
                    ["#=qFlq4galvWU3Tt6MSXvMJ1A=="] = "#=qX_1cKT2vHlsrZyTEg7E_Ow=="
                }
            },
            ["#=qw9eIJEFyM0haCoRC$WEpdGwk0bY6UAYVYLcN35LGGZMvjOHZ4sSkbDhlYTNSdvzL"] = new TypeMapping()
            {
                typeName = "#=qVgiPeCSxqfDTQUYKHpB_ran8EH35Rnso_KdKxjgNhzalUT6dNKWEEWluvVqGxuYp",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qzhql2jNVQafhnumyGoHitQ=="] = "#=qE7_4jO7jbwBVwg18B7xRwg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw="
                }
            },
            ["#=qwBWJnu6NISiYEdRgtBDCqmn6YVCXrLR9hyFqbE1Es8wtHE5FgAscNWEKjbirT2fL0cBwi5j0Lm32nt_UQ68bDQ=="] = new TypeMapping()
            {
                typeName = "#=qWjCBU1ihb4_$1ydcsFnxz1oQQnFTomtcqfaBgwh8mF2TiQK1_luTZrxoR9F1RlFPdy4yVdryS0gVWW17RUe6jg==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qWgrbwqbvXvEqIZMyqWhn55SeNhulH_VkhJsCuQxkpAA="] = new TypeMapping()
            {
                typeName = "#=qjIbBfjO8aBJkqwPh7texnUpanCXgU8EjXj0bL6$ydAE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qv0QYiQzIAjSEoH_waza2ZQ=="] = "#=qTCLUdpt$H8xgw3RTJQ8Pow==",
                    ["#=qLmDt2c7rO6CfWA6u_iTWCw=="] = "#=qkaJJ8lbwCqgmObNBQS11bw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qFphH1$6KeFVyx5KxARmVtcdFkuQxoy1TNfbODoLu1vo="] = "#=qdGw48VjzCU0275VKCACfu8r3WewM4E4WiTQuxNBjAiY=",
                    ["#=qUdJAv97HJ0T0$5XqDzI7VA=="] = "#=qh9jxbKubhaYvsuCklqAYgw==",
                    ["ToString"] = "ToString",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Multiply"] = "op_Multiply"
                }
            },
            ["#=qWGXo7CWjri14kL1KpjFWXmwQ4b2te49NBeIST7CjDNE="] = new TypeMapping()
            {
                typeName = "#=qRnUjCB0anMXtXWn_ZwRApI$GZ1yKyeZjVaFzfgz30Aw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qWHJXkVQqlrpStVArowlCpsHoZeN4zBR18e5WYbQp4_4="] = new TypeMapping()
            {
                typeName = "#=qMX6$iZBEiHwFQYvb_MY_iJLHXG74ow0VR9o6bl1Am1c=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qwupUx8FMIkuebtQyWbSzUR2lEyibxmvT$lYfnS906MXEVN$6ozRuc0InOVZFrNbk"] = new TypeMapping()
            {
                typeName = "#=qxOJ4hgjbkRx1TIZI8cOzbpD5qlUC0RBuN1gFcpXIqFqs5hZVfKsvSOPLCb_kJ9zs",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qwwoBYqcrJHTJsr6colcJvNIkiFuVsblNyMdtJDEWvDE="] = new TypeMapping()
            {
                typeName = "#=qYhOjegbQZNSfIHpySQ1yUQcK6uo6sXfT8A5$sHh8BuA=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qh6Cye_E4G32bBdEi09Nzug=="] = "#=qVOXmDn4jqI1Ww_$TVFlNlQ==",
                    ["#=qhKXUSYutrXwqP8a7QHEvKA=="] = "#=qBBGVTwYgx$ZUZg5nJrxS5g==",
                    ["#=qyZtFKi_z4$S7OkZGqqsklw=="] = "#=qNY75VONiwkS1fSdIvbOg8g==",
                    ["#=qDfGbZnUKzodqyQb7G25dKg=="] = "#=qV89uOdq05qMWcPJK02KeDA==",
                    ["#=qL4Nnr20_WzmYm8TJ5Zm$_w=="] = "#=qtonBwZ1EQ_A4sMHQ0rzh_w==",
                    ["#=q1EbgOB3qQnjfzSXx$VdYBQ=="] = "#=qVe9_UDAqm6ZgWn$SJq5EXA==",
                    ["#=q41zWU5a$fmeFhM1bneU7bA=="] = "#=qXw1dsjTHF1BjxY4_t5mRvA==",
                    ["#=qROnf2xcYPTwQwktEMJw2qQ=="] = "#=qHyjJYIu$1$SqpUPbP1fmFA==",
                    ["#=qfuYIxFX4Au3QPIRNWbPMsQ=="] = "#=qFoBNiRspj83bNIeeE5wyxw==",
                    ["#=q_2aobTMH65avDxfh$8Wosw=="] = "#=qicZvNz1XFZwU1uc6$yoSBg==",
                    ["#=ql5srtNA0xNnrGsiPrRxVOQ=="] = "#=qFY2v2FreoRaPaDMJUxAViw==",
                    ["#=qQ2UmoFK0q8fgvFSGAgdoVA=="] = "#=q1BStd$rkbSlPrYs6Ca84rA==",
                    ["#=q8MXCh_hYCgls3sJNM1XqJQ=="] = "#=q6PeR9pp4RETjld9A$dVQ_Q==",
                    ["#=qfGr1Z9ejE_9tkR7FGqpkvw=="] = "#=qTXI3QadOfb6onzmXk8LULg==",
                    ["#=qcq27nBpdqBd4VlZ3x_5Nzg=="] = "#=qrwgQBclHzCXLysg5uaxESw==",
                    ["#=qyccixNRTNbzTcYwILXc8WA=="] = "#=qTyLv80Gd611ESbk4sHK7Pw==",
                    ["#=qHKu7dII8H_0T8r6XKI1niQ=="] = "#=qLDYj1Tqu21jxxyPMNQN6xg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                }
            },
            ["#=qX_UjzLg4dALSnuGFZbBWYe6koz3gzqJBOEbX_TUYKqgotv74FFmpsDNrquYURkeQ"] = new TypeMapping()
            {
                typeName = "#=qDtNO7y_DRVkQpcWjGhLXRvHGt3Gmy9CTrNNPt4uK8xMevECASnLBb5UhMWE7fOaw",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qx4AoYcT3iK4Cg0BgDkiIciML4tk4oU3HvNILqpDl6s4="] = new TypeMapping()
            {
                typeName = "#=q2Ud1Ya6prEkGyPBazUdOtkueJbK2xdwGS6_a4c3KT3o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qeQ5Pz1t4oFj$J$qhvvYPnILEBrWIJvq4AlLuhHMiFS0="] = "#=qgWoLTUCjLjHx7EaMvFewklv0d4i4CCK3$99I$iXyLjo=",
                    ["#=q$8r7_mzfjO7rjolifYY21A=="] = "#=qTX72MOrrOmrYIsZTJqD4Yg==",
                    ["#=qnMAxlTWoK74lSxWnh9f1unMwvSfiNR9VPi7HX_m6Tnc79IogqvERpKn59i8cPJHg"] = "#=qTVRKfwqZXeruiGXr$R4Z4EL$TbGjn66u3$TGzjtOkiLRT4_G6QhnLfwOYwaX6Khn",
                    ["#=qQjCmZBHYUeEPAATn9EsRwHxjfyR5R6PQNDqWp0zozEG3wJHHwMt8ihqHVr$ux41P"] = "#=qXDII$PccFynpJSanqkMBpE1xiEdKNY6zLtlNLt4oij3N7bNnbTuXQO$2MaVxzxEN"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qEYtmcqaYJFxOgJ3loj70OQ=="] = "#=qujT2KIR4JN9j8P8GgWmSMw==",
                    ["#=qlLiUtAK4G0IwGcNNEdT_oA=="] = "#=qa5vPDeSNKCGUhIZQhrDbzA==",
                    ["#=qDpLCLwjsbZUAM4qgrW5$7Q=="] = "#=qqtXvtu_dV23HOKN0vDUJDg==",
                    ["#=q8CYro6IaCT2xRM1LXyd84g=="] = "#=q_LRFiY4beeeJ3z7nS_X7XA==",
                    ["#=qmtDe2qyzP1AhItNinZILrw=="] = "#=qwuFCkXURpBiW$nOuWbTB3Q==",
                    ["#=qk3P3zDa7rpNmfF7WMc6HZ1Xz2zd_fvoMjRmNhI1bn7c="] = "#=qewWnzXvEyZid6CfGg7s$8EyLoW00Vk2pXhlLfFvEG6k=",
                    ["#=q8qRT6q0t9IHNqFOU$XvzNZ3fyaLzU1tDbRM0GK2qwjs="] = "#=quuQsjcIzQvmj_GatSbvUlcdSyCpIfb3RmS56oMOF9uU="
                }
            },
            ["#=qXARJXa1OoRmD7uyL6pSUnD2x4U9N5okPa$nums5pUtNdPa94UE3m6ZLAK1Z9LQrM"] = new TypeMapping()
            {
                typeName = "#=q1$jx2O$OMZkuhe31Ga$N5_T3AwNRvBpNckYFItBtaTXs9kK3Gw$0dzCjdnYoBqV3",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qXdJjdYyt_zzgAlset9j0Yn99tnKeSMcyQxztxcc9cMbWTMhIu8QElLjm2yfRVmk4"] = new TypeMapping()
            {
                typeName = "#=qcmCI6ej9MqWec8sGLfEwdsNWy90fpri6g2OLL29o4hI9VXCo8ilMubJxLKDMjsyN",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qxdZQAQYmj$NiQThV3PqkvqPAckNv$fv9tawoa5z$AvI="] = new TypeMapping()
            {
                typeName = "#=qBVddxMwl9rLlZm_AVybs1QLXgqDPJRey1_OgyFucGrc=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qlWpQwYyOqMIJbWacLKihPw=="] = "#=qzl09_Z683sLB40QHJlOW9A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=q2hfluxH_AsGFO4gTZw2tCA=="] = "#=qXw87wHWyVf72eb0VSEhPyw==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=qSmrCWX7SmMgUM04UUjsgPg=="] = "#=qaIq8AelgjVp4CS$MR1SaLQ=="
                }
            },
            ["#=qxEtHnWFcY5e3fay$B96dSRKdQT6kUmTNQilOcFYD5f0SR9OOqV2UFJREv1V11oJc"] = new TypeMapping()
            {
                typeName = "#=qbcYTnv0$tgaMJ1OO7E6jec4P2wKwrcvoaarCiavvHzkAv$rCqFarBbyZyUf_T5TV",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qMsb00levww4auZD2FRwtZg=="] = "#=qrqW$rGAVKjAaAU53VujRhQ==",
                    ["#=q8oRHR1f7Pa$DCXl_rnnvEw=="] = "#=q73XKVgOaA1iuZWwEGEAh1Q==",
                    ["#=qnrsSxdyqF6k0_voa28dlfQ=="] = "#=qBWgyasXMcXQycKB4OmpV0A==",
                    ["#=qo6uNG7owLnBQUXzFF$N2e2TcOWrN3rgZeR6YtJfWLRU="] = "#=qX$BRgaEEAprV4eUuSYf36S1IdaWHE3d5AY0fOaOCzAo="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qXI0YakJD$6u5sgFKxLIMhw=="] = new TypeMapping()
            {
                typeName = "#=qMvyhFpZHC_NvZiCBgFuoeQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qLTwgWtQIw43X7xyLI8vPEg=="] = "#=qizuoBGL6eds9G0khj7Ch5Q=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qfSm6C4lPWUufqFd9hKQFpA=="] = "#=qFqTYWB30sqmTxV26IoawPA==",
                    ["#=qeyEQCHXdvxWOKsaRtaVxXg=="] = "#=qLwRhGJ0tTwk3uEjsRmpUIA==",
                    ["#=quid6AQcJAlHfHhlOZy2JvQ=="] = "#=qrFL3mETGiAivDykbgreemQ=="
                }
            },
            ["#=qXl$5a_3NK2Tos929AXbpyKUQXtilFx7SBrNIL2zjWRw="] = new TypeMapping()
            {
                typeName = "#=qhhKL5O05GeXDCFHNkVxNXuwmMv0YhPdGzMQE_2hwhjM=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qq2oPPblWn4Cp3h2O2ProeA=="] = "#=qsv7cQqzCcdD0FE$UIDt$MA==",
                    ["#=qmvVaIaqHnG8pKsDfu4OxbA=="] = "#=qWcnopLaMETl_14t$uxE9qQ==",
                    ["#=q2YmIKYEjKcmmdJBkMtjAeA=="] = "#=qnwbm2oKDGioX2g3XlT9ERQ==",
                    ["#=qha9RgWPxqLhH8E3sj6TT8KgAQjCRQx8lcF29kMJHMWA="] = "#=qzSI9frKkIzZhcH4nTndFVKX0WNgPrCy6KU7UfTdUmSY=",
                    ["#=qbj0xezIykQZ716dAyhulowWQk8hHgAZyUnq2C4w7x8A="] = "#=q$KKAYStgmGAqhzT0uN1$uyCftqOw7v3x6f$gPZbtRu8=",
                    ["#=qmsCB6Ksvhl$Skh9IAmhDMBKuVMdvKjQazRLphgsGpPw="] = "#=qzfupVokOHYdgQeYnByqC4rc1HfqHzGZx9mrHsJg4m08=",
                    ["#=qJ1daeEy1B4SPskzoCrCzLqVVLQfxmSq18MsVZxnWpw0="] = "#=q32qDnjLDl$x3NHpJRZXTj$qSkX51Hb6veoohM$SvB7Q=",
                    ["#=qlkfHtEVXfftgsmwlrhs61$rAweFZUFPNOQL_wyy9t3I="] = "#=q3z64tX252$dKtdYvEjkS8ROXsTkkpborqjCcVaoZr7Q=",
                    ["#=qyqdP_7M93gMBsblNzqmoJw=="] = "#=qs9scZN3bWx$4IOpyjN1gDQ==",
                    ["#=qb7MEJiKjWqXH_DYwfNtYlg=="] = "#=qw0M9XsFrj2bH_hkl$RW87A==",
                    ["#=qM2MHusbZvNXvOV7SEPpRGg=="] = "#=qqpswZDpJudmK4fK9Wddz9A==",
                    ["#=qapPq0EkLLzBeEAktInXYag=="] = "#=qyfsLIEBQVF0U_dnPdEeI6w==",
                    ["#=qPn8VE3zXCkwNQDN3nz0jzg=="] = "#=qjDvCM$0dko0Vu4Yp7oG$SQ==",
                    ["#=qC9D3ZmQsFZE1kTfv7ntUqflgfnip7I2qG7bPuagGsJY="] = "#=qXJALNV5noYkgR4tNOS$eskfU6cIm2E74Q5eiRlfOpAs=",
                    ["#=q7PwdgF2nF7X_2xUukh2xzw=="] = "#=qEGJZM8LoZiaeh0FqyvNUVw==",
                    ["#=qAh8mm8vj65_AFSbLhxu$2fvMvlqDSDPiE$_DmLCQmJNQi2N9SShCerFleVd5asTt"] = "#=qhTqBvopw_6RxU__BVi47xn62HxHJ6lQqU6rmgTU$EoILAYIgdnjdCfEO8bXj0JC2"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    [".ctor"] = ".ctor",
                    ["#=quYjBMubyGkQrQY_eSCuBBw=="] = "#=qGXZyw0vIuBiLKsPv_ZcUJg==",
                    ["#=qdgYYDNKjCVQywBe$5lrTUA=="] = "#=qPLA36oKesQEOS0y_Q3pUMw==",
                    ["#=qXg4JH9TBw0n$hCBsjm4xybQvID7hU2_f9TKA9TZU6KY="] = "#=qD$hYpBLGWNDUN8OOW8CYg3YlkpL7duUwr_wdSqISSDI=",
                    ["#=qC2fWUN2opBV3O09cq864ANOJJtchKpvJe9hvbf50_p8="] = "#=q6broq4Jb47dwYV5jcZjT7jChc8ZEajYJQOjnmOy4CV0=",
                    ["#=q5I61G6V1FZPhKEEghEG1BQ=="] = "#=qGckjp2_PCjAL8JgdCYEOqg==",
                    ["#=qgY_XwN7nTaZmmdGGqt4DL0tCDWbIdeqEnpc1R1kyanY="] = "#=qzrE62PfT$fTEY6oX0Mx2436SLyD3k4niy23iUPtaPr8=",
                    ["#=qvPcWYldlIJV$Kw0O0Df19np71NXEdKVaM1WU$E3cesU="] = "#=qNU$W96oBYDJBeVDVKmjXCNYJPyByLTVnp1Ut6akB5Qs="
                }
            },
            ["#=qxOJ4hgjbkRx1TIZI8cOzbkxl0yz2EKs4Qmz5WkBpIBCa$BsDTvPpqFnnlj_PAnmj"] = new TypeMapping()
            {
                typeName = "#=qXdJjdYyt_zzgAlset9j0YlGpDCI4iLzUwoacJUJ$CKBpLevtMdVOLs_NOP93k_rk",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qXsBwXbHRqKr4hep2iGVfRg=="] = "#=qyrvWNWX5HZ23sOFqQ08DlA==",
                    ["#=qqlcsYZ35_Q5G5so5Uuum0w=="] = "#=qk_51wFaYOM7XIBCWL6FhnA==",
                    ["#=q4bbuhQrGYwVpXXh19hEBkv7rlgQrAG6I$lNUytrSN_4="] = "#=qfnmjr6gGlA28x_EG4fDTNA7M$crBeCIKIo4ZFPSRMOc=",
                    ["#=qvaTLCVXlhVP6wHqe6Dn$lw=="] = "#=qTG9uwszR9XowzsDzm79BDA==",
                    ["#=q2VBTJc3zwiHNEJTW5vOf334VHLdRKh9r$1CH9G1gFa5YfysGCLdVv4byyhy8xT_x"] = "#=qRYtoSXeYjAZOD$yQoESy6lvAV7xsyRaU31sv1uh42V6d1jUab1DR9scCi6N$Xkv6",
                    ["#=qKUgp_3TiKgDJ2mUjw5pd1$G26_K293ZNdDZ8J_u9D9YNB5legfqsDuPz9lCGzOjC"] = "#=qq8Xe6NXzjijXX8S4G8GQaTcYuuQidFGb6fm0gEBy6LaA0avlkQ6rhUFb$j_g2477"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qUTzhf32EahI2O80y4_w9BA=="] = "#=qWVtUQXZWWgDOIDzEBziGvA==",
                    ["#=qA1joP30Mf5ua7gB1eqK8Jw=="] = "#=qlxgi7_2JdZ0t7QlcKe6k$Q==",
                    ["#=qSKNJEvkaPHNRJAsfx7cOhw=="] = "#=qOJv3pDJiQI3eMqmjn51XpQ==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU=",
                    ["#=qnd2PBee7cKwSHfEGcoo1Wh7SMespz6KSCLJlVaQ4iqw="] = "#=qrPItV5SJ9NYEoSETfWZPOQ50eSA0Hky3TyiLdoG3AzU=",
                    ["#=qu_t$7VD_7vJK55rqkvpnlNU6UI1rFvvaddUUYEepDIY="] = "#=qCsgfnSY6g95_BNhXZP$g8mgcviGZRXPlLYAUQwZ$hyI="
                }
            },
            ["#=qxOJ4hgjbkRx1TIZI8cOzblWqE_dqxTp3I3saVRtELvZ1WY3KWXCXzlXgcjEq4YZv"] = new TypeMapping()
            {
                typeName = "#=qKHntAJ9TP7UKJlIOurhQ4eVN3ni8CpOjIG5usiBgN4f42XoylLSaaWnZR40N9o8l",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q5XBWi1NwFhEy8PxIBpol5A=="] = "#=qAaBCNpJJCKkxp$MZ9tJQqw==",
                    ["#=qmOL9J$PeCm$Jrux6TDbVTQ=="] = "#=q4K3c1lF$IolSiJAzNxRSxA==",
                    ["#=q0AozAu5cYKoXhmLoW_ZP3FwlLnVC0x0__IZNS7G3$Es="] = "#=q6rqWTgKy5_0gGk8qGkA7DsJeu64udAzmU6hReMKwdsw="
                }
            },
            ["#=qxOJ4hgjbkRx1TIZI8cOzbn2gisgTy9Z1HBpCAhn9CvBYt3GkiQ24PnyYelaQxqXH"] = new TypeMapping()
            {
                typeName = "#=qnIxybuQUWaGrTirDdU13JBONyC_r9LAw$$o4KYuj_KDwAiEiaSz3VjUG8CfYyewz",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qT0dzUvuDwtL56sDEtuHvSkwETufAx1hRNHRVXf2eiP4="] = "#=qDw0eB5rVKYQh_eO2IFIVFsBmUcKzrkUfo7BfxIpG$Vw=",
                    ["#=qWU4vjKZ52AOyZyhUHaOfVQ=="] = "#=q2tvVLuQqN_$K7_A7$EcwBw==",
                    ["#=qkcNI85Oc4u4JpjKhP_FgFQ=="] = "#=qD8ImezISkkrbbns5pL8t_Q==",
                    ["#=qu_4PWfX5WlB7R0_CBgx4nw=="] = "#=qWcdYmmwpUDDbAtkwlsZFwQ==",
                    ["#=qedc84UST6vn6KS1TYrr7YOs6TEugzdMjm$iEWoAgAVo="] = "#=qOcx1FBiOxEMJOlVBbeiOuU3KslreFtHpgb5nqxMIX2w=",
                    ["#=qbAGOX3vhv_F5fVBwauNujQ=="] = "#=qvuJ6MFnY8BWQt5Y0KJo9ww==",
                    ["#=qHCZsLTydeIXBwNKAuH9VIw=="] = "#=q6b9rgsp9$NDtS71ZW2fPQg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=quQSQ$RcWT$4xVnPfSjvpILFACdz5ItE7Orjp3iDCk_U="] = "#=qVvEoPhEQSqd1K6e6Lz_tq9JUD_u8eDkfDRYbNvaAWh4=",
                    ["#=qc9dj6IoGrw7fvtQ__xSAMA$$1gs7WYpG4Y2UO6yxlSA="] = "#=qLVGuFFfZ8pRmB3djaLGhzPhsevhcqiHCGH52xo4JZ20=",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qXPDgDKkaLHv8dUsdBju7I9tSWtak8UKiL0LSEyQcDcc="] = new TypeMapping()
            {
                typeName = "#=q04te4O6w4Jmp3hxmQwgANKp3YAoQai9ry14SqXi7HyU=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qopKmgHBYdT0w2hQKyXBdoQ=="] = "#=qLmkKJuaxDHjkpzxbaRXkzA==",
                    ["#=qY5QfMW1_R$UATHiLHGEvfg=="] = "#=qAUTNeikyHWBaXeusVvYOOQ==",
                    ["#=q5szHZ3i1yF415_$WF7jfmQ=="] = "#=qf44TYS2LLcemj_waUo_19w==",
                    ["#=qhWdFf0zY0OJnX16X0$nvAQ=="] = "#=qYSP0ylzZv0JJPirGK5GmBQ==",
                    ["#=qf1_XbN7jA$70ly_czMfg6w=="] = "#=qLpiUZFk$sTeTiVTfn3Tb4A==",
                    ["#=q5NBeIu7zkCr3OGgI3AbpnA=="] = "#=qNEmoNwILvbgYRzesd1QbYQ==",
                    ["#=qYDZUclr8yUTDKKC_yJWxlw=="] = "#=qft5lALzT8ska9Y0C_1IGdA==",
                    ["#=qBNF6S6DLjZig5PbPQ2SFvQ=="] = "#=q6j3I3XxDxmWbf8RCcGsJxg==",
                    ["#=qzC9EEQuP_UpqvcMs1ZqpaA=="] = "#=qS_SnlkPbIhCM_0CU8iykoA==",
                    ["#=qilt9oEgICGxcjW3CQPXAPQ=="] = "#=qfBInhMLUo$6VHp2B4idBrQ==",
                    ["#=qfKFrZXk8M8q$BRj6lJAuRw=="] = "#=qLks78cD72jqeo1luZOlH5w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qN9v7po2DeOjTkzoalvjtCg=="] = "#=qcDzQgmqdlaei4ggQRyKkLQ==",
                    ["#=qhvIlqclEAMMfqYswuzssgg=="] = "#=qwIiCjlM3B2eJezeYXr0glw==",
                    ["#=qVDSImnaSVH_rg15znjAx7BOgL_$VvoUW$iTB9cwq_TA="] = "#=qUBfXemis4td$KJFKAWKPNNVHcQ2rRE3U848vB8pFbZY=",
                    ["#=qL7Iuc7Y8JDAM7yuusGrh_A=="] = "#=qbt7oIgXl321aSgcWhtmDbQ==",
                    ["#=q6vWSzL7cwBfC_DRBZbUZ8g=="] = "#=qJ1lIciHRhq5sSi1XwOLU6w==",
                    ["#=qg$u8MPIHJ6xxKmzZXWAXlA=="] = "#=qv0nuZq4f6FNy62Cu5s1kGw==",
                    ["#=qL9nUvzYdDEFlRfZ789opxg=="] = "#=qT_A4CItbi_ZumF8cvUPTXA==",
                    ["#=q7bu58eKrsodQOD$6q0nd8w=="] = "#=qXkIgsvWQ5VGafPOQ7k_OUw==",
                    ["op_Implicit"] = "op_Implicit",
                    ["#=qGn0xgPBL4OLIgm3$cwVG2Q=="] = "#=q8ygKn0UFErJzPA_1206FPg==",
                    ["#=q86tO5E4OCwE2NdvF_l_MSw=="] = "#=qkxb10DsvSXFJFTBxGgHYBA==",
                    ["#=qmQvqPxPJGOnDmg5VxZyn1A=="] = "#=qbLRGQSg2zyl65cpR4tK2_A==",
                    ["#=ql12L$Ra4qspuopfe8vIpUA=="] = "#=qqOhLf11Z0GDMvgk60zRfLw==",
                    ["#=qPgVG4DQDLqHkFK3fjgqojw=="] = "#=qi65V7PYIIRJW3GL3522dAg==",
                    ["#=qIBndD_EcEDaYHYrfPFfsag=="] = "#=qXB_Rf_Bxq8bxSDa4Hq8_8A==",
                    ["#=qZtnCnxgcpkSUKNYBm98bkA=="] = "#=q9NhpX5NFPcJA1b6UtjUGdA==",
                    ["#=qEKf2yrf16tLtiivqTu9u1A=="] = "#=qvpmKvmqZ$duoT7XrtOZItg==",
                    ["#=qeKZyErvWwgWkby4XdnDnxQ=="] = "#=qzNMvfGi8IU1_kGp4QBteig==",
                    ["#=qNK7HhrTDan9XAj8IEjajkw=="] = "#=qRHm5vna97F0o7NHW_YXBaw==",
                    ["ToString"] = "ToString",
                    ["op_Addition"] = "op_Addition",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_UnaryNegation"] = "op_UnaryNegation",
                    ["op_Increment"] = "op_Increment",
                    ["op_Decrement"] = "op_Decrement",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Division"] = "op_Division",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_LessThan"] = "op_LessThan",
                    ["op_LessThanOrEqual"] = "op_LessThanOrEqual",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_GreaterThanOrEqual"] = "op_GreaterThanOrEqual",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode",
                    ["CompareTo"] = "CompareTo"
                }
            },
            ["#=qxUKNUoUepCKOrclmZTZv_aJhhldclFn_VRd0J_aEo0Q="] = new TypeMapping()
            {
                typeName = "#=q5tH50hT3fuI$rP5k7yZQCtWJ0L0YJC5QS5eZ83tt4Mg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qkMW$APS0PH3ypqGiUdaQCvi1ekJ3mv78Dk$rbs2DDgM="] = "#=qL8dWccjC8rFMT2A8umAWSyOiIFNQMH4$o3tTbO0o9$M=",
                    ["#=qDJZupT_KjkCdyopVbvp1T9Uss42CFzQ0zRrrxNLTNPA="] = "#=qI67fzh68Onq4KCM6f_PH1ppo6b658Z1kKvwJnYaHKNA=",
                    ["#=qs7SzIshGh4GZ2PXLJRiFaw=="] = "#=qGwp95000QzlsSyZFwmi4Iw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q9aH0OZDTSDTZuGjB_IUWEw=="] = "#=qmHofWUhRc$iBtbYgEb7$bg==",
                    ["#=qFAVDuy7y42vHSkurUcIk8Q=="] = "#=qemzQcxgXE17Q3X38t61DQA==",
                    ["#=qPBsvujhl64iXcnS70eHaNVncr0MA_C0edv1l3T4BgJg="] = "#=q02htqu4vcLSGuve$ag$UZwVQWHAWyWabF0oev4mZU3M="
                }
            },
            ["#=qxUWeZsKHEkzKRZT33ihc2_SJbRDrIxCo1ZGeQmMd091ZmWCaxlRVSzoMbumXhZj_"] = new TypeMapping()
            {
                typeName = "#=qqwOI6Yuz9WsEbVy5Vy2zzLH9zRsK0PNPrTC1pIgY8zYnwsxRk8ei2P93b4w9F5nX",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qK10ZVg9YcUq7Aua20_BqJA=="] = "#=qASL5WABUCeXunygj6K_$eA==",
                    ["#=qUBlKqDyktX$_4bVq2FnXVQ=="] = "#=qF4Thr2a9bogONOC_nWgvkA==",
                    ["#=qsA558UuziiJojr4SGX0yEg=="] = "#=qCkqpYdd8YHS4Up7x$Ku6_w==",
                    ["#=qofYwwTCTwk7vQKZEC1H7jQ=="] = "#=qTj7xpRJsqKwqVLWPQn93VQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qV5Zp8zhD0BJyxOt2Wj0gGVFASRh3$Hd4QmX9i7tYEcw="] = "#=qIRBf1viz86aKAfkH3DvXv1QMNjguHXaC14$XBCqbcN4=",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA=="
                }
            },
            ["#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I="] = new TypeMapping()
            {
                typeName = "#=qfANkm4$fMRlil8GpF8SRnVMAIuuPrGZjDcnjVpenifo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q1ZDpp2v7RNCvf_3vpc$ZoA=="] = "#=qjVvBxtH545dYO76sNauP3w==",
                    ["#=qPCIcCqoV2w6ex6WB5x0aPiWYYMGNwrEnjNVAAQVQr3d8QjpL9b4nuVCpsYKusRWK"] = "#=qC97zwAbh$AK4rZ54FAVB_sBtjsHLAIFWdeuFjPM6uD8Rx9mp0xZBnXjr7P$jsyUm"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qHao93d4t2hZ2OPUC_mQ53w=="] = "#=q5O3$n8XIURoOkfPyFi7pDw==",
                    ["#=q1yXTWEvMDMnFbCwhCbQ6GQ=="] = "#=qzC1iA7GH05n11F$hXR$LRA==",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qxcDCHDfzRNqAM6XohCf1zA=="] = "#=qplI7oNck7oP1FbOuTjzFpw=="
                }
            },
            ["#=qXyaSZ9OnnCiny4GxVyuAnGdpHLQpLzwxEk7O_nbKX14="] = new TypeMapping()
            {
                typeName = "#=q$mTkJf4Oi$O6hK_5V9JlHqk5biSNdxt1ak2clRWrGKk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxxoWhztsCWPAifgKh90Vmg=="] = "#=qMB3NCkCIN2gKRrovmev5Qg==",
                    ["#=qX$_Z8UorYFJhNmgk9ZFjsQ=="] = "#=qxIeJ2m5SUwHoY20c0o0uDw==",
                    ["#=qzFBeA2ZQ3ly6H54Emgi6Zw=="] = "#=qE456YGYRET7Ci65Tle7jzg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=q6kfVugDg66HzbBVumL5tOQ=="] = "#=qgi8h46TOUptYHVuYUyIbdQ==",
                    ["op_Addition"] = "op_Addition",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Explicit"] = "op_Explicit",
                    ["op_Implicit"] = "op_Implicit"
                }
            },
            ["#=qXybtTWc6YL3Bmjhy$yqnlfUddKSeC7LYrXOWWRjn3Mw="] = new TypeMapping()
            {
                typeName = "#=qYd6NdFgg8c1kRrKHqep59orjlG$PUpyvfIVm6MpMtDs=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qZsBQo$nA1twDqYDMhtQQZ7KXHTX$vr6jlKyvlLqOMuI="] = "#=qVxAhsNfEo3msCH9TiMgT4Kmqgmd2ac8xSLBv60LE8NE=",
                    ["#=qM_XW07zc24HTsXnmNorG1p44vtUV29ivHO$wqmr$WWQ="] = "#=qwsP$2GkNqXQhYEN6ut0_qcb5zlG$tnQgS3MfEaDa1rA=",
                    ["#=qjFwOTlATjIv_J1S75zba_sQiudaihMYMsyaMvcJMRgw="] = "#=qpgJzF2NROTPnOpX9PTtrQ252Oe6ywbHZ9CYDD48CsAg=",
                    ["#=qLL3QOCQVhjHivCEAE88w2A=="] = "#=qFqw90iVnfay5UMvWf2lPYQ==",
                    ["#=qhIbgJQxM1GJz3RiAvWMJJQ=="] = "#=qTc4i17jAF886GpVc7KLSOA==",
                    ["#=q9SP2$Dh5QNREf68hUrRFMw=="] = "#=qfog_IpIqKqWoDXvsDyyziQ==",
                    ["#=qtHaRyX8EjLy772WyiLnYIC1FJsCs6jbgEVTiJuCViTA="] = "#=q$xQKJXhATdVc3KRFnyZGqvEJ3x5F$Sy4qha4XObuDMI=",
                    ["#=qpVg32pj$5DHyCqcAnJOOAg=="] = "#=qssHNlGj8cG2neDRCSxCR4w==",
                    ["#=qehyVaUnTk5x6nIuOB4uzkw=="] = "#=qnck6bUEChxqB7tDMYjuB$A==",
                    ["#=qvRIm153EFfGpPLaAH3i6wg=="] = "#=qpHSQTBaG5rmBLHARfXXpBw==",
                    ["#=qHxnhuVdSpAuwty3bTRYoWg=="] = "#=qV0uEuWYkJAmsowMUttlCXA==",
                    ["#=qM6Ey5T1a3oh11tat2NkWhN_ZvtM4Ih7Asx5zyQigFGU="] = "#=qXnGXIrePJbsM1OvL2MV2inhpj2rhYko$2Uj0UCOQXQM=",
                    ["#=qPWd8YCTL7tgd3zcGyMxEnA=="] = "#=qQGZven_D0wLPe0Xpw3jyrg==",
                    ["#=qDQbKsgZeTgbZH6Pf_xOGPA=="] = "#=q9oRgZanTj4rpAhviNx8Mxw==",
                    ["#=qUJ7RBiEiA3Gp9mfr9hpgxw=="] = "#=qxDOW9d5rZP1MKkQIq7m1GQ==",
                    ["#=q9kwXyZvNI_btZkVFaON3BA=="] = "#=qQOw1maFIQbrXrZOBnyprkw==",
                    ["#=q4E5YXWaxstKcbz_dOLevrw=="] = "#=qyppaMaGe7Ij6hAZmoZShXw==",
                    ["#=qBcxaP8mxU$5oV6gWiHR9pg=="] = "#=qb2hhRKPjeoGUF0_kFBpcsQ==",
                    ["#=qB0bfqln7T8rya7XXPYCh6nEBAaF1Cz086ah9054VNaQ="] = "#=q9mLA1ki_8VhfgaJLsgWHHID5B3lDJmedWVmZBrftk2Y=",
                    ["#=quIovh6vJMOGnavthZy5O__QoQTfhYLx6Nu5fsyu4lE8="] = "#=qaLbNm4uFTr2yPsnQVlsSk6ac2CARqtWTsTXAY_LdtSw=",
                    ["#=qf1m7DyTy3WVkMiVUDAwt3k7P6OMoIZSljrat$VGSYPM="] = "#=qEEB8gtL3LJHXLC9dj7Ck7tZol6LEtLvhvHe2cng0BiQ=",
                    ["#=qU3_lF5$kHGv6YBJPyWiMQA=="] = "#=qLNjPMX7RCBNREJh4DEmb_g==",
                    ["#=qJYwsW2QaUIqu8KVuoVYTjA=="] = "#=qWB_WJxA2QzAtuVUjygpz6A==",
                    ["#=q0cMxelsep9we0tq9Zknkcw=="] = "#=qYid1JfQ6DCSTNpZEeGMrAg==",
                    ["#=q5mVWB2ZoE6mntgmjxEavSA=="] = "#=qzxHwNOupl9HxB3ecU3rV3g==",
                    ["#=qnyXXI97goXhQaIyaRUrWosVVuQe$v3fFNlPq0vFBwr07fXd55nXxV1CQWZbWuP3G"] = "#=qGV$XNVbgR7SfXjzaUaNZtRtTXhUTeZmV68h7RaCtRQY__b5v1ZUACV_I08nljnGw",
                    ["#=q0zs_goJjyMCWBGkqp1Ib__WgRPM4xeeSjwtNKapXy$5fIyH2WhZQKEABkyfgsuK6"] = "#=qbyeXK4GyCkr3C7lbVwdVkLfhXqHQG$xWik7pSU1ZroF38SHjeN67FgDtVACWUe4g",
                    ["#=qHw_2LO_Nz$Y0vq1cf8uMw_1ypz8qO7kfpX8$nfYpuzWZ_oKacfynXwzxDMDRWtXD"] = "#=qQjCmZBHYUeEPAATn9EsRwHxjfyR5R6PQNDqWp0zozEFrqslOV1uZQ3U1MDvc2wG7",
                    ["#=qiMmVVdhsmE679kggC8VOvRJ6by$dtRRTDrmeuW2KqCoP4$kVNKI_Qdf6D8VChMLt"] = "#=qZI3qKA80atATQQL5pUD2m7FSeqvpFCebX_ZFxPbLV13D0vRHej6FDZy2DlK_Z3DE",
                    ["#=qsWuQXf1aTBHOPeMTPKwcWn$Us_dhtc3g357EI_h_LJYvK2Uau$UTFy9qfdmmcImF"] = "#=qbFNBF0pPRhOJQhDorwIHVza3djB093XA3L$Ve$WW6s4okGv3r2hwUJKDJkIodL81",
                    ["#=qE8uF$vYQPLbr6cQlHFILJ7R6$1yM2udPd0Dar0cBy2jDE2eadCBGNT42a4q2468o"] = "#=qUuS9yf3FG8B_MmeH16lkr9UluQ0S5ea2jpZeOjTBhBHK3n60zPJ81ui654gpwHx1",
                    ["#=qBO_YBERdpcASUHJYBaKaepo1updIpBpn$zG1hMmknFK6FX9VyUtsCAnXVfMMr$i_"] = "#=qeJ2zxR_2B_LD_dOVmw75TiaWtmcIbLLA_u$EW0XWtlix3mwlNhmoCx5rUnYGgp5i",
                    ["#=qbFNBF0pPRhOJQhDorwIHVza3djB093XA3L$Ve$WW6s541fPE0fN$jaKBfaQ2Rx0v"] = "#=q9Pg8XcoRzzJ3hP2C3RBJ6CIArXsidogQdeTSjWNGqhVWw$hQXXpRtSredWk3zOH$",
                    ["#=qARX7N7tvRJoVy$hETbVXSC9ua6UmglaJyHSsMEC7p$2m9E4ORjenTNZ17jUQ4TbL"] = "#=qo0f49EkuwC4ZkyMfM4UY1DU2hdgDIBZzMis4IKEdieUbfE72v3V3s$OdqHF8zPot",
                    ["#=qWZT_poIO4yS6b3F7gILl_bYpEBo$ZO8uSxubpqOINQwXOZe7vg$SGX3mIrIgcspn"] = "#=qrZCu1r5qCEtuSvBEEgZXY66vrwB2YK1UBCMR1o18ma7pVMN0S6RmkRd20KIV94hT",
                    ["#=qhTqBvopw_6RxU__BVi47xn62HxHJ6lQqU6rmgTU$EoJJD073t9F$7c_nUlSJMtwD"] = "#=qvoq9q_IyRQ3l09XUh5sQB89KR23DjyU2OdLea9wgEMtdazFXtBQxckj91qTFwVpq",
                    ["#=qv36bjNy3i3nLv6gGnHcV_sGblMBZSKynRTJmsvzJVbvcRSI5EMyGL0ZiK$ey$8zQ"] = "#=qlzxzY9rHkKxTJOrjFExoC3rCsUjKzXHtyyX$g_m7qaGJi$5ZHIcl_nmNWzmaJjra",
                    ["#=qx0_l8pnI2JruIsOcenadpyL70K6t1xDvi08bU9Vr9Ev9DioWXYz3yTXH_vvC11Aw"] = "#=qq4gPuDwY_5u0M53SAf48Hi3tVjDd3CHfosuTzkxffrVIqueoJXByukk4pbsT3rIE",
                    ["#=qwF4fXmtqVePh7UIGjn31qR$MmhaFhbizI9rqgAR9_s44zw_beVyiAgNck2tz9Lkp"] = "#=qLy$vfO71YRp5BQQ37L4ItdenxlK3X8hLlKYRNTY9PGtLRB44N37D5rYX0670q9Z6",
                    ["#=q94dPNfZeyHxSoIptE3FuTA9mevNGmOp$xuIYSriwmJgUmIg0Eq4TPUv$KWuOIB_A"] = "#=qU1ssvtk$leEsQwmy8XTvZJtViCYsMaBEnn0eSIYi$bbKDEb8d0AoaYkCv2PMJjHP",
                    ["#=q6jNOZZdAmsSMGVRZdAQ5VGqk_eAXjLCiHLtQqvivvixo8$HwR4EmVr0iM6NsxvPi"] = "#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$AODkYQKjwBxhXTfat2Y$Oj9",
                    ["#=qvYM3C9$wP3C1Ba4bBsQkJLX9WLIgSsp7kQMzGw6XCwcbbaJzJYhQxSjUjlZGmrRz"] = "#=qmx$XmhZcogq3HC$iA7_0ja2T_2EBm1qYGexH9hx2tmsvyrQcpMW5qTJL7xTrat6Q"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2gV66E4VAo4QA9df1fsydg=="] = "#=qbCnmlswtKuD4I$znMnMQSg==",
                    ["#=qnQj4KVukKLhtAe0G_S_94A=="] = "#=qx1L9wW_THmNYac5sWuHymA==",
                    ["#=qq8u8A5_Fq5zZyBKSyiiS2A=="] = "#=qxijy133nujBFpHONxzRHGA==",
                    ["#=qN8IAFCBZrXeZZPrQqtEpuw=="] = "#=qdxhpCR7SfgCALAUXoAzQLg==",
                    ["#=q_Z7XTI3V5XZ6zpHNO8sLVQnGrnDzInSbvzTYplr0wP0="] = "#=qZqSYLN6aO4yJRlM5z1mtZa3tQZCPLMrLzVHpd0doMJk=",
                    ["#=q9mvtSbOac8yQADghVMHpOA=="] = "#=qROxNZVMliIuFUplf0EfJbg==",
                    ["#=qllJBIbK0DPLdvHTYBwLeTg=="] = "#=quX_6Lx_one7QeSsZp_85Pw==",
                    ["#=qr2RX1b7lecCxc2WmGwdbjQ=="] = "#=qjteoRu3IBTntoL71iPSz8g==",
                    ["#=q_PspAzNjOTuwig8cVDGsoA=="] = "#=qz1opOafM_VyRtzpsi6APsQ==",
                    ["#=qVq1dwKYaTvdT0H7LyH1cMQ=="] = "#=qfypdlrrvCV0QJppimfITRw==",
                    ["#=qRHH7BepPx_u9HLuJ9P2GPg=="] = "#=q3Rs5CxPescVWWRIeDZ9taw==",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qEEXsEoxpeK0PL$ac1Q2j7l2QEyEEOlb_Lhdeo$pvs6VQmgTuvSNLfsPaK$95yE3j"] = "#=qQPzlkLnPI3Zi623lpMh$SOo0i652gBT0dA_XhPhLzUuVrpEqy827qXYJViojXdf0",
                    ["#=qkKRJ9osY8OWwS_$RJUlApw=="] = "#=qNU_o1xEGgI4AYwu06PZ$4w==",
                    ["#=qrI0b8qDvVb$8IZE$sw6dPw=="] = "#=qfsqutS2fLFo_elorlMLCMw==",
                    ["#=qVXWWKCnj8d3pDluq2MJ3TQ=="] = "#=qXTK5A6f1eppvLi3x69TT5A==",
                    ["#=qGYhtZUHwTuMz5UJh4RhYZQ=="] = "#=q_HQEY57UokqJDzcoaeVo0A==",
                    ["#=qA_GV0kIsbJuzrm67BPpvO9ywpBDaTjRAVpybL$AdAPU="] = "#=qupDNHkcz$4eNhNXMle3$8qefz30Yl46No4QZkXLSieE=",
                    ["#=qeDjtTVMbWS06DOoJ2NzsOw=="] = "#=q6CCrUc0HBZQgTu4m2LXgZQ==",
                    ["#=qRP$okNLI2FtCp$v14riOwBJMMHy5Q93LFFhwn3aCMQo="] = "#=q6$hAe3wLA5mSR9f5j4NaosMfndU1l65MqYchKZDFlHc=",
                    ["#=qdDxIzT_gIVhGXLoxmqMENV0$jZp_DA7w6Dla6Eg$Q4Q="] = "#=qGkw3pXuztDmGJl3l3hiTfO2LvOXRECON33ByiBs8qX0=",
                    ["#=qLGyXgf9L3PzMYK1Hv6k$SGfU_II0AqRtl88c0ePHPsM="] = "#=qCElLoU0FBMv00SR$aaEmmZZWDrRjw$tzeN3v7KaXI1Y=",
                    ["#=qUHhYwtQZoY5KTjX$VtzoiQ6bVgZJCEXdr5vrMsjwbp8="] = "#=qgCXUW666QCqNPtlRH9TQfzG3eT0SiH51mVi0AEhlO2E=",
                    ["#=qz0kNRZrDTM0udsH6mmkjij7rekn8$t7pljMrkOCcAH8="] = "#=q0XqBxDBZ7AdhAOZngl4CZuXv623hwhzEZ1L4xI8H2Po=",
                    ["#=q1PDWbPlKMgj$tb$GrSyuuqCeg5Mp1fKRwnwiFw7Qc$4="] = "#=qClSlaN3icBVODFPok2AA8kObBwxERxr6WrBzEk7gN38=",
                    ["#=q2ESTf10xNyBDYeyR_BLv9JEb1FzRR7Uv_COVehP65MY="] = "#=qBOSx3NPpo5HU2DqmlhXWPr2MkME3_DtUt_0i0HIvfaE=",
                    ["#=qu9dhieftXMK7ipvy3D7xZW6cHc6UqW8Rq6KflMTcvyM="] = "#=qcy5rjRmbK8RPKUGtcAYUJCIrFX0G43fXHB1idSbCRAU=",
                    ["#=qVce43b4QwgWJ0sa2BJGiWAP43sjotyV0wHMwfVnMoX0="] = "#=qpifGP1csgk3gnpTRYXnFqMEUCEKkBIxWVM4hLqVY9ds=",
                    ["#=q3sFcba5dTnX1BuWG4P878Q=="] = "#=qdCgVD0RyQc5KXxYu9IFUEg==",
                    ["#=qwcXkdzLEW5k08LKBASjmsA=="] = "#=qevQIqgvTMoINFj$XYNrteA==",
                    ["#=qbzrExG80s2CKpqAr1ZrrWHwJz_gXpCCvTatkMtCYHwg="] = "#=q_eB1ds_24FvfFfyx1elpis$YT8FDsDLqWddNH$liR_k=",
                    ["#=qQsBO26A2HaS0lBEN6y0MSA=="] = "#=qC_K12Tf3dwgfa5q92Wnqbw==",
                    ["#=qvtlAGkE5YL5S5gYVx8N8FA=="] = "#=qvXxuWSFjKgrHSIo112ngxg==",
                    ["#=qWn9wG$0ssBqdsFFofdxC48hN6PLPjZE2S$v4JzPtwZg="] = "#=qPFy1tijEhHH4wwnqR8cFES446dsyKXkWn3KvTX5HImk=",
                    ["#=quWKgwm6BcZ3QD_60CrJ1DHDFX7RbMoUcpV9FJ_5HPs8="] = "#=qJ2PawSuvBWH7dJ660m4tAn1SUZuDIWFLee3eTMWBtJ4=",
                    ["#=qJJgp8D0RERn_u9LZOTxv74ungAapyUkKvwYfYnnBaog="] = "#=qQdtG5ENpEauRKcS7RElwVQETRkW$0g$eFSZjgKZvTzs=",
                    ["#=qnBABc7$jV0QW2krd7BxgTnDsNqwzv5n0zdy2mZHNlcc="] = "#=qlyOacllftHYBo7cSaYzwG7IADUkx1XFK9xWOWlOzIHc=",
                    ["#=q6mJ2HB2ulSZHXk28uv0RPEO4uoKUY1DrLM3sPHMey6s="] = "#=qmlaa4N6oEo0z1u65gLp0cbQ_ewJ6n8ucP3RYnBu3nZk=",
                    ["#=qcHjj_3hoeomxlUM$uEGcGbdECNLtEgztb65GIjQGeOA="] = "#=qSRC5icGC3A7tzWvqrpNLVf4fXZmIARyQBbnnzW6StqY=",
                    ["#=qA2Sp9Lu0RHA4gdwAChcE2gRjWSE$WNK$mTfJZYQh29Y="] = "#=qwiwn_PU8cAFL1XOtxZvocKARK9hy58bf8LOfl$vss8w=",
                    ["#=qtb40RD5zDa9$YDO$90cqCSIoXfXwldlRIZdLQ0sgGfc="] = "#=qFaPEkOGkiJ0YoYBhWJRDS2xXXZG1QhC$QdXZ1vQD6u4=",
                    ["#=qJzcyV1310M$xV0HeawCBG7UtnreaZweCw6zv6UZxc70="] = "#=qzT4SILy6lnPhYcrukS1eIbvSh4ZBYG4MOIgG4ypTHnI=",
                    ["#=qVkCwpcNvi81PlUjb8y9P140Qvx9Vi6ItUp2ZAk196mrK1gyObvtVxIUQF6NsfUY_"] = "#=qD7UanoaEBcnLKPeP0U5u09YT7d$eKBDnODZWkSm6KioVGM7OMWx_PSzPP5C$xsx1",
                    ["#=qnfrWm0NUASe$dR9TUZ7bAVTq8FdMFXcypmm6_8LXZ$uPdiuxdhPcFhnB8HlvL9To"] = "#=q7YIYeHqVpZPhzQslPIEDSP8qGHcTe$S$eQvUZaL78JGWNcm1qPl3uUQXLIsUUZ0j",
                    ["#=qSK7vWEhODwd97GO$xpo6KsH6JYG2ZmiGhbxz8i5pMEc="] = "#=qCF_cLcqMO948SD1izR2cLynRqi0tiflvqAxIbW_BJxk=",
                    ["#=qgk1rCqV2E5vDEGhfwaT48Q=="] = "#=qAy4Gyv7W5iLPjcweBnCOlQ==",
                    ["#=qWoylvkqx8gwjHWqsmaFZ8A=="] = "#=qmfBf41V5kucJtLUeYQM$gg==",
                    ["#=qktCdajE9C_nwn5XhO_YfJQ=="] = "#=qbfpej0XBlJGK1VeBWtHmGg==",
                    ["#=qaWsOjDeEU6uRSL2LotnJ1mDvZjNfv$xGY7o_rUMZQrA="] = "#=q8hLiAySvfJeJ6ffh3z32GVym99IcdLxfGMu1JoY$YHY=",
                    ["#=qtcYtoIjJc_ZlIkyQB1h16A=="] = "#=qN3Mo7Qw$y3E8DKxXeMfL_g==",
                    ["#=qmb8SWR0bT5rNHvxTQH7gCg=="] = "#=q5fiRfGzxW$AQn6FV7B23NA=="
                }
            },
            ["#=qyAckAPepN4h2$bJ6uBcszc0RJ0azirzYDJ_yNvVvHGo="] = new TypeMapping()
            {
                typeName = "#=qW_IvH8Z7nljWyEfxT17NKvMMIuCa7ei8Bh$xMUZO7js=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qUwBKvGbsgj$HxjZX$VBFwA=="] = "#=q8cR4K5_0pCLyyRV5a37IEw==",
                    ["#=qSaxV$hhXhQa3EGEYprBStA=="] = "#=qgw2nxBC8Y3$JdLs16UsjSg==",
                    ["#=q9$S0BBr1gp_J5dWJYIV0hBiSJtNSePDKdRiHqCRFHZI="] = "#=qn87LJaijlKjLbU4FXCyxAdHGmlnkGbuprWO$nES4ia0=",
                    ["#=qOxsvVOfFCBHHaspM86D$bg=="] = "#=qCBHnqiSPejiQiXlJ8NiYQw==",
                    ["#=qUc$k4BS_WQpyFb7aBYIAnA=="] = "#=qzdNJUX_kcFY48x0_OZw2Uw==",
                    ["#=qVAGNys9aNeOi2HhFElB1qw=="] = "#=qbyoNk0b6I7bSVW$JjaNnyA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qJJaVkb$zRX16HPIeBPtwQxdl9OERj9HEKnyn9D1PM2w="] = "#=qfB29nwvqI9DakHFEwYWK9_Vmh1swPocLgMd0_mwuNDw=",
                    ["#=qmy$CalIDN82GfHA$UCme$w=="] = "#=qC7KCkz8MfAVU6BTJ4moGjQ==",
                    ["#=q9$zqgSDCzmgGBjAh2zPxNFq6GPzblURj2MnZuX9$jFg="] = "#=qIyTixAuwHWnpu4__dqXwtk3IKW70DFMz8xvwZeo9nLE=",
                    ["#=q97TqHx2atffv9mwHZzivDg=="] = "#=qvip5VxTExewR1StcoN4x2g==",
                    ["#=qBDLZFz7cVgEmxd8E$LasqA=="] = "#=qCWOxnoK1DfledQ0shsvMaQ==",
                    ["#=q_hZt0CDWefffSvBmS7YZ_BFsAQhQ1E_ZJyDDU_JGjQk="] = "#=qPDX65LFko1xAIJps25djlEhQqZBC1JzYPjx0h$HNnVk=",
                    ["#=queMoluRCoFN$SSODUEDlJQ=="] = "#=qNNaz8cAloAWqfYh4jXRvsw==",
                    ["#=q$seCjTnsCcM9m_QQC8wvVg=="] = "#=qUz8t61W_uQfwYGfqFFuCTg==",
                    ["#=qniqqmphBbBrVGsdmIueBIQ=="] = "#=qiLEU_pkr3HXYD2u0dkNfow==",
                    ["#=qvpmsGJCmn_gGGwgQqd2Q_g=="] = "#=qzf9NdYz69undVdmAnCiY6w=="
                }
            },
            ["#=qyBMOpPCIzRCe1TWF2GQTyxmD2EDmlbDOMVeXoT80F5Q="] = new TypeMapping()
            {
                typeName = "#=q_vd4fp2u085j2nnFt1KRp0bV7aBszeIt2nsDmgXptLw=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qgCHJjk_3ZhL8kezgf2J0Yg=="] = "#=qt74h8eOVFgNuFPVTjhwQnA==",
                    ["#=q_ZihIEmZ6vlzlOguYeA9BA=="] = "#=qeg6_9ofPZcsKmEQZepTJow=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qSnurg85XDK_pTXYbSZKxBA=="] = "#=qigIcIjp2agZgMLGb7cbS0g==",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qzcIILEHYrLM4YObDoj7mFw=="] = "#=q3mxUhuSTz9P9IKK7TYpUsg==",
                    ["#=qd9w$QiMelAYb4JU1sM5ndzeLF28SOySL6qL31XduzvY="] = "#=qQfG0zmvlvWB7BGXUeipRosJ1__t9v1_reqUjNHGpxWM=",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=q8MU495ysfs7ikAh8VGQcdAvtQ54UTCa3EzcGZCMsA84="] = "#=qKfZnpuDCFEtiqXxlPFt0aSkTqU4M$5JDC6Kyt2CE0ow=",
                    ["#=queTrR6On2k1NqqWDFyJ3VquzioPBWRl6GOpqkK5d9nI="] = "#=q6FhuVyLU_P$f3BAO0r_Hwq9IDVWMWqbmOUi7uX_KumM=",
                    ["#=qtW7ZkXXFjJny6fNYA7XnCf628mNk0eZfcu55dfzPAmU="] = "#=qo$CG5FatxVFba8pyovhhW2tXBK9eUPwvjbBQXhqmfKY=",
                    ["#=qBIclwJqpL7c28$veL8Z_aUrt2ovSLSGeYkKKEiQ$gec="] = "#=qVlbKc5xNEq4qmTkmmkJgLnodgG9udcwlyzwE1Acz8ac=",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g=="
                }
            },
            ["#=qYd6NdFgg8c1kRrKHqep59qOS8aNtfKlRvGHr_YxWwE9YpJQPqnqRoAbFllwv2ACH"] = new TypeMapping()
            {
                typeName = "#=qBBL6X8KSk57qSlgtlcomwasJpLjEaMUNqH3dUBJtE8dseEvtryFN9sg6Wg2caTwt",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qe94rPm1jI38$gsSFUqry9w=="] = "#=quxR1kWobWhhUIHgpo6yqTg==",
                    ["#=qDr3_7vrtQqizCwfnDmruwA=="] = "#=q8EoKX$bYgrNCy5YbSEl1fQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qrKYHAuSdNPao_rjV5n9Jrg=="] = "#=qjETTeWL9n$ujYG4w0Pl2Ng==",
                    ["#=qdUqDbD2ge0tHdLMmhc9bLw=="] = "#=quQi58DWPipjtad9BaLLsuw==",
                    ["#=qQ35xZz04iKhiXjOwE7un_g=="] = "#=qDNod_$iB1_hf6C49UEuWzA==",
                    ["#=qaeJCWr8zzIV8ggrvqv7oXw=="] = "#=qau4tM0PuXtTqzpmrWSoWIQ==",
                    ["#=qCB0s_JWmmUnr1ifvWpBBOFCGD$A_GnGQEBUUnrVbjwI="] = "#=qMGMAqDX7Ubm3itN2w0olpDGN3LuuOoFmOyNcOx7y2cg=",
                    ["#=qwbGEajCyhYX$7vq4oM98tI8pteT4xk8uJxG2Rld_68g="] = "#=qO6sn5V$_cQ1yk6kxDS1WSFGsHaQJTEpNdv1_WgYFAIA=",
                    ["GetEnumerator"] = "GetEnumerator",
                    ["#=qn3FrUrxVW_0wwjeqY1OiK2GaALghURucj96NG9KYgIa$vlwhYSqdJMuh1FPjGsc5"] = "#=qojaJhKlXXa3Az6kJeCa_S59MRKcy4WgzfjsyLTUqnCrYWU7fxWbl$pioqp1r_Uev"
                }
            },
            ["#=qyET7JqVXFX$Z98vLBkEd4QNF2hlQy9ttblTNl_spn1c="] = new TypeMapping()
            {
                typeName = "#=qnQ9DzO7rLkHdiFlWK8nVs3WBmpcH2TO_ZSCkfRkYOhI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qYFT6rbP_0e63O2TmGaNRdVWtDN7WXu8n0hnFw9YMgnpBSnlfUiZRpOYaPMxP$dKK"] = new TypeMapping()
            {
                typeName = "#=q07_2RXXivreQjbaZ$SaWnHZk1DDbnQYRnYwt5Y3lhaT194P_pw498VFiepVEQvxo",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qyfWynCebWI5N2epMgsSkFuHZk9v7wiND45TsC95re08="] = new TypeMapping()
            {
                typeName = "#=qnQ9DzO7rLkHdiFlWK8nVs8m0LQVmJf5nq9$IMfFqVlY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qGpvQMuFkWjy0G3TjfwfvtqkkKt_eef8kIjMxqkLwNlM="] = "#=qJr8Bdgr$W64MPIGO0yIGkcabAo4dbek4YfTGnkmdhH8=",
                    ["#=qFVJxRBjaMzP7RzUkVDF0hw=="] = "#=qpvyFKZ3n7Lpb19W5ixY6Vw==",
                    ["#=qpTKGCxG2E8dtYMy3G3iOmw=="] = "#=qkmKUGhuYkXuVT4MhcuFZXQ==",
                    ["#=qgD4ZAUBPa27zZIvyp0i6Ig=="] = "#=qaCariWPg_bP898e5Cr9doQ==",
                    ["#=qCH1drd3QxLQ1yppWzFMGPA=="] = "#=qKrg0pvqx0uwV_yri1VGOgw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qAHgVw9an8F6_Z5oXloPFdQ=="] = "#=qDpJgnWNX7k3LUb5haMJd_A==",
                    ["#=qwWMXPq02d3i205Ak0sF3pA=="] = "#=qHrzIpYWEzchtqDaB6uqoZw==",
                    ["#=qYi4fRQ2Rv0$eTCmwqJCdgA=="] = "#=qnD$fG50TpTNM4h1qCrB3Tg=="
                }
            },
            ["#=qyI6BCZWLY2a1ImeuEBIyhIdNgeKZHIC9hsMgSvAKBww="] = new TypeMapping()
            {
                typeName = "#=qaw4m4kxNcUH7In3HA8$ZfMpGt4S5xky4BO5WNEXKp4o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qMvJi_YkzciItiafjIF5h8Q=="] = "#=q_lHX1rK$muafyjfsKWRZLg==",
                    ["#=qeLDwaur0Ozn7d8vCyfww4Q=="] = "#=qA8p8HIbLsEnyhY6fzjTFGA==",
                    ["#=qb1SC_XBQCtwdH$lGrRTMmA=="] = "#=qKPXNHxa3GELT6pzuxgybIg==",
                    ["#=qhhmwAgXCF4$qZamiTEfTDA=="] = "#=qmnPC4hcAUqqH6e6B2Uzvaw==",
                    ["#=qm61ZbBS72zQNXU4uuQkTEA=="] = "#=q1FTTtDt0KoDT3r7qwa6ulQ==",
                    ["#=qmhkVS8Hu9Q2n_KpYobbTng=="] = "#=qdGrldQxi74F4r1c6FRT8Lw==",
                    ["#=qlq$oMtpxiX5ABrE3xWufow=="] = "#=qtAykcHDFlkbbK9DT71lg7A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2Z6q$5NG1IYuRn4RhYC39Q=="] = "#=qh$3$CH0nqPpg6IEcv9v9wQ==",
                    ["#=qgGT48JNEYsn7m_s5NVB5ag=="] = "#=qdZRT_3l8BQBhe6bBUEtORA==",
                    ["#=q_VumAQAY67$PDKrlO_UoZA=="] = "#=q5K81FODeIMYpY7CHHAWxYQ==",
                    ["#=qlceTJv4hwL6n5YkMqRyfFw=="] = "#=qRlqYDEgVHbuR94eVZstQ2Q=="
                }
            },
            ["#=qyieQKZ59LDN4jR8gropHKPKYnCtCtC$6EETQif5BOUY731AQterCsziZibxXrX0h"] = new TypeMapping()
            {
                typeName = "#=qp11EERO0IIQE8oDsoQD0X_by$PyahLG6BYdgrF0cRAcVpkzskdeJFzXsDyBKdAA$",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qHUd6Ukd70N0TGY5K0_TDUA=="] = "#=qvmRSeBK_6sKj3thpanBE$Q==",
                    ["#=qG_PorwDemU6$mOH7D50pjw=="] = "#=qaG25tcHZ6F4MmvW$ZhKmPQ==",
                    ["#=qpSlqcrVFDQCQywkiq5k1zw=="] = "#=q9us69SlH8ZIeDBhN75WUcQ==",
                    ["#=qVEcmJBROyjJ9fzPx9YVvkg=="] = "#=qojnnT7FZ6PMLfxC$EGnJ5w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkvizJGxlR2Rr0VxrwvXCLQ=="] = "#=qQ39kEjAa2n1kx0tByukdzw==",
                    ["#=qgL78IpV_Lj2DbU7R6LXfSA=="] = "#=qzxpyT0ocQtXfQHL2tIZoAg==",
                    ["#=qTwuG5i4Z5xS4X2SJ0jRBYg=="] = "#=q8cy7Nsw73azQpbfU43LVEw==",
                    ["#=qqamLm0v3hX0C5jdNUAX9yA=="] = "#=qGIwVDdviwWxcOlg4OwEpEA==",
                    ["#=qxFvC5jnw5fkpHsYw_xhW6A=="] = "#=qEwprSsWLT85_k4aRt8K4lg==",
                    ["#=q1xt4a1PWZOcHv7kX5Y80_l4lZdcYuyrhyZlzZkm8CYw="] = "#=qFcdBsUPuQ0nzPsL5mAVnzqkx9P9ThSFwT6_lfBb9OvI="
                }
            },
            ["#=qYJwfHHvecc5m4pqmQ58mAurKPdpLBgz$FTsTg6IIXfc="] = new TypeMapping()
            {
                typeName = "#=qz76pS4PcHrbR5s_G0RKB2_9GjS952t$UmqXTa_02eF8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q0NglPbwvdPuu46Fwhpi7dg=="] = "#=q9iV7s3Fre8p9C24r65TD$w==",
                    ["#=qOhmastdQjQ5OiRsmfbaAKA=="] = "#=ql96RdZlvEMtTrr5$gudA6A==",
                    ["#=qIfYwyMBeU30i1Jn_SY5BSYFpYkm3CVFPZShlqUHiKEw="] = "#=qv9Bcu4VrpwXAnYFtehFaBDjUGsqAG_61iRbQxgzzDvA=",
                    ["#=qFhlJsRCqYr68m$msVxTMICZ7Oc5nx5MeNvzuyFpPDHk="] = "#=qgK3kCaKs7NBEPS8gZBU5r2gEm_U3xiwIVYImuKt2bjU="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6RigPj_rwfrUGOFmzIV2jw=="] = "#=qhc7mxex9cctMzv9b0UpQMA==",
                    ["#=q6i9B242tyYBPLdypQqG89g=="] = "#=qrHcxGYpn3wFQnVeUPumM0A==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg=="
                }
            },
            ["#=qYjwOfIdXhFNER96AQP4GsxR0FqJetpzvIKHlNpV6Fmc="] = new TypeMapping()
            {
                typeName = "#=qoRjt0M_W7F2EjhyFZnIgZFF4hdZ1NBojVoGyjs4U26o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxW3I0ejUGd4_fFtOs6D0NA=="] = "#=qoO8LQhv1TuBGEZYBlD7_Ug==",
                    ["#=qVpAuFG69B9EVK68UUebX6A=="] = "#=qiX5MUJFwR$zuGssFV7pdsA==",
                    ["#=qG46tfKQhv5r0XVF4whTE6g=="] = "#=qXQtZmtM7DLSOO953Oh0tYw==",
                    ["#=qAV4CzdjPW3IZDiwzlV6GIWVAluL9suXEylIEEqCLYbo="] = "#=qr$TcZWJXWzuxowTVapGILYobU6D9CP_lPFDAMxr1fgM=",
                    ["#=q$O$gf9I7bzZdwgqIiTk02g=="] = "#=qq2dMCp$12NIcLCheC00KMQ==",
                    ["#=qLuB5ioTXqABowT2pyIz5$A=="] = "#=q5ASOZCR4cKQj$x_r_JHgjQ==",
                    ["#=qyjQEGzp1ghqgFYklHaheGA=="] = "#=qC0R7xt$A8tIaj53co5BmBA==",
                    ["#=qIk_JiT7A0W_9$p3MWZduhw=="] = "#=qvFuvI2_ruOXtm$ufE$j1jA==",
                    ["#=qzENNDDTd_0Kxmf9yxFYfoA=="] = "#=qvOYIWX6lb5YFEydJOM89RQ==",
                    ["#=qjHQDs3lx$pJpBUZFOlOIJQ=="] = "#=q9RtQnMgD58HSKw0KXeIDwA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUwJvokdsmV8I7YitH_m1SA=="] = "#=q8wl0$YJBtBVJZY3coSS0Aw==",
                    ["#=qLvbc5yVYmBOGg12HZEkNHA=="] = "#=qEJ797qTPBMEeB4Q$eg9PxQ==",
                    ["#=qLGJqiOIbjT0g5nFbS16rGw=="] = "#=qOgtZwEStGpyaW4J025zfXw==",
                    ["#=qw4msK7MM4soXmUHCMaZlhA=="] = "#=qjU8VXBkm6gSaQFu0HGzx5w==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=q3dd_o3MlBao$KF0h6ddxtg=="] = "#=qtwxraA1lDW4IWtQqlAWVWQ==",
                    ["#=qkPWz6oc3f3dBQnxLHbm$fQ=="] = "#=qa8z_EzfntlFpoAip4a1pwQ==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=qYkbAMFs1sGIh31NQaeNLO41I$rUA2DfiaNnuV4qmuis="] = new TypeMapping()
            {
                typeName = "#=qbYQlBCn5BNkqQ5q69yODEF7rhW$GnVNYDgbvxq9KbOo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qGQG8Rn$69TY1rnLtPzVwhg=="] = "#=q4zaMev5uWScy$U7WAED1KA==",
                    ["#=qvuT0mK2u3cRdiv_T6k8XrQ=="] = "#=qdoX9rRnm_twOGkgHVEMFxQ==",
                    ["#=qPWtRzYjTjnZ8MdOGN340IQ=="] = "#=qeSU10hcwC2WgQrOl8U_GXg==",
                    ["#=qCa36xU86Rgg9HGNBaPjHHg=="] = "#=qP3exH7UtQIPGEDr3gWF70A==",
                    ["#=qzUthuzzv7Yr3ziZLENkilQ=="] = "#=qyCRl3S6uuIZVJjR5PyYe9w==",
                    ["#=qpTj_jZaTm8MsjN6vGl_3Pw=="] = "#=q9ZTa5zqUiKu1Yd7xVoeNpQ==",
                    ["#=qFGofQo41e1sNLSs76EOwjw=="] = "#=q56t4D8Xazf3kYT2hm8rvVA==",
                    ["#=qyFESURIh7Yru8jX$Z6W7PA=="] = "#=qiyeYVint2nGxHGIYSd43uA==",
                    ["#=qGEPngsLDRBvcGIRmvJSOTw=="] = "#=qOyysYQO0$MMxYvT_wT15Pg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    ["#=qRFmE_xT2J3hwM1Hbcaa_Ow=="] = "#=q8znQT4wDylQ$zYx5bVJpEA==",
                    ["#=qfA$u5aSS9zRsxvefbDBn1Q=="] = "#=qgg1hXvf4qmDDEc$0y3v3dQ==",
                    ["#=qRrMGUUP1wjVL9mPg2QdFbw=="] = "#=qGe3Yg9ONsDrhkUqrDSSfJg==",
                    ["#=q9hNMuPfGfiv9uhC9oyp2JA=="] = "#=qVpPHv__eznZFUZ$LZ68yeA==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=qpHpvIk7_tyHlNOQfeUX$Zbsq2ZuM3C5pCBiSnNjGQcs="] = "#=quX12DoJiX3HZ1OgthHNHXDADEpMVwqfEcN4WsegKCoM=",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s="
                }
            },
            ["#=qymShyfhoLce$CC6ln_b8hbB8KW30ZEsvMxiWtJspT8I="] = new TypeMapping()
            {
                typeName = "#=qUVcP3WTH0AJ032QKoaAITno17_nERpzTLqqPm8mxNt0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qqvzE$LE8cs2RqEHYoKZnbQ=="] = "#=qf3vlHbBmH6oDjzwKJ8vkCQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qPAdyvZIDReevP$Vp9qOazg=="] = "#=q$0g819GpVjiCcmXXHiv6uQ==",
                    ["#=qxyqQyyT$oWpA44gdwbKWjw=="] = "#=qcPmLTo3xwCxDa$6yKqPywA==",
                    ["#=qSpUbLy60MS2Q1HsGi_0EfQ=="] = "#=qC2dRslGfwYnWMhvROq5wMA==",
                    ["#=qERQ$MkhfI22CDc214YUhCg=="] = "#=qXAuXXVHvxZpJBQPrkYt0AQ==",
                    ["ToString"] = "ToString"
                }
            },
            ["#=qyNjfXv3fnacLBNXMDMBs6Fw6u70JjeZH$MUcJek49ts="] = new TypeMapping()
            {
                typeName = "#=qQUM4PBdYICFo5XjEXbwmmf96f0gQcOhF2WNqX28wE1Q=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qaItM9V7qlqEqsC$foAa91w=="] = "#=qP9W2pDbncGEZ7mqqGjeTVQ==",
                    ["#=qn51LQMnd4OZvw98Pma5a_TIPAreNhZIOKZIIIduVuQ4="] = "#=qucy_SUcr5xSowDDrFMbcNDVIBHeVmAxVhUKh1kC$S2w=",
                    ["#=qAOB1s18lXGFSzKAhwAhNcA=="] = "#=q478cJGImGVsHAp_INulqIQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qcIcyNpew6rWZlPhbfh2Y5A=="] = "#=qfW1QmiCCLMnhKlAZyf6tSg==",
                    ["#=qXc2X6Nz9sAm0GSIbfEvjaQ=="] = "#=qh3kNWB7l9LQcEI1KI6RaBw==",
                    ["#=qOMR5j_yJSDCzqpF5dtNEqQ=="] = "#=qTOVMi9j6WYx1YpIrZJc_YQ==",
                    ["#=qEEYEFr2OhPeK7agBOZ99aBx378YadKXm5n_NPlWW59g="] = "#=qYHxoaXUVffy_HwVwATLUD7ZJvh59jgfYPzmMGmHNJIA=",
                    ["#=qGHGm74pnLtbx$2iiMTjr4g=="] = "#=qKBotUpxMB1X5zY_tHKKrLw==",
                    ["#=qWDsk8Z4uTfsCL97pSKjXZkNRB3QVmSsSMcBvvGklmTg="] = "#=qjKCWeqH1Jl8xK70HLHcRGXTNCz5m70oI3FSs3uhfOA0=",
                    ["#=qlFpqArmfEwrm_M9cSz8C1eILMtIjmhkmZmjqljJBUsc="] = "#=qLdYtV3OVeGegFHg8hIUm6TIr56_uOeLgXNpGPxYDHLw=",
                    ["#=q1A3n_bHJUv7VRFQMHpgysQa_egK5PoRhYvaicHf_zE4="] = "#=qY2eCpB89DbpFxVUmvU4XRZcmrvxKoxFRGElqQYfbWCA=",
                    ["#=q7DXuDgng1vSlX_GKY4bwckDQt23e3YSgbEaVDsOvtoE="] = "#=qMyplnLh4ee4JyXQOrjHQGGfwaweT4ERkopBL30UUBCU=",
                    ["#=qW1LtRLC6PSzit4dvMIxYMLQ87T$4Lot9NxswLbZo8VE="] = "#=qAMKfH$WbPn97HuHd_Ysl31jR_iL1gSQOH0yk6Ky653M=",
                    ["#=qHT0j5r_dHGD4GlASQSa3LidlPVkAyLyt1rD1yuKcCHU="] = "#=qYe2vVlesplGEIjE2gMdmXOxcRAW99InUKGRQXeGNRMw=",
                    ["#=qYEaecTHG3VoBeQvzlSbmGG1QEYeimR21MG5sOn3sLJM="] = "#=qbDIKwbpAo8MI5G2GJd5UrEfjDDYpYEMiVTrIN9kg5L8=",
                    ["#=q8IhWnYE0$NmyS0il5XXaR7Gm1IGQfZ7ov1$k8A39l6Y="] = "#=qwP77rvqfK$s5V8KbPekTqp7SXyJRsbmguupEt4kFmD0=",
                    ["#=qlj0$4SRVeEEpVuu6J1s_5g=="] = "#=qNFnWpaoHIC1hQKtv1niR5g==",
                    ["#=qjTTkYhWvLSmbpTH5VhBmcA=="] = "#=qkncouGlz3nTK18JzwrA0zA==",
                    ["#=qv20_GDfe9t6iifXkiK4wuLM_leLVefvvhzBOdVU78Wc="] = "#=qtRAcz9ER5qBhUYLqPTO_IMfIULD3h3TJ_Ad7qvAdelI=",
                    ["#=qqgcGx_yNTuOW7IOb1WCrEA=="] = "#=qtWltMNBTupMYFZHPCLw6Ig==",
                    ["#=qTb8n5bUa2mnvuN9LKlgEUZe6G5bSgGZvlWdkhQkm2Qs="] = "#=q_RnJNYiwE3fQO4Q0vKls$I$Wfy8o$eZGYDY6mcqZF8c="
                }
            },
            ["#=qYRo2m1j69Se4pQJg7kP_HHuWlOd6L5h8YGH$hZrWwcTWFX5cA7o35bKoIQO1n7Sw"] = new TypeMapping()
            {
                typeName = "#=qelo5ZwYvQMxH0m06U3A6xfLBRFupAVIOzwM4H9kWp$Y21OWtrQosa0hefDugNv_s",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEQPLy7wKzwvd6pQssklEkg=="] = "#=q9kvzOeZ3JMrW7muuWfaROA==",
                    ["#=qwI7VorR0BF4hvp2QqXR7EA=="] = "#=qpmBWUzJJpx6NNNF5u2gqJA==",
                    ["#=qHIAOYk2sX72yTX_y6uKCtQ=="] = "#=qwZEemThjNDDGnI5Pj3uVNw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qJMdNjqho5mGkTXMyWanqPg=="] = "#=qqHqACeCXfaG14qJRq5Im8A==",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA=="
                }
            },
            ["#=qywe$cmUus9b_zw2ErmgoI5LfmVAmB1w7NfLtjxaTDOs="] = new TypeMapping()
            {
                typeName = "#=qeIPgR8B4CbReu5nuqxMAJ1Abs3ZlhSuK0Hv8Pr7R$$E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qbpdnMQUI9IrB5ZB$lzA1oyAFM$3IpKcD$un2eKZI8sU="] = "#=q2$rVgHzlCYz5m0phKU0asfvC9cLcKFqZ0wiZuco0jGg=",
                    ["#=qkdwm4i9GgKyLQeowOL3L5sEObccU0vE3HWXTZgxhLt0="] = "#=qf3i0uwGZtpBQ9VmzFZofd9CNyq_R1TxX_L4IgjirJOI=",
                    ["#=qdwuhmAeIEAi8WEcm_oOXwucDsIwSClgzZD733$BVwaE="] = "#=qHOrj7WY$clYPS6DeH1AIPWBOvzRCMo_XEjUnbv7hrd0=",
                    ["#=qtXYCZnUQHcy1SO7$438cKaTzNlc4Mpjs7j5s1RpXSHk="] = "#=qtG82jAq5I3nNDsq7nuyT3QOhpGdngMABI0TTq2HXFu0=",
                    ["#=q6PYvfLJxME9$ODPir9NQ7q6NgMzvQXThqfDCcbkM_nE="] = "#=qI7GHD_i0l$t2uSbjz6GJpIDRLO8qOcfHh4WmSjvN$sA=",
                    ["#=qrHJeafhge0evjP5CdiwFrA=="] = "#=qe3Gs442uctky4uLpZ2WjzQ==",
                    ["#=qIMHpKiCRlr4rECFuDrdiHg=="] = "#=qBZe$3IuLGKDTFKuGHj1I5w=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qWQJ$dMDcjxjokRp8n71Fzg=="] = "#=qb_VspxdNNUgbPUAsWODFTw==",
                    ["#=qIX0HrwfMGJM9q8zf9dh0nIOJXqrUwAYqTZnxe$S1Hl4="] = "#=qdWgkUljnZYJQruWjXxrqE11imjNLbOsoDrjj0IJtOQ0=",
                    ["#=qRzBNFsc9x3OKuCI0p8sV$A=="] = "#=qeaQ0HTz92VoaL6h$U_990A==",
                    ["#=q9Ex07pRytRaKkY48g$vUmA=="] = "#=q94K_inlbNQSwyw4m53lm0Q=="
                }
            },
            ["#=qyxvYEyh_XXczKsrp$xbt6wfwBBN1WtKbUqnePTvB4WTRF1jUmhQjEjUWoX_0B2An"] = new TypeMapping()
            {
                typeName = "#=qWAED1CL4HzJFonKa07GmsbFSmhdM3Qa7twS0OrF25DTFRe$Yos6Go5sn4JmqP5YG",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qxoFpVDbUc$85RddKKNwslQ=="] = "#=q3YUFnqxLgAacNIn4gIfpxg==",
                    ["#=qn1wcwk56vEkWvMe8uwQmX7mxoSfH_PlIcUbzlQT79dQ="] = "#=qAaEN6AtFNZpjYWyRumJ2xCsgC_5mXViis$16igpoWUI=",
                    ["#=q0Iy0spSIkDeYpf56Wv$LSv1xgC7_2tQNw1U66lq03gQ="] = "#=qi2AOUm5XTLeUPqtwL3gaOkk3EH77gDs8fInbHukOico=",
                    ["#=q3dOtpAVsy4si8nCpwB8Z5w=="] = "#=qAqTzoUfpJcN1STDKOtmswQ==",
                    ["#=qpfj4sQzry0_RXuY4Vsc9Uw=="] = "#=qh4HWRupQOTojoVGRsX$N1A==",
                    ["#=qKROTf6KlXacqduSQwTkGDoqGxQfr46u$MxJvRKJZ45g="] = "#=qVttena6$QN799x5bduj5qqb8NpJIZJf$QkrNitPRCxA=",
                    ["#=qnfa2zPbiBK$WT59rYsVp4Q=="] = "#=qQbDRGioDTQfoLLglnWSmcA==",
                    ["#=qzvEWN2DEbrmb6EjbrLXGwNqZwya0evMEJn9CfOs8aa4="] = "#=qsPVGoOrxnmlrRnpcnPEgkXRmxafbuGN8lpZxyn1dcTQ=",
                    ["#=qtXpgtXdaqhJnA6ugKkSgC_Ry7fauwYOcfjq_PM6PziI="] = "#=qk2nn6xlqGzGAKvDlVdneABmV8XyzJotAMY1P7Xi3y_0="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qZkx7YGZaSxwiIsSOJm7CCw=="] = "#=qihYl$av$lhgdYcrc7rf8IQ==",
                    ["#=qyprUNr5PYDLlo0sqHUD1Lw=="] = "#=q5bXtkzQuZMYFROt4Fz3odA==",
                    ["#=q7mwd6G$UIucOT7w0Sw2K95B_kFf$2GvivjjSvV6p9DA="] = "#=qa_AGBCdBrEApM3hl2VIohHc17fQhRd9XXcvkgBf3D_E=",
                    ["#=qMbXJFFhrpdQg4VxA0sMGYQ=="] = "#=qOsG7HEQHRu8rstXxvO34hg==",
                    ["#=q_J4LWziRyUs5S0FyKZuoMmxYr2IdZHuH9s8JZOuTao0="] = "#=qPMz0JTBjpia96AAO2biNuvVfBiTtr$u7NnvpRCjo$D8=",
                    ["#=q8Xdpv7r6Mk2gqupF2Ni0uw=="] = "#=qikPTL_8kBtx$k7QREGDTtQ=="
                }
            },
            ["#=qYyGotu8HEOouxPb993$O_U8N_Ud8fIGDlhKqN5b$rEQ="] = new TypeMapping()
            {
                typeName = "#=qtVBXUAB$NjQsO4TNSpF0FXrwu74Y0dELx3jR4EVpfBg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qtB1H9vmcrZJm8bkOkCcdQQ=="] = "#=qGRxwKWbSYbLsr7z0f0IEVA==",
                    ["#=quAFaYApFx8TMNWt2cmi0kQ=="] = "#=q9y5_oc$59JtbUk7wUBcgxQ==",
                    ["#=qipWOSNZkzBM4JGUIzWE6$Q=="] = "#=qDnQAZIWNq$6iy$1NT4jDeQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qyyh1CiNAA8$AeF3S0f1itNyUb7JovA5UoS2I_cVpqL0="] = new TypeMapping()
            {
                typeName = "#=q_kZBoSY6VAb9iwlxdXfK4KEXFGmdkmZi$yKSNO0Vu$o=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qERRrAhE2NRyeLNABPSm6_g=="] = "#=qgG4_v$HVk5c3LopzjTlLPQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qz6qwRK7eWCngqBAMoztYeEO9kjecyNaCnTQJFRYAXgg="] = new TypeMapping()
            {
                typeName = "#=qu65sw5LCa8vu0v6fotSsGhYYvpxVfhgUNh5u$luf6zQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qz6qwRK7eWCngqBAMoztYeLs8f_FlWdLhDKz0a2hrxe0="] = new TypeMapping()
            {
                typeName = "#=qla11SCPapeeK1TX1JCxbRgUuiEaw63CZIWHpQOfr4aY=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qz6qwRK7eWCngqBAMoztYeP6OUemkA6pfPFLZTrBKn54="] = new TypeMapping()
            {
                typeName = "#=qKVUJrfmtuSILxaMGhID93uy$noAkzaOJt52mhR_qGFQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qZBoyrzQj20R8rdULQBRXM7qExfsLwLcsPh3gIbcTweY="] = new TypeMapping()
            {
                typeName = "#=qcY9VCeA3a2kMsFXAWnwDHBqIc0u8aKR6$0fcklMvB$Y=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qj$5L$F9VC76Fvxx2GEImy$OrmOPhEEHp4V3nobYp3rA="] = "#=qk2b$2umNHuP5L1KFsmYTXlkq8zx6vW7S8bIoEiCLrgE=",
                    ["#=qHi_s1mWH52c79C4o2v61rSsfCZ$qs3xDkgqhWZpMVA0="] = "#=qRCutV56BbXF4WAl4$UHuIYxsPVuDAphuV8vzhHh3eGI=",
                    ["#=q_CyJMt57u4kvOhJiMRQahQ=="] = "#=qJmFmQPm$o6lwK9wgOmU3mA==",
                    ["#=qUD7nJ2IzPuFxt1lQCojlau6Yg$y12maiQ$umgpfT7J8="] = "#=qWTnrFvtZHZckieAr3_Lk_ilu7JkTC93YCB4ITgsh7CQ=",
                    ["#=qHmS5lBQyjCaeJW030ByF_FLcWKekg6iVip8S3g6_ddA="] = "#=qAXvLD00G5wXpK6ElNdWqEJMudsqBk0idDs9VkChdNXY=",
                    ["#=qR2yUvrxa4rf12tOvzf4QRH4h5HZR5O6On0z_AbLH0VE="] = "#=qcXhq34DjSbfvnUl7l2gf556NQ5Twg9JQhPmq5VsFou0=",
                    ["#=qLYl9zzN5vkqyCOJRCHz7ZAew$oJy59D$$xDFbye0YEM="] = "#=q5TEaRD4JCKbeMyk4fsqRyAmnHPuBntYBSqawxgm9tUg=",
                    ["#=qtlAr7X_n3WfBdUy_j8rd09LCftAqDD_Z8yaIh33pr$w="] = "#=qfBXdgxIJJYW3Nu6GNCo29T2nv0P9bglBXVZTOLjw860=",
                    ["#=qRO5I5UVZf3Vegyep$xbBuIb_sE7d6J$Jr8PeeYbUsF4="] = "#=qxmGb7pzN4UKetCB_G1xTaC6Wuy23LhtYXzS3qc3VsgY=",
                    ["#=q4rTpYj2cnw9LLrgooVf6UMqoKJxZTZwuwdGIcLKc_IU="] = "#=qp0fn0J3eIeX_wjgU3met4uHA0bQOdXxNcz2Fq1PsGGs=",
                    ["#=qL06Ic$5Zo3s4Yel5lS8sMlSs1RlUN3Cm26kzzwpRJ2k="] = "#=qKhRmRS77M1Lzd9KpjaQKWI36HU_xItK1sdtE$_XEM7Q="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q2DLEkfhB0eEb2hLIxfv8zvfEmZ6KD1Qc8okd$vO7QAA="] = "#=qlu1OEwN$1SeZVDiYhnhGnYLVafzOVOcRLx70OGhkTL8=",
                    ["#=q_D_o2O7G28WC_WDR1HIP5LNNBpCRIwIRF0H11C7wfZA="] = "#=qTYKzVRHRiZhDAQOyz1Fxt$XyItv08VhQmFc12aD3U2s=",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qqUmNo$37urnEQFFO1UPAjAabOZRq052vPBxTU_7zdkQ="] = "#=qAPzPkU5wrr5Kef9_pFAJ3ANzr2gZdaTXZF_R2fAsk3k=",
                    ["#=qkLiN8FUt5uFW23a$j6fsdoEaI70Nkhq9W0mTO8wVK44="] = "#=q5SXkM6vMO6el6_FbF_hhy8$AwJwfDF61kjcjXJRV4Gg="
                }
            },
            ["#=qzdwd9C84rrTRdPvL4Tk_npulqfrA7KR2_$FJRqkJrm4="] = new TypeMapping()
            {
                typeName = "#=q_c2LL9TI620febHI7tF3DYxt3JIYNfcBheAzK6PgAUE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEth4a3l9hd2eFdd$gCJgEg=="] = "#=qSYejCy_LlcOMCZvuENiD4g==",
                    ["#=qD9HEFUaBb167R13IXs2BEA=="] = "#=qC0ILl8LEAVKfe8pMpIqgUg==",
                    ["#=quMZx0lCAgooNPk35ZPNkTQ=="] = "#=q4htYNyakwJXX3AAB20afFA==",
                    ["#=q2vve$roQc8HF7lVxgqqRBQ=="] = "#=qO3Z$7CvM2LvIjU2opRh_Ng==",
                    ["#=qjejfNQWHiXlcgR0OXrE83Q=="] = "#=qTSz1UNHwpSVM3yEUhAUfqg==",
                    ["#=qQxdfCBIfzpo4N7vuArAnapTq6$r1lpgkIeWGdFnxtYc="] = "#=q39DmSR9S8eBuZIFoEGGovffVSFydyI1P95VBUvJ3j7I=",
                    ["#=qkIp4KW07k4uzN2lFY1xzDrSay$VrlWn4zgtopgai9Zk="] = "#=qPmM8ChLk0pOurtTlznEFkUfDXVoxiYoowR$x7HjPz9Y="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qyu2$$lez16U4esyFynQkgg=="] = "#=qxxKYYK_3To_0TU11nWvRbQ==",
                    ["#=qVNMA$Ffm88fV1FTWH654ECFc_HUtXebhUlBOuOuO17A="] = "#=q3u3o9C66GDJKxpQjQTED$lyHASAaPJuzRuY0WSXw0U8=",
                    ["#=qbeDUMzmqbnrb3hM42wudGw=="] = "#=q7v2Ztzp$LTzxJSFZz99eUw==",
                    ["#=qqoEaQPCfWUFe8UDSaQpdLg=="] = "#=qT1ZepkigACFSRbskF_XkSA==",
                    ["#=qtkFIJ0nAZG9I4q$vNmO9OQ=="] = "#=qEXZ1i22ZGQJgae1VgERojQ==",
                    ["#=qz4hoUEGSSvQ0QPjfd4nK4A=="] = "#=q$rbHhwApjG0P1o8WRwqwsw==",
                    ["#=qaFHCvWEmgq1tqFKTchUYiA=="] = "#=qm$MxVgDvEbtRhfsXI335aw==",
                    ["#=qHPqisKh0hTJPtAsA$fdoNw=="] = "#=q_b3C4Iok8SjnU7sLip8xDw==",
                    ["#=qlmeJkkWk1MAX6dZrIfXoPQ=="] = "#=qc6VhnD5nLvUnzrwQY5Ah$A==",
                    ["#=qBJA3dZZQpgC7cp0uASfZhA=="] = "#=qLQUw4NVi1qxshkcTehTT0g==",
                    ["#=qP$CZzhAhdsXBBaA8farCzg=="] = "#=qQr4k0_kqT65W2ETrXmt3mQ=="
                }
            },
            ["#=qZeYXrtOJ5j$IGcYQXGvBcQltydfgyRcQ4ciBoCJGRj0="] = new TypeMapping()
            {
                typeName = "#=qJTweUBQqVAhCh2D3Zk9ymt9mrZxjv9eoYoxpzka2nQI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAz_5O7LThWsy571Z8Ej3tA=="] = "#=qVHYs_iYFXv23I2ci$DtYYg==",
                    ["#=qkloKhhh6eVnqnUjSPrvkOg=="] = "#=qY3hAemeX9FozeN98kNjQDg==",
                    ["#=qSP$M8j0Sct2idXsZdlZAxQ=="] = "#=qgncq4FB5tzeNXMcrFWJsTA==",
                    ["#=qhLL1AFzzx12novKpli$7RQ=="] = "#=qBedlZHjfkjB8nITsXV$lmA=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=q8UhzhPf8v$Psvo65xMNZVQ=="] = "#=qSFl5u9_AMDBSQkpKwQMRYg==",
                    ["#=qd47BgWyoeejkx27ackRisQ=="] = "#=qXghcmmmrINL1ldhXXxmeyQ==",
                    ["#=qW$Hysl4nzW7knqDRBYFlVA=="] = "#=qoE9C_5B3fYFdSSJ6ajCB6g==",
                    ["#=qjM71QGFEd7gkB9HvhMugOA=="] = "#=q98lSd9uUJBBG3kVqCJGwfQ==",
                    ["#=qzkzhoJ1o9tskXBTO1Fz0eQ=="] = "#=qvSSugSNh9vKGHh6zqnx0ew==",
                    ["#=qY_VJ0NICSBZ0Kwnw4R7HGw=="] = "#=qGURshx8SZsPsyCJr$2wGEQ==",
                    ["#=qb2B3yhjikrI8e9CsRTplew=="] = "#=qh05mJflMR6C1Q_DKpjdNAA==",
                    ["#=qYxZVi86Du7l$UCSEp8iyOQ=="] = "#=qOhDjIgte8fYgzjLhEGEexQ==",
                    ["#=qoAzaXZ5MfB8fa3DqyrFlLQ0H6qoT$HDx7nRu8ZO8pvU="] = "#=qrnR_cwLB_gEZeX$ZgqlzP5cqHjmFoDXZlDPQMeirmro=",
                    ["#=qhYD0RUpN4r0AOYhwDBd1fg=="] = "#=qe3nDsy1d0f_a5Y9mjohD5g==",
                    ["#=qsU$21KbTQTTFp1yB46_Hxw=="] = "#=qtYaY0rtJEBKnF$RzX3OH4w==",
                    ["#=q2JLEqT_ifE1h7bNLbrD_zg=="] = "#=qVAsaWph_ZD3MisA5adio9Q==",
                    ["#=qqmomkGCV5QikQsAyZJrNXg=="] = "#=qP3Jbb$eoFrPmqznQ4uNcow==",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qf2mWxduIA319HWcsuNr3nQ=="] = "#=qTAbkzZ7xO8kTmxXJYMIFCw==",
                    ["#=qfPLVJV92PLcXHf4GbXOsKw=="] = "#=qQo0jnxIOi_XHlwN3wlarmw==",
                    ["#=qoETwogFn4dwuc1OgUsRWXg=="] = "#=q1CfEkGUUQhzGXcoAqAGV9w==",
                    ["#=qaHxOVAHS$yRH9tCBjBMdmJnQmzaXW3LIum9xbVmUjk8="] = "#=qVTAe55A7I1TYZoGu1ALQsvCpbbXgArY_LY$MxQKEhio=",
                    ["#=qs8Nlw3NDQAjoLPqW6KCu5w=="] = "#=qOyakR2cCOSEovpHaAtY4wQ=="
                }
            },
            ["#=qzflJSnTnCGcowF9jzZq7KuI6xIXnPu4VlfzhGP2Cr2KP4tLADfxKyY0fpvWbaaG3"] = new TypeMapping()
            {
                typeName = "#=qo$nDEatBJslXpVklYJ2RIBUta_VhBIxM8WM$t7S8bKhlCsv8DVAcDatvq4aGfJ8G",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qDA$o_1DrJiLrxmGPK$GkzQ=="] = "#=qDjWjY3Sj7J0Gi5lqoM4zWg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qTGDid3mjkUF8q6Z8N_OOUw=="] = "#=qxnwJpnxqh7Vw2rkVHVb5vA==",
                    ["#=qeumt5xWsaDcGhmHt_Yuz8g=="] = "#=qK4gB61Dd4_9Euzxy1cf1yg==",
                    ["#=qgzizvToxmKBMcnRommXUhQ=="] = "#=q8GTnkUKBpb6x76wkaAfS1g=="
                }
            },
            ["#=qZIglpuberKdwZtTj5Siubl$FajCF2m0Ydh7j0b9UL2E="] = new TypeMapping()
            {
                typeName = "#=qeQWZuCVfLjR198IGLXlhqi_tMp6i8h7gl64aDflDy04=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qzmBMSF_LTshDTaytOo20qSpxzo2bKpmzWiYEs2jHGxc="] = new TypeMapping()
            {
                typeName = "#=qhEigH0Iw23UsdDyi_BPoxt0I3k6EHmX2GuEsQQOFjAk=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qzMEZMr9SKcbR3qzXYmOQ0CFUpn6U_cpqA2mUaXByuGr3MrWM5UMFD3Co$LFURGPG"] = new TypeMapping()
            {
                typeName = "#=qNNR8d0CCCYIp_eyDjD4jOt9Ctoz9IdrrM9pcKTvq1jPAFnuQXW5j94PUPbuW95kY",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qNUedJXp_g7FFXGHBtgBYGA=="] = "#=qaVq2nUz$Ug7zyea7yVt_CQ==",
                    ["#=q2sDp3_dexU3JVbnf6d_EYg=="] = "#=qqD956HTM3rKuOuy4Pj1HNw==",
                    ["#=q1DtkwzUqi1B31H4Ems$ZiA=="] = "#=qIuELnHUk7DCxoMOcnL60Wg==",
                    ["#=qOCDu8WJNo381WeN2ZlFfRyOJmc5ZY8oSa_kehJQxrRw="] = "#=qMfZex7SlMGagWutOD8CX4S2XbFaITETlQYten$npDHg=",
                    ["#=qOVp7St1UmwdzMkdBIMB8Wg=="] = "#=qOSQ4hLjcuL0y3v_vUHE8Iw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qgVDQrkttH7i02Y9qIdm$UDolfXQbXkTh5kUdWiD2_F4="] = "#=q1iozE6ow_tmzFX8$hLnlSjBakyP1icbkUTSyip08t7g=",
                    ["#=qQaAgjh9Spv9ebHyH74QvkA=="] = "#=qlqkNnMBV5k0TkkPmbRJpLQ==",
                    ["#=qYu_KbfDZqcpqJIPrCIT9mg=="] = "#=qV8w_yjTYMceFUWJO5czl$w==",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qzMEZMr9SKcbR3qzXYmOQ0KVJlBbvXePl8mdmof5Wn19yiwGuhmevtUxTunWMRm5ASKEVvjQoe4eeib9Wf1l_tg=="] = new TypeMapping()
            {
                typeName = "#=qcaiTEWxJTIxDmqhCjhxUixER0nbjnkFe7wsCYu4x_pxGFDDRYzZCLlmcIH06jrRG1Ts0xADDa$tdGrZoxqJSQA==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qTuoJSbE9D4zxCjjChU2k_w=="] = "#=qDy4ESWNBkIAiJ_oHIRLeNQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E="] = "#=qN_4O$dDDk$2PPhPaakNavG1wVgmrgyuNBdval4QeyaM=",
                    ["#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY="] = "#=qcq9T0C3Q_Tvd0OQFhXis41IS4yznWWAePmHvJLzwo6w="
                }
            },
            ["#=qZmVouIwdOUk3rgavS2kQXg=="] = new TypeMapping()
            {
                typeName = "#=q2kSaZwz$U9SOwjpClHm_yQ==",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qS4unN0MQxgW5Si8epsBU4A=="] = "#=qj$EKRyCRrqnSgL1b0ZvrNQ==",
                    ["#=qs4qAUQBmoo1RGnumX5PXM9KqWFVpAi_9c1AC2zaJOwQ="] = "#=qXd$kncA2BKfgHFvqKOli6UbluRlnpJZKtDaXNzSN8oA=",
                    ["#=qJNd$jbxx5Xt$bbB4U8hmpNRRUUUxxQDWCSEYr9$cpGs="] = "#=qisDrpUEK9fYp8Dh4PloNan2jpTxhv4m_TGdYCEnFcac=",
                    ["#=qx93jY5BAa60qPN20xDbUbdtttalSrievUve87JPANTc="] = "#=qfwMiYR9ufboYsGvJbXhRlbWKJOzq9Wp_T4XEAIxjqlg=",
                    ["#=qcegoc0tPzOg3I6MLjL1oUg=="] = "#=qE2ZZTZ6o8pgLEI2irAYM6g==",
                    ["#=qiGJQt8w3PM8Fgaj5DI8QWg=="] = "#=qpg_Mxjf6a$EuBonNgRNkRQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qojWtgViAiCHMHDI5UC699w=="] = "#=q_gAXMGxNb2sdBrRQTNcsMQ==",
                    ["#=q7n$fP13oGhsBLJT9TZqSVQ=="] = "#=qlqs5ECMW0V5gHOWD7c7HRQ==",
                    ["#=qP$zaMfup7hWMBSbziLr1pHL_JT_q4fwUf$A2mDYcU6E="] = "#=qISPAdDj_IVAcVswdEYtW_bnf_5fCfbKLQzOwBrlXN$A=",
                    ["#=q5nz4BWCd7rdyMfM0xjF7qw=="] = "#=q5nz4BWCd7rdyMfM0xjF7qw==",
                    ["#=q9RHikyM873QBYoFuAOeIhQ=="] = "#=qELD6PO00s_g9nmBwOU5PEg==",
                    ["#=q7Sr3YR90EqVpJzk$lsYNWg=="] = "#=qGVpjQqBGN_4DwAleBUyYsw==",
                    ["#=quwJAXM8JuTk9OPK66yTq4g=="] = "#=qTf_iHqpmbMKidHEe8pP3tQ==",
                    ["#=qhhlsFrdvG4LVpFkqOskkaA=="] = "#=qK2G$fG3GCb2PYDfipMBivw==",
                    ["#=qMnm0V4FTTjvhj06hg29_2A=="] = "#=q6cndWcIbWd3h$gayrx6Vdg==",
                    ["#=qWGlLAL6z6u5TLotUbqx4LA=="] = "#=q1ZkNEOZ4_ZxIRotvQYRgMQ==",
                    ["#=qLPL1nmUeLhbVdXcMT8o$Qj624VhEcSUbaT7CRuu$j_4="] = "#=q9Vi1paW$aoCoZ4xMXQbrVa0aWChjIsutsYAcyiUN3tA=",
                    ["#=q9Ds5bBTEp4AxD$R3f4XqmA=="] = "#=qyJXSdesY5zDnIIHo1ZVZkA==",
                    ["ToString"] = "ToString",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode"
                }
            },
            ["#=qZnp0TBS9R_vt1AlH9LD$td3UxoUN4JCDq67bw5oVyik="] = new TypeMapping()
            {
                typeName = "#=qv7er1RDx9eQlciBQxk0KLbYZ4aPe6W$tE7aQVkS7cr8=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qU66a8rgUCQpdHJYB4_nvxg=="] = "#=qW93GqEOWe7sq36rxUiEzpg==",
                    ["#=qG$uakGoswp_y2C7TRsC2Tw=="] = "#=qI1fDOzN2xsn7N5DBfvreBw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qEEv1FZL2THrq_CVxCTvAWA=="] = "#=qMHLzqP4Jb5XFBas8bDAErw=="
                }
            },
            ["#=qZnTZuCLNl6f7zx3q92ZwB6c9sIVkzNFJs1lVparcnCc="] = new TypeMapping()
            {
                typeName = "#=qjGDa6ynHQybDCpQT4cejxFPKayDZT4389Ym8_MXS57E=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qAGtjh92JVXNnGvt3rX3qag=="] = "#=q77qhpMmWL2EcWDeav3iNvA==",
                    ["#=q4Qp7SX7mL3LMfSmxj0n7TA=="] = "#=qenCaX9Hf_WwRfwxO1kg7ag==",
                    ["#=qqurc15GK9DWbYalBtkc2Dw=="] = "#=qKJM8GGQtjgndkb_7JQ67Vg==",
                    ["#=qb$QTgAOi6LKjRVbJyCAmITVpMpagwzZg06ApzZraPsA="] = "#=q_su9B_zRXrVErCnO5ljXyk_tZ42x$n6IhVsfQXPSi04=",
                    ["#=qMHcwlbJ$mCdLkoUuttexKw=="] = "#=qHZufV47JjCGoYwCJocmEvA==",
                    ["#=qDsz2Bbrv9J5SWa5zlPXeLQ=="] = "#=q$gUAp6_aMKMUqJZxGVEpzw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qe72yppm6$nm_NGNdDpje8Q=="] = "#=qjAnUNKsTz9cQTG5ZXfFiDw==",
                    ["#=q34Bz0kpM_crvFe_srnWnoYJYtZZrAOr7qnCSUSINMoI="] = "#=qT9aakaUagU6L1LSmAx1afGZg8Ai6vTkafX_y6_VT0h8=",
                    ["#=qCQsOvjdD8Dju9I5rjnbrJA=="] = "#=qCmC5i$FXJZXYCcfdIAeTvw==",
                    ["#=qfT6wBjEKjxePm3MqTTJtmQ=="] = "#=qzkuz1gqqSvXlQt1P57Jzyw==",
                    ["#=qygk$$FezDZcPhEbc8bALPw=="] = "#=qnjZw_FylwwKy5pYDImXykQ==",
                    ["#=q8W2Rrq76dQbGDyilfEvipg=="] = "#=qEkQe2c6Xu8Fgeb3MSto9eA==",
                    ["#=qBQ$Bpf0FqknCxIJmJVHaZQ=="] = "#=qHTGZO3OETxR9HVf$DJIwMw==",
                    ["Dispose"] = "Dispose",
                    ["#=qcBfE0JjZDmBWI447MtWtJQ=="] = "#=qPy64aUn7VeDsEoo_pEWnvg==",
                    ["#=qNYXyqnYpidT10XzuD$OWp$0JOrnuHCHFFOv0PtIpWyw="] = "#=qoT7t522luV$QT$VV0qZRzy06q$V$nsbgtdNLr8YLPp4=",
                    ["#=qzUgoi4i8Gg1qjHf1QzYhYopA_jlkmi7UJmp$7rcYWMo="] = "#=qSIs1QV_iyhTdxEPASOAH0Hy2xhTdpzjcb4tYn$gByX4=",
                    ["#=q55qS$oqQIyOKUG_r3aLGyA=="] = "#=qur9BA$pbWRKsD0xVSGfqXg=="
                }
            },
            ["#=qZpxFu1yogIbYbsjjxx8kEZeFFPlQpes$eT$Uu3bDgSM="] = new TypeMapping()
            {
                typeName = "#=qogTNLAZwQYe4aLmWTpQLo2p$Vhd9hBHuXjip34r1IcI=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qLoxfvZAleSX$$2yi52cgAA=="] = "#=qB_Y4r54Xg0a1ynEbXhnXrQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["#=qz0$WPqAxOgLiYQj_WbzH03$hjI56mjJuHU4zXfFsHeA="] = "#=qasmnd92HK2TYW4KGI$FOpNTD_EB_LDu_TfnqU303Eu4=",
                    ["#=qg2PvkR4kGhKlmltHNBLDNA=="] = "#=qtCvpqLUATnlXfQwu4POkjA==",
                    ["#=qdlGn$K_FEco$bBYE28gUrQ=="] = "#=qY3fxYysff0ovZ4E2AVPM2A==",
                    ["#=qmXCnEuhBNkuYq_EVkO7PLg=="] = "#=qfw2f5Q$3c_ZGf5dBk3fUyg==",
                    ["#=q78X8fmC09HirABZ17DxM0w=="] = "#=qCRSA_jayzSAgFyIu0UbGGg==",
                    ["#=q2X103K$HxwUoSAF_nGIZVg=="] = "#=qT$R8$cA4SD36kXZ1Ww$G3w=="
                }
            },
            ["#=qZszUSIUaVit5DkLyaIBsf7Dvcd$eF9eCvkgGoPuAXQE="] = new TypeMapping()
            {
                typeName = "#=q0oCvT5_D6xnDjIHZEBi1F24KH0xOjQXaA8t4z54WjI0=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qOB1GWftZkSuespc3LMNyiQ=="] = "#=qeDq2VOLWlsjld8w$1F7IsQ=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qCJDfhkOgWfW0uVF_ksYJJQ=="] = "#=qGM1t8dFHd1v_FjBBcPsFCg=="
                }
            },
            ["#=qzTy21NC18LjeSDb3VsvZybLVv3B$ZNV5cZYGfsAQCm9iIXSbdUQNpAtSkRwTg4_Q"] = new TypeMapping()
            {
                typeName = "#=q7EMmU8LKk6JCj8JfAFLg6wA3sqe$tM_rTOqZDmWcSchxRxr0y5rmNHIVZOPQsEw4",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=q99WjuutMugfFtwHVwb6mklyxT0tkKW_O1ir56J$d5PA="] = "#=qlJt_$E9zwyKWivYOlsO_YWRk7mvEkb29yrSTCtRDSSk="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg=="
                }
            },
            ["#=qzw21PDVpgBEgpFsc1Bn5TthNWkRfIR00ae5kHzc3Phc="] = new TypeMapping()
            {
                typeName = "#=q2b2Pwht3knNp4rLXml7DWw6bgZlX3Ldq94GAiI4eyZo=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qYgWS4TToSIobtaQEp_tDBQ=="] = "#=qWWsvU3C2AcFTCnWQuI35Qw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    ["op_Explicit"] = "op_Explicit",
                    ["#=qiouyWXMai4$D5YRb1VObmA=="] = "#=qcK3mBnPYo$KW31ZSREz9iQ==",
                    ["#=qlRdLnYsqkpFrBdpSDihY7g=="] = "#=qjLGIqVTbZtNtmQLCrXLDFg==",
                    ["#=q8tKu6edpv0s9EQRVP4OUDw=="] = "#=qzkbxUUJC8gMdWzXPJjwHeg==",
                    ["#=q6SoEnIIYjVzC4VL65h4u5A=="] = "#=qzw2$6xJokgkJw_zWpuX7cw==",
                    ["#=qzfFKde$zUHI9X3NxnuJe5w=="] = "#=qLm4FrPyIu_aUU0BHm2mEiQ==",
                    ["#=qrbchLBQPJ2Atzw1cUc65qw=="] = "#=qTq73oqv4fX0zDhUT$TYG6A==",
                    ["#=qDL6pC3Edbq1OvMFu0xH9Bw=="] = "#=qvJAMM4kVCLh4k88JqLo0HQ==",
                    ["#=qVt93GgwHXrP8CWB1Urp9Mw=="] = "#=qMNndIUfVCXwMo_hdMhQWcA==",
                    ["#=qP9m_Drk2S9Y8__tOR0B14A=="] = "#=qvPr8SZYAt8RlhnxnC3GVqQ==",
                    ["#=q9BrWYIT5JL$X_hW2fxysWg=="] = "#=qngejppdg39PkI8GhA4$lkA==",
                    ["#=qRe99k6TTmyyRhcweePE8Pg=="] = "#=q4tHjlOHs1yG2AJTDxyTy8A==",
                    ["#=qgxQnZd9wCmE8YRIJQY1Pozi4LmpNv_2Bg4Q18d3LpCI="] = "#=qbVWQbYpfWUUyagkJO9vzsjh8FnhnypLWxRYd$oOa4$s=",
                    ["#=qNSIcCXJ2WqRP7im8GXdrlzTbxCumesjkPaF8CxaIivM="] = "#=q6REGrvR_hjBMmROyKbFL8hq2R81zGZdcAfPqYawgNEc=",
                    ["#=qPHZbuB11QrFM2kIm33z1Dw=="] = "#=qpgIIguwcdFVQyweifXe6Tw==",
                    ["#=qCoodQ6zeH8kYt9$OSwT51g=="] = "#=qPFC3WlIFEmdLgK6uIR1_Xw==",
                    ["#=q6Rt_BBreTivWqf7fr1bQPA=="] = "#=q5IpKuGlEbQWyUB2ZSzCBAQ==",
                    ["#=qrcCOSWrCtbRS1PD$ldET6Q=="] = "#=qdeISijq3h2vq4JS0HtZuTg==",
                    ["#=qvt1e1$POUCc1lVZz$uYYLQ=="] = "#=qBS97p5uRaXitGlT1EYJWMA==",
                    ["#=qfDMTCIghGlyoYmF_fQ$UOQ=="] = "#=qqTkNJ6RrAAoXoIvlq$v1lQ==",
                    ["#=qiMnF_huDZ_gmIgHP9WL2aQ=="] = "#=q9uXN_jFgqhYL1zzlG4sjmQ=="
                }
            },
            ["#=qZX_3h$N97YtF_Am7cvQKqtdNuKKBIymbh3Ay$rDlJiTFZl_Vp9$HKK64kz_jP0Bq"] = new TypeMapping()
            {
                typeName = "#=qXARJXa1OoRmD7uyL6pSUnA9xl5h6m1Vk5wKr3mZ$snolzS5JeSAEUbMhjzxeClvL",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qEyJ0BJsUvCu$Ldt6KytflrJ6Y1ezs41YeuSiLRsKWec="] = "#=qSsKlkaC8lfsHzw7E6uBRaVWS441$zYYH9gQZI2kvHG4=",
                    ["#=q1dk8Ded_6h5E5hGniKxjWA=="] = "#=qsMBSCrubgekdIXQiiHk3PQ==",
                    ["#=qKmmiBdj45YtyFTp9MndzuA=="] = "#=qVcOLHNPiccJBbKF6f81jpw==",
                    ["#=q93$cyUwm0SegP1blEYeLLA=="] = "#=qIcY9iM8ZydS6MgtOfcVazA==",
                    ["#=q6hGRutU2WasvNK6HqkPfnqABnMyuohKnXR9ELm9tmq4="] = "#=qWu1x1_J1Dc69aZJt6BK6LvC7Q8JJy5DBs_50kpczbf0=",
                    ["#=qQlM6B45YkHonDd$Ik9ImwQ=="] = "#=qDFC4RsZjzZy21hqLhyn7Mg==",
                    ["#=qKZE4aTHahclZslBGF2zNjQ=="] = "#=q_lNYomrBqIftTUHSxkn$Ig==",
                    ["#=q4fcYzMRrZ6270skdLHGhmzK7pLB11UeAn7_WkR06EQ4="] = "#=qVZvGBR5mSH3Hy1VQSBXvz50$nRWiNABcGUKQEzoG9Kg=",
                    ["#=qYaBpY6PNSuI2jKKEHIeIaA=="] = "#=qdQ6gswYZ98Xg6ctlFS6qSA==",
                    ["#=qTddmzv9n$KPpH4LeBqxKnw=="] = "#=qqjmsk83sO2SI4VdzjuPY0A=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qJe1Q_1Y2se_3UN_dElyT4Nwtalw6SIY7F4418EpAcvc="] = "#=q4GSmI$7arfD5S_Ot_sBdEExbfE94HdDqkK1PsIqw$SA=",
                    ["#=q2Y3x2eAkw6ftGUDGyimPcg=="] = "#=q$2vNTlKWQ1TKKyXge92lWg==",
                    ["#=qnEvNfmjLcoTsGwey9NIsrA=="] = "#=qYxBWf5KotueMaSWFV4FZYA==",
                    ["#=qw2jzvJ4nBXbOwA9qdUAaiTD7ts$28sl3Mlq6sf48EWg="] = "#=q02xUdsSi4JC3$kGT_4lEt5eprxppW_xj1nT3oS0TxZw=",
                    ["#=qrmDDtq_g0k_GY7Wg1T_z6eeHvOA0a$$tMjgYLYd2YRU="] = "#=qeHYAXhRHlZTV8FicUTnnM$8FkxkJLUPZxmsMOBwR8ig=",
                    ["#=qtrBzOdYZZ65GB65VDAbBsQ=="] = "#=qeIaMI4ByADwJ3OB23UW0Vg==",
                    ["#=qS08C2_SJir3a30B6NRLrSMrCbJMDU1AB9zVC6Q9j2FY="] = "#=qRxwT7OlWjJVylJ7Q3d$R__0Z8lMJTdvxL2yX5wCFffU="
                }
            },
            ["#=qzXqFkEyvv2ZL301LNfRVBR0aCPJxhbib_vWS8bTG79A="] = new TypeMapping()
            {
                typeName = "#=qzXqFkEyvv2ZL301LNfRVBR0aCPJxhbib_vWS8bTG79A=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qnR5hZgawXjIz5EzrVMhrGQ=="] = "#=q7DFwvYaFAl7CJuqYWy8jfg==",
                    ["#=q8pHPf3DQlRgpm2L0KXKIYPu46g4inNWzgcz7fNU8DBw="] = "#=qPMzgM0G_KdRJKRUKsLFiIdI_PbdBQg_eAfTh7dTQJaQ=",
                    ["#=qAbSx1vgFHiIOlyibwUEQIw=="] = "#=qvgr1iZ8y4PV23ZFdC80yeg==",
                    ["#=qKKohcZhNeaZWC0t86xpUDOtjHrLS3W6DwV_v6Xz_Qy8="] = "#=qRBqxyZ5qllwVX4bheGj66AMhEMkLzI$VEK_EhZaxU3A=",
                    ["#=qYyXnQd4zEeROHO0o0RD4vw=="] = "#=qS9RkJW$$qEl0pUoUqf0Xhg==",
                    ["#=qyaYMhVV3cczSXPW45jWMow=="] = "#=qy2LYzR9gDX0cIjgP3AuS5w==",
                    ["#=qA2y4EgJ_64rH9O34rVd4Xg=="] = "#=qdUNPCkW8sh5QWqh_RLAjyg==",
                    ["#=qPGSLbaqOq9aOKAX02wzCgA=="] = "#=qN5iDshuvuM9TeYB_90WJ3g==",
                    ["#=q7_kVCqt$C7wCXJF3oeYeDQ=="] = "#=qTGrDYia3d09YWpWtzpBZRg==",
                    ["#=qyPrsXihpgLUMu259MO5AVw=="] = "#=q2$bM8RL41u_d46mTs9BF5w==",
                    ["#=qa_zB0zwdlthinb$KcsRxbA=="] = "#=q9aKG605bFxNg3SwKhkqmtg==",
                    ["#=q6cJ_9c8bOWLxIgTp3r6MaA=="] = "#=qRYSDtxLdR7SzlysNK76hzQ==",
                    ["#=qcTek$qb5Kjq1t_2KT_v3nA=="] = "#=qq1fyTODoBWLD5PYN8fF9rQ==",
                    ["#=q84zntScOZXC_r0GZxCSCXQ=="] = "#=qyUm0c$igUC3dvPAB73mSmg==",
                    ["#=qluBipwaQxOLK7xq9ugc2uc$WIvGyUcmpegFN$gstVAINjPOma4kgBhZYWTeRZ3Bx"] = "#=qAToU1MIWDHrRPKWpcR8wejSnNr5GMn5AqNDnVGCACFF12X4YKsaAbhKex_NhItdK"
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=q6AFjdHE8BnOjZGfaghEBdvYUghOr9sKeIfqCOuhYErg="] = "#=qppQ7H6zEhMXY2Jo3L0EZHHWEtIHI41GPuBGAmYOjw8w=",
                    ["#=qfYNx0n3z4x6srR86hSERYQ=="] = "#=qS5lr78KXsieL0vs7f9gknw==",
                    ["#=qXt$pq76hGk8xCSfneRhJraXXWxAjvBLuTryAJF1g9tM="] = "#=qGe9DxMxEkfq7CWkq_vGJfQ4I8qcSCmdnml6YFAHmymQ=",
                    ["#=q0yX_PTE0NLELnUZZhFeM$0mC$oVgvIuzF5ThDdgxnk8="] = "#=qWtfv$uejPKW3dWe10Bz9M_yPqtV6oijRkJ9eBjmxoPE=",
                    ["#=qwXjNf9Qz20liU8fFOZY4UPkkjeOP3oC4OxLQOhRqKYw="] = "#=qvDrFC73mqXTwILyePxoDoX9b5ehaKMPDw52j0A8Tf0Y=",
                    ["#=qJCM7lXL5rWtXl2DM7TkqFNvsn9pMTU$pzyHInrC6xzA="] = "#=qViKB6sVyls5_TbxvbFlsqtNVauSEvKtTnmJFWR1j5M8=",
                    ["#=qv8XcEk4wN0O1o4O5kCS18WKO8INJwOtzPNUQCd1vvYM="] = "#=qsoTLECsf9ldykQdqK4m9oXS$sjputPBPhb55m07g$BQ=",
                    ["#=qPURF3c078QL3A0wiXj37OVQWFv_c60i53ujsk0K_$$Y="] = "#=qCXJKDKWawQgTl55Ue6XCHyrr8Z8pwev_TZRSICFzR14=",
                    ["#=qTrjufNM4uowO$zEK49HkKQ=="] = "#=qR43d$O$1A7uQ$W_k6nodtg==",
                    ["#=qWjG0et9YJAKk2H1UV2KQag=="] = "#=qw_H86MG4iiHih6eRo9LSlw==",
                    ["#=qhGt8yLQvgohxTl5xvzlR2Q=="] = "#=q8onjvxEeiBr6IQaD5JMx9A==",
                    ["#=q9_eHfjW4mIFex37B4IS9Hg=="] = "#=qTVdDqiM6gjKsqfSj6YRT$Q==",
                    ["#=qYxPwyuwAk9ZaKQ2olM5FVt4LAMVW0PoyqKO6Bw8_ukk="] = "#=qhWQJdJQZVlyqw6MU1z2mue$sNw4uejBQk4GsDmvYJeY=",
                    ["#=qJ_$jc71KP3NB5$M9e7UuRQ=="] = "#=qMERknpzSxgHtD$1dert50g==",
                    ["#=qMlmJrsL9elzrNfZfFtcLLw=="] = "#=qP3r338$Am2sr7BRYPmMvMA=="
                }
            },
            ["#=qzYxr4Vg6Ob8l0R9Qv_gLsxhUeEGPQfdA2aU1y6gX03M="] = new TypeMapping()
            {
                typeName = "#=q5vW6A0LxOe6IqspC4B7obD3DGPJjbzEyRVfeZycyaVQ=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qMVpyh2FVNVBdLnc9wNEN2Q=="] = "#=qTGIs$bR6zo_PaEQpg1W95g==",
                    ["#=qQdvTE_Ss3BqtA09gwMQcOA=="] = "#=qjHPt7Bs4rx_nADhfrMj4Zw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".cctor"] = ".cctor",
                    ["#=qNXe1otB_AYQ_n6FOQm0IGA=="] = "#=q8MM_ZcP1T7RTudGUI8oqng==",
                    ["#=qp1hix6RdufTirqAmCoR1Palpupk3A9DbJF2ZV_XIDf8="] = "#=qTdolFMvfUrJnDlA6qW$Oisx6cWqDgZXq95R0uNwnr10=",
                    ["#=qjkxVe1QA$JDFP0hzJOCqGg=="] = "#=qhHLkzf$jbCzdBXmBA4_zqQ=="
                }
            },
            ["Vector2i"] = new TypeMapping()
            {
                typeName = "Vector2i",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qGV0w7kQYbQhuIHYpzGvEkA=="] = "#=qiLFFGQn3k7i$oONryuAbHw==",
                    ["#=qyknUIyO7dwhSf7he9n0i1A=="] = "#=qo24XjShrjddQfsee65btJg==",
                    ["#=qYrud5ecmyFEXBp4VXrtqeA=="] = "#=qL_7jmbqvyBfbsdr5YhRazA==",
                    ["#=qx2ux7g_A0XWcZCfjrsYkxA=="] = "#=qDVTaLo7vNKxOBZ_aHgNR_g==",
                    ["#=qWvFIdOhxzi702Ma5LwgaLg=="] = "#=qq7WmZS2QppotricwryLt8Q==",
                    ["#=qak4PT0quEVCmCXll3BDINQ=="] = "#=qbQ2ABcNlILX0ClhesHLftg==",
                    ["#=qNdnvju8XgPdvjr_RMrADOg=="] = "#=qLZyFNLTPEniWJV0yDRGg6Q==",
                    ["#=q9lvjfmS2sAmatjqp$WxctA=="] = "#=qzEHA4WYHFA9Dea_blH$b1Q==",
                    ["#=q6$RflSKPn4ujxaN53y9X3w=="] = "#=qmfxM4ck4mliFZiNTDHTVhw==",
                    ["#=qQeZspJ4Xad5R9_RFi53Asw=="] = "#=q4kGSs3WyD9M2fkNrapuvug==",
                    ["#=qPkNd7qcHpcMBBXqDfc5GPQ=="] = "#=q7rf6pSnJA5sngwMcDAfjdg=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor",
                    [".ctor"] = ".ctor",
                    [".cctor"] = ".cctor",
                    ["#=qyQguM9WbkN$ELenU1IplmQ=="] = "#=qk319fbeUhyM$KmqBlWITbw==",
                    ["#=qZs5vaGMebiTk0AJ7dYS30g=="] = "#=qvWBHLq3jKSaqt1tUHsDmPg==",
                    ["#=qpg6H1FYsTnxJIk7CPL46lxbs$7WYOdKlmEsY7nq1AIw="] = "#=qNfPcTgj9RNoJI01NJmRdsWd39xO26m1z23o4oulEtzE=",
                    ["#=qe2FYYM0FZQ5BEJb77Wda6Q=="] = "#=qFgGThIfNUcCoJva9rSaM6Q==",
                    ["op_Implicit"] = "op_Implicit",
                    ["#=qK$220BKEfd4jeGgy3ZCgng=="] = "#=qrgSsssWsT0CyfhRfqGxI$Q==",
                    ["#=qZYqtRH1O$yCSsLhUEjok2Q=="] = "#=qPC3gjytiVsc0jJBrqTY0lg==",
                    ["#=qtxq7$r8vMX7pj79ykE3t6A=="] = "#=qu7D6npl8DQFx_naFb$0Tcw==",
                    ["#=qVRg00kZi2p1usvBibx7jyw=="] = "#=qJqwdV_A2rkFfL40izHJ8Ug==",
                    ["#=qTgzLVfinD7_PMHxPw9AxWA=="] = "#=qCQsxHmzWZUKT3UEk17oqrw==",
                    ["#=qXCwjRF7ml8HQR_2arCxdjg=="] = "#=q8Bq7N$dLdPi$HmKuuOlPPA==",
                    ["#=qnFN5fQV9Ie0XSx8EFkk5iA=="] = "#=qGzRVt5z0LifAyKmpodYK0w==",
                    ["#=qqaPugG6Y2oND_rtIwCf9Nw=="] = "#=qVcuvTuQh0VaeNojJNRlTUg==",
                    ["#=qkkz4DXooE3c2aH7B$TAd2A=="] = "#=qnSIFUm7kD2JuRWsqnTzIrw==",
                    ["#=qXxDGkg2lr$PEF6ytORzDIg=="] = "#=qTxaPKaGP8wH$daPlYOm2rA==",
                    ["#=qVeoncXyAX5f2$gyphulOlA=="] = "#=qyeM9UzCyhDzSoWqa0lKgiw==",
                    ["#=qA2FiR9ejeEKqRF1n8yegnw=="] = "#=qf6sgUbKb3WId0OTUWPehEw==",
                    ["#=qYZLcKuAZk78nrcpmV3wMhA=="] = "#=qDmPbXnHULEvyYHw6nd1$Cg==",
                    ["ToString"] = "ToString",
                    ["op_Addition"] = "op_Addition",
                    ["op_Addition"] = "op_Addition",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_Subtraction"] = "op_Subtraction",
                    ["op_UnaryNegation"] = "op_UnaryNegation",
                    ["op_Increment"] = "op_Increment",
                    ["op_Decrement"] = "op_Decrement",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_Division"] = "op_Division",
                    ["op_Division"] = "op_Division",
                    ["op_Division"] = "op_Division",
                    ["op_LeftShift"] = "op_LeftShift",
                    ["op_RightShift"] = "op_RightShift",
                    ["op_Multiply"] = "op_Multiply",
                    ["op_LessThan"] = "op_LessThan",
                    ["op_LessThanOrEqual"] = "op_LessThanOrEqual",
                    ["op_GreaterThan"] = "op_GreaterThan",
                    ["op_GreaterThanOrEqual"] = "op_GreaterThanOrEqual",
                    ["op_Equality"] = "op_Equality",
                    ["op_Inequality"] = "op_Inequality",
                    ["Equals"] = "Equals",
                    ["GetHashCode"] = "GetHashCode",
                    ["CompareTo"] = "CompareTo"
                }
            },

            // Added manually
            ["#=qBW3QpGFIuxV5sSCs5OT5dbAwAeGDje_UNAdyp8bmiII="] = new TypeMapping()
            {
                typeName = "#=qadIXs7RYUqULDXLsiN_Kbew2OzO7nK0RHzoFH643qGg=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=qsRELApGqRaZfdn8IHNBXyzGElxS9ktUTStbJiNRNhf8="] = "#=qNQNw2dwNu6UPYuuEzVpESodhD8miY65JesOAXgU1aKo="
                }
            },
            ["#=qqC60YH9eL7nVxVeHV2L4D707tbZfxtYtT3Yl9jgfZj_W39CBigyUDQPzPEj4I01c"] = new TypeMapping()
            {
                typeName = "#=qo$nDEatBJslXpVklYJ2RIEij0cQ83Ed59rwQ_fOTH7I0F$N54BqjT_ZH9C6gjuDP",
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J"] = "#=qdU9ONl7OzTiwqEhiiLIIW6k7u5XTMLHP4q2pu0HMMT0PhXadfwEAYtRzIAtuMGGm",
                    ["#=qdF7My9Z0ImSiDeMprbILuA=="] = "#=q$osW7SuAA99n7RqRDnYNow=="
                },
                nestedTypeEquivalences = new Dictionary<string, TypeMapping>()
                {
                    ["#=qVEhtCjvTuNUzW3aKSV$g6V2nhb2QKRaDS743hL10PkQ="] = new TypeMapping()
                    {
                        typeName = "#=qF8fwUO_tv89VofrX7XRci1byFRr4Egi1xacW_Gxqpj8=",
                        fieldEquivalences = new Dictionary<string, string>()
                        {
                            ["#=qCQ0ldOB_AtDsw0EbITo5Zg=="] = "#=qPMCoSgH9oI_lMqHFqypahQ==",
                            ["#=qv8rpL9eRMRqEUS1YjrmSFg=="] = "#=qCdXZrMp73vXOjN0xHig9fw=="
                        }
                    }
                }
            },
            ["#=qG4fRLTF7VgPjIT82MmidAKaNZJLG$uA83rXzQGp40b0="] = new TypeMapping()
            {
                typeName = "#=qwrXZcfrINdoXIIgQAimGv_nt_6pR2UP8oBE3PcYEbjE=",
                fieldEquivalences = new Dictionary<string, string>()
                {
                    ["#=quY9YhhTOhinNRAlMHGe_BA=="] = "#=q2ukEDR7w9HFZperMxqk$UA==",
                    ["#=qBePJmry0TzqLZdQMcgmrvQ=="] = "#=q6T02ro0dLNoP7ZbDAAhPrw=="
                },
                methodEquivalences = new Dictionary<string, string>()
                {
                    ["#=qTd598wTpL30A8GqUuGFkdhSGZcGtw8vhkCEuOPZjfj0="] = "#=q65juUjzUlEdp1XnJIX$WivYuGdJl3qTbhoNth$Epgr4=",
                    ["#=qBSpkp4g1gcs3G8qeUnlTEAvDsZNAXSZt0HFSUvl197U="] = "#=qrIT5KPGTJtZ7PMTk1n8uqFQGDNt0QwXPv6CzzoXRt1M=",
                    ["#=qcAI4xoajB5c0nSHhfDrzAw=="] = "#=qsLj4azzXwidTQYGE3Rj5EQ==",
                    ["#=qsoCro4fIXL_XiE72I3Qawg=="] = "#=qgbYcn6unS$APtMWWtxmEqg==",
                    ["#=qUcmoUVau7Ojk9o6cxOlrfw=="] = "#=qdSqZN$L85N8nO4DNJYzpTw==",
                    ["#=qEOwPCzqdYEPHZzccOMAjsQ=="] = "#=qrOL0ggnSSW5rp1Rm8yy0ig==",
                    ["#=qqX78R1WZtC9w50e$D7ubig=="] = "#=qQ$ijIDaoro$pu$6HymKTUw==",
                    ["#=qh7iU6l7yfahEIFu0I6WHVA=="] = "#=q$CLQXXCRQ4jqzUCnJPNkIw==",
                    ["#=qCaZyX4916r1WTQ4t11XP8w=="] = "#=quir8t2RfdqEn26RH$fM_qw==",
                    ["#=qEWMFMGYt$ds9yZCF1hDd_Q=="] = "#=qP1l_yEEofn2Of$6k3UloHA==",
                    ["#=qQH0U9w$CRrIgsuNXzn1TSA=="] = "#=qRUaTY30gpk1JhQXqdYqHrA==",
                    ["#=q2UHh48ywQ2poY0A8Bxu6Ug=="] = "#=qIrsjZSEBfxQg0RERMP6oig==",
                    ["#=qs43NDZaM71S7Vvv2bGsbxFVtigjocHzMX0hvFioIORY="] = "#=qXMm5Jl$TQ_GMTHALbkOg4linsLSgOR42Mj2jcMRc1bY=",
                    ["#=qhm_cjQgiQdt8lty_PSYJd_vHIOsKU2AapEGcQrL9vOE="] = "#=q4Ju8RItjgAkTBaPKMDxl$XvTfBc$FRUDnvaow2kL5k0=",
                },
                nestedTypeEquivalences = new Dictionary<string, TypeMapping>()
                {
                    ["#=qMte2gARWVWATIryhhstFwgRW9JVIdt$VnuS8gIMhh0w="] = new TypeMapping()
                    {
                        typeName = "#=qoNl43w5VorTFfQVg0ZFnHTIIvyi$vixCZQ3CLRQbbAY=",
                        fieldEquivalences = new Dictionary<string, string>()
                        {
                            ["#=qtrjhr78JXu6d$kQfY7Fsqg=="] = "#=q4rejfsGkMrWb5D5erxV3dg==",
                            ["#=qc3S6mAs1TOE_3QWOt0tLXQ=="] = "#=q$qlf$rUA6Y5Ru2LmueZMjQ=="
                        },
                        methodEquivalences = new Dictionary<string, string>()
                        {
                            ["#=q8g9zLb_qi5zv_vYuh4Hn0Q=="] = "#=qVBQeFER11SGlRm4LfrWwzA=="
                        }
                    },
                    ["#=qLTbI8ygTeJm7wKqQHN1CmAIMJc3bt38WbrBXvJCjWOU="] = new TypeMapping()
                    {
                        typeName = "#=qAwm7EVUF9Q9IhICKODMWSbAS$dvMb7JzJYjhLhh0C34=",
                        fieldEquivalences = new Dictionary<string, string>()
                        {
                            ["#=q8I31dseSEfqB1a3XAs73Ig=="] = "#=qhs8779damjytkEDuxTLuGQ==",
                            ["#=q435pjqyaHqnFovzWf9g_mA=="] = "#=qBLpyCJWGqxEKsyX2ac49Ew==",
                            ["#=qY60ztVRPK8HtMDj_Lgrhjg=="] = "#=qI94ZiIxyiL1tX2TT9ZbITA=="
                        }
                    }
                }
            },
            ["#=qbVYiuFUiFv8DeuzGAXnnRxuTdfxzeNCIX7$CehSd03DrAwVAtHPJJcEdzhpKYRZJ"] = new TypeMapping()
            {
                typeName = "#=qd$NHgyE25bphJ9$pmpAnjYgn_EhCad5J1HUVpxOVmwAo7yTeiRfJGVrGfac9lBmf",
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qQ6CyedymXCIh4eawekuhYeGzoc$3z4fjcH2LHbSxCIVndIEFY8DUMjKBTqqYUrlb"] = new TypeMapping()
            {
                typeName = "#=qRnUjCB0anMXtXWn_ZwRApPjhv9iHMN0Kgl7zZLjkVWilM0MDMtvo6ZFh6ej0UwDd",
                methodEquivalences = new Dictionary<string, string>()
                {
                    [".ctor"] = ".ctor"
                }
            },
            ["#=qBqzSCxNWjNPtABUjoHPdXdmmMLWNmfIdJZwq3qjbt$8="] = new TypeMapping()
            {
                typeName = "#=qvSlWieZd308X4GqZkqCVfDVh9iAuPtm_mVlcRjR45rg="
            },
            // enums
            ["#=qdRTIxzfvGW5aPQCMcMPe10Ffm8HqcCZZWjNp4lOnYjA="] = new TypeMapping()
            {
                typeName = "#=qIU6JhdWHGRNCqLmI7NhyfDQcT5I$OmhjONddDmvPigU="
            },
            ["#=qurnS7cd8bvsK1DYQiwcxck$_OK8HcG4xuyIKX7J9Alw="] = new TypeMapping()
            {
                typeName = "#=qaWyE3wGcPQC92CHWX5uxzlYLUL_d0ixG93dITBHXSUg="
            },
            ["#=qS4TRKyhEwHcAdM3BTA06nBDVEKnXie8G2gX5kHo_Rms="] = new TypeMapping()
            {
                typeName = "#=qOKGNdkizjcbIoTfsnJG_EZ1VElUnnDm$jXcpoKdPS7Y="
            },
            ["#=qMx$gCGX_L2CDEf2PuT4McJ5YmvDibmxiCM1ubaXcX60="] = new TypeMapping()
            {
                typeName = "#=qUUGBOUS_4GkdTl1EUbU0shXl9uME6GS7d5d0HVwvG7s="
            },
            ["#=qorWB$Uhh9bupIBK$6WpVbzbRwL7uQvz21jttamAdjDH_BYYC5LGXPA8c0A2GCSb3"] = new TypeMapping()
            {
                typeName = "#=qtWUlupoa$fXNR_cCyPEB8Tsu5mgB2pQ5kGDfUGmXzyjfegB7cv9P_mqe1rUTp1OD"
            },
            ["#=qh2pSYbUJLebVWoIXIt7zQSEPMTK12GgkFAme864uKfs="] = new TypeMapping()
            {
                typeName = "#=q2nbmIkSBD8RZp2HqJxREGXeg7lvp4V3k08kLbsM3tkY="
            },
            ["#=qdSDhLjYKhncTWU1UVqMBie2h_pZEpfblL5Zd3XrA12bne1nUPh_IlCE8UrAuM2kg"] = new TypeMapping()
            {
                typeName = "#=qD6wLE2citv9TeABlgsuuSntlGQsabLSi1CqDpB1VLwOLELmWzt7CVrFAH8VZApdB"
            },
            ["#=qDeyuW9wN6BLaeyOmuixpPdcasu0UCFFh2nNNcGaIYww="] = new TypeMapping()
            {
                typeName = "#=q8AE_iWI8kbjQdYsRWRyljIatwYyQmmJhJltL4389B_c="
            },
            ["#=qMq4X5JnRUXr3gftTjK6KZQvGDn1gHzVUHshB3c0mNiQ="] = new TypeMapping()
            {
                typeName = "#=qdkrhYwTvlVKUT3KMWoVTm3bBtsxx54kuakiaYGIyI_s="
            },
            ["#=qtXuEH31$Qt9ie_6L9YKlTA=="] = new TypeMapping()
            {
                typeName = "#=qo$mwG7BbEptJpMcCBvGW7g=="
            },
            ["#=qemlibnROmcyhIxcbT6K1ryf3zk0HbkC8fGl_FK$lJyA="] = new TypeMapping()
            {
                typeName = "#=q0cebqUOFU_WefUEJ6ouUB07cpSgPqaqDf9oywNsfEBg="
            },
            ["#=q12z$4f4l7QpZR5agQsrR9VhdD48v$cSJsw1LolJLeIl1J4uDUvJNYGS5T0rTb3vh"] = new TypeMapping()
            {
                typeName = "#=q2NRLPZgfZey0JQjkfO$$FvFXE69OZwVyuPeZuQedsqIzU48Hn56EtikI5H0zdeFR"
            },
            ["#=qdkrhYwTvlVKUT3KMWoVTm1CHNWhszSBqjJOltUAwOa9DOilLN68Nd$S3dSdgSV2w"] = new TypeMapping()
            {
                typeName = "#=qnGNr7QZJtW35UqiUaaD_0gL85k2FPrN8mrwD681DJoS2HqFE$MG4yBHgJSe5cr46"
            },
            ["#=qROT1ixOqL1gxJq_nDVKjRXoWfw3yU9B0DWRy2UBg3WU="] = new TypeMapping()
            {
                typeName = "#=qyyQFFv9vsiSWLj7RQ0EBWhUmA7fQeoVS0CsW$7k98B8="
            },
            ["#=qOgfE8lBMFeWPgW3U8uaBbmwywjXLM$H7Iq8cxYp$FME="] = new TypeMapping()
            {
                typeName = "#=qS3Fb8VC8qtBBDLaTA2g$6LcltBKmemOIykBp8EuNNqM="
            },
            ["#=q3R7nWroE4ndLko_a2R2fQM5fO1uRvWfaWUGajvsYuXQ="] = new TypeMapping()
            {
                typeName = "#=qzqDmC9rYvocBubv9XMWxBvpu34nlT6YMEu2SzAkJKEM="
            },

            // Unmatched top-level non-enum types: #=q6nFQ7j0czfMML633KX3NXw==, #=qBqzSCxNWjNPtABUjoHPdXdmmMLWNmfIdJZwq3qjbt$8=, #=qBW3QpGFIuxV5sSCs5OT5dbAwAeGDje_UNAdyp8bmiII=, #=qG4fRLTF7VgPjIT82MmidAKaNZJLG$uA83rXzQGp40b0=, #=qnH6iBO6MQt97JINRbHwrsw==, #=qqC60YH9eL7nVxVeHV2L4D707tbZfxtYtT3Yl9jgfZj_W39CBigyUDQPzPEj4I01c, #=qy0XryZJ1YjnJepAdJT57$Q==

            // Top-level non-enum types with more than one potential match:
            // #=q07_2RXXivreQjbaZ$SaWnO1cDw8iQ_Hxwjx7S24GsKSXHAisRQYXZmwkOfqyhoqA : #=qgTP8eV086NJY9b1bFZLubYmxFKYKFi8hFlCjQ76esMs=, #=qrh9qUgG5_gs248FQz6Bw9dckTs$uU0LDNf0FAB9Oz1KlXoi39Dt6l4xsqz27x8td
            // #=q3KPohspw1wrCX08Gi_j7BytMq2kCB8jZG3O2zvjySd0= : #=qilVFwuBwDmucH5y3kZOx2f6pKeISSn6P_bJueq4XC8M=, #=qUVe1LRERHFa75mMbIr$CHy5JcWxHZaf$jjfda3qkcoQ=
            // #=q3uln4LSIWXdzKWPtMsaB7F62J_aThtb8c6jIwUtgDSWAAZGS4i8RO9ePE6JTega9 : #=qd$NHgyE25bphJ9$pmpAnjYgn_EhCad5J1HUVpxOVmwAo7yTeiRfJGVrGfac9lBmf, #=qG22_8rDgeS7Qpbz8C_nCJJUgMJGdjqkxUaBSeXc6whr6O99MopA$Wb$DddEm45EF
            // #=qADivd72VF7sh8s0RxlI2dAMJJNvkmnFi2RIL7VnHVFWJZC_gycCRaYuzKj3XXZC2 : #=q6DNFsuB$3XLOFm9mf_yhanv23Ehuh2gCbu4xaggCsD0BKgvylTlRGyiBYoL_0ryK, #=qDuKEREFsWVmhFkpounRsGbXig1jwusrx$$1CqUyqDbg=
            // #=qBFYI6MvE3IZqis3k33iK2SX3mbSdOPgL9XG$YUM_Nuw= : #=qilVFwuBwDmucH5y3kZOx2f6pKeISSn6P_bJueq4XC8M=, #=qUVe1LRERHFa75mMbIr$CHy5JcWxHZaf$jjfda3qkcoQ=
            // #=qbqr3GxhaMcPya2FyqUXZb7Rsqs2RjONySftt7KMxQI4p_KBvwAOdI1s_$cmcdw_z : #=qwR4bwvwMP$A33FxOTjjcQE35FhggprFK1KrgwxMmdZ6jDJA75wq4_BUWnU8wcwb9, #=qwR4bwvwMP$A33FxOTjjcQOCtgyjZUupKb_4EbLInqrBvivbozBAlo4w6CgbqBwbV
            // #=qbVYiuFUiFv8DeuzGAXnnRxuTdfxzeNCIX7$CehSd03DrAwVAtHPJJcEdzhpKYRZJ : #=qd$NHgyE25bphJ9$pmpAnjYgn_EhCad5J1HUVpxOVmwAo7yTeiRfJGVrGfac9lBmf, #=qG22_8rDgeS7Qpbz8C_nCJJUgMJGdjqkxUaBSeXc6whr6O99MopA$Wb$DddEm45EF
            // #=qc$TlKV_97hVrasxI$h7PL6Hs0kReuF44bH4ce_Og3PA= : #=qgTP8eV086NJY9b1bFZLubYmxFKYKFi8hFlCjQ76esMs=, #=qrh9qUgG5_gs248FQz6Bw9dckTs$uU0LDNf0FAB9Oz1KlXoi39Dt6l4xsqz27x8td
            // #=qCzbY0ArXnimNQVLnsSGcKM3Fqgc7Lz1Gig57BkWfnD0= : #=qjwHBkm2_bFecWYNheBHFp5WKkK3CzDCTQKEA528TbzU=, #=qXr4o0szuV2HxrwZB$T2e_NbG8h_web8$SgskcllJvww=
            // #=qdTN5cZRZ4RnjSnAhPvYBm1VEkJM9hHqIt$DicJA1gzs= : #=qEj6Idkv69Hv5CFxfHq$T$O8NXY0wyq5wLwnnghgY3ps=, #=qPoHarUEcbwLXXYQ12Nc$pufidLEvSa4Lm8F3ihCQcro=
            // #=qF9sMRjaCwje1laTFEXC$TLb9SWQDvf8trAEytmaXKIJj2H_B_EqneMacJ13e0H3f : #=qf6fTbNCbKks8mKcDlBlodr3J6nemrfjNPkqehVe5HOGU2cevSI767NRyQKYGVMZR, #=qgdg56hMZDKoghTTx4uIJcCmqRwQg27CIKP4CXPh0$qVnlNWAmZQfZChXharPMteN, #=qvr95uX838ht8zHvUw7C89YyTHKWlVKR7yvY6hNgm2xrUu2nRp1y8Q1svA_28lliw
            // #=qfZzBK7p7Jicmh7ShuPSt45wEU_1o4hOjI7zu8EMIRkk= : #=qC4rS4aZmQsCxug5eFH_hFD3i3btCfAu2HNhtU7YAPbg=, #=qFDGrfVZjPmYjrpe2OquUS$Ro4Q5TCDA_lKSPjo5bqgk=, #=qQG_KwH8M5cY89tpyKQRfS14_r3URUsL7pXr4ozbGVeY=, #=qUh7hDljx7vKumjfRvAkR3L0laKR_6wlK$aVBU5Gn67s=
            // #=qgC6HSAr7BvJz062WSx4Y8l_52vQ1HwentJP0mfiL5Jj7xvGgQ34hdeIegQC7JQXU : #=qfHCpINVluc4ExN5NhaBxyP4d9p4L8KVT03PgRGwmxQQktVd$fWgpj_aQJxQNchWM, #=qMX6$iZBEiHwFQYvb_MY_iNFL45U1ShSaQmW49vO$FgbgxlrItGBho1sKOerv0CuJ
            // #=qhNo45l_sz8BhofU7DzFTPnTh5QAn3gE996hI4Jd1ouU= : #=q$W_Q8ZKiOqOKvzX$U5DCX4syEaA2Gvt84zjobTAj7lw=, #=qhNpdk8U7cGJ2$wq$WNWvskpoZiDHEdKIxQ0h4rXsoMk=, #=qT96wL9wWBJso6Nux89ItSyjfIGUb6dMBq5b1AzjgZd8=
            // #=qhPJVotgdpP8q9QQo2BIDH0zgJSyZC08pZimBDkEFEzg= : #=qEj6Idkv69Hv5CFxfHq$T$O8NXY0wyq5wLwnnghgY3ps=, #=qPoHarUEcbwLXXYQ12Nc$pufidLEvSa4Lm8F3ihCQcro=
            // #=qHuI0$lhotCk1esRPBTiyi6vnDsMuGd1SJHWV8PLUmlo= : #=qjwHBkm2_bFecWYNheBHFp5WKkK3CzDCTQKEA528TbzU=, #=qXr4o0szuV2HxrwZB$T2e_NbG8h_web8$SgskcllJvww=
            // #=qlCPm6MRNg3$HkpYzkVmhUCw4LBSrmOdcR6zIP8mvL84zKU7c64qGBK$pF9xPOBLv : #=qf6fTbNCbKks8mKcDlBlodr3J6nemrfjNPkqehVe5HOGU2cevSI767NRyQKYGVMZR, #=qgdg56hMZDKoghTTx4uIJcCmqRwQg27CIKP4CXPh0$qVnlNWAmZQfZChXharPMteN, #=qvr95uX838ht8zHvUw7C89YyTHKWlVKR7yvY6hNgm2xrUu2nRp1y8Q1svA_28lliw
            // #=qLRAL3JGNJKlUvp4Mr2zeT07UQ3lVy_Dp6Q7NKfViwSg= : #=qe5daO5vtcmABemGiEIfkh$QZQCSrcUOZL4tymbwqxLE=, #=qtDumn$t$NUpF25Pk_87DZtf7EMLGpI12Mz8tSlsxFJ4=
            // #=qLYRijl5b3vMG$asi2l7BrmKGcm2DYXffuk7WIOMkCzp5BunjxoXDFuzrFkVCRd22 : #=qJPhnVDl5UHVY36NTIyyo3W7n0eMa_l3UisRU5xI040t$zqZT_aeVNvfvNdwA4z_9, #=qZ1nFd7qB7FKBt1rtGzWVPMFLmA3l1wuBi_08FLz1xXNwiAMAg7j9De_2WOq_dgUE
            // #=qmIS2IRy9EOfrqTRoFNY1jQrrW1VP1LbM2ibWm2oMJWUSco6cBpCMAwLmhM2ZdVXZ : #=qAmC$NfIXu5IKpj1FqiXKOQg5KluxKjcqMN5lKFYq9KorQvKjjTIySeYSzjiv53zi, #=qreKWZBUYAC0UrVmbm4lsMiosgSY5FEoYe6n5srDlLPVrnFGbWh91F5PuunyO4jMC
            // #=qNfc2P1_zznYxLfHd_4mlNIUzY9eymXYezV0YBiPd4z0= : #=qC4rS4aZmQsCxug5eFH_hFD3i3btCfAu2HNhtU7YAPbg=, #=qFDGrfVZjPmYjrpe2OquUS$Ro4Q5TCDA_lKSPjo5bqgk=, #=qQG_KwH8M5cY89tpyKQRfS14_r3URUsL7pXr4ozbGVeY=, #=qUh7hDljx7vKumjfRvAkR3L0laKR_6wlK$aVBU5Gn67s=
            // #=qOBpSd1vAu3b9pnGsO1HgJwPKXPB73SYOhELI_9aa3QE= : #=q0veyFlk4QDpwsSkY5_X0IQTFiJE1lA_b9S3FJaXnMsY=, #=q6yUXRSibhXdtcWqt15_l_EVasqdOiHBPMkTyqyqqj3g=
            // #=qQ6CyedymXCIh4eawekuhYeGzoc$3z4fjcH2LHbSxCIVndIEFY8DUMjKBTqqYUrlb : #=q3KWoAX9cvf72DMwYnIQWuecKCYM9pzU1RNN8VUPIrik=, #=qRnUjCB0anMXtXWn_ZwRApPjhv9iHMN0Kgl7zZLjkVWilM0MDMtvo6ZFh6ej0UwDd, #=qxPD0WDSn8mra11Mix1AIP$0JuvlbHgN5BZLAc5zwe1E=
            // #=qQaHEtX5c_H8C7$eqgiS6Y4HwOM_gvZT3RA7jPMY7EG4= : #=qC4rS4aZmQsCxug5eFH_hFD3i3btCfAu2HNhtU7YAPbg=, #=qFDGrfVZjPmYjrpe2OquUS$Ro4Q5TCDA_lKSPjo5bqgk=, #=qQG_KwH8M5cY89tpyKQRfS14_r3URUsL7pXr4ozbGVeY=, #=qUh7hDljx7vKumjfRvAkR3L0laKR_6wlK$aVBU5Gn67s=
            // #=qqefGW$Qe6uaj8ByiwWIMTz9fEZb8XXMMTE_W7lqny6A= : #=q6DNFsuB$3XLOFm9mf_yhanv23Ehuh2gCbu4xaggCsD0BKgvylTlRGyiBYoL_0ryK, #=qDuKEREFsWVmhFkpounRsGbXig1jwusrx$$1CqUyqDbg=
            // #=qqlExsdut2TthlzYfqM7jbwrrGBGa8K1FwGmtJWoGRlNLekOuHEvI5RDINW2tP4be : #=qfHCpINVluc4ExN5NhaBxyP4d9p4L8KVT03PgRGwmxQQktVd$fWgpj_aQJxQNchWM, #=qMX6$iZBEiHwFQYvb_MY_iNFL45U1ShSaQmW49vO$FgbgxlrItGBho1sKOerv0CuJ
            // #=qrvmigetEH1o_M1QRE5FiW2TSZ0d5fxnMtf4gaf1lwHQ= : #=q$W_Q8ZKiOqOKvzX$U5DCX4syEaA2Gvt84zjobTAj7lw=, #=qhNpdk8U7cGJ2$wq$WNWvskpoZiDHEdKIxQ0h4rXsoMk=, #=qT96wL9wWBJso6Nux89ItSyjfIGUb6dMBq5b1AzjgZd8=
            // #=qsdiB9fiuSFL8PLX1ynGMuBpazLAwNeMPwrUj2hto0fCp_dGBY9q75bp3j8Tnvt47 : #=qJPhnVDl5UHVY36NTIyyo3W7n0eMa_l3UisRU5xI040t$zqZT_aeVNvfvNdwA4z_9, #=qZ1nFd7qB7FKBt1rtGzWVPMFLmA3l1wuBi_08FLz1xXNwiAMAg7j9De_2WOq_dgUE
            // #=qSnCF6_Y61UNNI_oWST$Kki4XJwSDJMSg4RQKqf28KJ8= : #=qC4rS4aZmQsCxug5eFH_hFD3i3btCfAu2HNhtU7YAPbg=, #=qFDGrfVZjPmYjrpe2OquUS$Ro4Q5TCDA_lKSPjo5bqgk=, #=qQG_KwH8M5cY89tpyKQRfS14_r3URUsL7pXr4ozbGVeY=, #=qUh7hDljx7vKumjfRvAkR3L0laKR_6wlK$aVBU5Gn67s=
            // #=qSWDfkWclPqStZ0SBNed8I$qNCnyDF_Pe3a6hjUlaY4w= : #=qI725CJRZBaMJFKAFhU426$4ia1MfW8PNPG744TVS9wM=, #=qq0A1ho5JFw7BgXKLTxnNEPOuwIcM2SnOCqkRLlVrbM2P6bawjLnj60fcFbNnO5xZ
            // #=qt7CD68S$RhkqBChI__IgIuZdmNyT9P79WhjR02o8kCk= : #=qe5daO5vtcmABemGiEIfkh$QZQCSrcUOZL4tymbwqxLE=, #=qtDumn$t$NUpF25Pk_87DZtf7EMLGpI12Mz8tSlsxFJ4=
            // #=qTNaiL1GP1bc7iYNWsRG6xSw2T$kz6Cy3vC18CtBMbPl4PYcrCpZsuXp8FU5vOUoY : #=qwR4bwvwMP$A33FxOTjjcQE35FhggprFK1KrgwxMmdZ6jDJA75wq4_BUWnU8wcwb9, #=qwR4bwvwMP$A33FxOTjjcQOCtgyjZUupKb_4EbLInqrBvivbozBAlo4w6CgbqBwbV
            // #=quBFsfDnfJX72pgcYDNXofEEQY3LmiUIOgBiijmFQhxo= : #=q3KWoAX9cvf72DMwYnIQWuecKCYM9pzU1RNN8VUPIrik=, #=qRnUjCB0anMXtXWn_ZwRApPjhv9iHMN0Kgl7zZLjkVWilM0MDMtvo6ZFh6ej0UwDd, #=qxPD0WDSn8mra11Mix1AIP$0JuvlbHgN5BZLAc5zwe1E=
            // #=qvJR9ixsrhhoigS4$Ul34RjnlbrJbEdFc61XhbhfbDBo= : #=q0veyFlk4QDpwsSkY5_X0IQTFiJE1lA_b9S3FJaXnMsY=, #=q6yUXRSibhXdtcWqt15_l_EVasqdOiHBPMkTyqyqqj3g=
            // #=qvK5IjbSeHZrvjtJeElCPRMSydJ8xu2i1YWLK5NRyhgLg1d8eBuaMrOe3mgwJ6Kfp : #=qAmC$NfIXu5IKpj1FqiXKOQg5KluxKjcqMN5lKFYq9KorQvKjjTIySeYSzjiv53zi, #=qreKWZBUYAC0UrVmbm4lsMiosgSY5FEoYe6n5srDlLPVrnFGbWh91F5PuunyO4jMC
            // #=qwX4yQfcm4UvMHojKIw1qfNa3csBX4aqzGugJrX7jw_6XhYjQD9lZHjQr3RfdM6hn : #=qcRCFP$OezKnuxTWRSt5O$dtufk_aEpsuk31pTCdlW_AO0J1K$Xn7JDRq_3C9gp8bEt0xT5WQm1aS_CuVRsIXVA==, #=qTVuym3udVO6_LtBhM1W2Z5zbY94HlT9BWYqC1trYFLwy65r2jxFJ2Gfvaxib1$7W
            // #=qyT_hzvmbgQhX2z$_$WCy8trnPPmOhlbb6n_D_n5NVVoseIh17v6NibbJu5JJK_J0 : #=qf6fTbNCbKks8mKcDlBlodr3J6nemrfjNPkqehVe5HOGU2cevSI767NRyQKYGVMZR, #=qgdg56hMZDKoghTTx4uIJcCmqRwQg27CIKP4CXPh0$qVnlNWAmZQfZChXharPMteN, #=qvr95uX838ht8zHvUw7C89YyTHKWlVKR7yvY6hNgm2xrUu2nRp1y8Q1svA_28lliw
            // #=qZaRQRQONFqdFDxwS$JHZEgljoNDgD6onhfyGydHYSHhTcw6usLOUDcYW1hJ5vWHU : #=qI725CJRZBaMJFKAFhU426$4ia1MfW8PNPG744TVS9wM=, #=qq0A1ho5JFw7BgXKLTxnNEPOuwIcM2SnOCqkRLlVrbM2P6bawjLnj60fcFbNnO5xZ
            // #=qZCp4gXk42T09BcHG0rNNoMKD2D_QnOgCamUmePy8hk0n5cEaz2Fr15CUeUit2mjp5DRGITs81sMzueAm56GfFA== : #=qcRCFP$OezKnuxTWRSt5O$dtufk_aEpsuk31pTCdlW_AO0J1K$Xn7JDRq_3C9gp8bEt0xT5WQm1aS_CuVRsIXVA==, #=qTVuym3udVO6_LtBhM1W2Z5zbY94HlT9BWYqC1trYFLwy65r2jxFJ2Gfvaxib1$7W
        };

    }
}
