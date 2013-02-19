﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace Tx.Windows
{
    public static class PerfCounterExtensions
    {
        [FileParser("Performance Counters Logs", ".blg", ".csv", ".tsv")]
        public static void AddPerfCounterTraces(this IPlaybackConfiguration playback, params string[] files)
        {
            playback.AddInput(
                () => PerfCounterObservable.FromFile(files[0]),
                typeof(PerfCounterPartitionTypeMap),
                typeof(PerfCounterTypeMap));
        }

        public static IObservable<PerformanceSample> GetPerformanceCounter(this IPlaybackConfiguration playback, string counterPath)
        {
            return null;
        }
    }
}
