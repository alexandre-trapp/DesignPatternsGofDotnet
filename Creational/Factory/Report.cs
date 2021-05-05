namespace DesignPatternsGofDotnet.Factory
{
    /// <summary>
    /// Report: classe concreta construtora/criadora 'ConcreteCreator'
    /// </summary>
    class Report : Document
    {
        // Implementação método Factory 
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}