		    FileHeader fh = data(string.Empty);
		    Assert.AreEqual(gitLine(name).Length, fh.parseGitFileName(0, fh.buf.Length));
				    + "new File mode 100644\n"
				    + "deleted File mode 100644\n"