using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qpoo9B8HJ1jfTSlmA$jY_f$B8kCgrbb033C6bfA352$Ttko8vqcnml6AiS9bKcL3$")]
    class AfterVictoryScreen : IScreen
    {
        [Decoy("#=qZ1jUGdHkRoDbakG8NvUpwK7DfGdKbRuYcWCc4kQcp8g=")]
        private static readonly Vector2i positionTab1;
        [Decoy("#=qN7aUmGbF49l7XmVp8f6W5y3z_kn6HdDoDsDgmQsE0iA=")]
        private static readonly Vector2i positionTab2;
        [Decoy("#=qdzLL2xCMAnOU5akEOqYoUeYygrambWIUpZ1EPCJ_y90=")]
        private static readonly Vector2i positionTab3;
        [Decoy("#=qoHWosUA1cnUeTocYFYMmiA==")]
        private WholeUI wholeUI;
        [Decoy("#=qnzbvaoP2amItxeWk8EaaKg==")]
        private Optional<Score> thisScore;
        [Decoy("#=qCCEo0Wz$VOddL9gcYcES$g==")]
        private Optional<Score> bestScore;
        [Decoy("#=qgwxnQxSVPHlWH4pH9wfRzw==")]
        private Optional<string> plaqueLevel;
        [Decoy("#=qMXF$2m$Uyh7muNihyH5RrA==")]
        private bool storyIsPresentAndUnlocked;
        [Decoy("#=qd7tZj3ftZO1umMFx8EG38g==")]
        private bool trainingIsPresentAndUnlocked;
        [Decoy("#=qIdEXAB3j_MxqprV8j04xXWgMkr6bcHKoKezqalw5RM0yGE3kdei6iWQYk2soOSjH")]
        private static Func<Score, int> getCycles_1;
        [Decoy("#=qiIgBLxbUnVNACfr8AcklsBYNxE_85TMXgzmr7UDquY7uIGTSerBCN_7lGc3Fec8E")]
        private static Func<Score, int> getCycles_2;
        [Decoy("#=qYalx4WUHeIEPMQfWjLNbvuP7P5UsMrXTREwf95p140qx7EfahMQ2ODGqn9PQivw6")]
        private static Func<Score, int> getReactors_1;
        [Decoy("#=qE8uF$vYQPLbr6cQlHFILJ7R6$1yM2udPd0Dar0cBy2gHSWWDhrpZnaPYOgW0oO23")]
        private static Func<Score, int> getReactors_2;
        [Decoy("#=q5TMIokeivS_tFzY3nEFeHsBJs$MKImDRrb9em105O5AGCU2BkFCG8tUFmds6DWlv")]
        private static Func<Score, int> getSymbols_1;
        [Decoy("#=qnMAxlTWoK74lSxWnh9f1unMwvSfiNR9VPi7HX_m6TncFkKEu5SnPhz1lqqsT73QB")]
        private static Func<Score, int> getSymbols_2;
        [Decoy("#=qm1fTiztmRDWIFReCKkF1_a2Q_EhnErtFzqeE3ZKHRYvNLKkb_wRpHvbyMhWjlgF$")]
        private static Func<Score, int> getCycles_3;
        [Decoy("#=qfLD7j7ju6ogoElPkK_pwrJaRlvwSx3kx1tNhjzl8yhyr_xCdY8DhUsr3tuV5$j_V")]
        private static Func<Score, int> getCycles_4;
        [Decoy("#=qSu$5aTe9PFANPkj4mgAgJAb2uRHFx7oRZQjgOCWX$AOtPokUbs$UFZOS7yO1VVcm")]
        private static Func<Score, int> getReactors_3;
        [Decoy("#=qIIPTH4n2clqCoOvhJGchb5frupeB3ZaHHBD3yZTh8_LHxFhc7WS3ojQd_X0S$PMo")]
        private static Func<Score, int> getReactors_4;
        [Decoy("#=qU1ssvtk$leEsQwmy8XTvZJtViCYsMaBEnn0eSIYi$baqYcJQahI0JN0rooEE2AbK")]
        private static Func<Score, int> getSymbols_3;
        [Decoy("#=q8c3bExyAMSh7ZuL30rWmzCNjwLRSCnA4dQr0$wctEGTwYdxOcrsjqfK8DEcfuzzT")]
        private static Func<Score, int> getSymbols_4;

        [Decoy("#=qIHft7FcH67tGrv3WupGmng==")]
        private AbstractRenderable MakeTabButtonState(string text, bool hoverState, bool addNewIcon) => null;

        [Decoy("#=qwnOPT03KNoXwmP8bgzjOwpqW6gU1UNt2cWxE01qP7_A=")]
        private Button MakeTabButton(string text, bool addNewIcon, Action actionWhenPressed) => null;

        [Decoy("#=qGIs1DbwX$lv5bLgmlBtApA==")]
        private Optional<int> MinOptional(Optional<int> int1, Optional<int> int2) => null;

        [Replaced("#=qo2GrFemBul1wgilIBVWsOb126uSD6cW6fwfXt8ce01Q=", Patch.DeclassifyDefenses)]
        private void ShowPerformanceTab()
        {
            Optional<string> cycleCounts = (Optional<string>)Empty.INSTANCE;
            Optional<string> reactorCounts = (Optional<string>)Empty.INSTANCE;
            Optional<string> symbolCounts = (Optional<string>)Empty.INSTANCE;
            Optional<HistogramsContent> histogramsContent = LocalHistogramsUtils.GetScoreOrEmpty(CurrentPuzzle.name);
            if (histogramsContent.isPresent)
            {
                cycleCounts = (Optional<string>)histogramsContent.GetValue().cycleCounts;
                reactorCounts = (Optional<string>)histogramsContent.GetValue().reactorCounts;
                symbolCounts = (Optional<string>)histogramsContent.GetValue().symbolCounts;
            }
            bool isDefense = PuzzleManager.IsDefense(CurrentPuzzle.name);
            AbstractRenderable completedLabel = AbstractRenderable.MakeColoredLabel(FontManager.huge, Localization.Localize("Assignment Complete!", "ENGLISH ALPHABET ONLY"), LabelFactory.darkYellow);
            AbstractRenderable mainUIBlock;
            // here is the only change: the section that made a dummy box in the defense case was removed, 
            // so that we show full metrics for them as well (sadly the game has no hist data)
            if (Constants.ShowLeaderboards())
            {
                Optional<MetricLeaderboard> cyclesLB = PuzzlesUtils.GetSteamLBForLevelAndMetric(CurrentPuzzle.name, MetricType.Cycles);
                Optional<MetricLeaderboard> reactorsLB = PuzzlesUtils.GetSteamLBForLevelAndMetric(CurrentPuzzle.name, MetricType.Reactors);
                Optional<MetricLeaderboard> symbolsLB = PuzzlesUtils.GetSteamLBForLevelAndMetric(CurrentPuzzle.name, MetricType.Symbols);
                Optional<int> thisCycles = thisScore.isPresent ? GetCycles_1(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestCycles = bestScore.isPresent ? GetCycles_2(bestScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> newBestCycles = MinOptional(thisCycles, bestCycles);
                Optional<int> thisReactors = thisScore.isPresent ? GetReactors_1(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestReactors = bestScore.isPresent ? GetReactors_2(bestScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> newBestReactors = MinOptional(thisReactors, bestReactors);
                Optional<int> thisSymbols = thisScore.isPresent ? GetSymbols_1(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestSymbols = bestScore.isPresent ? GetSymbols_2(bestScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> newBestSymbols = MinOptional(thisSymbols, bestSymbols);
                AbstractRenderable pressTABLabel = AbstractRenderable.EMPTY;
                if (SystemUtils.isSteamVersion)
                    pressTABLabel = FontManager.tooltip.MakeRenderable(Localization.Localize("Press Tab to view\nGRAPHS."), HorizontalAlignment.Center, (Optional<int>)Empty.INSTANCE).WithColor(LabelFactory.paleBlue);
                mainUIBlock = completedLabel.WithAddedRenderableBelow(AbstractRenderable.LayoutVertically(HorizontalAlignment.Center, 20, new AbstractRenderable[2]
                {
                    AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Your performance, compared to other engineers, is as follows:"), LabelFactory.paleBlue),
                    AbstractRenderable.LayoutHorizontally(VerticalAlignment.Center, 40, new AbstractRenderable[4]
                    {
                      pressTABLabel,
                      HistogramUtils.MakeLeaderboard(cyclesLB, newBestCycles, HistogramUtils.elapsedCycles, false, false, false),
                      HistogramUtils.MakeLeaderboard(reactorsLB, newBestReactors, HistogramUtils.reactorsUsed, false, false, false),
                      HistogramUtils.MakeLeaderboard(symbolsLB, newBestSymbols, HistogramUtils.symbolsUsed, false, false, false)
                    })
                }), HorizontalAlignment.Center, 20);
            }
            else
            {
                AbstractRenderable pressTABLabel = AbstractRenderable.EMPTY;
                if (SystemUtils.isSteamVersion)
                    pressTABLabel = FontManager.tooltip.MakeRenderable(Localization.Localize("Press Tab to view\nLEADERBOARDS."), HorizontalAlignment.Center, (Optional<int>)Empty.INSTANCE).WithColor(LabelFactory.paleBlue);
                AbstractRenderable[] histogramsBlock = new AbstractRenderable[4]
                {
                    pressTABLabel,
                    null,
                    null,
                    null
                };
                Optional<int> thisCycles = thisScore.isPresent ? GetCycles_3(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestCycles = bestScore.isPresent ? GetCycles_4(bestScore.GetValue()) : Optional<int>.ABSENT;
                AbstractRenderable cyclesHist = HistogramUtils.MakeHistogram(cycleCounts, thisCycles, bestCycles, Localization.Localize("THIS"),
                                                                             HistogramUtils.elapsedCycles, false, false, false);
                histogramsBlock[1] = cyclesHist;
                Optional<int> thisReactors = thisScore.isPresent ? GetReactors_3(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestReactors = bestScore.isPresent ? GetReactors_4(bestScore.GetValue()) : Optional<int>.ABSENT;
                AbstractRenderable reactorsHist = HistogramUtils.MakeHistogram(reactorCounts, thisReactors, bestReactors, Localization.Localize("THIS"),
                                                                               HistogramUtils.reactorsUsed, false, false, false);
                histogramsBlock[2] = reactorsHist;
                Optional<int> thisSymbols = thisScore.isPresent ? GetSymbols_3(thisScore.GetValue()) : Optional<int>.ABSENT;
                Optional<int> bestSymbols = bestScore.isPresent ? GetSymbols_4(bestScore.GetValue()) : Optional<int>.ABSENT;
                AbstractRenderable symbolsHist = HistogramUtils.MakeHistogram(symbolCounts, thisSymbols, bestSymbols, Localization.Localize("THIS"),
                                                                              HistogramUtils.symbolsUsed, false, false, false);
                histogramsBlock[3] = symbolsHist;
                AbstractRenderable histogramsRow = AbstractRenderable.LayoutHorizontally(VerticalAlignment.Center, 40, histogramsBlock);
                AbstractRenderable[] mainBlock = new AbstractRenderable[2]
                {
                    AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Your performance, compared to other engineers, is as follows:"), LabelFactory.paleBlue),
                    histogramsRow
                };
                AbstractRenderable mainRow = AbstractRenderable.LayoutVertically(HorizontalAlignment.Center, 20, mainBlock);
                mainUIBlock = completedLabel.WithAddedRenderableBelow(mainRow, HorizontalAlignment.Center, 20);
            }
            AbstractRenderable achievBox = BoxesButtonsFactory.MakeAngledBox(new Vector2i(560, 150), LabelFactory.paleBlue, LabelFactory.gray);
            Optional<Achievement> completedAchiev = CurrentPuzzle.GetCompletedAchievement();
            if (this.plaqueLevel.isPresent)
                achievBox = achievBox.WithAddedCenteredRenderable(AbstractRenderable.MakeColoredLabel(FontManager.medium, Localization.Localize("Congratulations! You have been promoted to"), LabelFactory.paleBlue)
                                                                                    .WithAddedRenderableBelow(AbstractRenderable.MakeColoredLabel(FontManager.large, this.plaqueLevel.GetValue(), LabelFactory.paleBlue), HorizontalAlignment.Center, 10));
            else if (completedAchiev.isPresent && completedAchiev.GetValue().showAtLevelEnd)
                achievBox = achievBox.WithAddedCenteredRenderable(AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Challenge complete!"), LabelFactory.paleBlue)
                                                                                    .WithAddedRenderableBelow(completedAchiev.GetValue().AchievIcon(), HorizontalAlignment.Center, 0));
            AbstractRenderable recordButtonContent = AbstractRenderable.LayoutVertically(HorizontalAlignment.Center, 0, new AbstractRenderable[5]
            {
                AbstractRenderable.MakeLabel(FontManager.large, Localization.Localize("Record Solution")),
                FontManager.normal.MakeRenderable(Localization.Localize("After recording your solution, you can save the video to your desktop or upload it to a YouTube account."), HorizontalAlignment.Center, (Optional<int>) 280),
                AbstractRenderable.MakeBlankRenderable(new BoundingBox(0, 0, 1, 8)),
                AbstractRenderable.MakeTexturedRectangle(ResourceUtils.LoadResource<TextureElement>("misc/youtube_small")),
                AbstractRenderable.MakeBlankRenderable(new BoundingBox(0, 0, 1, 8))
            });
            if (isDefense)
                recordButtonContent = AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Record Solution"), LabelFactory.paleBlue)
                                                        .WithAddedRenderableBelow(FontManager.normal.MakeRenderable(Localization.Localize("The details of this assignment are SpaceChem confidential and may not be shared with unprivileged employees."), HorizontalAlignment.Center, (Optional<int>)280), HorizontalAlignment.Center, 0);
            if (AbstractGame.FBOUnavailable || SystemUtils.GetOnlive())
                recordButtonContent = AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Record Solution"), LabelFactory.paleBlue)
                                                        .WithAddedRenderableBelow(FontManager.normal.MakeRenderable(Localization.Localize("This action is disabled."), HorizontalAlignment.Center, (Optional<int>)280), HorizontalAlignment.Center, 0);
            Button recordButton;
            AbstractRenderable achievUIBlock = achievBox.WithAddedRenderableAbove(AbstractRenderable.MakeColoredLabel(FontManager.large, Localization.Localize("Additional Information"), LabelFactory.darkYellow), HorizontalAlignment.Right, 10);
            AbstractUiElement performanceUI = AbstractUiElement.LayoutVertically(HorizontalAlignment.Center, 20, new AbstractUiElement[2]
            {
                (AbstractUiElement) mainUIBlock,
                AbstractUiElement.LayoutHorizontally(VerticalAlignment.Center, 30,  new AbstractUiElement[2]
                {
                    (AbstractUiElement) achievUIBlock,
                    AbstractUiElement.LayoutVertically(HorizontalAlignment.Center, 15,  new AbstractUiElement[1]
                    {
                        (recordButton = LabelFactory.MakeButtonWithContent(recordButtonContent, new Vector2i(300, 200), new Action(OpenRecordingScreen)))
                    })
                })
            });
            if (AbstractGame.FBOUnavailable || isDefense || SystemUtils.GetOnlive())
                recordButton.SetEnabled(false);
            AbstractRenderable performanceTab = AbstractRenderable.MakeTexturedRectangle(ResourceUtils.LoadResource<TextureElement>("mainmenu/story_background")).WithTranslation(7, 59)
                                                                  .NullSafeWithAddedRenderable(MakeTabButtonState(Localization.Localize("Performance"), false, false).WithTranslation(AfterVictoryScreen.positionTab3))
                                                                  .NullSafeWithAddedRenderable(AbstractRenderable.MakeTexturedRectangle(ResourceUtils.LoadResource<TextureElement>("mainmenu/story_tab_bottom")).WithTranslation(AfterVictoryScreen.positionTab3 + new Vector2i(0, 52)));
            wholeUI = new WholeUI((AbstractUI)new UiElementContainer(new ContainedUiElement[5]
            {
                new ContainedUiElement(Vector2i.NULL, MakeTopBar()),
                new ContainedUiElement(new Vector2i(AfterVictoryScreen.positionTab1), MakeTabButton(Localization.Localize("Story"), storyIsPresentAndUnlocked, new Action(ShowStoryTab_1))),
                new ContainedUiElement(new Vector2i(AfterVictoryScreen.positionTab2), MakeTabButton(Localization.Localize("Training"), trainingIsPresentAndUnlocked, new Action(ShowTrainingTab_1))),
                new ContainedUiElement(Vector2i.NULL, (AbstractUiElement) performanceTab),
                new ContainedUiElement(new Vector2i(512, 120), performanceUI)
            }), false, (Optional<AbstractUiElement>)Empty.INSTANCE, this);
        }

        [Decoy("#=qVmQ3uxZdFdkIzFQJQMIN7Q==")]
        private AbstractUiElement MakeTopBar() => null;

        [Decoy("#=qL$JLM$CG9minHbEaKkXnlEo9uavK_d_jy73Ga0sNk7w=")]
        private void ShowStoryTab_1()
        {
        }

        [Decoy("#=qeE5Amimt6E0f6x1YITAXiU2BG868HonWSBRHG1pyj9Y=")]
        private void ShowTrainingTab_1()
        {
        }

        [Decoy("#=quQX2iECV$i2pr_PNxHYsVQopeBYMPvzXrt52J6ihi_U=")]
        private void OpenRecordingScreen()
        {
        }

        [Decoy("#=qk4jLI3V2NtjYriX2vZk4xxVD8TRH5z17WkFOipbKY5I=")]
        private static int GetCycles_1(Score score)
        {
            return score.cycles;
        }

        [Decoy("#=qsgG9j$vRt5dCRlI9LjwiEli_laBZpGUsSCkfq06A0Jg=")]
        private static int GetCycles_2(Score score)
        {
            return score.cycles;
        }

        [Decoy("#=qikoldAO1u2tBqigRjftL60vrF7WRwYAcSFV4NyshDKQ=")]
        private static int GetReactors_1(Score score)
        {
            return score.reactors;
        }

        [Decoy("#=q55e5KZfg4edKGR8q_jR3eVZZGjTxgNqmUfeeJCQWM10=")]
        private static int GetReactors_2(Score score)
        {
            return score.reactors;
        }

        [Decoy("#=qzLpZC4dJInmPKfd6cdJHPAvyqmfXwwN1R$0tXh0uY04=")]
        private static int GetSymbols_1(Score score)
        {
            return score.symbols;
        }

        [Decoy("#=qvCA0IE79IPiA3pByL1CB7Glc$lwnwhrF8R9hdievPcE=")]
        private static int GetSymbols_2(Score score)
        {
            return score.symbols;
        }

        [Decoy("#=qy6uFemV76PB$rzBVMAslxMl9x5ey1KBt_pW_OU45yG8=")]
        private static int GetCycles_3(Score score)
        {
            return score.cycles;
        }

        [Decoy("#=qyYbIb7olrcZEtsCfS5Nwddoiqu39WBiZPVCsSSvG_MY=")]
        private static int GetCycles_4(Score score)
        {
            return score.cycles;
        }

        [Decoy("#=q69SiMrPFS2bqyyb27_7IFeVulNle5DQ93u3mROAPCxU=")]
        private static int GetReactors_3(Score score)
        {
            return score.reactors;
        }

        [Decoy("#=qMCNnCoQflGKRiSFafNv4Dn$$XrVdVZ9aozkrwXgz$ds=")]
        private static int GetReactors_4(Score score)
        {
            return score.reactors;
        }

        [Decoy("#=qMWnORaGH9zn3xXVl2YKo1yW1D7_A27ouDkwksMNbo88=")]
        private static int GetSymbols_3(Score score)
        {
            return score.symbols;
        }

        [Decoy("#=qMz$znbncOrjiXiP7wFXg5jgEAFb69_YFHQBk2aNC96s=")]
        private static int GetSymbols_4(Score score)
        {
            return score.symbols;
        }
    }
}
