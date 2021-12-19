﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PopSynIIIAutomatedTest;

[TestClass]
public class MetaControlFileTest
{
    [TestMethod]
    public void CreateMetaRecord()
    {
        var tazRecords = TazControlRecord.LoadRecordsFromLines(File.ReadAllLines("TestFiles/BaseYearData/taz_controls.csv"));
        Assert.IsNotNull(tazRecords);
        Assert.AreEqual(6, tazRecords.Length);
        var metaRecords = MetaControlRecord.CreateMetaControlsFrom(tazRecords);
        Assert.AreEqual(2, metaRecords.Length);
        Assert.AreEqual(24, metaRecords[0].TotalHouseholds);
        Assert.AreEqual(60, metaRecords[0].TotalPopulation);
        Assert.AreEqual(60, metaRecords[1].TotalHouseholds);
        Assert.AreEqual(150, metaRecords[1].TotalPopulation);
    }
}
